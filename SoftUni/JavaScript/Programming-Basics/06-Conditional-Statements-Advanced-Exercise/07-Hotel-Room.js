function hotelRoom(month, nights) {
  nights = Number(nights);
  let studio = 0;
  let apartment = 0;
  if (month === "May" || month === "October") {
    studio = 50 * nights;
    apartment = 65 * nights;
    if (nights > 14) {
      studio *= 0.7;
    } else if (nights > 7) {
      studio *= 0.95;
    }
  } else if (month === "June" || month === "September") {
    studio = 75.2 * nights;
    apartment = 68.7 * nights;
    if (nights > 14) {
      studio *= 0.8;
    }
  } else if (month === "July" || month === "August") {
    studio = 76 * nights;
    apartment = 77 * nights;
  }
  if (nights > 14) {
    apartment *= 0.9;
  }
  console.log(`Apartment: ${apartment.toFixed(2)} lv.`);
  console.log(`Studio: ${studio.toFixed(2)} lv.`);
}
