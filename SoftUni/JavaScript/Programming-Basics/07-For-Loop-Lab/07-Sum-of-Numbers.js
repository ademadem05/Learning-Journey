function sumOfNumbers(arr) {
  let total = 0;
  for (digit of arr) {
    total += Number(digit);
  }
  console.log(`The sum of the digits is:${total}`);
}

