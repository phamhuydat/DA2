using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class init_db9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HandOutExam",
                table: "HandOutExam");

            migrationBuilder.DropIndex(
                name: "IX_HandOutExam_GroupId",
                table: "HandOutExam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExamDetails",
                table: "ExamDetails");

            migrationBuilder.DropIndex(
                name: "IX_ExamDetails_ExamId",
                table: "ExamDetails");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "HandOutExam");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "HandOutExam");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "HandOutExam");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "HandOutExam");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "HandOutExam");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "HandOutExam");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "HandOutExam");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ExamDetails");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ExamDetails");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ExamDetails");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "ExamDetails");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "ExamDetails");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ExamDetails");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ExamDetails");

            migrationBuilder.AddColumn<bool>(
                name: "IsAutomatic",
                table: "Exam",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HandOutExam",
                table: "HandOutExam",
                columns: new[] { "GroupId", "ExamId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExamDetails",
                table: "ExamDetails",
                columns: new[] { "ExamId", "QuestionId" });

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1101,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1102,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1103,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1104,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1105,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1201,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1202,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1203,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1204,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1205,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1206,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1301,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1302,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1303,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1304,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1305,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1401,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1402,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1403,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1404,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1405,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1501,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1502,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1503,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1504,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1505,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1601,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1602,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1603,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1604,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1605,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1701,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1702,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1703,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1704,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1705,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1706,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1801,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1802,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1803,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1804,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1805,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1901,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1902,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1903,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1904,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1905,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 18, 23, 56, 40, 458, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(5002), new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(5002), new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(5002), new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(5048), "$2a$11$n/usfaDcPp.193jBSReAc.Kv0zrIBqM/NSIbNpxsDE3KjOQtucOK2", new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(5048), "$2a$11$n/usfaDcPp.193jBSReAc.Kv0zrIBqM/NSIbNpxsDE3KjOQtucOK2", new DateTime(2024, 11, 18, 23, 56, 40, 339, DateTimeKind.Local).AddTicks(5048) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HandOutExam",
                table: "HandOutExam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExamDetails",
                table: "ExamDetails");

            migrationBuilder.DropColumn(
                name: "IsAutomatic",
                table: "Exam");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "HandOutExam",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "HandOutExam",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "HandOutExam",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "HandOutExam",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "HandOutExam",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "HandOutExam",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "HandOutExam",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ExamDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "ExamDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ExamDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "ExamDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "ExamDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "ExamDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ExamDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HandOutExam",
                table: "HandOutExam",
                columns: new[] { "Id", "GroupId", "ExamId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExamDetails",
                table: "ExamDetails",
                columns: new[] { "Id", "ExamId", "QuestionId" });

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1101,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1102,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1103,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1104,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1105,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1201,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1202,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1203,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1204,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1205,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1206,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1301,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1302,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1303,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1304,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1305,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1401,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1402,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1403,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1404,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1405,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1501,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1502,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1503,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1504,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1505,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1601,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1602,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1603,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1604,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1605,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1701,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1702,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1703,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1704,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1705,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1706,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1801,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1802,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1803,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1804,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1805,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1901,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1902,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1903,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1904,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1905,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 17, 48, 21, 720, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8785), new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8785), new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8785), new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8835), "$2a$11$dalNFw.PBRzAw2UIPG80IO8TKsHyJ1TtfpIpjkbqMseON5DKiJlBu", new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8835), "$2a$11$dalNFw.PBRzAw2UIPG80IO8TKsHyJ1TtfpIpjkbqMseON5DKiJlBu", new DateTime(2024, 11, 18, 17, 48, 21, 593, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.CreateIndex(
                name: "IX_HandOutExam_GroupId",
                table: "HandOutExam",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamDetails_ExamId",
                table: "ExamDetails",
                column: "ExamId");
        }
    }
}
