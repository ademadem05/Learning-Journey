function oscars(input) {
  let actorName = input[0];
  let points = Number(input[1]);

  for (let i = 3; i < input.length; i += 2) {
    let currentName = input[i];
    let JudgePoints = input[i + 1];

    points += (currentName.length * JudgePoints) / 2;

    // Congratulations, ${actorName} got a nominee for leading role with ${points}!

    // Sorry, ${actorName} you need ${1250.5 - points} more!
    if (points > 1250.5) {
      console.log(
        `Congratulations, ${actorName} got a nominee for leading role with ${points.toFixed(
          1
        )}!`
      );
      return;
    }
  }
  console.log(
    `Sorry, ${actorName} you need ${(1250.5 - points).toFixed(1)} more!`
  );
}