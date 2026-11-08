function bonusPoint(point) {
  let bonus = 0.0;

  if (point <= 100) {
    bonus += 5;
  } else if (point <= 1000) {
    bonus += point * 0.2; // 100'den büyük, 1000'den küçük olanlar için %20 bonus
  } else if (point > 1000) {
    bonus += point * 0.1; // 1000'den büyük olanlar için %10 bonus
  }

  if (point % 2 == 0) bonus += 1; // Sayı çiftse 1 ekle
  if (point % 10 == 5) bonus += 2; // Sayı 5 ile bitiyorsa 2 ekle

  console.log("Bonus:", bonus);
  console.log("Toplam puan:", point + bonus);
}


