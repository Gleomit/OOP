<?php
namespace HotelReservationSystem\Models;

use HotelReservationSystem\Models\Guest;

class Reservation {
    private  $startDate;
    private  $endDate;
    private  $guest;

    public function __construct($startDate, $endDate, Guest $guest){
        $this->setStartDate($startDate);
        $this->setEndDate($endDate);
        $this->setGuest($guest);
    }

    private function setStartDate($startDate){
        if(is_string($startDate)){
            throw new \InvalidArgumentException("Invalid data specified for start date.");
        }
        if(is_string($startDate)){
            $date = date_parse($startDate);
            if (!($date["error_count"] == 0 && checkdate($date["month"], $date["day"], $date["year"]))){
                throw new \InvalidArgumentException("Invalid date string specified.");
            }
        }
        $this->startDate = $startDate;
    }

    public function getStartDate(){
        return $this->startDate;
    }

    private function setEndDate($endDate){
        if(is_string($endDate)){
            throw new \InvalidArgumentException("Invalid data specified for end date.");
        }
        if(is_string($endDate)){
            $date = date_parse($endDate);
            if (!($date["error_count"] == 0 && checkdate($date["month"], $date["day"], $date["year"]))){
                throw new \InvalidArgumentException("Invalid date string specified.");
            }
        }
        $this->endDate = $endDate;
    }

    public function getEndDate(){
        return $this->endDate;
    }

    private function setGuest(Guest $guest){
        $this->guest = $guest;
    }

    public function getGuest(){
        return $this->guest;
    }

    public function  __toString()
    {
        return "Reservation"
            . "Start date: " . $this->getStartDate()
            . "End date: " . $this->getEndDate()
            . "Guest: " . $this->getGuest();
    }
} 