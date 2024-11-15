using AutoMapper;
using Data.Entities;
using Web.Areas.Admin.ViewModels.Account;
using Web.Areas.Admin.ViewModels.AnswerVM;
using Web.Areas.Admin.ViewModels.ChapterVM;
using Web.Areas.Admin.ViewModels.GroupDetailVM;
using Web.Areas.Admin.ViewModels.GroupVM;
using Web.Areas.Admin.ViewModels.QuestionVM;
using Web.Areas.Admin.ViewModels.Role;
using Web.Areas.Admin.ViewModels.SubjectVM;
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

            //map dl từ subjectUpsertVM xang subject
            CreateMap<SubjectAddOrUpdateVM, Subject>().ReverseMap();


            //map dl từ chapterUpsertVM xang chapter
            CreateMap<ChapterAddOrEditVM, Chapter>().ReverseMap();


            // Map dữ liệu từ AnswerAddOrEdit sang Answer
            CreateMap<AnswerAddOrEdit, Answer>().ReverseMap();

            // map dữ liệu QuestionAddOrEditVM sang Question
            CreateMap<QuestionAddOrEditVM, Question>()
                .ForMember(q => q.answers, opts => opts.MapFrom(qVM => qVM.Options))
                .ReverseMap();

            // map dữ liệu từ group sang ListGroupVM
            CreateMap<Group, ListGroupVM>().ReverseMap();

            // map dữ liệu từ groupAddOrEditVM sang group
            CreateMap<GroupAddOrEditVM, Group>().ReverseMap();
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

        // Cấu hình mapping cho SubjectController, action Index

        public static MapperConfiguration SubjectIndexConf = new(mapper =>
        {
            mapper.CreateMap<Subject, ListSubjectVM>().ReverseMap();
        });

        // Cấu hình mapping cho ChapterController, action Index
        public static MapperConfiguration ChapterIndexConf = new(mapper =>
        {
            mapper.CreateMap<Chapter, ListChapterVM>().ReverseMap();
        });

        // Cấu hình mapping cho AnswerController, action Index
        public static MapperConfiguration AnswerIndexConf = new(mapper =>
        {
            mapper.CreateMap<Answer, AnswerAddOrEdit>().ReverseMap();
        });


        // Cấu hình mapping cho GroupController, action Index
        public static MapperConfiguration GroupIndexConf = new(mapper =>
        {
            mapper.CreateMap<Group, ListGroupVM>()
                .ForMember(vm => vm.Title, opts => opts.MapFrom(entity =>
                    $"{entity.subject.SubjectCode} - {entity.subject.SubjectName} - NH{entity.AcademicYear} - {entity.Semester}"))
                .ForMember(vm => vm.ListItemGroup, opts => opts.MapFrom(entity => new List<GroupDetailVM>
                {
                    new GroupDetailVM
                    {
                        Id = entity.Id,
                        Notes = entity.Note,
                        Quantity = entity.GroupDetails.Count,
                        Name = entity.Teacher != null ? "GV: " + entity.Teacher : entity.GroupName,

                    }
                })).ReverseMap();

            mapper.CreateMap<Group, GroupDetailVM>()
                .ForMember(vm => vm.Id, opts => opts.MapFrom(entity => entity.Id))
                //.ForMember(vm => vm.GroupName, opts => opts.MapFrom(entity => entity.GroupName))
                .ForMember(vm => vm.Notes, opts => opts.MapFrom(entity => entity.Note))
                //.ForMember(vm => vm.Visibility, opts => opts.MapFrom(entity => entity.Visibility))
                .ReverseMap();
        });


        // cấu hình mapper cho GroupDetailController, action ListUserGroup

        public static MapperConfiguration GroupDetailIndexConf => new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<GroupDetails, ListUserGroupVM>()
                .ForMember(dest => dest.Mssv, opt => opt.MapFrom(src => src.User.MSSV))
                .ForMember(dest => dest.fullName, opt => opt.MapFrom(src => src.User.FullName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.User.Gender))
                .ForMember(dest => dest.Birthday, opt => opt.MapFrom(src => src.User.Birthday))
                .ReverseMap();

        });

    }
}
