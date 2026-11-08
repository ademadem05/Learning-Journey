// function Nto1(n) {
//   for (let i = n; i > 0; i--) {
//     console.log(i);
//   }
// }
// Nto1(5);

// function chisla(n) {
//   for (let i = 1; i <= n; i += 3) {
//     console.log(i);
//   }
// }
// chisla(15);

// function evenNum(n) {
//   for (let i = 0; i <= n; i += 2) {
//     console.log(2 ** i);
//   }
// }
// evenNum(5);

// function sequance(text) {
//   for (let i = 0; i < text.length; i++) {
//     let letter = text[i];
//     console.log(letter);
//   }
// }
// sequance("hello");

function sumOfalphabet(text) {
  let total = 0;
  for (let i = 0; i < text.length; i++) {
    let letter = text[i];
    switch (letter) {
      case "a":
        total += 1;
        break;
      case "e":
        total += 2;
        break;
      case "i":
        total += 3;
        break;
      case "o":
        total += 4;
        break;
      case "u":
        total += 5;
        break;
    }
  }
  console.log(total);
}

