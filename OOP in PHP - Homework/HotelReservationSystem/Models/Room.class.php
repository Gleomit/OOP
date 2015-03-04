<?php
namespace HotelReservationSystem\Models;

use HotelReservationSystem\Interfaces\IReservable;
use HotelReservationSystem\Enumerations\RoomType;

abstract class Room implements IReservable {
    private $reservations;
    private $roomType;
    private $bedCount;
    private $roomNumber;
    private $extras;
    private $hasBalcony;
    private $hasRestroom;
    private $price;

    public function __construct($roomType, $hasRestroom, $hasBalcony, $bedCount, $roomNumber, $extras, $price){
        $this->setRoomType($roomType);
        $this->setBedCount($bedCount);
        $this->setPrice($price);
        $this->setRoomNumber($roomNumber);
        $this->setExtras($extras);
        $this->setHasRestroom($hasRestroom);
        $this->setHasBalcony($hasBalcony);

        $this->reservations = [];
        $this->roomType = $roomType;
    }

    public function addReservation(Reservation $paramReservation){
        array_filter($this->reservations, function(Reservation $reservation)
        {
            global $paramReservation;
            if($paramReservation->getStartDate() <= $reservation->getEndDate() &&
                $paramReservation->getEndDate() >= $reservation->getStartDate())
            {
                throw new EReservationException();
            }
        });
    }

    public function removeReservation(Reservation $reservation){
        if(in_array($reservation, $this->reservations) == true)
        {
            array_splice($this->reservations, array_search($reservation, $this->reservations), 1);
        }
    }

    private function setExtras($extras){
        if(!is_array($extras)){
            throw new \InvalidArgumentException("Invalid data specified for extras, must be array.");
        }
        foreach($extras as $extra){
            if(!is_string($extra)){
                throw new \InvalidArgumentException("Extras array must contain only string values");
            }
        }
        $this->extras = $extras;
    }

    public function getExtras(){
        return $this->extras;
    }

    private function setRoomType($roomType){
        if(!is_string($roomType)){
            throw new \InvalidArgumentException("Invalid data specified for room type.");
        }
        if($roomType != RoomType::Standart && $roomType != RoomType::Gold && $roomType != RoomType::Diamond){
            throw new \UnexpectedValueException("Invalid room type");
        }
        $this->roomType = $roomType;
    }

    public function getRoomType()
    {
        return $this->roomType;
    }

    private function setRoomNumber($roomNumber){
        if(!is_int($roomNumber)){
            throw new \InvalidArgumentException("Invalid data specified for room number.");
        }
        if($roomNumber < 1){
            throw new \InvalidArgumentException("Room number cannot be less than 1.");
        }
        $this->roomNumber = $roomNumber;
    }

    public function getRoomNumber()
    {
        return $this->roomNumber;
    }

    private function setPrice($price){
        if((is_numeric($price) && is_string($price)) ||  !is_numeric($price)){
            throw new \InvalidArgumentException("Invalid data specified for price.");
        }
        if($price < 0){
            throw new \InvalidArgumentException("Price cannot be less than 0.");
        }
        $this->price = $price;
    }

    public function getPrice(){
        return $this->price;
    }

    private function setBedCount($bedCount){
        if(!is_int($bedCount)){
            throw new \InvalidArgumentException("Invalid data specified for bed count.");
        }
        if($bedCount < 1){
            throw new \InvalidArgumentException("Bed count cannot be less than 1.");
        }
        $this->bedCount = $bedCount;
    }

    public function getBedCount()
    {
        return $this->bedCount;
    }

    private function setHasRestroom($hasRestroom){
        if(!is_bool($hasRestroom)){
            throw new \InvalidArgumentException("Invalid data specified for has restroom.");
        }
        $this->hasRestroom = $hasRestroom;
    }

    public function getHasRestRoom(){
        return $this->hasRestroom;
    }

    private function setHasBalcony($hasBalcony){
        if(!is_bool($hasBalcony)){
            throw new \InvalidArgumentException("Invalid data specified for has balcony.");
        }
        $this->hasBalcony = $hasBalcony;
    }

    public function getHasBalcony(){
        return $this->hasBalcony;
    }

    public function getReservations(){
        return $this->reservations;
    }

    public function __toString(){
        return
        "<br>Has restroom: " . $this->getHasRestRoom()
        . "<br>Has balcony: " . $this->getHasBalcony()
        . "<br>Bed cound: " . $this->getBedCount()
        . "<br>Room number: " . $this->getRoomNumber()
        . "<br>Price: " . $this->getPrice()
        . "<br>Extras: " . implode(', ', $this->getExtras());
    }
}