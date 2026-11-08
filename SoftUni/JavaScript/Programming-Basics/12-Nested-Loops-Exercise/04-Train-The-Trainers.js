function trainTheTrainers(arr) {
  let judgers = Number(arr[0]);
  let presentationCount = 0;
  let totalGradeSum = 0;
  let index = 1;
  let command = arr[index];
  while (command != "Finish") {
    let presentationName = command;
    let presentationgradeSum = 0;

    for (let currentjudege = 1; currentjudege <= judgers; currentjudege++) {
      index++;
      let currentgrade = Number(arr[index]);
      presentationgradeSum += currentgrade;
    }
    let avgPresentationGrade = presentationgradeSum / judgers;

    console.log(`${presentationName} - ${avgPresentationGrade.toFixed(2)}.`);

    presentationCount++;
    totalGradeSum += avgPresentationGrade;

    index++;
    command = arr[index];
  }
  console.log(
    `Student's final assessment is ${(
      totalGradeSum / presentationCount
    ).toFixed(2)}.`
  );
}

