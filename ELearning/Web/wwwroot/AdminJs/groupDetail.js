
$(document).ready(() => {
    // Initialize Select2 on page load
    //$('.select2').select2();
    // Initialize jqValidation setup for real-time  site.js
    jqValidation();
    // Initialize form validation
    $('#form-add-group').validate({
        rules: {
            "mssv": {
                required: true,
                number: true

            },

        },
        messages: {
            "mssv": {
                required: "Vui lòng nhập mã số sinh viên",
                number: "Mã số sinh viên phải là số"
            },

        }
    });
});

document.addEventListener("alpine:init", () => {
    Alpine.data("groupDetail", () => ({
        _listGroups: [],
        _listUser: [],
        _modal: {},
        currentYear: new Date().getFullYear(),
        _years: [],
        _listSubject: [],
        _modalSetting: {
            title: "",
            url: "",
            primaryButtonText: ""
        },
        _updinData: {
            id: 0,
            groupName: "",
            note: "",
            subjectId: "",
            subjectName: "",
            academicYear: "",
            semester: "",
        },

        init() {
            this._modal = new bootstrap.Modal("#modal-add-user");

            this.refreshData();
            this.LoadSubject();
            this.generateYearRange();
        },
        LoadSubject() {
            fetch("/Admin/Question/GetSubject")
                .then(x => x.json())
                .then(json => {
                    this._listSubject = json;
                })
                .catch(err => {
                    console.log(err);
                });
        },
        generateYearRange() {
            const startYear = this.currentYear - 5;  // Adjust as needed (e.g., start from 5 years ago)
            const endYear = this.currentYear + 5;    // Adjust as needed (e.g., go up to 5 years in the future)
            for (let year = startYear; year < endYear; year++) {
                // Create a year range as 'yyyy-yyyy'
                this._years.push(year + '-' + (year + 1));
            }
        },

        async refreshData() {
            fetch("/Admin/Group/ListGroup")
                .then(x => x.json())
                .then(json => {
                    this._listGroups = json;
                })
                .catch(err => {
                    console.log(err);
                });

        },
        OpenModalAdd() {
            this._modal.show();
            this._modalSetting = {
                title: "Thêm nhóm",
                url: "/Admin/Group/CreateGroup",
                primaryButtonText: "Lưu"
            };
            // Xóa dữ liệu khi mở modal add
        },

        OpenModalEdit(id) {
            this._modal.show();
            this._modalSetting = {
                title: "Cập nhật thông tin",
                url: "/Admin/Group/EditGroup/" + id,
                primaryButtonText: "Cập nhật"
            }

            // Lấy dữ liệu cho thao tác update
            fetch("/Admin/Group/GetGroup/" + id)
                .then(res => res.json())
                .then(json => {
                    this._updinData = json;
                    console.log(this._updinData);
                });

        },

        OpenListStudent(id) {

            //fetch("/Admin/Group/ListUser/" + id)
            //    .then(res => res.json())
            //    .then(json => {
            //        this._listUser = json;
            //        console.log(this._listUser);
            //    });

            window.location.href = "/Admin/Group/GetViewUser/"

        },


        SaveData() {
            var data = {
                id: this._updinData.id,
                groupName: this._updinData.groupName,
                note: this._updinData.note,
                subjectId: this._updinData.subjectId,
                academicYear: this._updinData.academicYear,
                semester: this._updinData.semester,
            }
            fetch(this._modalSetting.url, {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(data)
            })
                .then(res => {
                    return res.json();
                })
                .then(data => {
                    if (data.success) {
                        showNotification({
                            type: 'success',
                            message: data.message,
                        });
                        this.refreshData();
                    }
                    else {
                        showNotification({
                            type: 'danger',
                            message: data.message,
                        });
                    }
                })
                .catch(err => {
                    console.log(err)
                    showNotification({
                        type: 'danger',
                        message: "Thêm nhóm không thành công lỗi server",
                    });
                })
        },

    }))
});
