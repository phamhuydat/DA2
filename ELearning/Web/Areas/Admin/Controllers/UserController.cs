using App.Web.Areas.Admin.Controllers;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.Entities;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Share.Consts;
using Web.Areas.Admin.ViewModels.user;
using Web.Common;
using Web.WebConfig;


namespace Web.Areas.Admin.Controllers
{
	public class UserController : AdminBaseController
	{
		protected const int DEFAULT_PAGE_SIZE = 30;
		protected const string EXCEPTION_ERR_MESG = "Đã xảy ra lỗi trong quá trình xử lý dữ liệu (500).";
		protected const string MODEL_STATE_INVALID_MESG = "Dữ liệu không hợp lệ, vui lòng kiểm tra lại.";
		protected const string PAGE_NOT_FOUND_MESG = "Không tìm thấy trang.";


		private INotyfService _notyf;
		public UserController(GenericRepository repo, IMapper mapper, INotyfService notyf) : base(repo, mapper)
		{
			_notyf = notyf;
		}


		[AppAuthorize(AuthConst.AppUser.VIEW_DETAIL)]
		public IActionResult Index() => View();

		[HttpGet]
		[Route("/Admin/User/ListItem")]
		public IActionResult GetUser()
		{
			var data = ListItem();
			return Ok(data);
		}

		public List<ListUserVM> ListItem()
		{
			var data = _repo
			   .GetAll<Users>(u => u.FullName != this.CurrentUsername)
			   .ProjectTo<ListUserVM>(AutoMapperProfile.UserIndexConf)
			   .ToList();
			return data;
		}

		[HttpPost]
		[AppAuthorize(AuthConst.AppUser.CREATE)]
		public async Task<IActionResult> Create([FromBody] UserAddOrEditVM model)
		{
			model.MSSV = model.MSSV.ToString();
			if (!ModelState.IsValid)
			{
				//SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				_notyf.Error(MODEL_STATE_INVALID_MESG);
				return View(model);
			}

			if (await _repo.AnyAsync<Users>(u => u.MSSV.Equals(model.MSSV)))
			{
				SetErrorMesg("Tên đăng nhập này đã tồn tại!");
				return Redirect(Referer);
			}
			try
			{
				model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);
				var user = _mapper.Map<Users>(model);
				await _repo.AddAsync(user);

				SetSuccessMesg($"Thêm tài khoản [{user.FullName}] thành công!");
				return Redirect(Referer);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return Redirect(Referer);
			}
		}

		//[HttpPost]
		//[AppAuthorize(AuthConst.AppUser.CREATE)]

		//public async Task<IActionResult> ImportData(ImportData model)
		//{
		//	const string NO_DEPARTMENT = "Công ty này không có thông tin phòng ban, không thể import (có thể chọn vào \"Cho phép tự động thêm phòng ban nếu chưa tồn tại trong hệ thống\" để xử lý tự động).";
		//	const string EMPTY_FILE_CONTENT = "Dữ liệu import không hợp lệ.";
		//	const string INVALID_DEPARTMENT = "Dữ liệu phòng ban không khớp với dữ liệu trong hệ thống ở dòng {0}.";
		//	const string IMPORT_SUCCESSFULLY = "Import thành công dữ liệu của {0} người.";
		//	const string ERROR_MESSAGE_NOT_NULL = "Chưa có dữ liệu về {0}.";


		//	int errorRow = -1;

		//	if (!ModelState.IsValid || !model.FileExcel.FileName.ToUpper().EndsWith(".XLSX"))
		//	{
		//		return Ok(new AjaxAppResponse
		//		{
		//			Success = false,
		//			Message = MODEL_STATE_INVALID_MESG,
		//		});
		//	}
		//}

		//[HttpPost]
		//[AppAuthorize(AuthConst.AppUser.UPDATE)]

		public async Task<IActionResult> Update(int id, [FromBody] UserAddOrEditVM model)
		{
			if (!ModelState.IsValid)
			{
				SetErrorMesg("hãy nhập đủ thông tin yêu cầu");
				return Redirect(Referer);
			}

			var oldUsers = await _repo.FindAsync<Users>(id);

			var userData = _mapper.Map<Users>(model);
			await _repo.UpdateAsync(userData);

			_mapper.Map(model, oldUsers);
			await _repo.UpdateAsync(oldUsers);

			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Delete(int id)
		{
			var user = await _repo.FindAsync<Users>(id);
			if (user != null)
			{
				await _repo.DeleteAsync(user);
				SetSuccessMesg("Xóa tài khoản thành công");
				return RedirectToAction("Index");
			}
			else
			{
				SetErrorMesg("Tên đăng nhập nà");
				return Redirect(Referer);
			}

		}

		public async Task<Users> Detail(int id)
		{
			return await _repo.FindAsync<Users>(id);
		}
	}
}
