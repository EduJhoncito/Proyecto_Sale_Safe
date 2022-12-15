// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var precioUnitario;
var precioTotal;
var cantidad;

$(document).ready(function () {

	$(window).scroll(function () {
		if ($(this).scrollTop() > 0) {
			$('.header').addClass('header2');
		} else {
			$('.header').removeClass('header2');
		}
	});

	$('.carousel').carousel({
		interval: 2000,
		pause: "hover",
		wrap: true
	})

	$()
});

$('#myModal').on('shown.bs.modal', function () {
	$('#myInput').trigger('focus')
})

function login() {
	var email = "eduardo@gmail.com";
	var password = "12345";

	if (email == document.getElementById("txtEmail-login").value && password == document.getElementById("txtContraseña-login").value) {
		location.href = "https://localhost:44366/pedidos1.html";
	} else {
		alert("Error al ingresar el correo electrónico o contraseña");
	}
}

function decrementar() {
	if (document.getElementById("contador").value == 1) {
		document.getElementById("contador").value++;

	}
	else {
		document.getElementById("contador").value--;
	}
}

function incrementar() {
	document.getElementById("contador").value++;
}

function compra() {
	precioUnitario = document.getElementById("precio-unidad").value;
	cantidad = document.getElementById("contador").value;
	precioTotal = precioUnitario * cantidad;

	document.getElementById("txtSubtotal").value = precioUnitario;
	document.getElementById("txtTotal").value = precioTotal;
}

function irComprar() {
	window.location = "fechaEntrega.html";
}

const fecha = new Date();

var dia = fecha.getDate();
var mes = fecha.getMonth() + 1;
var año = fecha.getFullYear();
var limite = 30 - 8;
var diaFinal;
var adicional;

if (dia <= limite) {
	diaFinal = dia + 8;
} else {
	adicional = 30 - dia;
	diaFinal = 1 + adicional;
	mes = mes + 1;
}

var fechaEntrega = diaFinal + "." + mes + "." + año;
document.getElementById("fechaEntrega").value = fechaEntrega;
