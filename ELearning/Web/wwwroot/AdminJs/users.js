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
            roleName: "",
            blockedTo: "",
            isBlock: "",
            AppRoleId: ""
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
                mssv: "",
                fullName: "",
                gender: "",
                birthday: "",
                email: "",
                phone: "",
                password: "",
                AppRoleId: ""
            };
        },
        openModalUpdate(id) {
            this._modal.show();
            this._modalSetting = {
                title: "Cập nhật thông tin",
                url: "/Admin/User/Update/" + id,
                primaryButtonText: "Cập nhật"
            }

            // Lấy dữ liệu cho thao tác update
            fetch("/Admin/User/Detail/" + id)
                .then(res => res.json())
                .then(json => {
                    this._updinData = json
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
                    console.log(data.data);
                    if (data.success) {
                        Dashmix.helpers('jq-notify', { type: 'success', icon: 'fa fa-times me-1', message: text.message });
                        this.refreshData();
                    }
                    else {
                        Dashmix.helpers('jq-notify', { type: 'danger', icon: 'fa fa-times me-1', message: text.message });
                    }
                })
                .catch(err => {
                    Dashmix.helpers('jq-notify', { type: 'danger', icon: 'fa fa-times me-1', message: `Thêm người không thành công!` });
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