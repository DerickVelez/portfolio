using Bookstore.Data.Entitites;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Service;

public class OrderItemsService
{
    private List<OrderItems> orderitemsList = new List<OrderItems>
    {
        new OrderItems
        {
         ItemNumber = 1,
         ItemAgreedPrice = 54,
         ItemComment = " no comment",
        }

    };
    public string connectionString = @"Server=DESKTOP-F3KVDMV\MSSQLSERVER01;Database=Bookstore;Trusted_Connection=True;";

    public bool IsAlreadyExist(int itemNumber)
    {
        var orderItems = orderitemsList.Where(a => a.ItemNumber == itemNumber).FirstOrDefault();
        return orderItems != null;
    }

    public List<OrderItems> GetOrderItems()
    {
        using var con = new SqlConnection(connectionString);
        con.Open();

        var orderItems = con.Query<OrderItems>("SELECT * FROM OrderItems");
        return orderItems.ToList();
    }

    public OrderItems Add(OrderItems orderitem)
    {
        using var con = new SqlConnection(connectionString);
        con.Open();

        var createdAuthor = con.QuerySingle<OrderItems>("INSERT INTO OrderItems (ItemAgreedPrice,ItemComment) OUTPUT INSERTED.ItemNumber, INSERTED.ItemAgreedPrice, INSERTED.ItemComment VALUES (@ItemAgreedPrice,@ItemComment);", orderitem);
        return createdAuthor;
    }

    public OrderItems Delete(OrderItems orderitem)
    {
        using var con = new SqlConnection(connectionString);
        con.Open();

        var createdAuthor = con.Execute("DELETE FROM OrderItems WHERE (ItemNumber = @ItemNumber)", orderitem);
        return orderitem;
    }

    public OrderItems Update(OrderItems orderitem)
    {
        using var con = new SqlConnection(connectionString);
        con.Open();

        var createdAuthor = con.Execute("UPDATE OrderItems SET ItemAgreedPrice = @ItemAgreedPrice, ItemComment = @ItemComment WHERE (ItemNumber = @ItemNumber)", orderitem);
        return orderitem;
    }

    public OrderItems? FindById(int itemnumber)
    {
        return orderitemsList.Where(a => a.ItemNumber == itemnumber).FirstOrDefault();
    }

}
