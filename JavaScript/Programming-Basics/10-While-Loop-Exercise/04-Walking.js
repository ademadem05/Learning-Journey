function steps(arr) {
  let totalSteps = 0;
  let index = 0;

  while (index < arr.length) {
    if (arr[index] === "Going home") {
      index++;
      totalSteps += Number(arr[index]);
      break;
    }
    totalSteps += Number(arr[index]);
    index++;
  }
  if (totalSteps >= 10000) {
    console.log(`Goal reached! Good job! 
${totalSteps - 10000} steps over the goal!`);
  } else {
    console.log(`${10000 - totalSteps} more steps to reach goal.`);
  }
}

