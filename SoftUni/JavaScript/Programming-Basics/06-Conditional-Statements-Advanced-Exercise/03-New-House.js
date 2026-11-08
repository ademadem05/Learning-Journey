function newHome(flower, quantity, budget) {
  let totalCost = 0;
  switch (flower) {
    case "Roses":
      totalCost = quantity * 5;
      if (quantity > 80) {
        totalCost -= totalCost * 0.1;
      }
      break;
    case "Dahlias":
      totalCost = quantity * 3.8;
      if (quantity > 90) {
        totalCost -= totalCost * 0.15;
      }
      break;
    case "Tulips":
      totalCost = quantity * 2.8;
      if (quantity > 80) {
        totalCost -= totalCost * 0.15;
      }
      break;
    case "Narcissus":
      totalCost = quantity * 3;
      if (quantity < 120) {
        totalCost += totalCost * 0.15; // 120'den azsa %15 ek fiyat
      }
      break;
    case "Gladiolus":
      totalCost = quantity * 2.5;
      if (quantity < 80) {
        totalCost += totalCost * 0.2; // 80'den azsa %20 ek fiyat
      }
      break;
  }

  if (totalCost > budget) {
    let moreMoney = totalCost - budget;
    console.log(
      `Not enough money, you need ${moreMoney.toFixed(2)} leva more.`
    );
  } else {
    console.log(
      `Hey, you have a great garden with ${quantity} ${flower} and ${(
        budget - totalCost
      ).toFixed(2)} leva left.`
    );
  }
}


