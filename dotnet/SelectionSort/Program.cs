﻿// MIN -> MAX перебор массива
// 0 1 2 3 4 5 6 7   индексы
// v
// 7 6 3 4 5 1 2 3   изначальный массив
//           ^
// 1 6 3 4 5 7 2 3   <- после первого перебора 1
//   v
// 1 6 3 4 5 7 2 3
//             ^
// 1 2 3 4 5 7 6 3   <- после второго перебора 2
//     v
// 1 2 3 4 5 7 6 3
//     ^
// 1 2 3 4 5 7 6 3   <- после третьего перебора 3
//       v
// 1 2 3 4 5 7 6 3
//               ^
// 1 2 3 3 5 6 7 4   <- после четвертого перебора 4
//         v
// 1 2 3 3 5 6 7 4
//               ^
// 1 2 3 3 4 6 7 5   <- после пятого перебора 5
//           v
// 1 2 3 3 4 6 7 5
//               ^
// 1 2 3 3 4 5 7 6   <- после шестого перебора 6
//             v
// 1 2 3 3 4 5 7 6
//               ^
// 1 2 3 3 4 5 6 7   <- после седьмого перебора 7 
//               v
// 1 2 3 3 4 5 6 7
//               ^
// 1 2 3 3 4 5 6 7   <- перебранный массив 8


