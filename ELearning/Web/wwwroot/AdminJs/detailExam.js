document.addEventListener("alpine:init", () => {
    Alpine.data("detailExam", () => ({
        _list: [],

        init() {

        },


        async refreshData() {
            // load data
            let response = await fetch("/api/Exam/GetDetailExam");
            let data = await response.json();
            this._list = data;

        }

    }));
});