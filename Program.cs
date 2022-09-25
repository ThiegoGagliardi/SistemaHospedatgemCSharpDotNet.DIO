using System.Text;
using SistemaHospedagemCSharpDotNet.DIO.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Guest> guests =  new List<Guest>();

Guest  person1 = new Guest("Nome 1", "Sobrenome1");
Guest  person2 = new Guest("Nome 2", "Sobrenome1");

guests.Add(person1);
guests.Add(person2);

Room bookedRoom = new Room("Quarto 1", 4, 50);

Reservation booking =  new Reservation(10);

booking.SetBookRoom(bookedRoom);
booking.AddGuest(guests);

Console.WriteLine($"Quantidade de hóspedes: {booking.getQuantityGuests()}");
Console.WriteLine($"Valor total da hospedagem: {booking.CheckOut()}" );

Console.ReadLine();