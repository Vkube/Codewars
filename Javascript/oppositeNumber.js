//Very simple, given an integer or a floating-point number, find its opposite.

function opposite(number) {
  if (number > 0) {
    return Number("-" + number.toString());
  } else {
    return Number(number.toString().slice(1));
  }
}

console.log(opposite(1), -1);

export default opposite;
