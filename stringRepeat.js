//Write a function called repeatStr which repeats the given string string exactly n times.

function repeatStr(n, s) {
  let str = "";
  for (let index = 0; index < n; index++) {
    str += s;
  }
  return str;
}

console.log(repeatStr(3, "*"), "***");
export default repeatStr;

//const repeatStr=(n, s)=>s.repeat(n);
