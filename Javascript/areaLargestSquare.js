//Determine the area of the largest square that can fit inside a circle with radius r.

function areaLargestSquare(r) {
  const square = (2 * r) / Math.sqrt(2);
  return Math.ceil(Math.pow(square, 2));
}

console.log(areaLargestSquare(5), 50);
console.log(areaLargestSquare(7), 98);
console.log(areaLargestSquare(15), 450);

export default areaLargestSquare;
