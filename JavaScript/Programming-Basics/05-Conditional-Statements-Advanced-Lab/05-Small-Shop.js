// град / продукт	coffee	water	beer	sweets	peanuts
// Sofia	          0.50	  0.80	   1.2    1.45	  1.60
// Plovdiv	         0.40	   0.70	  1.15	    1.30	1.50
// Varna	           0.45   	0.70  	1.10	    1.35	1.55

// function miniMarket(product, town, quantity) {
//   total = 0;
//   switch (town) {
//     case "Sofia":
//       if (product == "coffee") {
//         total = 0.5 * quantity;
//       } else if (product == "water") {
//         total = 0.8 * quantity;
//       } else if (product == "beer") {
//         total = 1.2 * quantity;
//       } else if (product == "sweets") {
//         total = 1.45 * quantity;
//       } else if (product == "peanuts") {
//         total = 1.6 * quantity;
//       }
//     case "Plovdiv":
//       if (product == "coffee") {
//         total = 0.4 * quantity;
//       } else if (product == "water") {
//         total = 0.7 * quantity;
//       } else if (product == "beer") {
//         total = 1.15 * quantity;
//       } else if (product == "sweets") {
//         total = 1.3 * quantity;
//       } else if (product == "peanuts") {
//         total = 1.5 * quantity;
//       }
//     case "Varna":
//       if (product == "coffee") {
//         total = 0.45 * quantity;
//       } else if (product == "water") {
//         total = 0.7 * quantity;
//       } else if (product == "beer") {
//         total = 1.1 * quantity;
//       } else if (product == "sweets") {
//         total = 1.35 * quantity;
//       } else if (product == "peanuts") {
//         total = 1.55 * quantity;
//       }
//   }
//   console.log(total);
// }
// miniMarket("water", "Plovdiv", 2);
function miniMarket(product, town, quantity) {
  let total = 0;
  switch (town) {
    case "Sofia":
      if (product == "coffee") {
        total = 0.5 * quantity;
      } else if (product == "water") {
        total = 0.8 * quantity;
      } else if (product == "beer") {
        total = 1.2 * quantity;
      } else if (product == "sweets") {
        total = 1.45 * quantity;
      } else if (product == "peanuts") {
        total = 1.6 * quantity;
      }
      break; // Sofia case sonu

    case "Plovdiv":
      if (product == "coffee") {
        total = 0.4 * quantity;
      } else if (product == "water") {
        total = 0.7 * quantity;
      } else if (product == "beer") {
        total = 1.15 * quantity;
      } else if (product == "sweets") {
        total = 1.3 * quantity;
      } else if (product == "peanuts") {
        total = 1.5 * quantity;
      }
      break; // Plovdiv case sonu

    case "Varna":
      if (product == "coffee") {
        total = 0.45 * quantity;
      } else if (product == "water") {
        total = 0.7 * quantity;
      } else if (product == "beer") {
        total = 1.1 * quantity;
      } else if (product == "sweets") {
        total = 1.35 * quantity;
      } else if (product == "peanuts") {
        total = 1.55 * quantity;
      }
      break; // Varna case sonu
  }
  console.log(total);
}


