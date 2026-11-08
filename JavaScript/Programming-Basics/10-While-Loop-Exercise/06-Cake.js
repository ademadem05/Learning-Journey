function cakepieces(arr) {
  let height = arr[0];
  let width = arr[1];

  let totalCake = height * width;

  let index = 2;
  while (index < arr.length) {
    if (arr[index] === "STOP") {
      break;
    }

    totalCake -= arr[index];
    index++;
  }

  if (totalCake >= 0) {
    console.log(`${totalCake} pieces are left.`);
  } else {
    console.log(
      `No more cake left! You need ${Math.abs(totalCake)} pieces more.`
    );
  }
}

