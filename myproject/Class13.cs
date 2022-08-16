using System;
using System.Collections.Generic;
using System.Text;
//int cost_price,int no_of_items and int profit.Complete the function calculate_sellingprice() and return the selling price of the item in float format. For example if the cost price of each item
//is 20, number of items is 10 and the profit to be earned is 20%, the output i.e., the selling price of each item is 24.0.
//Example 1
//Input
//cost_price = 15, no_of_items = 10, profit = 20

namespace Assingnment1
{
    class Class13
    {
        static void Main(string[] args)
        {
        int costprice = 15;
        int profit = 20 * 15 / 100;
        float selling = costprice + profit;
        Console.WriteLine("selling price is:"+selling);
        }
    }
}
