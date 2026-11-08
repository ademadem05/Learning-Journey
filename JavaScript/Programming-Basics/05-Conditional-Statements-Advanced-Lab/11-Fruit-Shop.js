function marketforFruits(product, day, quantity) {
  total = 0;
  switch (day) {
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
      if (product == "banana") total = quantity * 2.5;
      else if (product == "apple") total = quantity * 1.2;
      else if (product == "orange") total = quantity * 0.85;
      else if (product == "grapefruit") total = quantity * 1.45;
      else if (product == "kiwi") total = quantity * 2.7;
      else if (product == "pineapple") total = quantity * 5.5;
      else if (product == "grapes") total = quantity * 3.85;
      break;
    case "Saturday":
    case "Sunday":
      if (product == "banana") total = quantity * 2.7;
      else if (product == "apple") total = quantity * 1.25;
      else if (product == "orange") total = quantity * 0.9;
      else if (product == "grapefruit") total = quantity * 1.6;
      else if (product == "kiwi") total = quantity * 3;
      else if (product == "pineapple") total = quantity * 5.6;
      else if (product == "grapes") total = quantity * 4.2;
  }
  if (total === 0) {
    console.log("error");
  } else {
    console.log(total.toFixed(2));
  }
}

