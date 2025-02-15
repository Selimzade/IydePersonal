function confirmDelete(employeeId) {
    var deleteModal = new bootstrap.Modal(document.getElementById('deleteModal'));
    deleteModal.show();

    document.getElementById('confirmDeleteButton').onclick = function () {
        const deleteDate = document.getElementById('deleteDate').value; // Tarix dəyərini alırıq
        if (!deleteDate) {
            alert(' Please select a date!');
            return;
        }

        fetch(`/Admin/Employee/Delete/${employeeId}`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ date: deleteDate }) // Tarixi JSON olaraq göndəririk
        })
            .then(response => {
                if (response.ok) {
                    location.reload(); // Səhifəni yeniləyin
                } else {
                    alert('An error occurred!');
                }
            })
            .catch(error => console.error('Error:', error));
    }
};