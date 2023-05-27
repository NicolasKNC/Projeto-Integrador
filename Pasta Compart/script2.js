var imagens = ["Mercedes_CLA200.jpg", "cla200part2.jpg", "cla200part3.jpg"];
var indice = 0;

function trocar() {
  var imagem = document.getElementById("imagem");
  indice = (indice + 1) % imagens.length;
  imagem.src = imagens[indice];
}
