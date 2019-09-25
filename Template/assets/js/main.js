$(document).ready(function () {
  $('.sidenav').sidenav();
 
 $('.modal').modal(); 
  //$('.materialboxed').materialbox();
  
  $('.parallax').parallax();
  
  $('.tabs').tabs();
  
  // $('.datepicker').datepicker(
  //     {
  //         disableWeekends:true
  //     }
  // );
  });

  $('select').formSelect();
  $('.tooltipped').tooltip({delay: 50});

  
  // document.addEventListener('DOMContentLoaded', function() {
  //   var elems = document.querySelectorAll('.sidenav');
  //   var instances = M.Sidenav.init(elems, options);
  // });