function graduate(arr) {
  let name = arr[0];
  let total = 0;
  let index = 1;
  let gradesCount = 0;

  while (index < arr.length) {
    let grade = Number(arr[index]);

    // Not 4'ten düşükse öğrenciyi ihraç et
    if (grade < 4) {
      console.log(`${name} has been excluded at ${index} grade`);
      return; // Fonksiyondan çık
    }

    total += grade;
    gradesCount++;
    index++;
  }

  // Ortalama hesapla ve mezuniyet bilgisi yazdır
  let average = total / gradesCount;
  console.log(`${name} graduated. Average grade: ${average.toFixed(2)}`);
}


