function sumOrdinarynums(arr) {
  let primeSum = 0;
  let nonPrimeSum = 0;

  index = 0;
  let command = arr[index];

  while (command !== "stop") {
    let num = Number(command);
    if (num < 0) {
      console.log("Number is negative.");
      index++;
      command = arr[index];
      continue;
    }

    let isPrime = true;

    for (let i = 2; i < num; i++) {
      if (num % i === 0) {
        isPrime = false;
      }
    }
    if (isPrime) {
      primeSum += num;
    } else {
      nonPrimeSum += num;
    }
    index++;
    command = arr[index];
  }
  console.log(`Sum of all prime numbers is: ${primeSum}`);
  console.log(`Sum of all non prime numbers is: ${nonPrimeSum}`);
}

