// Assignment-2: Interfaces  (Payment System Interface)
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

// Objective: Implement interfaces and multiple classes.

// Requirements:

// 		1.  	Create an interface IPayment:
// 							void Pay(double amount)

// 		2.   Implement classes:
// 					CreditCardPayment
// 					UPIPayment
// 					PaypalPayment

// 			3.  Demonstrate usage in the Main() method.
			
			

// Hint :  Prepare the child classes with required properties based on the payment type class. 

namespace ObjectOrientedProgramming
{

    namespace ConsoleApp39
    {
        namespace PaymentSystem
        {

            interface IPayment
            {
                void Pay(double amount);
            }
            class CreditCardPayment : IPayment
            {
                public string CardNumber { get; set; }
                public string CardHolderName { get; set; }

                public CreditCardPayment(string cardNumber, string cardHolderName)
                {
                    CardNumber = cardNumber;
                    CardHolderName = cardHolderName;
                }

                public void Pay(double amount)
                {
                    Console.WriteLine($"Credit Card Payment");
                    Console.WriteLine($"Card Holder: {CardHolderName}");
                    Console.WriteLine($"Card Number: {CardNumber}");
                    Console.WriteLine($"Amount Paid: {amount}");
                    Console.WriteLine("Payment Successful using Credit Card\n");
                }
            }

            class UPIPayment : IPayment
            {
                public string UpiId { get; set; }

                public UPIPayment(string upiId)
                {
                    UpiId = upiId;
                }

                public void Pay(double amount)
                {
                    Console.WriteLine($"UPI Payment");
                    Console.WriteLine($"UPI ID: {UpiId}");
                    Console.WriteLine($"Amount Paid: {amount}");
                    Console.WriteLine("Payment Successful using UPI\n");
                }
            }

            class PaypalPayment : IPayment
            {
                public string Email { get; set; }

                public PaypalPayment(string email)
                {
                    Email = email;
                }

                public void Pay(double amount)
                {
                    Console.WriteLine($"PayPal Payment");
                    Console.WriteLine($"PayPal Account: {Email}");
                    Console.WriteLine($"Amount Paid: {amount}");
                    Console.WriteLine("Payment Successful using PayPal\n");
                }
            }


            internal class Program
            {
                static void Main(string[] args)
                {
                    IPayment creditCardPayment = new CreditCardPayment("1234567812345678", "Lekhana K");
                    IPayment upiPayment = new UPIPayment("lekhana@upi");
                    IPayment paypalPayment = new PaypalPayment("lekhana@example.com");

                    creditCardPayment.Pay(1500.00);
                    upiPayment.Pay(850.75);
                    paypalPayment.Pay(2300.50);

                    Console.ReadLine();


                }
            }
        }
    }
}


