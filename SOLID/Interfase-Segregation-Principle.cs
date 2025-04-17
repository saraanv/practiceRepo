//SOLID: I:Interface Segregation
public interface IOrder
{
    void PlaceOrder();
    void CancleOrder();
    void UpdateOrder();
    void CalculateTotal();
    void GenerteInvoice();
    void SendConfirmationEmail();
    void PrintLabel();
}

public class OnlineOrder : IOrder
{

}

public class InStoreOrder : IOrder
{

}

//The Problem With Code Above Is That An Interface Should Not Contains Constraints Of A Class
//Have To Implement Them Without Any Real Needs.

//Fixed Code:
public interface IOrder
{
    void PlaceOrder();
    void CancleOrder();
    void UpdateOrder();
}
public interface IOrderProcessing
{
    void CalculateTotal();
}
public interface IInvoiceGenerator
{
    void GenerateInvoice();
}
public interface IEmailSender
{
    void SendConfirmationEmail();
}
public interface ILabelPrinter
{
    void PrintLabel();
}
public class OnlineOrder : IOrder , IOrderProcessing , IInvoiceGenerator , IEmailSender
{

}

public class InStoreOrder : IOrder, IOrderProcessing, ILabelPrinter
{

}