function confirmDelete(UserId) {
    var deleteModal = new bootstrap.Modal(document.getElementById('deleteModal'));
    deleteModal.show();

    document.getElementById('confirmDeleteButton').onclick = function () {
        fetch(`/Admin/User/Delete/${UserId}`, {
            method: 'POST'
        })
            .then(response => {
                if (response.ok) {
                    location.reload(); // Səhifəni yeniləyin
                } else {
                    alert('An error occurred!');
                }
            })
            .catch(error => console.error('Error:', error));
    };
}
