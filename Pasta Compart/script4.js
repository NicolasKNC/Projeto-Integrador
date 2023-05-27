function mostrarCampoPix() {
  var selecao = document.getElementById("pagamento");
  var avisoPix = document.getElementById("avisoPix");

  if (selecao.value === "pix") {
    avisoPix.style.display = "block";
  } else {
    avisoPix.style.display = "none";
  }
}