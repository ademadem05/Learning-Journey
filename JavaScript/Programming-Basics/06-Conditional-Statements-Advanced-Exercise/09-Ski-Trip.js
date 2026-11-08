function skiHoliday(days, Troom, raiting) {
  let total = 0;
  let nights = days - 1; // Gece sayısı, gün - 1

  if (Troom === "room for one person") {
    total = nights * 18;
  } else if (Troom === "apartment") {
    total = nights * 25;
    if (days <= 10) {
      total -= total * 0.3;
    } else if (days <= 15) {
      total -= total * 0.35;
    } else {
      total -= total * 0.5;
    }
  } else if (Troom === "president apartment") {
    total = nights * 35;
    if (days <= 10) {
      total -= total * 0.1;
    } else if (days <= 15) {
      total -= total * 0.15;
    } else {
      total -= total * 0.2;
    }
  }

  // Olumlu veya olumsuz değerlendirme uygulanıyor
  if (raiting === "positive") {
    total += total * 0.25;
  } else if (raiting === "negative") {
    total -= total * 0.1;
  }

  console.log(total.toFixed(2)); // Sonucu iki ondalık basamakla gösteriyoruz
}


