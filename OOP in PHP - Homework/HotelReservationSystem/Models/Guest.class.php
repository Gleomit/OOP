<?php
namespace HotelReservationSystem\Models;

class Guest {
    private $firstName;
    private $lastName;
    private $id;

    public function __construct($firstName, $lastName, $id){
        $this->setFirstName($firstName);
        $this->setLastName($lastName);
        $this->setId($id);
    }

    function setFirstName($firstName){
        if(!is_string($firstName)){
            throw new \InvalidArgumentException("Invalid data specified for first name, must be string.");
        }
        if(count_chars(trim($firstName)) == 0){
            throw new \InvalidArgumentException("First name cannot me empty string");
        }
        $this->firstName = $firstName;
    }

    function getFirstName(){
        return $this->firstName;
    }

    function setLastName($lastName){
        if(!is_string($lastName)){
            throw new \InvalidArgumentException("Invalid data specified for last name, must be string.");
        }
        if(count_chars(trim($lastName)) == 0){
            throw new \InvalidArgumentException("Last name cannot me empty string");
        }
        $this->lastName = $lastName;
    }

    function getLastName(){
        return $this->lastName;
    }

    function setId($id){
        if((is_numeric($id) && is_string($id)) || !is_numeric($id)){
            throw new \InvalidArgumentException("Invalid data specified for ID, must be number.");
        }
        if($id < 0){
            throw new \InvalidArgumentException("ID cannot be negative number.");
        }
        $this->id = $id;
    }

    function getId(){
        return $this->id;
    }

    public function  __toString()
    {
        return "Name: " . $this->getFirstName() . " " . $this->getLastName();
    }
} 