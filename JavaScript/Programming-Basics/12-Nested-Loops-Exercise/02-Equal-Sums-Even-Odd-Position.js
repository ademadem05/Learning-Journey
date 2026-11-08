function sameNums(first, second) {
  printLine = "";
  for (let i = first; i <= second; i++) {
    let current = "" + i;
    let oddSum = 0;
    let evenSum = 0;
    for (let j = 0; j < current.length; j++) {
      let currentDigit = Number(current.charAt(j));
      if (j % 2 === 0) {
        evenSum += currentDigit;
      } else {
        oddSum += currentDigit;
      }
    }
    if (oddSum === evenSum) {
      printLine += `${i} `;
    }
  }
  console.log(printLine);
}

