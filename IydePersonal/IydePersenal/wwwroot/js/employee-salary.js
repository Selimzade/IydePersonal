
    function loadSalaryDetails(employeeId) {
        console.log("Employee ID:", employeeId); // Konsolda yoxlayın

    // Modalı açırıq
    $("#inventoryModal").modal("show");

    // Mövcud cədvəli təmizləyirik ki, köhnə məlumatlar qalmasın
    $("#inventoryTableBody").html("");
    $("#employeeId").val(employeeId);

    $.ajax({
        url: `/Admin/Salary/GetSalaryByEmployee?employeeId=${employeeId}`,
    type: "GET",
    success: function (data) {
        console.log("Gələn data:", data); // Konsolda yoxlayın

    // Əgər data boşdursa, mesaj göstərək
    if (!data || data.length === 0) {
        $("#inventoryTableBody").html("<tr><td colspan='10' style='text-align:center; color:red;'>Bu işçiyə aid maaş tapılmadı</td></tr>");
    return;
                }

                data.forEach(salary => {
        $("#inventoryTableBody").append(`
                        <tr>
                            <td>${salary.fixSalary}</td>
                            <td>${salary.payment}</td>
                            <td>${salary.sales}</td>
                            <td>${salary.totalCheck}</td>
                            <td>${salary.award}</td>
                            <td>${salary.penalty}</td>
                            <td>${salary.countingdown}</td>
                            <td>${salary.additionalBonus}</td>
                            <td>${salary.conclusion}</td>
                            <td>${new Date(salary.createDate).toISOString().split('T')[0]}</td>
                            <td>
                            
                             <button class="btn btn-danger btn-sm" onclick="deleteInventory(${salary.id}, ${employeeId})">Delete</button>
                            </td>
                        </tr>
                    `);
                });
            },
            // error: function (xhr, status, error) {
        //     console.log("Xəta:", xhr.responseText);
        //     alert("Xəta baş verdi!");
        // }
    });
    }

    function loadaddSalaryDetails(){
        $("#addEditInventoryForm").show();
    $("#salaryId").val("");
    $("#fixsalary").val("");
    $("#payment").val("");
    $("#sales").val("");
    $("#totalcheck").val("");
    $("#award").val("");
    $("#penalty").val("");
    $("#countingdown").val("");
    $("#additionalbonus").val("");
    $("#conclusion").val("");
    $("#tarix").val("");

}

    function editInventory(id, fixsalary, payment,sales,totalcheck,award,penalty,countingdown,additionalBonus,conclusion,tarix) {
        $("#addEditInventoryForm").show();
        $("#salaryId").val(id);
        $("#fixsalary").val(fixsalary);
        $("#payment").val(payment);
        $("#sales").val(sales);
        $("#totalcheck").val(totalcheck);
        $("#award").val(award);
        $("#penalty").val(penalty);
        $("#countingdown").val(countingdown);
        $("#additionalbonus").val(additionalBonus);
        $("#conclusion").val(conclusion);
        $("#tarix").val(tarix);

}

    function saveInventory() {
    var inventory = {
    Id: $("#salaryId").val() || 0,
    EmployeeId: $("#employeeId").val(),
    Fixsalary: $("#fixsalary").val(),
    Payment: $("#payment").val(),
    Sales: $("#sales").val(),
    Totalcheck: $("#totalcheck").val(),
    Award: $("#award").val(),
    Penalty: $("#penalty").val(),
    Countingdown: $("#countingdown").val(),
    Additionalbonus: $("#additionalbonus").val(),
    Conclusion: $("#conclusion").val(),
    Tarix: $("#tarix").val()
    };

    var url = inventory.Id == 0 ? "/Admin/Salary/AddSalary" : "/Admin/Salary/UpdateSalary";

    $.ajax({
        url: url,
    type: "POST",
    contentType: "application/json",
    data: JSON.stringify(inventory),
    success: function () {
        alert("Əməliyyat uğurla tamamlandı!");
    $("#inventoryModal").modal("hide");
    location.reload();
        },
    error: function (xhr) {
        alert("Xəta: " + xhr.responseText);
        }
    });
}

    function deleteInventory(id, employeeId) {
    if (!confirm("Bu inventarı silmək istədiyinizə əminsiniz?")) return;

    $.ajax({
        url: `/Admin/Salary/DeleteSalary?id=${id}&employeeId=${employeeId}`,
    type: "POST",
    success: function () {
        alert("İnventar silindi!");
    openInventoryModal(employeeId);
        },
    error: function (xhr) {
        alert("Xəta: " + xhr.responseText);
        }
    });
}

