(() => {
  const o = {};
  function e(o) {
    return Number(o.toString(2));
  }
  ((o) => {
    typeof Symbol !== "undefined" &&
      Symbol.toStringTag &&
      Object.defineProperty(o, Symbol.toStringTag, { value: "Module" }),
      Object.defineProperty(o, "__esModule", { value: !0 });
  })(o),
    console.log(e(1)),
    console.log(e(2)),
    console.log(e(3)),
    console.log(e(5)),
    (0, o.toBinary)();
})();
