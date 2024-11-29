//function getChartColorsArray(e) {
//    if (null !== document.getElementById(e)) {
//        var t = document.getElementById(e).getAttribute("data-colors");
//        if (t)
//            return (t = JSON.parse(t)).map(function (e) {
//                var t = e.replace(" ", "");
//                return -1 === t.indexOf(",")
//                    ? getComputedStyle(document.documentElement).getPropertyValue(t) || t
//                    : 2 == (e = e.split(",")).length
//                        ? "rgba(" +
//                        getComputedStyle(document.documentElement).getPropertyValue(e[0]) +
//                        "," +
//                        e[1] +
//                        ")"
//                        : t;
//            });
//        console.warn("data-colors atributes not found on", e);
//    }
//}
//var worldlinemap,
//    vectorMapWorldLineColors = getChartColorsArray("users-by-country"),
//    barchartCountriesColors =
//        (vectorMapWorldLineColors &&
//            (worldlinemap = new jsVectorMap({
//                map: "world_merc",
//                selector: "#users-by-country",
//                zoomOnScroll: !1,
//                zoomButtons: !1,
//                markers: [
//                    { name: "Greenland", coords: [72, -42] },
//                    { name: "Canada", coords: [56.1304, -106.3468] },
//                    { name: "Brazil", coords: [-14.235, -51.9253] },
//                    { name: "Egypt", coords: [26.8206, 30.8025] },
//                    { name: "Russia", coords: [61, 105] },
//                    { name: "China", coords: [35.8617, 104.1954] },
//                    { name: "United States", coords: [37.0902, -95.7129] },
//                    { name: "Norway", coords: [60.472024, 8.468946] },
//                    { name: "Ukraine", coords: [48.379433, 31.16558] },
//                ],
//                lines: [
//                    { from: "Canada", to: "Egypt" },
//                    { from: "Russia", to: "Egypt" },
//                    { from: "Greenland", to: "Egypt" },
//                    { from: "Brazil", to: "Egypt" },
//                    { from: "United States", to: "Egypt" },
//                    { from: "China", to: "Egypt" },
//                    { from: "Norway", to: "Egypt" },
//                    { from: "Ukraine", to: "Egypt" },
//                ],
//                regionStyle: {
//                    initial: {
//                        stroke: "#9599ad",
//                        strokeWidth: 0.25,
//                        fill: vectorMapWorldLineColors,
//                        fillOpacity: 1,
//                    },
//                },
//                lineStyle: { animation: !0, strokeDasharray: "6 3 6" },
//            })),
//            getChartColorsArray("countries_charts"));
//function generateData(e, t) {
//    for (var o = 0, a = []; o < e;) {
//        var r = (o + 1).toString() + "h",
//            s = Math.floor(Math.random() * (t.max - t.min + 1)) + t.min;
//        a.push({ x: r, y: s }), o++;
//    }
//    return a;
//}
//barchartCountriesColors &&
//    ((options = {
//        series: [
//            {
//                data: [1010, 1640, 490, 1255, 1050, 689, 800, 420, 1085, 589],
//                name: "Sessions",
//            },
//        ],
//        chart: { type: "bar", height: 436, toolbar: { show: !1 } },
//        plotOptions: {
//            bar: {
//                borderRadius: 4,
//                horizontal: !0,
//                distributed: !0,
//                dataLabels: { position: "top" },
//            },
//        },
//        colors: barchartCountriesColors,
//        dataLabels: {
//            enabled: !0,
//            offsetX: 32,
//            style: { fontSize: "12px", fontWeight: 400, colors: ["#adb5bd"] },
//        },
//        legend: { show: !1 },
//        grid: { show: !1 },
//        xaxis: {
//            categories: [
//                "India",
//                "United States",
//                "China",
//                "Indonesia",
//                "Russia",
//                "Bangladesh",
//                "Canada",
//                "Brazil",
//                "Vietnam",
//                "UK",
//            ],
//        },
//    }),
//        (chart = new ApexCharts(
//            document.querySelector("#countries_charts"),
//            options
//        )).render());
//var columnoptions,
//    options,
//    chart,
//    chartHeatMapBasicColors = getChartColorsArray(
//        "audiences-sessions-country-charts"
//    ),
//    chartAudienceColumnChartsColors =
//        (chartHeatMapBasicColors &&
//            ((options = {
//                series: [
//                    { name: "Sat", data: generateData(18, { min: 0, max: 90 }) },
//                    { name: "Fri", data: generateData(18, { min: 0, max: 90 }) },
//                    { name: "Thu", data: generateData(18, { min: 0, max: 90 }) },
//                    { name: "Wed", data: generateData(18, { min: 0, max: 90 }) },
//                    { name: "Tue", data: generateData(18, { min: 0, max: 90 }) },
//                    { name: "Mon", data: generateData(18, { min: 0, max: 90 }) },
//                    { name: "Sun", data: generateData(18, { min: 0, max: 90 }) },
//                ],
//                chart: {
//                    height: 400,
//                    type: "heatmap",
//                    offsetX: 0,
//                    offsetY: -8,
//                    toolbar: { show: !1 },
//                },
//                plotOptions: {
//                    heatmap: {
//                        colorScale: {
//                            ranges: [
//                                { from: 0, to: 50, color: chartHeatMapBasicColors[0] },
//                                { from: 51, to: 100, color: chartHeatMapBasicColors[1] },
//                            ],
//                        },
//                    },
//                },
//                dataLabels: { enabled: !1 },
//                legend: {
//                    show: !0,
//                    horizontalAlign: "center",
//                    offsetX: 0,
//                    offsetY: 20,
//                    markers: { width: 20, height: 6, radius: 2 },
//                    itemMargin: { horizontal: 12, vertical: 0 },
//                },
//                colors: chartHeatMapBasicColors,
//                tooltip: {
//                    y: [
//                        {
//                            formatter: function (e) {
//                                return void 0 !== e ? e.toFixed(0) + "k" : e;
//                            },
//                        },
//                    ],
//                },
//            }),
//                (chart = new ApexCharts(
//                    document.querySelector("#audiences-sessions-country-charts"),
//                    options
//                )).render()),
//            getChartColorsArray("audiences_metrics_charts")),
//    dountchartUserDeviceColors =
//        (chartAudienceColumnChartsColors &&
//            ((columnoptions = {
//                series: [
//                    {
//                        name: "Current Year",
//                        data: [
//                            36.2, 22.4, 38.2, 30.5, 26.4, 30.4, 20.2, 29.6, 10.9, 36.2, 22.4,
//                            38.2,
//                        ],
//                    },
//                ],
//                chart: { type: "bar", height: 309, stacked: !0, toolbar: { show: !1 } },
//                plotOptions: {
//                    bar: { horizontal: !1, columnWidth: "20%", borderRadius: 6 },
//                },
//                dataLabels: { enabled: !1 },
//                legend: {
//                    show: !0,
//                    position: "bottom",
//                    horizontalAlign: "center",
//                    fontWeight: 400,
//                    fontSize: "8px",
//                    offsetX: 0,
//                    offsetY: 0,
//                    markers: { width: 9, height: 9, radius: 4 },
//                },
//                stroke: { show: !0, width: 2, colors: ["transparent"] },
//                grid: { show: !1 },
//                colors: chartAudienceColumnChartsColors,
//                xaxis: {
//                    categories: [
//                        "Jan",
//                        "Feb",
//                        "Mar",
//                        "Apr",
//                        "May",
//                        "Jun",
//                        "Jul",
//                        "Aug",
//                        "Sep",
//                        "Oct",
//                        "Nov",
//                        "Dec",
//                    ],
//                    axisTicks: { show: !1 },
//                    axisBorder: {
//                        show: !0,
//                        strokeDashArray: 1,
//                        height: 1,
//                        width: "100%",
//                        offsetX: 0,
//                        offsetY: 0,
//                    },
//                },
//                yaxis: { show: !1 },
//                fill: { opacity: 1 },
//            }),
//                (chart = new ApexCharts(
//                    document.querySelector("#audiences_metrics_charts"),
//                    columnoptions
//                )).render()),
//            getChartColorsArray("user_device_pie_charts"));
//dountchartUserDeviceColors &&
//    ((options = {
//        series: [78.56, 105.02, 42.89],
//        labels: ["Desktop", "Mobile", "Tablet"],
//        chart: { type: "donut", height: 219 },
//        plotOptions: { pie: { size: 100, donut: { size: "76%" } } },
//        dataLabels: { enabled: !1 },
//        legend: {
//            show: !1,
//            position: "bottom",
//            horizontalAlign: "center",
//            offsetX: 0,
//            offsetY: 0,
//            markers: { width: 20, height: 6, radius: 2 },
//            itemMargin: { horizontal: 12, vertical: 0 },
//        },
//        stroke: { width: 0 },
//        yaxis: {
//            labels: {
//                formatter: function (e) {
//                    return e + "k Users";
//                },
//            },
//            tickAmount: 4,
//            min: 0,
//        },
//        colors: dountchartUserDeviceColors,
//    }),
//        (chart = new ApexCharts(
//            document.querySelector("#user_device_pie_charts"),
//            options
//        )).render());

// Hàm lấy màu sắc từ data-attributes

function getChartColorsArray(elementId) {
    const element = document.getElementById(elementId);
    if (element) {
        const colors = JSON.parse(element.getAttribute("data-colors"));
        return colors.map(color => {
            const cssVar = getComputedStyle(document.documentElement).getPropertyValue(color);
            return cssVar || color;
        });
    } else {
        console.warn(`Element with ID '${elementId}' not found.`);
        return [];
    }
}
// Lấy idExam từ URL
const currentURL = window.location.href; // URL hiện tại
const idExam = currentURL.split("/").pop(); // Lấy giá trị idExam từ phần cuối của URL

// Thiết lập dữ liệu và render biểu đồ cột
const colors = getChartColorsArray("audiences_metrics_charts");
if (colors) {

    // Lấy dữ liệu từ server qua API (nếu có)
    fetch("/Admin/Exam/ListStudentOfTakingExam/" + idExam)
        .then(response => response.json())
        .then(data => {
            const options = {
                series: [
                    {
                        name: "Scores",
                        data: data.scores, // Dữ liệu từ server
                    },
                ],
                chart: { type: "bar", height: 350, toolbar: { show: false } },
                plotOptions: {
                    bar: { horizontal: false, columnWidth: "50%", borderRadius: 5 },
                },
                xaxis: {
                    categories: ["<= 1", "<= 2", "<= 3", "<= 4", " <=5", "<= 6", "<= 7", "<= 8", "<= 9", "<= 10"], // Trục x từ 1 đến 10
                },
                colors: colors,
                dataLabels: { enabled: true },
                yaxis: { title: { text: "Số lượng học sinh" } },
                grid: { borderColor: "#f1f1f1" },
            };

            const chart = new ApexCharts(document.querySelector("#audiences_metrics_charts"), options);
            chart.render();
        })
        .catch(error => console.error("Lỗi khi tải dữ liệu:", error));
}







