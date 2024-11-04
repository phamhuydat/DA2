document.addEventListener("alpine:init", () => {
    Alpine.data("questions", () => ({
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
            mSSV: "",
            fullName: "",
            gender: "",
            birthday: "",
            email: "",
            phone: "",
            password: "",
            //roleName: "",
            blockedTo: "",
            //isBlock: "",
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

            this._modal = new bootstrap.Modal("#modal-add-question");

            this.refreshData();
        },
        refreshData() {

        }
    }))
});