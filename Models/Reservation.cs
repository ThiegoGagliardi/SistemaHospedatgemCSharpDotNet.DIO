using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemCSharpDotNet.DIO.Models
{    
    public class Reservation
    {
        const int QUATITY_NIGTHS_DISCOUNT = 10;
        const decimal PERCENTUAL_DISCOUNT = 10;

        public Room BookRoom { get; set;}

        public List<Guest> Guests {get; set; }

        public int StayingNights { get; set;}

        private Decimal _discount;

        public Reservation(int stayingNights)
        {
            _discount = 0;

            if (stayingNights >= QUATITY_NIGTHS_DISCOUNT) {
                _discount = PERCENTUAL_DISCOUNT;  
            }
            
            this.StayingNights = stayingNights;

            Guests = new List<Guest>();
        }

        public void AddGuest (List<Guest> guests){

            if (this.BookRoom is null){
                Console.WriteLine("Necessário cadastrar um quarto.");
                return;
            }

            if ((guests.Count + this.Guests.Count) > BookRoom.Capacity) {

                Console.WriteLine("Quarto selecionado não suporta esta quantidade de hospedes.");
                return;
            }

            this.Guests.AddRange(guests);
        }
        
        public void SetBookRoom(Room room){
            BookRoom = room;
        }

        public Decimal CheckOut(){

            if (this.BookRoom is null){
                Console.WriteLine("Necessário cadastrar um quarto.");
                return 0;
            }

            if (this.Guests.Count == 0) {

                Console.WriteLine("Reserva sem hóspedes cadastrados.");
                return 0;
            }                        
           
           return  (StayingNights * BookRoom.Price) * (1 - (_discount/100));
        }

        public int getQuantityGuests()
        {
            return this.Guests.Count;
        }
    }
}