<?php
namespace HotelReservationSystem\Interfaces;

use HotelReservationSystem\Models\Reservation;

interface IReservable {
    function addReservation(Reservation $reservation);
    function removeReservation(Reservation $reservation);
} 