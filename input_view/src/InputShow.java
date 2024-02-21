import java.util.Scanner;

public class InputShow {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter number of elements in list: ");
        int n = scanner.nextInt();
        int[] numbers = new int[n];
        System.out.println("Enter numbers:");

        for (int i = 0; i < n; i++) {
            System.out.print("Number " + (i + 1) + ": ");
            numbers[i] = scanner.nextInt();
        }
        System.out.println("\nInput Numbers:");

        for (int i = 0; i < n; i++) {
            System.out.println(numbers[i]);
        }
        scanner.close();
    }
}
