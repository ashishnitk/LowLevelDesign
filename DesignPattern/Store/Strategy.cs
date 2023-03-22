using System;
using System.Collections.Generic;

namespace Stratgy
{
    interface IStrategy
    {
        int GetFinalBill(int BillAmount);
    }
    class LowDiscountStrategy : IStrategy
    {
        public int GetFinalBill(int BillAmount)
        {
            return (int)(BillAmount - (BillAmount * 0.1));
        }
    }
    class HighDiscountStrategy : IStrategy
    {
        public int GetFinalBill(int BillAmount)
        {
            return (int)(BillAmount - (BillAmount * 0.5));
        }
    }
    class NoDiscountStrategy : IStrategy
    {
        public int GetFinalBill(int BillAmount)
        {
            return BillAmount;
        }
    }
    class ShoppingMall
    {
        public string CustomerName { get; set; }
        public int BillAmt { get; set; }
        public IStrategy current_strategy;
        public ShoppingMall(IStrategy strategy)
        {
            current_strategy = strategy;
        }

        public int GetFinalBill()
        {
            return current_strategy.GetFinalBill(this.BillAmt);
        }
    }

    public class MainApp
    {
        public static void MainChange()
        {
            ShoppingMall orion = new ShoppingMall(null);
            orion.CustomerName = "New Customer";
            orion.BillAmt = 1000;

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    orion.current_strategy = new LowDiscountStrategy();
                    break;
                case DayOfWeek.Monday:
                    orion.current_strategy = new HighDiscountStrategy();
                    break;
                case DayOfWeek.Tuesday:
                    orion.current_strategy = new HighDiscountStrategy();
                    break;
                case DayOfWeek.Wednesday:
                    orion.current_strategy = new HighDiscountStrategy();
                    break;
                case DayOfWeek.Thursday:
                    orion.current_strategy = new HighDiscountStrategy();
                    break;
                case DayOfWeek.Friday:
                    orion.current_strategy = new LowDiscountStrategy();
                    break;
                case DayOfWeek.Saturday:
                    orion.current_strategy = new LowDiscountStrategy();
                    break;
                default:
                    orion.current_strategy = new NoDiscountStrategy();
                    break;
            }


            Console.WriteLine("Final Bill" + orion.GetFinalBill());
        }
    }

}
