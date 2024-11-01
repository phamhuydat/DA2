using AutoMapper;
using Data.Entities;
using Web.Areas.Admin.ViewModels.Account;
using Web.Areas.Admin.ViewModels.QuestionVM;
using Web.Areas.Admin.ViewModels.Role;
using Web.Areas.Admin.ViewModels.user;
using Web.ViewModels.Account;

namespace Web.WebConfig
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            // Map dữ liệu từ kiểu AppUser sang UserAddOrEditVM

            CreateMap<Users, UpdateUserViewModel>().ReverseMap();

            CreateMap<Users, AcceptUpdateViewModel>().ReverseMap();

            // map dl từ UserAddOrEditVM xang User
            CreateMap<UserAddOrEditVM, Users>().ReverseMap();

        }


        public static MapperConfiguration RoleIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<Role, RoleListItemVM>();
        });

        // Cấu hình mapping cho UserController, action Index
        public static MapperConfiguration UserIndexConf = new(mapper =>
        {
            // Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
            mapper.CreateMap<Users, ListUserVM>()
                .ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.Role.Name)).ReverseMap();

        });


        public static MapperConfiguration LoginConf = new(mapper =>
        {
            // Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
            mapper.CreateMap<Users, UserDataForApp>()
                .ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.Role == null ? "" : uEntity.Role.Name))
                .ForMember(uItem => uItem.Permission, opts => opts.MapFrom
                (
                    uEntity => string.Join(',', uEntity.Role
                                                        .RolePermissions
                                                        .Select(p => p.MstPermissionId))
                )).ReverseMap();
        });


        // Cấu hình mapping cho QuestionController, action Index AppQuestion xang ListQuestionVM
        public static MapperConfiguration QuestionIndexConf = new(mapper =>
        {
            mapper.CreateMap<Question, ListQuestionVM>()
                .ForMember(qItem => qItem.SubjectName, opts => opts.MapFrom(qEntity => qEntity.subject.SubjectName))
                .ForMember(qItem => qItem.ChapterName, opts => opts.MapFrom(qEntity => qEntity.chapter.ChapterName))
                .ForMember(qItem => qItem.Answers, opts => opts.MapFrom(qEntity => qEntity.answers)).ReverseMap();
        });




    }
}
