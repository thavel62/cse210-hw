using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Lecture St", "Lecture City", "Lecture State", "12345");
        Event lecture = new Lecture("Tech Talk", "A talk on the latest in tech", new DateTime(2024, 6, 15), new DateTime(2024, 6, 15, 18, 0, 0), lectureAddress, "John Doe", 100);

        Address receptionAddress = new Address("456 Reception Ave", "Reception City", "Reception State", "67890");
        Event reception = new Reception("Networking Event", "An event to network with professionals", new DateTime(2024, 7, 20), new DateTime(2024, 7, 20, 19, 0, 0), receptionAddress, "rsvp@example.com");

        Address outdoorAddress = new Address("789 Outdoor Rd", "Outdoor City", "Outdoor State", "11223");
        Event outdoorGathering = new OutdoorGathering("Picnic", "A fun outdoor picnic", new DateTime(2024, 8, 10), new DateTime(2024, 8, 10, 12, 0, 0), outdoorAddress, "Sunny with a chance of rain");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("\n------------------------\n");
        }
    }
}
