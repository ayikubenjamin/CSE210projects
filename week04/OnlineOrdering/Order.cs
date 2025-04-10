public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public string GetPackingLabel()
    {
    string label = "Packing Label:\n";
    foreach (Product product in _products)
    {
        label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
    }
    return label;
    }

    public string GetShippingLabel()
    {
    string label = "Shipping Label:\n";
    label += $"{_customer.GetCustomerName()}\n";
    label += _customer.GetAddress().DisplayAddress();
    return label;
    }

    public double TotalCost()
    {
        double total = 0;

    foreach (Product product in _products)
    {
        total += product.ProductTotalCost();
    }

    if (_customer.IsInUSA())
    {
        total += 5; 
    }
    else
    {
        total += 35; 
    }

    return total;
    }

    public void AddProduct(Product product)
    {
         _products.Add(product);
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
    foreach (Product product in _products)
    {
        label += $"{product.GetName} (ID: {product.GetProductId})\n";
    }
    return label;
    }

    public string ShippingLabel()
    {
    string label = "Shipping Label:\n";
    label += $"{_customer.GetCustomerName}\n";
    label += _customer.GetAddress().DisplayAddress();
    return label;
    }

}