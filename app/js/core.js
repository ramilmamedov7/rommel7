 $(document).ready(function () {
   console.clear();
   // Side Nav Menu
   $(".button-collapse").sideNav();
   // Interest Tooltip
   $(".tooltipped").tooltip({
     delay: 20
   });
   // AnimateCSS, WOW.js
   let wow = new WOW({ mobile: false });
   wow.init();
   // Profeesional skills
   let determinatePos,
     windowPos,
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
         let progressBar = $(this),
           width = 0,
           verilenWidth = $(value).text();
         progressBar.empty();
         progressBar.width(width);
         let interval = setInterval(function () {
           width += 3.5;
           progressBar.css("width", width + "%");

           if (width >= verilenWidth) {
             clearInterval(interval);
           }
         }, 100);
         const circle = '<i class="fa fa-circle" style="position: absolute; top: -8px; right: 0;"></i>';
         progressBar.append(circle);
       });
       cheked = true;
     }
   });
   //  MixItUp on projects page
   let mixItUrl = 'https://rommel7.github.io/portfolio.html';
   let localUrl = 'http://localhost:3000/portfolio.html';

   if (window.location.href == mixItUrl) {
     $('.screenshots').mixItUp();
   }
 });