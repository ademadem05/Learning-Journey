function fishingBoat(budget, session, fisher) {
  let total = 0;
  if (session == "Spring") {
    total += 3000;
  } else if (session == "Summer" || session == "Autumn") {
    // "Autumn" olarak düzeltildi
    total += 4200;
  } else if (session == "Winter") {
    total += 2600;
  }

  if (fisher <= 6) {
    total -= total * 0.1;
  } else if (7 <= fisher && fisher <= 11) {
    total -= total * 0.15;
  } else if (12 <= fisher) {
    total -= total * 0.25;
  }

  if (fisher % 2 == 0 && session !== "Autumn") {
    // Sonbaharda ek indirim uygulanmaz
    total -= total * 0.05;
  }

  let moneyleft = Math.abs(budget - total); // Pozitif değere dönüştürülür
  if (budget >= total) {
    console.log(`Yes! You have ${moneyleft.toFixed(2)} leva left.`);
  } else {
    console.log(`Not enough money! You need ${moneyleft.toFixed(2)} leva.`);
  }
}


