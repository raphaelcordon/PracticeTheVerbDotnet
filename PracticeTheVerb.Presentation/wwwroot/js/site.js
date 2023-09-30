// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Function to automatically close alerts after a specified time (in milliseconds)
function closeAlerts() {
    $(".alert").fadeTo(2000, 500).slideUp(500, function () {
        $(".alert").slideUp(500);
    });
}

// Call the closeAlerts function when the document is ready
$(document).ready(function () {
    closeAlerts();
});