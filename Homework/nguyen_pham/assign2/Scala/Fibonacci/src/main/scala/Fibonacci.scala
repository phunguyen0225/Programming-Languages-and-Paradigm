def FibonacciIterative( number: Int) : Array[Int] = {
  if (number < 1) 
    Array(1); 
  else 
    Array.range(1, number + 1)
         .map(values => Array(1, 1))
         .reduce((values, ignore) => Array.concat(values, Array(values(values.size - 1) + values(values.size - 2))))
}
