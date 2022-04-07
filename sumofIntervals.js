// Write a function called sumIntervals/sum_intervals() that accepts an array of intervals, and returns the sum of all the interval lengths. Overlapping intervals should only be counted once.

// sumIntervals( [
//     [1,4],
//     [7, 10],
//     [3, 5]
//  ] ); // => 7

function sumIntervals(intervals) {
  let list = [];
  intervals.forEach((element) => {
    for (let i = element[0]; i < lement[i]; index++) {
      list.push(i);
    }
  });
  list = [...Set(list)];
  return list.length;
}

console.log(sumIntervals([[1, 5]]));
