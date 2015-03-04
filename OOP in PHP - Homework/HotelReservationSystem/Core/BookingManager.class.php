<?php
namespace HotelReservationSystem\Core;

use HotelReservationSystem\Models\Room;
use HotelReservationSystem\Models\Reservation;

class BookingManager {
    public static  function bookRoom(Room $room, Reservation $reservation)
    {
        $room->addReservation($reservation);
    }
} 