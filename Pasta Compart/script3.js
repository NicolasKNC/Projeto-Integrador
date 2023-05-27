window.addEventListener('DOMContentLoaded', function() {
    var horarioInput = document.getElementById('horario');
    var esportivosDiv = document.getElementById('esportivos');
  
    horarioInput.addEventListener('input', function() {
      var horario = horarioInput.value;
      var hora = horario.split(':')[0];
  
      if (hora >= 18) {
        esportivosDiv.style.display = 'none';
        alert ("Apartir das 18 horas os carros esportivos não ficaram disponiveis");
      } else {
        esportivosDiv.style.display = 'block';
      }

     
    });
  });
  