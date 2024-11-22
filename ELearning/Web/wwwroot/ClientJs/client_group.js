document.addEventListener("alpine:init", () => {
    Alpine.data("clientGroup", () => ({
        _list: [],
        _listGroups: [],

        invitedCode: "",

        init() {
            this.refreshData();
        },

        refreshData() {
            fetch("/GroupUser/LoadListGroup")
                .then(x => x.json())
                .then(json => {
                    this._listGroups = json;
                    console.log(this._listGroups);
                })
                .catch(err => {
                    console.log(err);
                });
        },


        BtnJoinGroup() {
            fetch("/GroupUser/JoinGroup", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify({
                    invitedCode: this.invitedCode,
                }),
            })
                .then(x => x.json())
                .then(json => {
                    console.log(json);
                    showNotification({
                        type: 'success',
                        message: data.message,
                    });
                    this.refreshData();
                })
                .catch(err => {
                    console.log(err);
                    showNotification({
                        type: 'danger',
                        message: "Lỗi sersver rồi",
                    });
                });
        },
        LoadDataGroup(id) {

        }

    }));
});
