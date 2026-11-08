function depositcalculator(deposit, month, rate) {
  let rate_price = deposit * (rate / 100);
  let rateFor1Month = rate_price / 12;
  let total_amount = deposit + rateFor1Month * month;
  console.log(total_amount);
}

