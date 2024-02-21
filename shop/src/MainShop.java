import java.util.Scanner;
interface DiscountRate {
    double getServiceDiscount();
    double getProductDiscount();
}

public class MainShop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter customer name: ");
        String cusName = scanner.nextLine();

        System.out.print("Enter customer type (Premium/Gold/Silver/Normal): ");
        String customerType = scanner.nextLine();

        Customer customer = new Customer(cusName, customerType);

        System.out.print("Enter sale date: ");
        String saleDate = scanner.nextLine();

        System.out.print("Enter service expense: $");
        double serviceExpense = scanner.nextDouble();

        System.out.print("Enter product expense: $");
        double productExpense = scanner.nextDouble();

        Sale sale = new Sale(customer, saleDate);
        sale.setServiceExpense(serviceExpense);
        sale.setProductExpense(productExpense);

        System.out.println("\nSale Information:");
        sale.displayInfo();

        scanner.close();
    }
}
