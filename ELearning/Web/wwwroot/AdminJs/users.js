$(document).ready(() => {
    $('.select2').select2();
    // Initialize jqValidation setup for real-time
    jqValidation();

    $('.form-add-user').validate({
        rules: {
            "mssv": {
                required: true,
                number: true
            },
            "user_email": {
                required: true,
                email: !0
            },
            "user_name": {
                required: true,
            },
            "user_gender": {
                required: true,
            },
            "datepicker": {
                required: true,
            },
            "user_nhomquyen": {
                required: true,
            },
            "user_password": {
                required: true,
                minlength: 4
            },
        },
        messages: {
            "masv": {
                required: "Vui lòng nhập mã sinh viên của bạn",
                number: "Mã sinh viên phải là các ký tự số"
            },
            "user_email": {
                required: "Vui lòng cung cấp email của bạn",
                email: "Phải nhập đúng định dạng email"
            },
            "user_name": {
                required: "Cung cấp đầy đủ họ tên",
            },
            "user_gender": {
                required: "Tích chọn 1 trong 2",
            },
            "datepicker": {
                required: "Vui lòng cho biết ngày sinh của bạn",
            },
            "user_nhomquyen": {
                required: "Vui lòng chọn nhóm quyền",
            },
            "user_password": {
                required: "Nhập mật khẩu",
                minlength: "Mật khẩu phải có ít nhất 5 ký tự!"
            },
        }

    });
});


document.addEventListener("alpine:init", () => {
    Alpine.data("users", () => ({
        _list: [],
        _modal: {},
        activeTab: '#btabs-static-home',
        _noti: {},
        _modalSetting: {
            title: "",
            url: "",
            primaryButtonText: ""
        },
        _updinData: {
            id: 0,
            mssv: "",
            fullName: "",
            gender: "",
            birthday: "",
            email: "",
            phone: "",
            password: "",
            blockedTo: "",
            appRoleId: ""
        },

        init() {
            var config = {
                durations: {
                    success: 2000
                },
                labels: {
                    success: "Thành công"
                }
            };

            this._modal = new bootstrap.Modal("#showModal");

            this.refreshData();
        },

        async refreshData() {
            fetch("/Admin/User/ListItem")
                .then(x => x.json())
                .then(json => {
                    this._list = json;
                })
                .catch(err => {
                    console.log(err);
                });
        },

        CheckIsBlock(date) {
            var now = Date.now();
            if (date && date > now) {
                return true;
            }
            return false;
        },

        get totalPages() {
            return Math.ceil(this.users.length / this.pageSize);
        },

        get paginatedList() {
            const start = (this.currentPage - 1) * this.pageSize;
            return this.users.slice(start, start + this.pageSize);
        },

        goToPage(page) {
            if (page < 1 || page > this.totalPages) return;
            this.currentPage = page;
        },

        OpenModelAdd() {
            this._modal.show();
            this._modalSetting = {
                title: "Thêm người dùng",
                url: "/Admin/User/CreateUser",
                primaryButtonText: "Thêm người dùng"
            };
            // Xóa dữ liệu khi mở modal add
            this._updinData = {
                id: 0,
                mSSV: "",
                fullName: "",
                gender: "",
                birthday: "",
                email: "",
                phone: "",
                password: "",
                appRoleId: ""
            };
        },

        openModalUpdate(mssv) {
            this._modal.show();
            this._modalSetting = {
                title: "Cập nhật thông tin",
                url: `/Admin/User/Update?mssv=${mssv}`,
                primaryButtonText: "Cập nhật"
            }

            // Lấy dữ liệu cho thao tác update
            fetch(`/Admin/User/Detail?mssv=${mssv}`)
                .then(res => res.json())
                .then(json => {
                    this._updinData = json;
                    console.log(this._updinData);
                });
        },

        saveCategory() {
            fetch(this._modalSetting.url, {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(this._updinData)
            })
                .then(res => {
                    return res.json();
                })
                .then(data => {
                    if (data.success) {
                        showNotification({
                            type: 'success',
                            //icon: 'btn-close',
                            message: data.message,
                        });
                        this.refreshData();
                    }
                    else {
                        showNotification({
                            type: 'danger',
                            //icon: 'btn-close',
                            message: data.message,
                        });
                    }
                })
                .catch(err => {
                    showNotification({
                        type: 'danger',
                        //icon: 'btn-close',
                        message: 'Lỗi rồi',
                    });
                })
        },

        removeCategory(id) {
            var url = "/Admin/User/Delete/" + id;

            this._noti.confirm("Chắc chưa", () => {
                fetch(url)
                    .then(res => {
                        if (res.status == 200) {
                            this._noti.success("Xóa thành công!");
                        } else {
                            this._noti.alert("Lỗi rồi, không xóa được.");
                        }
                    });
                this.refreshData();
            });
        },
        loadRoleComponent(selectedId) {
            // Gọi AJAX để tải lại ViewComponent với giá trị mới của `selectedId`
            fetch(`/path/to/load-component?selectedId=${selectedId}`)
                .then(response => response.text())
                .then(html => {
                    document.querySelector('#roleSelect').innerHTML = html;
                });
        }
    }))
});

