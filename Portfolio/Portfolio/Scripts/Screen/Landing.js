'use strict';
var Portfolio;
(function (Portfolio) {
    $(window).on("load", function (event) {
        $("#factory-btn").on("click", function () {
            window.location.href = "/Portfolio/Factory";
        });
    });
})(Portfolio || (Portfolio = {}));
//# sourceMappingURL=Landing.js.map