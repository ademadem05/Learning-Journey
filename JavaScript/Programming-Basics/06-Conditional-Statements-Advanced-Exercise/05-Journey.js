function journey(budget, season) {
  budget = Number(budget);
  let destination = "";
  let place = "";
  let spent = 0;
  if (budget <= 100) {
    destination = "Bulgaria";
    place = season === "summer" ? "Camp" : "Hotel";
    spent = season === "summer" ? budget * 0.3 : budget * 0.7;
  } else if (budget <= 1000) {
    destination = "Balkans";
    place = season === "summer" ? "Camp" : "Hotel";
    spent = season === "summer" ? budget * 0.4 : budget * 0.8;
  } else {
    destination = "Europe";
    place = "Hotel";
    spent = budget * 0.9;
  }
  console.log(`Somewhere in ${destination}`);
  console.log(`${place} - ${spent.toFixed(2)}`);
}
