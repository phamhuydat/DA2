document.addEventListener("alpine:init", () => {
    Alpine.data("subjects", () => ({
        _list: [],
        _listChapter: [],
        _modal: {},
        _modalChapter: {},
        _modalSetting: {
            title: "",
            url: "",
            primaryButtonText: ""
        },
        _modalSettingChapter: {
            title: "",
            url: "",
            primaryButtonText: ""
        },
        _updinData: {
            id: 0,
            subjectCode: "",
            subjectName: "",
            credit: "",
            numTheory: "",
            numPractice: "",
        },
        _dataChapter: {
            rowIndex: 0,
            id: 0,
            chapterName: "",
            subjectId: 0
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

            this._modal = new bootstrap.Modal("#modal-add-subject");
            this._modalChapter = new bootstrap.Modal("#modal-chapter");
            this.refreshData();
        },

        GetListChapter(subjectId) {
            fetch("/Admin/Subject/GetListChapter/" + subjectId)
                .then(x => x.json())
                .then(json => {
                    this._listChapter = json.map((item, index) => ({
                        ...item,
                        rowIndex: index + 1
                    }));
                })
                .catch(err => {
                    console.log(err);
                });
        },


        refreshData() {
            fetch("/Admin/Subject/ListItem")
                .then(x => x.json())
                .then(json => {
                    this._list = json;
                })
                .catch(err => {
                    console.log(err);
                });
        },
        OpenModalAdd() {
            this._modal.show();
            this._modalSetting = {
                title: "Thêm môn học",
                url: "/Admin/Subject/CreateSubject",
                primaryButtonText: "Lưu"
            };
            this._updinData = {
                subjectCode: "",
                subjectName: "",
                credit: "",
                numTheory: "",
                numPractice: "",
            }
        },

        OpenModalUpdate(subjectId) {
            this._modal.show();
            this._modalSetting = {
                title: "Cập nhật thông tin",
                url: "/Admin/Subject/EditSubject/" + subjectId,
                primaryButtonText: "Cập nhật"
            }

            // Lấy dữ liệu cho thao tác update
            fetch("/Admin/Subject/GetSubject/" + subjectId)
                .then(res => res.json())
                .then(json => {
                    this._updinData = json
                });

        },

        SaveSubject() {
            fetch(this._modalSetting.url, {
                method: "POST",
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(this._updinData)
            })
                .then(x => x.json())
                .then(json => {
                    console.log(json);
                    this.refreshData();
                    Dashmix.helpers('jq-notify', { type: 'success', icon: 'fa fa-times me-1', message: json.message });

                })
                .catch(err => {
                    console.log(err);
                    Dashmix.helpers('jq-notify', { type: 'danger', icon: 'fa fa-times me-1', message: 'thêm môn học không thành công' });

                });
        },
        DeleteSubject(subjectId) {
            fetch("/Admin/Subject/DeleteSubject/" + subjectId, {
                method: "POST"
            })
                .then(x => x.json())
                .then(json => {
                    console.log(json);
                    this.refreshData();
                    Dashmix.helpers('jq-notify', { type: 'success', icon: 'fa fa-times me-1', message: json.message });

                })
                .catch(err => {
                    console.log(err);
                    Dashmix.helpers('jq-notify', { type: 'danger', icon: 'fa fa-times me-1', message: 'Xóa môn học không thành công' });

                });
        },

        OpenModalChapter(subjectId) {
            this._modalChapter.show();
            this._modalSettingChapter = {
                title: "Thêm chương",
                url: "/Admin/Subject/CreateChapter",
                primaryButtonText: "Lưu"
            };
            this._dataChapter = {
                id: 0,
                chapterName: "",
                subjectId: subjectId
            }
            this.GetListChapter(subjectId);
        },


        OpenModalEditChapter(id) {
            this._modalChapter.show();
            this._modalSettingChapter = {
                title: "Cập nhật thông tin",
                url: "/Admin/Subject/EditChapter/" + id,
                primaryButtonText: "Cập nhật"
            }

            // Lấy dữ liệu cho thao tác update
            fetch("/Admin/Subject/GetChapter/" + id)
                .then(res => res.json())
                .then(json => {
                    this._dataChapter = json
                });
        },
        SaveChapter() {
            fetch(this._modalSettingChapter.url, {
                method: "POST",
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(this._dataChapter)
            })
                .then(x => x.json())
                .then(json => {
                    console.log(json);
                    this.refreshData();
                    Dashmix.helpers('jq-notify', { type: 'success', icon: 'fa fa-times me-1', message: json.message });
                    this.GetListChapter(this._dataChapter.subjectId);
                })
                .catch(err => {
                    console.log(err);
                    Dashmix.helpers('jq-notify', { type: 'danger', icon: 'fa fa-times me-1', message: 'thêm môn học không thành công' });

                });
        },
        DeleteChapter(id) {
            fetch("/Admin/Subject/DeleteChapter/" + id, {
                method: "POST"
            })
                .then(x => x.json())
                .then(json => {
                    console.log(json);
                    this.refreshData();
                    Dashmix.helpers('jq-notify', { type: 'success', icon: 'fa fa-times me-1', message: json.message });
                    this.GetListChapter(this._dataChapter.subjectId);
                })
                .catch(err => {
                    console.log(err);
                    Dashmix.helpers('jq-notify', { type: 'danger', icon: 'fa fa-times me-1', message: 'Xóa môn học không thành công' });

                });
        }








    }))
});