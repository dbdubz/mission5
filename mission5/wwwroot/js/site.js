// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
document.addEventListener("DOMContentLoaded", function () {
    // variables
    var letter = $("#letter").val();
    var possible = ["A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "E"]

    // if the grade is acceptable, show the grade
    for (let i = 0; i < possible.length; i++) {
        if (letter === possible[i]) {
            $("#print_grade").removeAttr("hidden");
        }
    }
}, false);