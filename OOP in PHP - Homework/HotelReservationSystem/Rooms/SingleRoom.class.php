<?php
namespace HotelReservationSystem\Rooms;

use HotelReservationSystem\Models\Room;
use HotelReservationSystem\Enumerations\RoomType;

class SingleRoom extends Room {
    public function __construct($roomNumber, $price){
        parent::__construct(RoomType::Standart, true, false, 1, $roomNumber, [], $price);
    }

    public function  __toString()
    {
        return "<br><br>Type - SingleRoom" . parent::__toString();
    }
} 