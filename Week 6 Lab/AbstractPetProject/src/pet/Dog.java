package pet;

//this represents a dog and is a subclass of abstract class pet.
public class Dog extends Pet {
	//static variable
	//default sound for all dogs.
	//only accessible within this class.
	private static String SOUND = "Bark!";
	
	
	//instance variable
	//breed of dog only accessible within this class
	private String breed;
	
	
	//constructor
	//creates a dog with given name age weight and breed
	public Dog(String name, int age, double weight, String breed) {
		//must call constructor in superclass pet
		super(age, name, weight);
		
		//set breed of dog
		this.breed = breed;
	}
	//getters and setters
	//gets breed of dog
	public String getBreed() {
		return breed;
	}

	//sets breed of dog
	public void setBreed(String breed) {
		this.breed = breed;
	}
	
	//inherited abstract methods
	//must override and implement these (provide bodies)
	//makes dog sound
	@Override
	public void makeSound() {
		System.out.println(Dog.SOUND);
	}
	//returns name and breed of dog for print/debug
	@Override
	public String toString() {
		return this.name + " is a " +this.breed;
	}
	

	
}
