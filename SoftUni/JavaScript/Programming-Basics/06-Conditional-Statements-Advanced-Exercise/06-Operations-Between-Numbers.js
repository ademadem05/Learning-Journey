function calculator(n1, n2, opeation) {
  if (opeation == "-") {
    let total = n1 - n2;
    if (total % 2 == 0) {
      console.log(`${n1} - ${n2} = ${total} - even`);
    } else {
      console.log(`${n1} - ${n2} = ${total} - odd`);
    }
  }
  if (opeation == "+") {
    let total = n1 + n2;
    if (total % 2 == 0) {
      console.log(`${n1} + ${n2} = ${total} - even`);
    } else {
      console.log(`${n1} + ${n2} = ${total} - odd`);
    }
  }
  if (opeation == "*") {
    let total = n1 * n2;
    if (total % 2 == 0) {
      console.log(`${n1} * ${n2} = ${total} - even`);
    } else {
      console.log(`${n1} * ${n2} = ${total} - odd`);
    }
  }
  if (opeation == "/") {
    let total = n1 / n2;
    if (n2 == 0) {
      console.log(`Cannot divide ${n1} by zero`);
    } else {
      console.log(`${n1} / ${n2} = ${total.toFixed(2)}`);
    }
  }
  if (opeation == "%") {
    let total = n1 % n2;
    if (n2 == 0) {
      console.log(`Cannot divide ${n1} by zero`);
    } else {
      console.log(`${n1} % ${n2} = ${total}`);
    }
  }
}

