function biggestNUm(arr) {
  let current = -999999999999999999;
  let index = 0;

  while (arr[index] !== "Stop") {
    if (Number(arr[index]) > current) current = Number(arr[index]);
    index++;
  }
  console.log(current);
}

