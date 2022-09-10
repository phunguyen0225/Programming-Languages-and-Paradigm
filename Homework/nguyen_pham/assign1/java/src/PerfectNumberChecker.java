package assign1;
import java.util.*;

public class PerfectNumberChecker {
    public static List<Integer> getFactors(int number) {
        List<Integer> factors = new ArrayList<Integer>();
        for (int i = 1; i < number; i++) {
            if (number % i == 0) {
                factors.add(i);
            }
        }
        return factors;
    }
}
