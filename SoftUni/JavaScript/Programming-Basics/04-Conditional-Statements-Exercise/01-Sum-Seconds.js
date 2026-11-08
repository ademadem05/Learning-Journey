function sumOFseconds(fist_time, second_second, third_time) {
  let total_time = fist_time + second_second + third_time;
  let minutes = Math.floor(total_time / 60);
  let seconds = total_time % 60;

  if (seconds < 10) {
    console.log(`${minutes}:0${seconds}`);
  } else {
    console.log(`${minutes}:${seconds}`);
  }
}


