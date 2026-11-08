function tennisTournament(input) {
  let totaltournament = Number(input[0]);
  let currentPoints = Number(input[1]);
  let totalWin = 0;

  for (let i = 2; i < input.length; i++) {
    let roundOFtournament = input[i];

    if (roundOFtournament === "F") {
      currentPoints += 1200;
    } else if (roundOFtournament === "SF") {
      currentPoints += 720;
    } else if (roundOFtournament === "W") {
      currentPoints += 2000;
      totalWin++;
    }
  }

  let averagePoints = (currentPoints - input[1]) / totaltournament;

  console.log(`Final points: ${currentPoints}`);
  console.log(`Average points: ${Math.floor(averagePoints)}`);
  console.log(`${((totalWin / totaltournament) * 100).toFixed(2)}%`);
}

