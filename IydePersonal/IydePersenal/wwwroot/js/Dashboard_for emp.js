
document.addEventListener("DOMContentLoaded", function () {
    fetch('/Admin/Employee/GetEmployeeStatistics') // Controller adı ilə URL-i dəyişin

        .then(response => response.json())
        .then(data => {
            // Gender Chart
            new Chart(document.getElementById("genderChart"), {
                type: "pie",
                data: {
                    labels: ["Male", "Female"],
                    datasets: [{
                        data: [data.gender.male, data.gender.female],
                        backgroundColor: ["#3498db", "#e74c3c"]
                    }]
                },
                options: {
                    responsive: true,
                    maintainAspectRatio: false
                }
            });

            // Age Chart
            new Chart(document.getElementById("ageChart"), {
                type: "bar",
                data: {
                    labels: data.age.labels,
                    datasets: [{
                        label: "Employee Count by Age Group",
                        data: data.age.counts,
                        backgroundColor: "#2ecc71"
                    }]
                }
            });

            // Position Chart
            new Chart(document.getElementById("positionChart"), {
                type: "doughnut",
                data: {
                    labels: data.position.labels,
                    datasets: [{
                        data: data.position.counts,
                        backgroundColor: ["#9b59b6", "#f1c40f", "#e67e22", "#1abc9c"]
                    }]
                }
            });
        })
        .catch(error => console.error("Error loading data:", error));
});




