function workingTime(num, day) {
  switch (day) {
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
    case "Saturday":
      if (10 <= num && num <= 18) {
        console.log("open");
      } else {
        console.log("closed");
      }
      break;
    case "Sunday":
      console.log("closed");
      break;
  }
}

