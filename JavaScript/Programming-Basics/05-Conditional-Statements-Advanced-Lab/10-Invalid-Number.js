function validNum(num) {
  let isvalid = (100 <= num && num <= 200) || num == 0;
  if (!isvalid) {
    console.log("invalid");
  }
}

