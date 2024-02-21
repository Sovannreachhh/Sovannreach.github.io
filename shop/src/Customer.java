class Customer implements DiscountRate {
    private String cusName;
    private String cusType;
    public Customer(String cusName, String cusType) {
        this.cusName = cusName;
        this.cusType = cusType;
    }
    public String getCusName() {
        return cusName;
    }
    public void setCusName(String cusName) {
        this.cusName = cusName;
    }
    public String getCusType() {
        return cusType;
    }
    public void setCusType(String cusType) {
        this.cusType = cusType;
    }
    @Override
    public double getServiceDiscount() {
        switch (cusType.toLowerCase()) {
            case "premium":
                return 0.20;
            case "gold":
                return 0.15;
            case "silver":
                return 0.10;
            default:
                return 0.0;
        }
    }

    @Override
    public double getProductDiscount() {
        switch (cusType.toLowerCase()) {
            case "premium":
            case "gold":
            case "silver":
                return 0.10;
            default:
                return 0.0;
        }
    }
}