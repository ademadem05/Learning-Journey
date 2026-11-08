function onTime(hour_for_exam, minute_for_exam, hour_of_arriving, minute_of_arriving) {
  let examTotalMinutes = hour_for_exam * 60 + minute_for_exam;
  let arrivalTotalMinutes = hour_of_arriving * 60 + minute_of_arriving;

  let diff = arrivalTotalMinutes - examTotalMinutes;

  let hours = Math.floor(Math.abs(diff) / 60);
  let minutes = Math.abs(diff) % 60;

  if (diff > 0) { // Geç kalma durumu
    console.log("Late");
    if (diff >= 60) {
      console.log(`${hours}:${minutes.toString().padStart(2, '0')} hours after the start`);
    } else {
      console.log(`${minutes} minutes after the start`);
    }
  } else if (diff === 0) { // Tam zamanında gelme durumu
    console.log("On time");
  } else { // Erken gelme durumu
    if (Math.abs(diff) <= 30) {
      console.log("On time");
      console.log(`${minutes} minutes before the start`);
    } else {
      console.log("Early");
      if (Math.abs(diff) >= 60) {
        console.log(`${hours}:${minutes.toString().padStart(2, '0')} hours before the start`);
      } else {
        console.log(`${minutes} minutes before the start`);
      }
    }
  }
}
