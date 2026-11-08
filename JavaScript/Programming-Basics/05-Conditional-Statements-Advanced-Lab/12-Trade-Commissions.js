function tradingCommision(city, sell) {
  let selling = 0;
  switch (city) {
    case "Sofia":
      if (0 <= sell && sell <= 500) {
        selling = 0.05 * sell;
      } else if (500 < sell && sell <= 1000) {
        selling = 0.07 * sell;
      } else if (1000 < sell && sell <= 10000) {
        selling = 0.08 * sell;
      } else if (sell > 10000) {
        selling = 0.12 * sell;
      }
      break;
    case "Varna":
      if (0 <= sell && sell <= 500) {
        selling = 0.045 * sell;
      } else if (500 < sell && sell <= 1000) {
        selling = 0.075 * sell;
      } else if (1000 < sell && sell <= 10000) {
        selling = 0.1 * sell;
      } else if (sell > 10000) {
        selling = 0.13 * sell;
      }
      break;
    case "Plovdiv":
      if (0 <= sell && sell <= 500) {
        selling = 0.055 * sell;
      } else if (500 < sell && sell <= 1000) {
        selling = 0.08 * sell;
      } else if (1000 < sell && sell <= 10000) {
        selling = 0.12 * sell;
      } else if (sell > 10000) {
        selling = 0.145 * sell;
      }
      break;
  }
  if (selling === 0) {
    console.log("error");
  } else {
    console.log(selling.toFixed(2));
  }
}

