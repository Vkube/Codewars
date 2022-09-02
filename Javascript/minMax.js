function minMax(arr) {
  let min = Math.min(...arr),
    max = Math.max(...arr);
  return Array.of(min, max); // fix me!
}

console.log(minMax([1, 2, 3, 4, 5]));
console.log(Math.max(arr));
