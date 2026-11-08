function launchBreak(movie_name, continues_episode, launch_break) {
  let time_for_lunch = (launch_break * 1) / 8;
  let time_for_peace = (launch_break * 1) / 4;
  let additional_time = launch_break - time_for_lunch - time_for_peace;
  let time_left = additional_time - continues_episode;
  if (additional_time >= continues_episode) {
    console.log(
      `You have enough time to watch ${movie_name} and left with ${Math.ceil(
        Math.abs(time_left)
      )} minutes free time.`
    );
  } else {
    console.log(
      `You don't have enough time to watch ${movie_name}, you need ${Math.ceil(
        Math.abs(time_left)
      )} more minutes.`
    );
  }
}

