<?php
namespace HotelReservationSystem;
    date_default_timezone_set("UTC");

    spl_autoload_register(function ($class) {
        if(file_exists(str_replace("HotelReservationSystem\\", "", $class) . '.class.php'))
            include_once '' . str_replace("HotelReservationSystem\\", "", $class) . '.class.php';
    });

    use HotelReservationSystem\Models\Reservation;
    use HotelReservationSystem\Rooms\SingleRoom;
    use HotelReservationSystem\Models\Guest;
    use HotelReservationSystem\Core\BookingManager;
    use HotelReservationSystem\Rooms\Apartment;
    use HotelReservationSystem\Rooms\Bedroom;
    use HotelReservationSystem\Models\Room;

    $room = new SingleRoom(1408, 99);
    $guest = new Guest("Svetlin", "Nakov", 8003224277);
    $startDate = strtotime("24.10.2014");
    $endDate = strtotime("26.10.2014");
    $reservation = new Reservation($startDate, $endDate, $guest);
    BookingManager::bookRoom($room, $reservation);

    $rooms = [new Bedroom(100, 50), new Apartment(150, 100), new SingleRoom(10, 2)];

    //filter by price and type of room
    foreach(array_filter($rooms, function(Room $tempRoom){
        if($tempRoom instanceof SingleRoom || ($tempRoom instanceof SingleRoom && $tempRoom->getPrice() <= 250000)){
            return $tempRoom;
        }
    }) as $room)
    {
        print $room;
    }
    print "<br><br>";
    //filter rooms by having balcony
    foreach(array_filter($rooms, function(Room $tempRoom){
        if($tempRoom->getHasBalcony() == true)
        {
            return $tempRoom;
        }
    }) as $room)
    {
        print $room;
    }
    print "<br><br>";
    //filter rooms by extras
    foreach(array_filter($rooms, function(Room $tempRoom){
        if(in_array("bathtub", $tempRoom->getExtras()))
        {
            return $tempRoom;
        }
    }) as $room)
    {
        print $room;
    }