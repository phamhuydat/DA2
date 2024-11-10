using AutoMapper;
using Data.Entities;
using Web.Areas.Admin.ViewModels.Account;
using Web.Areas.Admin.ViewModels.AnswerVM;
using Web.Areas.Admin.ViewModels.ChapterVM;
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
    }
}
