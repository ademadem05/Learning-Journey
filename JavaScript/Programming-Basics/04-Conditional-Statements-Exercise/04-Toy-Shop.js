function toyShop(tripPrice, puzzles, dolls, bears, minions, trucks) {
  const puzzlePrice = 2.60;
  const dollPrice = 3.00;
  const bearPrice = 4.10;
  const minionPrice = 8.20;
  const truckPrice = 2.00;

  // Изчисляване на общата сума
  let totalPrice = (puzzles * puzzlePrice) + 
                   (dolls * dollPrice) + 
                   (bears * bearPrice) + 
                   (minions * minionPrice) + 
                   (trucks * truckPrice);

  // Общо количество играчки
  let totalToys = puzzles + dolls + bears + minions + trucks;

  // При 50 или повече играчки - отстъпка от 25%
  if (totalToys >= 50) {
    totalPrice *= 0.75;
  }

  // Изваждане на 10% за наем
  totalPrice *= 0.90;

  // Проверка дали парите са достатъчни за екскурзията
  if (totalPrice >= tripPrice) {
    let moneyLeft = totalPrice - tripPrice;
    console.log(`Yes! ${moneyLeft.toFixed(2)} lv left.`);
  } else {
    let moneyNeeded = tripPrice - totalPrice;
    console.log(`Not enough money! ${moneyNeeded.toFixed(2)} lv needed.`);
  }
}

