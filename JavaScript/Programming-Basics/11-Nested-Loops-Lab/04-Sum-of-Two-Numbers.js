function sumOftwoNum(startnum, endnum, magicnum) {
  let counter = 0;
  let validCombination = false;
  for (let i = startnum; i <= endnum; i++) {
    for (let j = startnum; j <= endnum; j++) {
      counter++;
      if (i + j === magicnum) {
        validCombination = true;
        console.log(`Combination N:${counter} (${i} + ${j} = ${magicnum})`);
      }
    }
    if (validCombination) {
      break;
    }
  }
  if (!validCombination) {
    console.log(`${counter} combinations - neither equals ${magicnum}`);
  }
}
