using System.Collections.Generic;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    // Single-responsibility principle 
    public class Item
    {

    }
    class Order
    {
        private IItemManager itemManager;

        public Order(IItemManager itemManager)
        {
            this.itemManager = itemManager;
        }

        public IReadOnlyList<Item> GetItems() => itemManager.GetItems();
    }

    public interface IItemManager
    {
        IReadOnlyList<Item> GetItems();
        void AddItem(Item item);
        void DeleteItem(Item item);
    }

    public class ItemManager : IItemManager
    {
        private List<Item> itemList = new List<Item>();

        public IReadOnlyList<Item> GetItems() => itemList.AsReadOnly();
        public void AddItem(Item item) { }
        public void DeleteItem(Item item) { }
    }


    class OrderCalculator
    {
        Order _order;
        public void CalculateTotalSum() {/*...*/}
        public void GetItemCount() {/*...*/}
    }

    class OrderPrinter
    {
        Order _order;

        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}
    }

    class OrderRepository
    {
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
