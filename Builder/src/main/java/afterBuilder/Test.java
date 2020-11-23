package afterBuilder;

import com.sun.javafx.collections.ImmutableObservableList;
import jdk.nashorn.internal.ir.annotations.Immutable;

import java.awt.*;
import java.util.List;

public class Test {
    public static void main(String[] args) {
        Name name=new Name.Builder()
                .firstName("pamal")
                .middleName(new ImmutableObservableList("sahan","vijay"))
                .surName("jayawickrama")
                .build();

        Address address=new Address.Builder()
                .city("Elpitiya")
                .houseNumber(342)
                .street("Ananda Vidyala Mavatha")
                .zipCode("80400")
                .build();

        Account account=new Account.Builder()
                .address(address)
                .name(name)
                .email("p.s.jayawickrama@gmail.com")
                .id(12)
                .build();
    }
}
