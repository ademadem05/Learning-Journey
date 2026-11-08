function cinema(typeP, row, column) {
  let income = 0;
  switch (typeP) {
    case "Premiere":
      income = row * column * 12;
      break;
    case "Normal":
      income = row * column * 7.5;
      break;
    case "Discount":
      income = row * column * 5;
      break;
  }
  console.log(`${income.toFixed(2)} leva`);
}

