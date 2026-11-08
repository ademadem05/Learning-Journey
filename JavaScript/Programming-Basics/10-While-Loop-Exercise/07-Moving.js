function moving(arr) {
  let totalCubicMeter = arr[0] * arr[1] * arr[2];
  let totalFreeSpace = 0;

  let index = 3;
  while (index < arr.length) {
    if (arr[index] === "Done") {
      break;
    }
    totalFreeSpace += Number(arr[index]);
    index++;
  }

  if (totalFreeSpace > totalCubicMeter) {
    console.log(
      `No more free space! You need ${Math.abs(
        totalCubicMeter - totalFreeSpace
      )} Cubic meters more.`
    );
  } else {
    console.log(
      `${Math.abs(totalFreeSpace - totalCubicMeter)} Cubic meters left.`
    );
  }
}

