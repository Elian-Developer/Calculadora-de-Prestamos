// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var tasa = document.getElementById("Tipoprestamo");
document.getElementById("interes").value = tasa.value

function cambiarTasa() {
    var tasa = document.getElementById("Tipoprestamo");

    if (tasa.selectedIndex >= 0) {
        var option = document.createElement("option");
        option.text = "Cambio";
        var select = tasa.options[tasa.selectedIndex];
        tasa.add(tasa, select);
    }
}

var act = document.getElementById("Tipoprestamo");

act.addEventListener("click", function () {
    document.getElementById("interes").value = tasa.value
});

actvities.addEventListener("change", function () {
    document.getElementById("interes").value = tasa.value;
});