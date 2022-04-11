package pet;
//represents a cat, and is a subclass of abstract class Pet.
public class Cat extends Pet {
	//static variable
	//default sound for all cats
	private static String SOUND = "Meow!";
	
	//instance variable
	//type of cat only accessible from within this class
	private String type;
	
	//constructor
	//creates a cat with given name, age,weight, type
	public Cat(String name, int age, double weight, String type) {
		//must call constructor in superclass Pet.
		super(age, name, weight);
		//set type of cat
		this.type = type;
	}
	//getters and setters 
	//gets type of cat
	public String getType() {
		return type;
	}
	//sets type of cat
	public void setType(String type) {
		this.type = type;
	}
	
	//inherited abstract methods
	//must override and impliment these (provide bodies)
	
	//cat makes sound
	@Override
	public void makeSound() {
		System.out.println(Cat.SOUND);
	}
	//returns name and type of cat for print/debug
	@Override
	public String toString() {
		return this.name + " is a " + this.type;
	}
}
