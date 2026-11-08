function vendingMachine(amount) {
  let totalCoins = 0;
  amount = Math.round(amount * 100); // Преобразуваме в стотинки, за да избегнем проблемите с плаваща запетая

  while (amount > 0) {
    if (amount >= 200) {
      totalCoins += Math.floor(amount / 200);
      amount %= 200;
    } else if (amount >= 100) {
      totalCoins += Math.floor(amount / 100);
      amount %= 100;
    } else if (amount >= 50) {
      totalCoins += Math.floor(amount / 50);
      amount %= 50;
    } else if (amount >= 20) {
      totalCoins += Math.floor(amount / 20);
      amount %= 20;
    } else if (amount >= 10) {
      totalCoins += Math.floor(amount / 10);
      amount %= 10;
    } else if (amount >= 5) {
      totalCoins += Math.floor(amount / 5);
      amount %= 5;
    } else if (amount >= 2) {
      totalCoins += Math.floor(amount / 2);
      amount %= 2;
    } else if (amount >= 1) {
      totalCoins += amount; // Всички останали монети от 1 стотинка
      amount = 0;
    }
  }

  console.log(totalCoins);
}

