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
        currentPage: 1,
        itemsPerPage: 10,
        searchTerm: "",

        get filteredList() {
            if (!this.searchTerm) {
                return this._list;
            }
            return this._list.filter(item =>
                item.mssv.toLowerCase().includes(this.searchTerm.toLowerCase()) ||
                item.fullName.toLowerCase().includes(this.searchTerm.toLowerCase())
            );
        },

        get paginatedList() {
            const start = (this.currentPage - 1) * this.itemsPerPage;
            const end = start + this.itemsPerPage;
            return this.filteredList.slice(start, end);
        },

        get totalPages() {
            return Math.ceil(this.filteredList.length / this.itemsPerPage);
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
        },

        prevPage() {
            if (this.currentPage > 1) {
                this.currentPage--;
            }
        },

        nextPage() {
            if (this.currentPage < this.totalPages) {
                this.currentPage++;
            }
        },

        goToPage(page) {
            this.currentPage = page;
        }
    }))
});
