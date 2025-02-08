
$(document).ready(function () {
    var yearlyEmployeesUrl = app.Urls.totalusercountUrlss;
   
        $.ajax({
            url: yearlyEmployeesUrl, //"Admin/Home/YearlyEmployeeCounts", // Backend URL
            method: "GET",
            success: function (response) {
                var ctx = document.getElementById("startYearChart").getContext("2d");
                var datasets = [];

                // Rəng palitrası
                var colors = [
                    "rgba(255, 99, 132, 0.6)",
                    "rgba(54, 162, 235, 0.6)",
                    "rgba(255, 206, 86, 0.6)",
                    "rgba(75, 192, 192, 0.6)",
                    "rgba(153, 102, 255, 0.6)",
                    "rgba(255, 159, 64, 0.6)"
                ];

                var borderColors = [
                    "rgba(255, 99, 132, 1)",
                    "rgba(54, 162, 235, 1)",
                    "rgba(255, 206, 86, 1)",
                    "rgba(75, 192, 192, 1)",
                    "rgba(153, 102, 255, 1)",
                    "rgba(255, 159, 64, 1)"
                ];

                Object.keys(response).forEach((year, index) => {
                    datasets.push({
                        label: year + " Employees",
                        data: response[year],
                        backgroundColor: colors[index % colors.length],
                        borderColor: borderColors[index % borderColors.length],
                        borderWidth: 1
                    });
                });


                new Chart(ctx, {
                    type: "bar",
                    data: {
                        labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"],
                        datasets: datasets
                    },
                    options: {
                        responsive: true,
                        maintainAspectRatio: false, // Ölçünü məhdudlaşdırır
                        scales: {
                            y: { beginAtZero: true }
                        }
                    }
                });
            },
            error: function (error) {
                console.log("Error fetching data:", error);
            }
        });
   
});