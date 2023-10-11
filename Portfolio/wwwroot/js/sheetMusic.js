$(document).ready(function () {
    /******************************/
    /* PDF Viewer for Sheet Music */
    /******************************/
    var pdfModal = document.getElementById('pdf-viewer');
    pdfModal.addEventListener('show.bs.modal', function (event) {

        // Remove previous PDF from the viewer
        $('.embed-element').remove();

        // The button's ID is the name that the PDF can be reached with
        var viewButton = event.relatedTarget;
        var path = $('#' + viewButton.id + '-path').val();

        // This disables downloading the PDF
        path += "#toolbar=0";

        // Set the modal header
        var modalHeader = $('.' + viewButton.id + '-display-name').html();
        $('.modal-title').html(modalHeader);

        // Create the new embed element with the appropriate PDF
        var embedElement = document.createElement('iframe');
        embedElement.setAttribute('src', path);
        embedElement.setAttribute('class', 'embed-element responsive-iframe');
        embedElement.setAttribute('oncontextmenu', 'return false');  // This isn't working anymore......

        // Add the embed element
        $('#iframe').append(embedElement);
    })
})