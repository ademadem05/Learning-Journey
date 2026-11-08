function numsDivideBy9(num1, num2) {
  let total = 0;
  let result = "";
  for (let i = num1; i < num2; i++) {
    if (i % 9 === 0) {
      result += i + "\n";
      total += i;
    }
  }
  console.log(`The sum: ${total}`);
  console.log(result);
}
