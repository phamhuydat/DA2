using App.Web.Areas.Admin.Controllers;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.Entities;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
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
        [Route("Admin/User/CreateUser")]
        [AppAuthorize(AuthConst.AppUser.CREATE)]
        public async Task<IActionResult> CreateUser([FromBody] UserAddOrEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Dữ liệu không hợp lệ",
                    data = model
                });
            }

            if (await _repo.AnyAsync<Users>(u => u.MSSV.Equals(model.Mssv)))
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Mã sinh viên này đã tồn tại",
                    data = model
                });
            }

            try
            {
                model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);
                var user = _mapper.Map<Users>(model);
                user.CreatedBy = this.CurrentUserId;
                user.CreatedDate = DateTime.Now;
                user.UpdatedBy = this.CurrentUserId;
                user.UpdatedDate = DateTime.Now;
                await _repo.AddAsync(user);

                return Ok(new
                {
                    success = true,
                    message = $"Thêm tài khoản [{user.FullName}] thành công!"
                });
            }
            catch (Exception ex)
            {
                LogException(ex);
                return BadRequest(new
                {
                    success = false,
                    message = ex,
                    data = model
                });
            }
        }

        [HttpPost]
        public async Task<Users> CheckUser(string mssv)
        {
            return await _repo.GetOneAsync<Users>(u => u.MSSV == mssv);
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

        [HttpPost]
        [AppAuthorize(AuthConst.AppUser.UPDATE)]

        public async Task<IActionResult> Update(string mssv, [FromBody] UserAddOrEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Dữ liệu không hợp lệ",
                    data = model
                });
            }
            model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);
            var oldUsers = await _repo.GetOneAsync<Users>(u => u.MSSV == mssv);
            if (oldUsers == null)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Không tìm thấy tài khoản",
                    data = model
                });
            }

            _mapper.Map(model, oldUsers);
            oldUsers.UpdatedBy = this.CurrentUserId;
            oldUsers.UpdatedDate = DateTime.Now;
            await _repo.UpdateAsync(oldUsers);

            return Ok(new
            {
                success = true,
                message = "Cập nhật tài khoản thành công"
            });
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

        [HttpGet]
        public async Task<IActionResult> Detail(string mssv)
        {
            var data = await _repo.GetOneAsync<Users>(u => u.MSSV == mssv);
            var result = _mapper.Map<UserAddOrEditVM>(data);
            return Ok(result);

        }
    }
}
