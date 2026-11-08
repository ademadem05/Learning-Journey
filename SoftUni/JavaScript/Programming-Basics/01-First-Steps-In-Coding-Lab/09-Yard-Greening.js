function yardGreening(meters) {
  let total = Number(meters) * 7.61;
  let discount = total * 0.18;
  let finalPrice = total - discount;
  console.log(`The final price is: ${finalPrice} lv.`);
  console.log(`The discount is: ${discount} lv.`);
}
