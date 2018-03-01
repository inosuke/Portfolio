$(function () {
    $(window).scroll(function () {
        var y = jQuery(this).scrollTop();
        $("#scroll").text("スクロール量：" + y); //追加
    });
});
//# sourceMappingURL=skrollr.js.map