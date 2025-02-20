function openInventoryModal(storeId) {
    $("#inventoryModal").modal("show");
    $("#storeId").val(storeId);

    $.ajax({
        url: `/Admin/StoreInventory/GetInventories?storeId=${storeId}`,
        type: "GET",
        success: function (data) {
            $("#inventoryTableBody").html("");
            data.forEach(inventory => {
                $("#inventoryTableBody").append(`
                    <tr>
                        <td>${inventory.name}</td>
                        <td>${inventory.count}</td>
                        <td>${inventory.price}</td>
                        <td>${inventory.supplier}</td>
                        <td>${new Date(inventory.addedDate).toISOString().split('T')[0]}</td>
                        <td>${new Date(inventory.lastUpdated).toLocaleDateString('az-AZ')}</td>
                        <td>${inventory.codebar}</td>
                        <td>${inventory.description}</td>
                        <td>
                            <button class="btn btn-warning btn-sm" onclick="editInventory(${inventory.id}, '${inventory.name.replace(/'/g, "\\'")}', ${inventory.count}, ${inventory.price}, ${inventory.supplier},${inventory.codebar}, '${inventory.description.replace(/'/g, "\\'")}')">Edit</button>
                            <button class="btn btn-danger btn-sm" onclick="deleteInventory(${inventory.id}, ${storeId})">Delete</button>
                        </td>
                    </tr>
                `);
            });
        }
    });
}

function openAddInventoryForm() {
    $("#addEditInventoryForm").show();
    $("#inventoryId").val("");
    $("#name").val("");
    $("#count").val("");
    $("#price").val("");
    $("#supplier").val("");
    $("#codebar").val("");
    $("#description").val("");

}

function editInventory(id, name, count, price, supplier, codebar, description) {
    $("#addEditInventoryForm").show();
    $("#inventoryId").val(id);
    $("#name").val(name);
    $("#count").val(count);
    $("#price").val(price);
    $("#supplier").val(supplier);
    $("#codebar").val(codebar);
    $("#description").val(description);

}

function saveInventory() {
    var inventory = {
        Id: $("#inventoryId").val() || 0,
        StoreId: $("#storeId").val(),
        Name: $("#name").val(),
        Count: $("#count").val(),
        Price: $("#price").val(),
        Supplier: $("#supplier").val(),
        Codebar: $("#codebar").val(),
        Description: $("#description").val()

    };

    var url = inventory.Id == 0 ? "/Admin/StoreInventory/AddInventory" : "/Admin/StoreInventory/UpdateInventory";

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

function deleteInventory(id, storeId) {
    if (!confirm("Bu inventarı silmək istədiyinizə əminsiniz?")) return;

    $.ajax({
        url: `/Admin/StoreInventory/DeleteInventory?id=${id}&storeId=${storeId}`,
        type: "POST",
        success: function () {
            alert("İnventar silindi!");
            openInventoryModal(storeId);
        },
        error: function (xhr) {
            alert("Xəta: " + xhr.responseText);
        }
    });
}
