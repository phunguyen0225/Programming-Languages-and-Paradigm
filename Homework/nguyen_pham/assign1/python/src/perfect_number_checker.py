def sum_of_factors(number):
    sum = 0

    for i in range(1, number + 1):
        if number % i == 0:
            sum += i
    
    return sum

def is_perfect(number):
    return sum_of_factors(number) == number * 2