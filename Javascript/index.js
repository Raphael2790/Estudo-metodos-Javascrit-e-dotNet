const arr = [5, 8, 9, 25, 0, 7];
const arr2 = [4, 5, 10, 43, 0, 5];
const someWords = [
  "blue",
  "whale",
  "white",
  "cars",
  "driver",
  "police",
  "juice"
];

const sum = (acc, value) => acc + value;

const compareValues = (arr1, arr2) => {
  const board = [0, 0];
  for (let index = 0; index < arr1.length; index++) {
    if (arr1[index] == arr2[index]) continue;
    arr1[index] > arr2[index] ? board[0]++ : board[1]++;
  }
  return board;
};

const getValueRandom = (arr) => {
  let min = 0;
  let max = arr.length;
  let randomValue = Math.round(Math.random() * (max - min) + min);
  console.log(randomValue, max);
  return arr[randomValue];
};

const FindWordInArray = (arr, word) => {
  return arr.indexOf(word, 0);
};

const result = arr.reduce(sum, 0);
const board = compareValues(arr, arr2);
console.log(FindWordInArray(someWords, "juice"));
console.log(result);
console.log(board);
console.log(getValueRandom(arr));
