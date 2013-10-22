$(function () {
    initEvents();
    checkTxt();
});

function initEvents() {
    $("#find").keyup(function (e) {
        checkTxt();
        if (e.keyCode == 13) {
            search();
        }
    });

    $("#bigger").click(function () {
        search();

    });
}
function checkTxt() {
    var val = $("#find").val();

    if (val == "") {
        $("#find").css("background-image", 'url("../images/Crowd/search.png")');

    } else {
        $("#find").css("background-image", "none");
    }

}