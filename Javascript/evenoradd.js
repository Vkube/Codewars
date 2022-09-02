//Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.

const isEven = (number) => {
  return number % 2 == 0 ? "Even" : "Odd";
};

console.log(isEven(2), "Even");
console.log(isEven(7), "Odd");
console.log(isEven(-42), "Even");
console.log(isEven(-7), "Odd");
console.log(isEven(0), "Even");

export default isEven;
