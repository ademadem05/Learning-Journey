function cleverLily(age, washingMachine, toyPrice) {
  age = Number(age);
  washingMachine = Number(washingMachine);
  let savings = 0;
  let gift = 10;
  let toys = 0;
  for (let year = 1; year <= age; year++) {
    if (year % 2 === 0) {
      savings += gift - 1;
      gift += 10;
    } else {
      toys++;
    }
  }
  savings += toys * Number(toyPrice);
  if (savings >= washingMachine) {
    console.log(`Yes! ${(savings - washingMachine).toFixed(2)}`);
  } else {
    console.log(`No! ${(washingMachine - savings).toFixed(2)}`);
  }
}
