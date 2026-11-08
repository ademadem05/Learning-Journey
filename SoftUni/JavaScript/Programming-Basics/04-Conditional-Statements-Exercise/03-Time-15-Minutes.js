function plus15minute(hour, minute) {
  let newMinute = minute + 15;
  let newHour = hour;

  if (newMinute >= 60) {
    newMinute -= 60; // Dakikaları sıfırla ve saat 1 artır
    newHour += 1;
  }

  if (newHour >= 24) {
    newHour = 0; // Saat 24'ü geçtiyse sıfırla
  }

  // Dakika kısmını iki basamaklı göstermek için 'padStart' kullanıyoruz
  console.log(`${newHour}:${newMinute.toString().padStart(2, '0')}`);
}


