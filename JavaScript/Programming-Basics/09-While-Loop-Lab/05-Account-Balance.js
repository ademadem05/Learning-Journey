function accountBalance(arr) {
  let index = 0;
  let total = 0;
  let command = arr[index];
  while (command !== "NoMoreMoney") {
    let amount = Number(command);
    if (amount < 0) {
      console.log("Invalid operation!");
      break;
    }
    total += amount;
    console.log(`Increase: ${amount.toFixed(2)}`);
    index++;
    command = arr[index];
  }
  console.log(`Total: ${total.toFixed(2)}`);
}
