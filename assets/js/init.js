$(document).ready(function () {
    "use strict";

    $('.button-collapse').sideNav();

    // Profeesional skills

    var determinatePos, windowPos, cheked = false;

    function refreshVar() {
        determinatePos = $('.determinate').offset().top;
        console.log(determinatePos)
    }
    refreshVar();
    $(window).resize(refreshVar);
    $(window).scroll(function () {
        windowPos = $(window).scrollTop() + 300;
        console.log(windowPos)
        if (windowPos > determinatePos - 500 && !cheked) {
            $('.determinate').each(function (index, value) {
                var progressBar = $(this),
                    width = 0,
                    verilenWidth = $(value).text();
                progressBar.empty();
                progressBar.width(width);

                var interval = setInterval(function () {
                    width += 3.5;
                    progressBar.css("width", width + "%");
                    progressBar.append('<i class="fa fa-circle"></i>');

                    if (width >= verilenWidth) {
                        clearInterval(interval);
                    }
                }, 100)
            });
            cheked = true;
        };
    });

    $('.cv-style-switch').click(function () {
        if ($(this).hasClass('open')) {
            $(this).removeClass('open');
            $('#switch-style').animate({
                'right': '0'
            });
        } else {
            $(this).addClass('open');
            $('#switch-style').animate({
                'right': '-300'
            });
        }
    });

    jQuery(window).on('load', function () {
        var $ = jQuery;
        $('.blog').masonry({
            itemSelector: '.blog-post',
            columnWidth: '.blog-post',
            percentPosition: true
        });
    });

    var height = $('.caption').height();
    if ($(window).width()) {
        $('#featured').css('height', height);
        $('#featured img').css('height', height);
    }

    $('.tooltipped').tooltip({
        delay: 50
    });

    var wow = new WOW({
        mobile: false
    });
    wow.init();

    /*** CONTACT FORM **/

    $("#contactForm").validator().on("submit", function (event) {
        if (event.isDefaultPrevented()) {
            // handle the invalid form...
            formError();
            submitMSG(false, "Did you fill in the form properly?");
        } else {
            // everything looks good!
            event.preventDefault();
            submitForm();
        }
    });

    function submitForm() {
        // Initiate Variables With Form Content
        var name = $("#name").val();
        var email = $("#email").val();
        var message = $("#message").val();

        $.ajax({
            type: "POST",
            url: "process.php",
            data: "name=" + name + "&email=" + email + "&message=" + message,
            success: function (text) {
                if (text == "success") {
                    formSuccess();
                } else {
                    formError();
                    submitMSG(false, text);
                }
            }
        });
    }

    function formSuccess() {
        $("#contactForm")[0].reset();
        submitMSG(true, "Message Sent!")
    }

    function formError() {
        $("#contactForm").removeClass().addClass('shake animated').one('webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend',
            function () {
                $(this).removeClass();
            });
    }

    function submitMSG(valid, msg) {
        if (valid) {
            var msgClasses = "h3 text-center fadeInUp animated text-success";
        } else {
            var msgClasses = "h3 text-center text-danger";
        }
        $("#msgSubmit").removeClass().addClass(msgClasses).text(msg);
    }


    /*** Projects ***/

    //    $('#portfolio-item').mixItUp();

    $('.sa-view-project-detail').on('click', function (event) {
        event.preventDefault();
        var href = $(this).attr('href') + ' ' + $(this).attr('data-action'),
            dataShow = $('#project-gallery-view'),
            dataShowMeta = $('#project-gallery-view meta'),
            dataHide = $('#portfolio-item'),
            preLoader = $('#loader'),
            backBtn = $('#back-button'),
            filterBtn = $('#filter-button');

        dataHide.animate({
            'marginLeft': '-120%'
        }, {
            duration: 400,
            queue: false
        });
        filterBtn.animate({
            'marginLeft': '-120%'
        }, {
            duration: 400,
            queue: false
        });
        dataHide.fadeOut(400);
        filterBtn.fadeOut(400);
        setTimeout(function () {
            preLoader.show();
        }, 400);
        setTimeout(function () {
            dataShow.load(href, function () {
                dataShowMeta.remove();
                preLoader.hide();
                dataShow.fadeIn(600);
                backBtn.fadeIn(600);
            });
        }, 800);
    });

    $('#back-button').on('click', function (event) {
        event.preventDefault();
        var dataShow = $('#portfolio-item'),
            dataHide = $('#project-gallery-view'),
            filterBtn = $('#filter-button');

        $("[data-animate]").each(function () {
            $(this).addClass($(this).attr('data-animate'));
        });

        dataHide.fadeOut(400);
        $(this).fadeOut(400);
        setTimeout(function () {
            dataShow.animate({
                'marginLeft': '0'
            }, {
                duration: 400,
                queue: false
            });
            filterBtn.animate({
                'marginLeft': '0'
            }, {
                duration: 400,
                queue: false
            });
            dataShow.fadeIn(400);
            filterBtn.fadeIn(400);
        }, 400);
        setTimeout(function () {
            dataShow.find('.fadeInRight, .fadeInLeft, .fadeInUp, .fadeInDown').removeClass('fadeInRight').removeClass('fadeInLeft').removeClass('fadeInUp').removeClass('fadeInDown');
        }, 1500);
    });
});