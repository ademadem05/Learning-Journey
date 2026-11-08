function schoolSupliess(pencil, marker, chemic, discount) {
  let per_pencil = 5.8;
  let per_marker = 7.2;
  let chemical = 1.2;
  let total = per_pencil * pencil + per_marker * marker + chemical * chemic;
  let discount_price = discount / 100
  let finall_price = total - (total * discount_price)
  console.log(finall_price);
}

