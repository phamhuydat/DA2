using AutoMapper;
using Data;
using Data.Entities;
using Data.Repositories;
using DinkToPdf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Share.Consts;
using System.Text;
using Web.Common;
using Web.Services;

namespace Web.Areas.Admin.Controllers
{
    public class FileController : AdminBaseController
    {
        private readonly DataContext _db;
        private readonly IPDFService _pDFService;

        public FileController(DataContext db, GenericRepository repo,
                        IMapper mapper, IPDFService pDFService) : base(repo, mapper)
        {
            _db = db;
            _pDFService = pDFService;
        }

        public async Task<string> ExportPDF(int userId, int examId)
        {

            var exam = await _repo.GetAll<Exam>(x => x.Id == examId)
                       .Include(x => x.Subject)
                       .FirstOrDefaultAsync();


            var info = await _repo.GetOneAsync<Users>(x => x.Id == userId);

            var result = await _repo.GetOneAsync<Result>(x => x.UserId == userId && x.ExamId == examId);

            var resultDetail = _db.ResultDetails
                .Where(x => x.ResultId == result.Id)
                .Join(_db.Question,
                    rd => rd.QuestionId,
                    q => q.Id,
                    (rd, q) => new { rd, q })
                .Select(x => new
                {
                    QuestionId = x.q.Id,
                    Content = x.q.Content,
                    UserIsCorrect = x.rd.AnswerId,
                    Check = _db.Answers.Where(a => a.Id == x.rd.AnswerId).Single().Status,
                    Answers = _db.Answers
                        .Where(a => a.QuestionId == x.q.Id)
                        .Select(a => new
                        {
                            AnswerId = a.Id,
                            AnswerContent = a.AnswerContent,
                            IsCorrect = ((a.Status && x.rd.AnswerId == a.Id) || a.Status) ? 1
                                    : (!a.Status && x.rd.AnswerId == a.Id) ? 0 : (int?)null
                        })
                    .ToList()
                });
            if (exam == null) throw new Exception("Exam not found.");
            if (info == null) throw new Exception("User info not found.");
            if (result == null) throw new Exception("Result not found.");
            if (!resultDetail.Any()) throw new Exception("No result details found.");



            var html = new StringBuilder();

            html.Append(@"
<!DOCTYPE html>
<html>
<head>
    <meta http-equiv='Content-Type' content='text/html; charset=utf-8'/>
    <style>
        * {padding: 0;margin: 0;box-sizing: border-box;}
        body{font-family: 'Times New Roman', serif; padding: 50px 50px}
    </style>
</head>
<body>
    <table style='width:100%'>
        <tr>
            <td style='text-align: center;font-weight:bold'>
                TRƯỜNG ĐẠI HỌC<br>
                KHOA CÔNG NGHỆ THÔNG TIN
                <br><br><br>
            </td>
            <td style='text-align: center;'>
                <p style='font-weight:bold'>" + (exam.Title?.ToUpper() ?? "") + @"</p>
                <p style='font-weight:bold'>Học phần: " + (exam?.Subject?.SubjectCode ?? "0") + @"</p>
                <p style='font-weight:bold'>Mã học phần: " + (exam?.Subject?.SubjectName ?? "N/A") + @"</p>
                <p style='font-style:italic'>Thời gian làm bài: " + (exam?.WorkTime ?? 0) + @" phút</p>
            </td>
        </tr>
    </table>

    <table style='width:100%;margin-bottom:10px'>
        <tr style='width:100%'>
            <td>Mã sinh viên: " + (info?.MSSV ?? "") + @"</td>
            <td>Tên thí sinh: " + (info?.FullName ?? "") + @"</td>
        </tr>
        <tr style='width:100%'>
            <td>Số câu đúng: " + (result?.NumCorrect ?? 0) + "/" +
                        ((exam?.MQCount ?? 0) + (exam?.HQCount ?? 0) + (exam?.EQCount ?? 0)) + @"</td>
            <td>Điểm: " + (result?.TestScores ?? 0) + @"</td>
        </tr>
    </table>       

    <hr>
    <div style='margin-top:20px'>");

            int index = 1; // Bắt đầu đánh số câu hỏi
            foreach (var item in resultDetail)
            {
                html.Append(" <li style='list-style:none'>" +
                            "<strong>Câu " + index + "</strong>: " + (item.Content ?? "") + "<ol type='A' style='margin-left:30px'>");
                foreach (var answer in item.Answers)
                {
                    var dapAn = (answer.IsCorrect == 1) ? " (Đáp án chính xác)" : "";
                    var dapAnChon = (answer.AnswerId == item.UserIsCorrect) ? " (Đáp án chọn)" : "";
                    html.Append("<li>" + (answer.AnswerContent ?? "") + dapAnChon + dapAn + "</li>");
                }

                html.Append("</ol></li><br/>");
                index++; // Tăng số thứ tự câu hỏi
            }

            html.Append(@"
</div>
</body>
</html>");


            var resultPDF = _pDFService.GeneratePDF(html.ToString());

            //var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "result.pdf");

            //await System.IO.File.WriteAllBytesAsync(filePath, resultPDF);

            return Convert.ToBase64String(resultPDF);

        }






    }
}
