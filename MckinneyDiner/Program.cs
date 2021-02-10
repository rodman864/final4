using System;
using System.Collections;
using System.Collections.Generic;

namespace Diner
{
    public class MckinneyDiner
    {
        public InWaiting CurrentlyWaiting { get; set; }
        public PaidCustomer CleanTable { get; set; }
        private Queue<int> waitingQueue = new Queue<int>();

        public void addCustomerToQueue(int parameter)
        {
            waitingQueue.Enqueue(parameter);

        }

        public bool showCustomer(InWaiting inWaiting)
        {
            Console.Write("This is the amount of customers that need to be seated: " +
                                 waitingQueue.Count);

            if (inWaiting.IsAdded)
                return true;

            if (inWaiting.IsAdded != CurrentlyWaiting.IsAdded)
                return true;

            return false;

        }
        public void actualCustomer()
        {
            foreach (var item in waitingQueue)
            {
                Console.WriteLine("Customer: " + item);
            }
        }
        public void CustomerSeated()
        {
            waitingQueue.Dequeue();
        }
        private Stack<String> DirtyDish = new Stack<string>();
        private Stack<string> CleanDish = new Stack<string>();

        public bool CustomerDishes(PaidCustomer paidCustomer )
        {
            if (paidCustomer.CleanedTable)
                return true;

            if (paidCustomer.SentToWash != paidCustomer.CleanedTable)
                return true;

            return false;

        }
        public void CleanTheDishes()
        {
            string lastCustomer = DirtyDish.Pop();
            CleanDish.Push(lastCustomer);
        }
        public void CleanPile()
        {
            foreach(var item in  CleanDish)
            {
                Console.WriteLine("The dishes are put back:" + item);
            }
        }

        public void DishClean()
        {

        }
        public void DishDirty()
        {

        }
        public class InWaiting
        {
            public string CustomerName { get; set; }
            public bool IsAdded { get; set; }
            public bool IsDishDirty { get; set; }
            public bool IsDishClean { get; set; }
          
            

        }
        public class AddedToQue
        {
            public string isAddedToQue { get; set; }
        }
        public class PaidCustomer
        {
            public string Customer1 { get; set; }
            public bool CleanedTable { get; set; }
            public bool DirtyDish { get; set; }
            public bool SentToWash { get; set; }
        }
       
        






        static void Main(string[] args)
        {
            MckinneyDiner restaurantCustomer = new MckinneyDiner();
            restaurantCustomer.addCustomerToQueue(1);
            restaurantCustomer.addCustomerToQueue(2);
            restaurantCustomer.addCustomerToQueue(3);
            restaurantCustomer.addCustomerToQueue(4);
            restaurantCustomer.addCustomerToQueue(5);
            restaurantCustomer.addCustomerToQueue(6);

            restaurantCustomer.CustomerSeated();

            restaurantCustomer.actualCustomer();




        
            restaurantCustomer.CustomerDishes("dish1");
            restaurantCustomer.CustomerDishes("dish2");
            restaurantCustomer.CustomerDishes("dish3");

            restaurantCustomer.CleanTheDishes();
            restaurantCustomer.CleanPile();












        }

    }

    

}

