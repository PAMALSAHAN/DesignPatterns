package afterBuilder;

import java.util.List;

public class Name {
    private String firstName;
    private List<String> middleNames;
    private String surName;

    public Name(Builder builder) {
        this.firstName=builder.firstName;
        this.middleNames=builder.middleNames;
        this.surName=builder.surName;
    }

    public String getFirstName() {
        return firstName;
    }

    public List<String> getMiddleNames() {
        return middleNames;
    }

    public String getSurName() {
        return surName;
    }

    public static class Builder{

        private String firstName;
        private List<String> middleNames;
        private String surName;

        public Builder firstName(final String firstName){
            this.firstName=firstName;
            return this;
        }

        public Builder middleName(final List<String> middleNames){
            this.middleNames=middleNames;
            return this;
        }
        public Builder surName(final String surName){
            this.surName=surName;
            return this;
        }
        public Name build(){
            return new Name(this);
        }
    }
}

