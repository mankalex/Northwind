$(function(){
    $(".code").click(function(e) {

        var sound = new Audio('/sounds/whatsapp.mp3');
        e.preventDefault();
        sound.pause();
        sound.currentTime = 0;

        var code = $(this).data("code");
        var product = $(this).data("product");

        $(".toast-body").html(`${product} :  ${code}`);

        $(".toast").toast('show');
        sound.play();
    });
});