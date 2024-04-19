using ROOMMSMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROOMMSDL
{
    public class RoomManageDataServices
    {
        public List<Room> rooms = new List<Room>();

        public RoomManageDataServices()
        {
            CreateRoomData();
        }

        private void CreateRoomData()
        {
            Room room1 = new Room();
            room1.roomNo = "Room 101";
            room1.name = "John Smith";
            room1.phoneNum = "09123456789";
            room1.numRent = "3";
            room1.pets = "2";
            room1.ac = "Yes";
            room1.status="Not Available";


            Room room2 = new Room();
            room2.roomNo = "Room 102";
            room2.status = "Available";


            Room room3 = new Room();
            room3.roomNo = "Room 103";
            room3.name = "Michael Brown";
            room3.phoneNum = "09655423655";
            room3.numRent = "4";
            room3.pets = "0";
            room3.ac = "Yes";
            room3.status = "Not Available";

            Room room4 = new Room();
            room4.roomNo = "Room 201";
            room4.name = "Emily Davis";
            room4.phoneNum = "09568432568";
            room4.numRent = "5";
            room4.pets = "1";
            room4.ac = "No";
            room4.status = "Not Available";


            Room room5 = new Room();
            room5.roomNo = "Room 202";
            room5.status = "Available";


            Room room6 = new Room();
            room6.roomNo = "Room 203";
            room6.name = "Jennifer Taylor";
            room6.phoneNum = "09486315678";
            room6.numRent = "1";
            room6.pets = "0";
            room6.ac = "Yes";
            room6.status = "Not Available";


            Room room7 = new Room();
            room7.roomNo = "Room 301";
            room7.name = "James Martinez";
            room7.phoneNum = "09564873214";
            room7.numRent = "5";
            room7.pets = "0";
            room7.ac = "Yes";
            room7.status = "Not Available";


            Room room8 = new Room();
            room8.roomNo = "Room 302";
            room8.status = "Available";


            Room room9 = new Room();
            room9.roomNo = "Room 303";
            room9.name = "Robert Anderson";
            room9.phoneNum = "09648257396";
            room9.numRent = "3";
            room9.pets = "2";
            room9.ac = "Yes";
            room9.status = "Not Available";


            rooms.Add(room1);
            rooms.Add(room2);
            rooms.Add(room3);
            rooms.Add(room4);
            rooms.Add(room5);
            rooms.Add(room6);
            rooms.Add(room7);
            rooms.Add(room8);
            rooms.Add(room9);

        }
    }


}
