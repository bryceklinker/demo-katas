package vending.machine;

import org.junit.Test;

import static org.junit.Assert.*;

public class VendingMachineTest {
    @Test
    public void testSomething() {
        VendingMachine vendingMachine = new VendingMachine();
        assertEquals(0, vendingMachine.doSomething());
    }
}
