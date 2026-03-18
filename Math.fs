module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec iter n steps =
    if n = 1L then steps
    elif n % 2L = 0L then iter (n / 2L) (steps + 1)
    else iter (3L * n + 1L) (steps + 1)
  iter (int64 n) 0
