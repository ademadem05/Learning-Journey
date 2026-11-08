function basketball(annual_tax) {
  let sneakers = annual_tax - annual_tax * 0.4;
  let uniform = sneakers - sneakers * 0.2;
  let basket_ball = (1 / 4) * uniform;
  let basketball_accesories = (1 / 5) * basket_ball;
  let total_price =
    annual_tax + sneakers + basket_ball + basketball_accesories + uniform;

  console.log(total_price);
}


