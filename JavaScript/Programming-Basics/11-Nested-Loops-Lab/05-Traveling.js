function traveling(input) {
  let index = 0;
  let command = input[index];

  while (command !== "End") {
    let destination = command;

    index++;
    let targetSum = Number(input[index]);
    let totalSavedMoney = 0;

    while (totalSavedMoney < targetSum) {
      index++;
      let newSavedMoney = Number(input[index]);
      totalSavedMoney += newSavedMoney;
    }
    console.log(`Going to ${destination}!`);

    index++;
    command = input[index];
  }
}

