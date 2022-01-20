(() => {
  "use strict";
  var e = {};
  function o(e, o) {
    return 180 - (e + o);
  }
  ((e) => {
    "undefined" != typeof Symbol &&
      Symbol.toStringTag &&
      Object.defineProperty(e, Symbol.toStringTag, { value: "Module" }),
      Object.defineProperty(e, "__esModule", { value: !0 });
  })(e),
    console.log(o(30, 60), 90),
    console.log(o(60, 60), 60),
    (0, e.otherAngle)();
})();
