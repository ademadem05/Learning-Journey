function vacation(arr) {
  let days = 0;
  let currentMoney = Number(arr[1]);
  let vacationMoney = Number(arr[0]);

  let index = 3;
  while (index < arr.length) {
    days += 1;

    if (arr[index - 1] === "spend") {
      currentMoney -= Number(arr[index]);
    }
    if (currentMoney < 0) {
      currentMoney = 0;
    }

    if (arr[index - 1] === "save") {
      currentMoney += Number(arr[index]);
    }

    index += 2;
  }
  if (currentMoney >= vacationMoney) {
    console.log(`You saved the money for ${days} days.`);
  } else {
    console.log(`You can't save the money.
    ${days}`);
  }
}

