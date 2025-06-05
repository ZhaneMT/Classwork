
    /***********************************************************
     * This class will represent Pet information
     *
     * Data: Name of the Pet
     *      Type of Pet (Dog, Cat, Gerbil, Lizard, Bird, etc)
     *      Gender
     *      Weight (lbs)
     *      Is it spayed or neutered?
     *
     *      Behavior (methods):
     *      1. You should always have at least on constructor to the class
     *          (usually you have a default constructor and a constructor that
     * ****************************************
     */
    package Pet;

    import java.util.Objects;

    public class Pet {
    private String petName;
    private String petType;
    private char petGender;
    private int petWeight;
    private boolean isSpayed;    //boolean variable are usually  started with "is"
    /*********************************************
    * Constructors - Initialized objects instantiated for a class.
     ****************************************/
        public Pet(String petName,String petType, char petGender, int petWeight, boolean isSpayed) {

            this.petName = petName; //Copy the petName parameter to the petName data member
            this.petType = petType; //Copy the petType parameter to the petType data member
            this.petGender = petGender; //Copy the petGender parameter to the petGender data member
            this.petWeight = petWeight; //Copy the petWeight parameter to the petWeight data member
            this.isSpayed = isSpayed; //Copy the isSpayed parameter to the isSpayed data member
        }
        /*********************************************
         * Standard getters and setters to allow controlled access to private data members
         **********************************************/
        public String getPetName() {
            return petName;
        }


        public void setPetName(String petName) {
            this.petName = petName;
        }

        public char getPetGender() {
            return petGender;
        }

        public void setPetGender(char petGender) {
            this.petGender = petGender;
        }

        public String getPetType() {
            return petType;
        }

        public void setPetType(String petType) {
            this.petType = petType;
        }

        public int getPetWeight() {
            return petWeight;
        }

        public void setPetWeight(int petWeight) {
            this.petWeight = petWeight;
        }

        public boolean isSpayed() {
            return isSpayed;
        }

        public void setSpayed(boolean spayed) {
            isSpayed = spayed;
        }

        @Override
        public boolean equals(Object o) {
            if (!(o instanceof Pet pet)) return false;
            return getPetGender() == pet.getPetGender() && getPetWeight() == pet.getPetWeight() && isSpayed() == pet.isSpayed() && Objects.equals(getPetName(), pet.getPetName()) && Objects.equals(getPetType(), pet.getPetType());
        }

        @Override
        public int hashCode() {
            return Objects.hash(getPetName(), getPetType(), getPetGender(), getPetWeight(), isSpayed());
        }
    }


