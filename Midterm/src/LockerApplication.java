import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class LockerApplication extends JFrame {
    private String savedPassword = null;
    private JTextField passwordField;
    private JLabel statusLabel;

    public LockerApplication() {
        setTitle("Lock Class");
        setSize(400, 300);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        Container container = getContentPane();
        container.setLayout(new GridLayout(4, 3));

        JButton[] numberButtons = new JButton[9];
        for (int i = 0; i < 9; i++) {
            int number = i + 1;
            numberButtons[i] = new JButton(String.valueOf(number));
            numberButtons[i].addActionListener(e -> passwordField.setText(passwordField.getText() + number));
            container.add(numberButtons[i]);
        }

        JButton clearButton = new JButton("Clear");
        clearButton.addActionListener(e -> passwordField.setText(""));
        container.add(clearButton);

        passwordField = new JTextField();
        container.add(passwordField);

        JButton enterButton = new JButton("Enter");
        enterButton.addActionListener(new EnterButtonListener());
        container.add(enterButton);

        statusLabel = new JLabel("Enter Password");
        container.add(statusLabel);

        setVisible(true);
    }

    private class EnterButtonListener implements ActionListener {
        @Override
        public void actionPerformed(ActionEvent e) {
            String inputPassword = passwordField.getText();

            if (savedPassword == null) {
                savedPassword = inputPassword;
                statusLabel.setText("Password Set");
            } else {
                if (inputPassword.equals(savedPassword)) {
                    statusLabel.setText("Correct Password");
                } else {
                    statusLabel.setText("Incorrect Password");
                }
            }

            passwordField.setText("");
        }
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(LockerApplication::new);
    }
}
