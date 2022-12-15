
function calcular(i) {
    var precio = parseFloat(document.getElementById("precio " + i).value);
    console.log(precio);
    var cant = parseInt(document.getElementById("cant " + i).value);
    var cant1 = "cant " + i;
    console.log(cant1);
    var total = document.getElementById("total " + i).value = precio * cant;
    console.log(total);
}

function total(i) {
    var total2 = 0;
    for (var j = 0; j < i; j++) {
        total2 = parseInt(document.getElementById("total " + j).value) + total2;
    }
    var total = document.getElementById("totalF").value = "S/." + total2;
    console.log(total2);
}