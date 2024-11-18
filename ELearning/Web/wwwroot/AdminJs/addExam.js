function getMinutesBetweenDates(start, end) {
    // Chuyển đổi đối số thành đối tượng Date
    const startDate = new Date(start);
    const endDate = new Date(end);

    // Tính số phút giữa hai khoảng thời gian
    const diffMs = endDate.getTime() - startDate.getTime();
    const diffMins = Math.round(diffMs / 60000);

    // Trả về số phút tính được
    return diffMins;
}

$(document).ready(() => {
    $('.jq-select2').select2();
    // Initialize jqValidation setup for real-time  site.js
    jqValidation();
    // Add custom validation methods
    $.validator.addMethod(
        "validTimeEnd",
        function (value, element) {
            const startTime = new Date($("#time-start").val());
            const currentTime = new Date();
            const endTime = new Date(value);
            return endTime > startTime && endTime > currentTime;
        },
        "Thời gian kết thúc phải lớn hơn thời gian bắt đầu và không bé hơn thời gian hiện tại"
    );

    $.validator.addMethod(
        "validTimeStart",
        function (value, element) {
            const startTime = new Date(value);
            const currentTime = new Date();
            return startTime > currentTime;
        },
        "Thời gian bắt đầu không được bé hơn thời gian hiện tại"
    );

    // bug

    //$.validator.addMethod(
    //    "validSoLuong",
    //    function (value, element, param) {
    //        const chapter = $("#chuong").val() || "";
    //        const subjectId = $("#nhom-hp").val()
    //            ? groups[$("#nhom-hp").val()].mamonhoc
    //            : 0;
    //        const totalQuestions = parseInt(getToTalQuestionOfChapter(chapter, subjectId, param), 10);
    //        return totalQuestions >= parseInt(value, 10);
    //    },
    //    "Số lượng câu hỏi không đủ"
    //);

    $.validator.addMethod(
        "validThoigianthi",
        function (value, element, param) {
            const startTime = new Date($("#time-start").val());
            const endTime = new Date($("#time-end").val());
            const duration = parseInt(getMinutesBetweenDates(startTime, endTime), 10);
            return startTime < endTime && duration >= parseInt(value, 10);
        },
        "Thời gian làm bài không hợp lệ"
    );

    // Initialize validation
    $(".form-add-Exam").validate({
        rules: {
            "name-exam": {
                required: true,
            },
            "time-start": {
                required: true,
                validTimeStart: true,
            },
            "time-end": {
                required: true,
                validTimeEnd: true,
            },
            "exam-time": {
                required: true,
                digits: true,
                validThoigianthi: true,
            },
            "nhom-hp": {
                required: true,
            },
            chuong: {
                required: true,
            },
            coban: {
                required: true,
                digits: true,
                validSoLuong: 1,
            },
            trungbinh: {
                required: true,
                digits: true,
                validSoLuong: 2,
            },
            kho: {
                required: true,
                digits: true,
                validSoLuong: 3,
            },
        },
        messages: {
            "name-exam": {
                required: "Vui lòng nhập tên đề kiểm tra",
            },
            "time-start": {
                required: "Vui lòng chọn thời điểm bắt đầu của bài kiểm tra",
                validTimeStart: "Thời gian bắt đầu không được bé hơn thời gian hiện tại",
            },
            "time-end": {
                required: "Vui lòng chọn thời điểm kết thúc của bài kiểm tra",
                validTimeEnd: "Thời gian kết thúc không hợp lệ",
            },
            "exam-time": {
                required: "Vui lòng chọn thời gian làm bài kiểm tra",
                digits: "Vui lòng nhập số",
            },
            "nhom-hp": {
                required: "Vui lòng chọn nhóm học phần giảng dạy",
            },
            chuong: {
                required: "Vui lòng chọn số chương cho đề kiểm tra",
            },
            coban: {
                required: "Vui lòng cho biết số câu dễ",
                digits: "Vui lòng nhập số",
            },
            trungbinh: {
                required: "Vui lòng cho biết số câu trung bình",
                digits: "Vui lòng nhập số",
            },
            kho: {
                required: "Vui lòng cho biết số câu khó",
                digits: "Vui lòng nhập số",
            },
        },
    });
});

document.addEventListener("alpine:init", () => {
    Alpine.data("AddExam", () => ({
        _listSubject: [],
        _listChapter: [],
        _listGroup: [],
        _updinData: {
            id: 0,
            name: "",
            timeStart: "",
            timeEnd: "",
            examTime: "",
            subjectId: 0,
            chapterId: [],
            easy: 0,
            medium: 0,
            hard: 0,
        },
        choicesInstance: null,
        selectedChapters: [],

        init() {
            if (this.choicesInstance) {
                return; // Nếu đã khởi tạo rồi, không làm gì nữa
            }
            // Khởi tạo Choices.js
            this.choicesInstance = new Choices(this.$refs.selectElement, {
                removeItemButton: true,
                shouldSort: false,
            });

            // Thay thế danh sách option trong Choices.js bằng _listChapter
            this.updateChoices();

            // Lắng nghe thay đổi từ Choices.js
            this.$refs.selectElement.addEventListener("change", (event) => {
                this.selectedChapters = Array.from(event.target.selectedOptions).map(
                    (option) => option.value
                );
            });
            console.log(this.selectedChapters);

            this.LoadSubject();
        },
        LoadSubject() {
            fetch("/Admin/Exam/GetSubject")
                .then(x => x.json())
                .then(json => {
                    this._listSubject = json;
                })
                .catch(err => {
                    console.log(err);
                });
        },
        LoadChapter() {
            fetch(`/Admin/Exam/GetChapter?subjectId=${this._updinData.subjectId
                }`)
                .then(x => x.json())
                .then(json => {
                    this._listChapter = json;
                    this.updateChoices();
                })
                .catch(err => {
                    console.log(err);
                });
        },

        LoadListGroup() {
            fetch(`/Admin/Exam/GetListGroup?subjectId=${this._updinData.subjectId}`)
                .then(x => x.json())
                .then(json => {
                    this._listGroup = json;
                })
                .catch(err => {
                    console.log(err);
                });
        },

        updateChoices() {
            // Xóa tất cả các option hiện tại
            this.choicesInstance.clearChoices();
            console.log(this._listChapter)

            // Thêm các option mới từ _listChapter
            this._listChapter.forEach((chapter) => {
                this.choicesInstance.setChoices([
                    {
                        value: chapter.id,
                        label: chapter.chapterName,
                        selected: this.selectedChapters.includes(chapter.id),
                    },
                ]);
            });
        },



    }))
})