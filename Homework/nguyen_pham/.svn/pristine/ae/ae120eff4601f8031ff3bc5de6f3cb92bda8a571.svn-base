import unittest
from python.src.perfect_number_checker import *

class PerfectNumberChecker(unittest.TestCase):

    def test_canary(self):
        self.assertTrue(True)

    def test_sum_of_factors(self):
        samples = [(6, 12),  (50, 93)]

        for number, expected in samples:
            self.assertEqual(expected, sum_of_factors(number))

    def test_is_perfect(self):
        samples = [(6, True), (50, False)]

        for number, expected in samples:
            self.assertEqual(expected, is_perfect(number))