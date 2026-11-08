function fishtank(length, width, height, percent) {
  let volume = length * width * height;
  let litre = volume / 1000;
  let percent_for_aquavarium = percent / 100;
  let aquarium_volume = litre * (1 - percent_for_aquavarium);
  console.log(aquarium_volume);
}

