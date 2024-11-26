document.addEventListener('alpine:init', () => {
    Alpine.data("takeTest", () => ({
        _listQuestion: [],
        userAnswers: {},
        resultId: null,
        infoExam: [],
        examId: 0,

        // lấy id của bài thi
        getIdFromUrl() {
            const pathSegments = window.location.pathname.split('/');
            return pathSegments[pathSegments.length - 1];
        },
        formatTime(seconds) {
            const hrs = Math.floor(seconds / 3600);
            const mins = Math.floor((seconds % 3600) / 60);
            const secs = seconds % 60;

            return `${hrs.toString().padStart(2, '0')}:${mins.toString().padStart(2, '0')}:${secs.toString().padStart(2, '0')}`;
        },

        init() {
            this.examId = this.getIdFromUrl();
            this.fetchQuestions();

        },


        async fetchQuestions() {
            console.log(this.examId);
            console.log("/Test/TakeExamServer/" + this.examId)
            //fetch(`/Test/TakeExamServer/${this.examId}`)
            //    .then(response => response.json())
            //    .then(data => {
            //        this._listQuestion = data.questions;
            //        this.infoExam = data.examVM;
            //        this.infoExam.workTime = this.formatTime(this.infoExam.workTime);
            //        console.log(this._listQuestion, this.infoExam);
            //    })
            //    .catch(error => {
            //        console.error(error);
            //        alert('An error occurred. Please try again.');
            //    });

            try {
                const response = await fetch(`/Test/TakeExamServer/${this.examId}`);
                if (!response.ok) {
                    throw new Error(`Server error: ${response.status}`);
                }

                const data = await response.json();
                this._listQuestion = data.questions;
                this.infoExam = data.examVM;
                this.infoExam.workTime = this.formatTime(this.infoExam.workTime);
                console.log(this._listQuestion, this.infoExam);
            } catch (error) {
                console.error('Fetch error:', error);
                alert('An error occurred. Please try again.');
            }

        },



        async submitAnswers() {
            const payload = {
                resultId: this.resultId,
                userAnswers: Object.entries(this.userAnswers).map(([questionId, selectedOptionId]) => ({
                    questionId: parseInt(questionId),
                    selectedOptionId: parseInt(selectedOptionId),
                }))
            };

            try {
                const response = await fetch('/Test/SubmitTest', {
                    method: 'POST',
                    headers: { 'Content-Type': 'application/json' },
                    body: JSON.stringify(payload),
                });

                if (response.ok) {
                    const resultHtml = await response.text();
                    document.body.innerHTML = resultHtml; // Replace current page content with results
                } else {
                    alert('An error occurred while submitting the test.');
                }
            } catch (error) {
                console.error('Error:', error);
                alert('An error occurred. Please try again.');
            }
        },

    }));
});
