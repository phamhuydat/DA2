using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MstPermission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Table = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MstPermission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CanDelete = table.Column<bool>(type: "bit", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Credit = table.Column<int>(type: "int", nullable: false),
                    NumTheory = table.Column<int>(type: "int", nullable: false),
                    NumPractice = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolePermission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    MstPermissionId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermission_MstPermission_MstPermissionId",
                        column: x => x.MstPermissionId,
                        principalTable: "MstPermission",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RolePermission_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MSSV = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GoogleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlockedTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BlockedBy = table.Column<int>(type: "int", nullable: true),
                    OTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppRoleId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Roles_AppRoleId",
                        column: x => x.AppRoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    ChapterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chapters_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkTime = table.Column<int>(type: "int", nullable: false),
                    SeeAnswer = table.Column<bool>(type: "bit", nullable: false),
                    MixQuestion = table.Column<bool>(type: "bit", nullable: false),
                    MixAnswer = table.Column<bool>(type: "bit", nullable: false),
                    SubmitWhenExit = table.Column<bool>(type: "bit", nullable: false),
                    EQCount = table.Column<int>(type: "int", nullable: false),
                    MQCount = table.Column<int>(type: "int", nullable: false),
                    HQCount = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsAutomatic = table.Column<bool>(type: "bit", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exam_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvitationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademicYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Teacher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => new { x.Id, x.SubjectId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Assignment_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    ChapterId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Question_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AutomaticExam",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    ChapterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutomaticExam", x => new { x.ExamId, x.ChapterId });
                    table.ForeignKey(
                        name: "FK_AutomaticExam_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutomaticExam_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TestScores = table.Column<double>(type: "float", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalWorkTime = table.Column<int>(type: "int", nullable: false),
                    NumCorrect = table.Column<int>(type: "int", nullable: false),
                    NumTSC = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => new { x.Id, x.ExamId, x.UserId });
                    table.UniqueConstraint("AK_Result_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Result_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Result_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GroupDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsBlock = table.Column<bool>(type: "bit", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupDetails", x => new { x.Id, x.GroupId, x.UserId });
                    table.ForeignKey(
                        name: "FK_GroupDetails_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupDetails_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HandOutExam",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HandOutExam", x => new { x.GroupId, x.ExamId });
                    table.ForeignKey(
                        name: "FK_HandOutExam_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HandOutExam_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotificationDetails",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationDetails", x => x.NotificationId);
                    table.ForeignKey(
                        name: "FK_NotificationDetails_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationDetails_Notification_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExamDetails",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamDetails", x => new { x.ExamId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_ExamDetails_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExamDetails_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResultDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultDetails", x => new { x.Id, x.QuestionId, x.ResultId });
                    table.ForeignKey(
                        name: "FK_ResultDetails_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ResultDetails_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResultDetails_Result_ResultId",
                        column: x => x.ResultId,
                        principalTable: "Result",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MstPermission",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "GroupName", "Table" },
                values: new object[,]
                {
                    { 1001, "VIEW_LIST", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem danh sách người dùng", null, "Quản lý người dùng", "User" },
                    { 1002, "VIEW_DETAIL", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem chi tiết người dùng", null, "Quản lý người dùng", "User" },
                    { 1003, "CREATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Thêm người dùng", null, "Quản lý người dùng", "User" },
                    { 1004, "UPDATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Cập nhật người dùng", null, "Quản lý người dùng", "User" },
                    { 1005, "UPDATE_PWD", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Đổi mật khẩu", null, "Quản lý người dùng", "User" },
                    { 1006, "BLOCK", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Khóa người dùng", null, "Quản lý người dùng", "User" },
                    { 1007, "UNBLOCK", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Mở khóa người dùng", null, "Quản lý người dùng", "User" },
                    { 1008, "DELETE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xóa người dùng", null, "Quản lý người dùng", "User" },
                    { 1101, "VIEW_LIST", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem danh sách quyền", null, "Quản lý phân quyền", "Role" },
                    { 1102, "VIEW_DETAIL", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem chi tiết quyền", null, "Quản lý phân quyền", "Role" },
                    { 1103, "CREATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Thêm quyền", null, "Quản lý phân quyền", "Role" },
                    { 1104, "UPDATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Sửa quyền", null, "Quản lý phân quyền", "Role" },
                    { 1105, "DELETE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xóa quyền", null, "Quản lý phân quyền", "Role" },
                    { 1201, "VIEW_LIST", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem danh sách đề thi", null, "Quản lý đề thi", "Exam" },
                    { 1202, "VIEW_DETAIL", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem chi tiết đề thi", null, "Quản lý đề thi", "Exam" },
                    { 1203, "CREATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Thêm đề thi", null, "Quản lý đề thi", "Exam" },
                    { 1204, "UPDATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Sửa đề thi", null, "Quản lý đề thi", "Exam" },
                    { 1205, "DELETE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xóa đề thi", null, "Quản lý đề thi", "Exam" },
                    { 1206, "JOIN", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Tham gia bài thi", null, "Quản lý đề thi", "Exam" },
                    { 1301, "VIEW_LIST", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem danh sách môn học", null, "Quản lý môn học", "Subject" },
                    { 1302, "VIEW_DETAIL", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem chi tiết môn học", null, "Quản lý môn học", "Subject" },
                    { 1303, "CREATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Thêm môn học", null, "Quản lý môn học", "Subject" },
                    { 1304, "UPDATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Sửa môn học", null, "Quản lý môn học", "Subject" },
                    { 1305, "DELETE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xóa môn học", null, "Quản lý môn học", "Subject" },
                    { 1401, "VIEW_LIST", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem danh sách câu trả lời", null, "Quản lý trả lời", "Answer" },
                    { 1402, "VIEW_DETAIL", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem chi tiết câu trả lời", null, "Quản lý trả lời", "Answer" },
                    { 1403, "CREATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Thêm câu trả lời", null, "Quản lý trả lời", "Answer" },
                    { 1404, "UPDATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Sửa câu trả lời", null, "Quản lý trả lời", "Answer" },
                    { 1405, "DELETE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xóa câu trả lời", null, "Quản lý trả lời", "Answer" },
                    { 1501, "VIEW_LIST", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem danh sách câu hỏi", null, "Quản lý câu hỏi", "Question" },
                    { 1502, "VIEW_DETAIL", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem chi câu hỏi", null, "Quản lý câu hỏi", "Question" },
                    { 1503, "CREATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Thêm câu hỏi", null, "Quản lý câu hỏi", "Question" },
                    { 1504, "UPDATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Sửa câu hỏi", null, "Quản lý câu hỏi", "Question" },
                    { 1505, "DELETE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xóa câu hỏi", null, "Quản lý câu hỏi", "Question" },
                    { 1601, "VIEW_LIST", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem danh sách chương môn học", null, "Quản lý chương trình môn học", "Chapter" },
                    { 1602, "VIEW_DETAIL", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem chi tiết chương môn học", null, "Quản lý chương trình môn học", "Chapter" },
                    { 1603, "CREATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Thêm chương môn học", null, "Quản lý chương trình môn học", "Chapter" },
                    { 1604, "UPDATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Sửa chương môn học", null, "Quản lý chương trình môn học", "Chapter" },
                    { 1605, "DELETE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xóa chương môn học", null, "Quản lý chương trình môn học", "Chapter" },
                    { 1701, "VIEW_LIST", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem danh sách nhóm học phần", null, "Quản lý nhóm học phần", "Group" },
                    { 1702, "VIEW_DETAIL", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem chi tiết nhóm học phần", null, "Quản lý nhóm học phần", "Group" },
                    { 1703, "CREATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Thêm nhóm học phần", null, "Quản lý nhóm học phần", "Group" },
                    { 1704, "UPDATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Sửa nhóm học phần", null, "Quản lý nhóm học phần", "Group" },
                    { 1705, "DELETE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xóa nhóm học phần", null, "Quản lý nhóm học phần", "Group" },
                    { 1706, "JOIN", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Tham gia bài thi", null, "Quản lý nhóm học phần", "Group" },
                    { 1801, "VIEW_LIST", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem danh sách phân công", null, "Quản lý phân công học phần", "Assignment" },
                    { 1802, "VIEW_DETAIL", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem chi tiết phân công", null, "Quản lý phân công học phần", "Assignment" },
                    { 1803, "CREATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Thêm phân công", null, "Quản lý phân công học phần", "Assignment" },
                    { 1804, "UPDATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Sửa phân công", null, "Quản lý phân công học phần", "Assignment" },
                    { 1805, "DELETE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xóa phân công", null, "Quản lý phân công học phần", "Assignment" },
                    { 1901, "VIEW_LIST", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem danh sách bài thi đã giao cho nhóm nào", null, "Quản lý việc giao đề thi", "Assignment" },
                    { 1902, "VIEW_DETAIL", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem chi tiết bài thi được giao cho nhóm", null, "Quản lý việc giao đề thi", "HandOutExam" },
                    { 1903, "CREATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Thêm bài thi cho nhóm", null, "Quản lý việc giao đề thi", "HandOutExam" },
                    { 1904, "UPDATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Sửa bài thi đã giao 'vd: đổi bài thi, đổi nhóm thi'", null, "Quản lý việc giao đề thi", "HandOutExam" },
                    { 1905, "DELETE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xóa xóa bài thi của nhóm", null, "Quản lý việc giao đề thi", "HandOutExam" },
                    { 2001, "VIEW_LIST", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem danh sách thông báo", null, "Quản lý thông báo", "Notification" },
                    { 2002, "VIEW_DETAIL", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xem chi tiết thông báo", null, "Quản lý thông báo", "Notification" },
                    { 2003, "CREATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Thêm thông báo nhóm", null, "Quản lý thông báo", "Notification" },
                    { 2004, "UPDATE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Sửa thông báo", null, "Quản lý thông báo", "Notification" },
                    { 2005, "DELETE", new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2630), null, "Xóa thông báo", null, "Quản lý thông báo", "Notification" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CanDelete", "CreatedBy", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, false, null, new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2921), null, "Sinh Viên", null, "Student", null, new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2921) },
                    { 2, true, null, new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2921), null, "Quản trị toàn bộ hệ thống", null, "Admin", null, new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2921) },
                    { 3, true, null, new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2921), null, "giáo viên", null, "Teacher", null, new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2921) }
                });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "MstPermissionId", "RoleId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 106, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1101, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 107, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1102, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 108, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1103, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 109, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1104, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 110, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1105, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 111, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1001, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 112, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1002, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 113, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1003, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 114, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1004, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 115, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1005, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 116, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1006, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 117, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1007, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 118, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1008, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 119, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1201, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 120, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1202, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 121, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1203, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 122, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1204, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 123, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1205, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 124, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1401, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 125, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1402, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 126, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1403, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 127, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1404, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 128, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1405, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 129, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1501, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 130, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1502, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 131, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1503, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 132, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1504, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 133, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1505, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 134, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 2001, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 135, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 2002, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 136, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 2003, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 137, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 2004, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 138, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 2005, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 139, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1701, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 140, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1702, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 141, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1703, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 142, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1704, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 143, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1705, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 144, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1601, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 145, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1602, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 146, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1603, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 147, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1604, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 148, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1605, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 149, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1301, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 150, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1302, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 151, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1303, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 152, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1304, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 153, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1305, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 154, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1901, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 155, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1902, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 156, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1903, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 157, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1904, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 158, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1905, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 159, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1801, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 160, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1802, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 161, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1803, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 162, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1804, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 163, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1805, 2, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 164, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1206, 1, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 165, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1706, 1, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 166, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1201, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 167, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1202, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 168, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1203, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 169, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1204, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 170, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1205, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 171, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1401, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 172, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1402, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 173, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1403, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 174, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1404, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 175, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1405, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 176, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1501, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 177, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1502, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 178, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1503, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 179, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1504, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 180, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1505, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 181, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 2001, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 182, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 2002, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 183, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 2003, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 184, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 2004, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 185, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 2005, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 186, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1701, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 187, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1702, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 188, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1703, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 189, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1704, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 190, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1705, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 191, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1601, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 192, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1602, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 193, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1603, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 194, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1604, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 195, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1605, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 196, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1301, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 197, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1302, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 198, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1303, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 199, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1304, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 200, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1305, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 201, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1901, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 202, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1902, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 203, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1903, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 204, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1904, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 205, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1905, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 206, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1801, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 207, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1802, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 208, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1803, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 209, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1804, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) },
                    { 210, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245), null, null, 1805, 3, null, new DateTime(2024, 12, 2, 12, 0, 14, 440, DateTimeKind.Local).AddTicks(3245) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AppRoleId", "Avatar", "Birthday", "BlockedBy", "BlockedTo", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Email", "FullName", "Gender", "GoogleId", "MSSV", "OTP", "Password", "Phone", "Status", "Token", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 2, "~/Images/Avatar/default.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, -1, new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2974), null, null, "hello@gmail.com", "Admin", "Nam", null, "102024", null, "$2a$11$xD.3V3faiZ.RqPp6TgfgmOvptLf9uhjQtXhNTi7amtMz8ZeNfvRPa", "0928666158", 0, null, -1, new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2974) },
                    { 2, 1, "~/Images/Avatar/default.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, -1, new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2974), null, null, "codetoanbug@gmail.com", "Nguyen Van A", "Nam", null, "2110576", null, "$2a$11$xD.3V3faiZ.RqPp6TgfgmOvptLf9uhjQtXhNTi7amtMz8ZeNfvRPa", "0928666158", 0, null, -1, new DateTime(2024, 12, 2, 12, 0, 14, 317, DateTimeKind.Local).AddTicks(2974) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_SubjectId",
                table: "Assignment",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_UserId",
                table: "Assignment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AutomaticExam_ChapterId",
                table: "AutomaticExam",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_SubjectId",
                table: "Chapters",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_SubjectId",
                table: "Exam",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamDetails_QuestionId",
                table: "ExamDetails",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupDetails_GroupId",
                table: "GroupDetails",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupDetails_UserId",
                table: "GroupDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_SubjectId",
                table: "Groups",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_HandOutExam_ExamId",
                table: "HandOutExam",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationDetails_GroupId",
                table: "NotificationDetails",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_ChapterId",
                table: "Question",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_SubjectId",
                table: "Question",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_ExamId",
                table: "Result",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_UserId",
                table: "Result",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultDetails_AnswerId",
                table: "ResultDetails",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultDetails_QuestionId",
                table: "ResultDetails",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultDetails_ResultId",
                table: "ResultDetails",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_MstPermissionId",
                table: "RolePermission",
                column: "MstPermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_RoleId",
                table: "RolePermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_User_AppRoleId",
                table: "User",
                column: "AppRoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "AutomaticExam");

            migrationBuilder.DropTable(
                name: "ExamDetails");

            migrationBuilder.DropTable(
                name: "GroupDetails");

            migrationBuilder.DropTable(
                name: "HandOutExam");

            migrationBuilder.DropTable(
                name: "NotificationDetails");

            migrationBuilder.DropTable(
                name: "ResultDetails");

            migrationBuilder.DropTable(
                name: "RolePermission");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropTable(
                name: "MstPermission");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Subject");
        }
    }
}
