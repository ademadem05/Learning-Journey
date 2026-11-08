function ticketForCinema(arr) {
  let standardTicket = 0;
  let kidTicket = 0;
  let studentTicket = 0;

  let index = 0;
  let command = arr[index];

  while (command != "Finish") {
    let nameOfMovie = command;
    index++;
    let totalSeats = Number(arr[index]);
    let totalSeatsTaken = 0;
    index++;

    let command1 = arr[index];
    while (command1 !== "End") {
      let typeOfTicket = command1;

      if (typeOfTicket === "standard") standardTicket++;
      if (typeOfTicket === "kid") kidTicket++;
      if (typeOfTicket === "student") studentTicket++;

      totalSeatsTaken++;
      if (totalSeatsTaken === totalSeats) {
        break;
      }
      //console.log(`${nameOfMovie} - ${((totalSeats / totalSeatsTaken) * 100).toFixed(2)}`);

      index++;
      command1 = arr[index];
    }

    console.log(
      `${nameOfMovie} - ${((totalSeatsTaken / totalSeats) * 100).toFixed(
        2
      )}% full.`
    );

    index++;
    command = arr[index];
  }
  console.log(`Total tickets: ${standardTicket + kidTicket + studentTicket}`);
  console.log(
    `${(
      (studentTicket / (studentTicket + standardTicket + kidTicket)) *
      100
    ).toFixed(2)}% student tickets.`
  );
  console.log(
    `${(
      (standardTicket / (studentTicket + standardTicket + kidTicket)) *
      100
    ).toFixed(2)}% standard tickets.`
  );
  console.log(
    `${(
      (kidTicket / (studentTicket + standardTicket + kidTicket)) *
      100
    ).toFixed(2)}% kids tickets.`
  );
}
