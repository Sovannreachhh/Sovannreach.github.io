class Sale {
    private Customer cus;
    private String date;
    private double serviceExpense;
    private double productExpense;
    public Sale(Customer cus, String date) {
        this.cus = cus;
        this.date = date;
        this.serviceExpense = 0.0;
        this.productExpense = 0.0;
    }
    public String getDate() {
        return date;
    }
    public void setCus()
    {
        this.cus = cus;
    }
    public void setDate()
    {
        this.date = date;
    }
    public double getServiceExpense() {
        return serviceExpense;
    }
    public void setServiceExpense(double serviceExpense) {
        this.serviceExpense = serviceExpense;
    }
    public double getProductExpense() {
        return productExpense;
    }
    public void setProductExpense(double productExpense) {
        this.productExpense = productExpense;
    }
    public double getTotalExpense() {
        double totalExpense = serviceExpense * (1 - cus.getServiceDiscount()) +
                productExpense * (1 - cus.getProductDiscount());
        return totalExpense;
    }

    public void displayInfo() {
        System.out.println("Customer: " + cus.getCusName());
        System.out.println("Date: " + date);
        System.out.println("Service Expense: $" + serviceExpense);
        System.out.println("Product Expense: $" + productExpense);
        System.out.println("Total Expense: $" + getTotalExpense());
    }
}