// See https://aka.ms/new-console-template for more information
using OrderCommandExample;

Console.WriteLine("Hello, Order Command Pattern!");



Stock abcStock = new Stock();

BuyStock buyStockOrder = new BuyStock(abcStock);
SellStock sellStockOrder = new SellStock(abcStock);

Broker broker = new Broker();
broker.takeOrder(buyStockOrder);
broker.takeOrder(sellStockOrder);

broker.placeOrders();