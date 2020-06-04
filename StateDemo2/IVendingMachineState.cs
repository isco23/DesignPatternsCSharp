using System;

namespace StateDemo2
{
    public interface IVendingMachineState
    {
        void SelectProductAndInsertMoney(int amount, String productName);
        void DispenseProduct();
    }
}
