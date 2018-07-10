$('#myModal').on('hidden.bs.modal', function () {
    $(this).find("input[type='text'],textarea").val('').end();
    $(this).find("select").val('-1').end();
});

function validationCheck() {
    if ($(".search-btn").attr("data-validation") != "") {
        var elements = $(".search-btn").parents(".filter-section").find("[data-check='']");
        elements.addClass("validation-error");
    } else {
        console.log("true");
    }
}
$(document).ready(function () {
    var pathname = window.location.pathname.substring(0, 3);
    $(".langSection ul li").each(function () {
        $(this).removeClass("active");
        if ($(this).attr("data-lang") === pathname) {
            $(this).addClass("active");
        }
    })

});