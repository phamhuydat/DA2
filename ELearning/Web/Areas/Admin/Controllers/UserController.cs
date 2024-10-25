using App.Web.Areas.Admin.Controllers;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.Entities;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Share.Consts;
using Web.Areas.Admin.ViewModels;
using Web.Areas.Admin.ViewModels.user;
using Web.Common;
using Web.WebConfig;
using X.PagedList;


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
        public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
        {
            var data = await _repo
               .GetAll<Users>(u => u.FullName != this.CurrentUsername)
               .ProjectTo<ListUserVM>(AutoMapperProfile.UserIndexConf)
               .ToPagedListAsync(page, size);
            return View(data);
        }



        [HttpPost]
        [AppAuthorize(AuthConst.AppUser.CREATE)]
        public async Task<IActionResult> Create(UserAddOrEditVM model)
        {
            model.MSSV = model.MSSV.ToString();
            if (!ModelState.IsValid)
            {
                SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
                return View(model);
            }

            if (await _repo.AnyAsync<Users>(u => u.MSSV.Equals(model.MSSV)))
            {
                _notyf.Warning("mã số sinh viên bị trùng");
                //SetErrorMesg("Tên đăng nhập này đã tồn tại!");
                return Redirect(Referer);
            }
            try
            {
                model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);
                var user = _mapper.Map<Users>(model);
                await _repo.AddAsync(user);
                _notyf.Success($"Thêm tài khoản [{user.FullName}] thành công!");

                //SetSuccessMesg($"Thêm tài khoản [{user.FullName}] thành công!");
                return Redirect(Referer);
                //return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                LogException(ex);
                return Redirect(Referer);
                //return View(model);
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

    }
}
