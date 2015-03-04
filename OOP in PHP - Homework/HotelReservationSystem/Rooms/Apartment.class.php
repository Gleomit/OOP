<?php
namespace HotelReservationSystem\Rooms;

use HotelReservationSystem\Models\Room;
use HotelReservationSystem\Enumerations\RoomType;

class Apartment extends Room {
    public function __construct($roomNumber, $price){
        parent::__construct(RoomType::Diamond, true, true, 4, $roomNumber, [
            "TV", "air-conditioner", "refrigerator", "kitchen box", "mini-bar", "bathtub", "free Wi-fi"
        ], $price);
    }

    public function  __toString()
    {
        return "<br><br>Type - Apartment" . parent::__toString();
    }
} 