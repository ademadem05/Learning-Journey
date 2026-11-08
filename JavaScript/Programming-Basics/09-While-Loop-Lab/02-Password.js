function password(arr) {
  let userName = arr[0];
  let password = arr[1];

  let index = 2;
  let guesses = arr[index];
  while (guesses !== password) {
    index++;
    guesses = arr[index];
  }
  console.log(`Welcome ${userName}!`);
}