function confirmDelete(punktId) {
    var deleteModal = new bootstrap.Modal(document.getElementById('deleteModal'));
    deleteModal.show();

    document.getElementById('confirmDeleteButton').onclick = function () {
        fetch(`/Admin/Store/Delete/${punktId}`, {
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