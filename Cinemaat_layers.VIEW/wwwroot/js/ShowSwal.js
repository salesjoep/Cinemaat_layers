$(function () {
    $('#showswal').click(function () {
        Swal.fire({
            title: 'Aan het laden...',
            allowEscapeKey: false,
            allowOutsideClick: false,
            onOpen: () => {
                swal.showLoading();
            }
        })
    })
}
)