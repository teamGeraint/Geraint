$(function () {
    checktext();
    initEleEvents();

});

function initEleEvents() {
    $("#login").click(function () {
        $(".loginFunc div").addClass("sel");
        $(this).removeClass("sel");
        $("#btnreg").hide();
        $("#btnnext").hide();
        $(".errortip").text("");
        $(".loginForm").animate({"height":"110px"},500)
       
    })
    $("#register").click(function () {
        $(".loginFunc div").addClass("sel");
        $(this).removeClass("sel");
        $("#btnreg").show();
        $("#btnnext").show();
        $(".errortip").text("");
        $(".loginForm").animate({"height":"230px"},500)
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

    $("#regidInput").blur(function () {
            $.ajax({
                url: "ws/mydb.asmx/selectUserID",
                type: "POST",
                contentType: "application/json",
                data: "{uid:" + $("#regidInput").val() + "}",
                dataType: "json",
                success: function (res) {
                    $("#tipregid").text(res.d);
                    

                }

            });

        });

    $(".loginCrowd input").blur(function(){
        $(this).next().text("");
        



    })
    $("#btnnext").click(function(){
        $("#mainb").show();


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
    //$(".errortip").text("");
}