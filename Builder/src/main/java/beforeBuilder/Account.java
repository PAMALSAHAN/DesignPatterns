package beforeBuilder;

import java.util.List;

public class Account {
    private int id;
    private String firstName;
    private List<String> middleNames;
    private String surName;
    private int houseNumber;
    private String street;
    private String zipCode;
    private String city;
    private String email;

    public Account(int id, String firstName, List<String> middleNames,String surName,int houseNumber,String street,String zipCode,String city,String email ) {
        this.id = id;
        this.firstName = firstName;
        this.middleNames = middleNames;
        this.surName = surName;
        this.houseNumber = houseNumber;
        this.street = street;
        this.zipCode = zipCode;
        this.city = city;
        this.email = email;
    }
}
