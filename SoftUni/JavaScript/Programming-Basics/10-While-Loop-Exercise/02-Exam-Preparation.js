function preparationForExam(input) {
  let maxPoorGrades = Number(input[0]);
  let countOfPoorGrades = 0;
  let totalScore = 0;
  let countOfExam = 0;
  let lastExam = "";
  let index = 1;

  while (index < input.length) {
    let examName = input[index];
    let grade = Number(input[index + 1]);

    countOfExam++;
    totalScore += grade;
    lastExam = examName;

    // Проверка за незадоволителна оценка
    if (grade <= 4) {
      countOfPoorGrades++;
    }

    // Проверка дали броят на незадоволителните оценки е достигнат
    if (countOfPoorGrades >= maxPoorGrades) {
      console.log(`You need a break, ${countOfPoorGrades} poor grades.`);
      return;  // Излизане от функцията
    }

    index += 2;

    // Проверка за команда "Enough"
    if (input[index] === "Enough") {
      break;
    }
  }

  // Изчисление и отпечатване на резултатите, ако командата "Enough" е получена
  console.log(`Average score: ${(totalScore / countOfExam).toFixed(2)}`);
  console.log(`Number of problems: ${countOfExam}`);
  console.log(`Last problem: ${lastExam}`);
}


