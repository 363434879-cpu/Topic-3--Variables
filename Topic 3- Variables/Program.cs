namespace Topic_3__Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Naika
            string firstName, lastName, eyeColor, hairColor;
            int age, height, weight;

            firstName = "John";
            lastName = "Smith";
            age = 35; // not a lie
            height = 74; // inches
            weight = 180; // lbs
            eyeColor = "Blue";
            hairColor = "Brown";

            Console.WriteLine("Let's talk about " + firstName + " " + lastName + ".");
            Console.WriteLine("He's " + height + " inches tall.");
            Console.WriteLine("He's " + weight + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("His eyes are " + eyeColor + " and hair is " + hairColor);
            // This line is tricky; try to get it exactly right.
            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight
                + " I get " + (age + height + weight) + ".");

            



        }
    }
}
