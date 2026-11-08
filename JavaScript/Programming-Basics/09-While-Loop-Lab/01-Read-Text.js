function readingWords(arr) {
  let index = 0;
  let words = arr[index];

  while (words !== "Stop") {
    console.log(words);

    index++;
    words = arr[index];
  }
}


