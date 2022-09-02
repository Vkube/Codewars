//Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.

function fakeBin(x) {
  let arr = x.split("");

  let result = [];

  for (let index = 0; index < arr.length; index++) {
    const element = arr[index];
    if (element < 5) {
      result.push(0);
    } else {
      result.push(1);
    }
  }
  return result.join("");
}

console.log(fakeBin("45385593107843568"), "01011110001100111");

export default fakeBin;
