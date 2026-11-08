function foodDelivery(chicken, fish, vegan) {
  let chickenmenu = 10.35;
  let fishmenu = 12.4;
  let veganmenu = 8.15;

  let total = chicken * chickenmenu + fish * fishmenu + vegan * veganmenu;
  let discount = 20/100
  let price_with_discount = total * discount
  let total_price = total + price_with_discount + 2.50
  
  
  
  console.log(total_price);
}

