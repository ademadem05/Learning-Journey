function godzillaVsKong(budget, extras, clothingPrice) {
  budget = Number(budget);
  extras = Number(extras);
  let decor = budget * 0.1;
  let clothing = extras * Number(clothingPrice);
  if (extras >= 150) {
    clothing -= clothing * 0.1;
  }
  let total = decor + clothing;
  if (total > budget) {
    console.log("Not enough money!");
    console.log(`Wingard needs ${(total - budget).toFixed(2)} leva more.`);
  } else {
    console.log("Action!");
    console.log(`Wingard starts filming with ${(budget - total).toFixed(2)} leva left.`);
  }
}
