function areaOfFigures(figure, a, b) {
  a = Number(a);
  b = Number(b);
  let area = 0;
  if (figure === "square") {
    area = a * a;
  } else if (figure === "rectangle") {
    area = a * b;
  } else if (figure === "circle") {
    area = Math.PI * a * a;
  } else if (figure === "triangle") {
    area = (a * b) / 2;
  }
  console.log(area.toFixed(3));
}
