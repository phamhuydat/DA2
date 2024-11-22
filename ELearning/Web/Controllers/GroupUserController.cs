using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.Entities;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Areas.Admin.ViewModels.GroupVM;
using Web.ViewModels.ClientGroupVM;
using Web.WebConfig;

namespace Web.Controllers
{
    public class GroupUserController : BaseController
    {

        public GroupUserController(GenericRepository _repo, IMapper mapper) : base(_repo, mapper)
        {

        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult LoadListGroup()
        {
            // get all group of user in groupdetails

            var listGroup = _repo.GetAll<Group>(
                       x => x.DeletedDate == null && x.GroupDetails.Any(gd => gd.UserId == this.CurrentUserId))
                   .Include(x => x.subject) // Ensure that the Subject navigation property is included
                   .Include(x => x.GroupDetails) // Include GroupDetails to access it in the mapping
                   .ProjectTo<ListGroupClientVM>(AutoMapperProfile.GroupIndexClientConf) // Pass any parameters if needed
                   .ToList();

            return Ok(listGroup);
        }

        public async Task<IActionResult> JoinGroup(string code)
        {
            var group = await _repo.GetOneAsync<Group>(x => x.InvitationCode == code);
            if (group == null)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Mã lớp không tồn tại"
                });
            }

            var user = await _repo.FindAsync<Users>(CurrentUserId);
            if (user == null)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "User đăng nhập thất bại"
                });
            }

            var groupUser = new GroupDetails
            {
                GroupId = group.Id,
                UserId = user.Id,
                IsBlock = false
            };

            await _repo.AddAsync(groupUser);
            return Ok();
        }
    }
}
