function sumNumbers(arr) {
  let target = Number(arr[0]);
  let index = 1;
  let total = 0;
  while (total < target) {
    total += Number(arr[index]);
    index++;
  }
  console.log(total);
}
