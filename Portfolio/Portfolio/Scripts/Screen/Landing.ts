'use strict';

namespace Portfolio {
    $(window).on("load", (event: Event) => {
        $("#factory-btn").on("click", () => {
            window.location.href = "/Portfolio/Factory";
        })
    });
} 