function ozelNum(n) {
  let allResult = "";
  for (let i = 1111; i <= 9999; i++) {
    let currentnum = i + "";
    let isSpecial = true; // Varsayalım ki bu özel bir sayıdır

    for (let j = 0; j < currentnum.length; j++) {
      let digit = Number(currentnum[j]); // Şimdi doğru basamağı alıyoruz

      // Eğer herhangi bir basamaya bölünemezse, isSpecial'ı false yapıyoruz
      if (n % digit !== 0) {
        isSpecial = false;
        break;
      }
    }

    // Eğer tüm basamaçlar doğruysa, sayıyı yazdırıyoruz
    if (isSpecial) {
      allResult += i + " ";
    }
  }
  console.log(allResult);
}


