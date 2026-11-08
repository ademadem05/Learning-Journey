function shopping(budget, gpu, cpu, ram) {
  let graphic_card = 250;
  let owned_gpu = graphic_card * gpu;
  let owned_cpu = cpu * (owned_gpu * 0.35);
  let owned_ram = ram * (owned_gpu * 0.1);

  let total_cost = owned_cpu + owned_gpu + owned_ram;

  // Eğer GPU sayısı CPU sayısından fazlaysa %15 indirim
  if (gpu > cpu) {
    total_cost = total_cost - (total_cost * 0.15);
  }

  let total_left = budget - total_cost;

  // Eğer bütçe yetmiyorsa eksik olan miktarı, yetiyorsa kalan parayı yazdır
  if (total_left < 0) {
    console.log(`Not enough money! You need ${Math.abs(total_left).toFixed(2)} leva more!`);
  } else {
    console.log(`You have ${total_left.toFixed(2)} leva left!`);
  }
}


