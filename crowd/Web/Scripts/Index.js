$(function () {
    checktext();
    initEleEvents();

});

function initEleEvents() {
    $(".login").click(function () {
        $("#loginBlock1").hide();
        $("#loginBlock").show();
    })
    $(".register").click(function () {
        $("#loginBlock").hide();
        $("#loginBlock1").show();
    })
    $(".pwdInputLine input").keydown(function () {
        $(this).css("background-image", "none");
    });
    $(".idInputLine input").keydown(function () {
        $(this).css("background-image", "none");
    });

    $(".idInput").keyup(function (e) {

        var val = $(this).val();
        if (val == "") {

            $(this).css("background-image", 'url("../images/Index/zhanghao.jpg")');
        }
        else { $(this).css("background-image", "none"); };

    });
    $("#regemailInput").keyup(function (e) {

        var val = $(this).val();
        if (val == "") {

            $(this).css("background-image", 'url("../images/Index/youxiang.jpg")');
        }
        else { $(this).css("background-image", "none"); };

    });
    $(".pwdInput").keyup(function (e) {

        var val = $(this).val();
        if (val == "") {

            $(this).css("background-image", 'url("../images/Index/mima.jpg")');
        }
        else { $(this).css("background-image", "none"); };

    });

    $("#regpwdInput2").keyup(function () {
        var val = $("#regpwdInput2").val();
        if (val == "") {

            $(this).css("background-image", 'url("../images/Index/querenmima.jpg")');
        }
        else { $(this).css("background-image", "none"); };

    });
}

function checktext() {
    $(".idInput").val("");
    $("#idInput1").val("");
    $(".pwdInput").val("");
    $("#pwdInput1").val("");
    $(".idInput").css("background-image", 'url("../images/Index/zhanghao.jpg")');
    $("#regemailInput").css("background-image", 'url("../images/Index/youxiang.jpg")');
    $(".pwdInput").css("background-image", 'url("../images/Index/mima.jpg")');
    $("#regpwdInput2").css("background-image", 'url("../images/Index/querenmima.jpg")');
}