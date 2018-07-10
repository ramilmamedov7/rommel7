"use strict";

$(document).ready(function () {
  console.clear();
  // Side Nav Menu
  $(".button-collapse").sideNav();
  // Interest Tooltip
  $(".tooltipped").tooltip({
    delay: 20
  });
  // AnimateCSS, WOW.js
  var wow = new WOW({ mobile: false });
  wow.init();
  // Profeesional skills
  var determinatePos = void 0,
      windowPos = void 0,
      cheked = false;

  function refreshVar() {
    determinatePos = $(".determinate").offset().top;
  }
  refreshVar();
  $(window).resize(refreshVar());
  $(window).scroll(function () {
    windowPos = $(window).scrollTop() + 300;
    if (windowPos > determinatePos - 500 && !cheked) {
      $(".determinate").each(function (index, value) {
        var progressBar = $(this),
            width = 0,
            verilenWidth = $(value).text();
        progressBar.empty();
        progressBar.width(width);
        var interval = setInterval(function () {
          width += 3.5;
          progressBar.css("width", width + "%");

          if (width >= verilenWidth) {
            clearInterval(interval);
          }
        }, 100);
        var circle = '<i class="fa fa-circle" style="position: absolute; top: -8px; right: 0;"></i>';
        progressBar.append(circle);
      });
      cheked = true;
    }
  });
  //  MixItUp on projects page
  var mixItUrl = 'https://rommel7.github.io/portfolio.html';
  var localUrl = 'http://localhost:3000/portfolio.html';

  if (window.location.href == localUrl) {
    $('.screenshots').mixItUp();
  }
});