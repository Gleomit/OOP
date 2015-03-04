<?php
namespace HotelReservationSystem\Exceptions;

class EReservationException extends Exception {
    public function __construct(){
        parent::__construct("Reservation already exist in this period of time.", 1000);
    }
} 