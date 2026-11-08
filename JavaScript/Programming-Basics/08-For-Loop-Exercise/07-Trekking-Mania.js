function everest(input) {
  let total = 0;
  for (let i = 1; i < input.length; i++) {
    total += Number(input[i]);
  }

  let Mousalla = 0;
  let monblan = 0;
  let klimanjeron = 0;
  let K2 = 0;
  let everestter = 0;

  for (let i = 1; i < input.length; i++) {
    let current = Number(input[i]);
    if (current <= 5) Mousalla += current;
    else if (current <= 12) monblan += current;
    else if (current <= 25) klimanjeron += current;
    else if (current <= 40) K2 += current;
    else {
      everestter += current;
    }
  }
  console.log(`${((Mousalla / total) * 100).toFixed(2)}% `);
  console.log(`${((monblan / total) * 100).toFixed(2)}%`);
  console.log(`${((klimanjeron / total) * 100).toFixed(2)}%`);
  console.log(`${((K2 / total) * 100).toFixed(2)}%`);
  console.log(`${((everestter / total) * 100).toFixed(2)}%`);
}

