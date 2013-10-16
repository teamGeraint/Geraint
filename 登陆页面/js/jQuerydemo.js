$(function(){
	checktext();
    initEleEvents();
    	
});

function initEleEvents(){
	$(".login").mouseover(function(){
        $("#loginBlock1").hide();
        $("#loginBlock").show();
    })
    $(".register").mouseover(function(){
        $("#loginBlock").hide();
        $("#loginBlock1").show();
    })
    $(".pwdInputLine input").keydown(function(){
        $(this).css("background-image","none");
    });
    $(".idInputLine input").keydown(function(){
        $(this).css("background-image","none");
    });

    $(".idInput").keyup(function(e){

        var val=$(".idInput").val();
        if (val=="") {

           $(this).css("background-image",'url("css/images/zhanghao.jpg")');
        }
        else{$(this).css("background-image","none");};
        
    });
    $("#idInput1").keyup(function(e){

        var val=$("#idInput1").val();
        if (val=="") {

           $(this).css("background-image",'url("css/images/youxiang.jpg")');
        }
        else{$(this).css("background-image","none");};
        
    });
    $(".pwdInput").keyup(function(e){

        var val=$(".pwdInput").val();
        if (val=="") {

           $(this).css("background-image",'url("css/images/mima.jpg")');
        }
        else{$(this).css("background-image","none");};
        
    });
    
    $("#pwdInput1").keyup(function(){
        var val=$("#pwdInput1").val();
        if (val=="") {

           $(this).css("background-image",'url("css/images/querenmima.jpg")');
        }
        else{$(this).css("background-image","none");};
        
    });
    }

function checktext(){
            $(".idInput").val("");
            $("#idInput1").val("");
            $(".pwdInput").val("");
            $("#pwdInput1").val("");
            
            $(".idInput").css("background-image",'url("css/images/zhanghao.jpg")');
            $("#idInput1").css("background-image",'url("css/images/youxiang.jpg")');
            $(".pwdInput").css("background-image",'url("css/images/mima.jpg")');
            $("#pwdInput1").css("background-image",'url("css/images/querenmima.jpg")');
}