function repainting(nylon, paint, thinner, hours) {
  let materials =
    (Number(nylon) + 2) * 1.5 +
    (Number(paint) * 0.1 + Number(paint)) * 14.5 +
    Number(thinner) * 5 +
    0.4;
  let workers = materials * 0.3 * Number(hours);
  console.log(materials + workers);
}
