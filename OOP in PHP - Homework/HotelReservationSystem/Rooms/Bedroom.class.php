<?php
namespace HotelReservationSystem\Rooms;

use HotelReservationSystem\Models\Room;
use HotelReservationSystem\Enumerations\RoomType;

class Bedroom extends Room{
    public function __construct($roomNumber, $price){
        parent::__construct(RoomType::Gold, true, true, 2, $roomNumber, [
            "TV", "air-conditioner", "refrigerator", "mini-bar", "bathtub"
        ], $price);
    }

    public function  __toString()
    {
        return "<br><br>Type - Bedroom" . parent::__toString();
    }
} 