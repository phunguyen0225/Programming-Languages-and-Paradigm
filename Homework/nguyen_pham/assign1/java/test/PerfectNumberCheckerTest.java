package assign1;

import org.junit.jupiter.api.Test;

import java.util.*;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertTrue;


public class PerfectNumberCheckerTest {

  @Test
  public void canary() { 
    assertTrue(true);
  }

  @Test
  void getFactorOf6() {
    assertEquals(Arrays.asList(1, 2, 3), PerfectNumberChecker.getFactors(6));
  }

  @Test
  void getFactorOf50() {
    assertEquals(Arrays.asList(1, 2, 5, 10, 25), PerfectNumberChecker.getFactors(50));
  }
}
