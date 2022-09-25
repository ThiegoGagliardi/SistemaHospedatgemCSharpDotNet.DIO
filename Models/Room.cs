using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemCSharpDotNet.DIO.Models
{
    public class Room
    {
        public string RoomType { get; }

        public int Capacity { get; }

        public decimal Price { get; }

        public Room(string roomType, int capacity, decimal price)
        {    
            this.RoomType = roomType;
            this.Capacity = capacity;
            this.Price    = price;
        }
    }
}