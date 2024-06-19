import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class ProductDisplay {
    public static void main(String[] args) {
        String url = "jdbc:mysql://localhost:3306/product";
        String user = "reach";
        String password = "reach123";

        try {
            Connection connection = DriverManager.getConnection(url, user, password);

            Statement statement = connection.createStatement();

            String query = "SELECT * FROM Product";
            ResultSet resultSet = statement.executeQuery(query);

            while (resultSet.next()) {
                int id = resultSet.getInt("id");
                String name = resultSet.getString("name");
                double pricePerUnit = resultSet.getDouble("price_per_unit");
                boolean activeForSell = resultSet.getBoolean("active_for_sell");

                System.out.println("ID: " + id + ", Name: " + name + ", Price per Unit: " + pricePerUnit + ", Active for Sell: " + activeForSell);
            }
            
            resultSet.close();
            statement.close();
            connection.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
