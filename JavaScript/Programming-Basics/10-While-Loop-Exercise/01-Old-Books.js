function library(arr) {
  bookWeWant = arr[0];
  let checks = 0;
  let index = 1;

  while (index < arr.length) {
    checks++;
    if (arr[index] === bookWeWant) {
      checks -= 1;
      console.log(`You checked ${checks} books and found it.`);
      break;
    } else if (arr[index] === "No More Books") {
      checks -= 1;
      console.log(`The book you search is not here!
      You checked ${checks} books.`);
      break;
    }

    index++;
  }
}