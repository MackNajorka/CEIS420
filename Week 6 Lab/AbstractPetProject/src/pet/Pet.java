package pet;

import java.util.ArrayList;

//abstract class pet represents a generic pet
public abstract class Pet {

	//instance variables
	//default (package-private) access
	int age; 
	//all pets will have an age 
	String name; 
	//all pets will have a name
	double weight; 
	//all pets will have a weight
	
	//constructor
	//Called by subclasses of pet to create instances of different types of pet
	public Pet(int age, String name, double weight) {
		this.age = age;
		this.name = name;
		this.weight = weight;
	}
	
	//getters and setters
	//gets weight
	public double getWeight() {
		return weight;
	}
	//sets weight
	public void setWeight(double weight) {
		this.weight = weight;
	}
	
	
	//non-abstract method
	//tells pet to eat given food/food to eat
	public void eat(Food food) {
		this.weight	+= (food.getCalories()/100);
	}
	
	
	//abstract methods
	//forces all pets to make their own sound
	//all subclasses of pet must implement this method
	public abstract void makeSound();
	//forces all pets to override toString for printing and debug
	@Override
	public abstract String toString();
	
	
	
	
	
	
	
	public static void main(String[] args) {
		//creates list of pets 
		ArrayList<Pet> pets = new ArrayList<Pet>();
		
		Dog dog = new Dog("Buster", 14, 100, "German Shepherd");
		
		Cat cat = new Cat ("Cleo", 3, 40, "House Cat");
		
		//add pets to list
		pets.add(dog);
		pets.add(cat);
		
		for (Pet p: pets) {
			//pet makes sound
			//abstract method in pet class
			//every subclass of pet must have this method implemented.
			p.makeSound();
		}
		for (Pet p: pets) {
			//prints pet
			//abstract method in pet class
			//every subclass of pet must have this implemented
			System.out.println(p);
		}
		
		//call specific method in dog class
		String breed = dog.getBreed();
		System.out.println("dog breed: " + breed);
		
		//call specific method in cat class
		String type = cat.getType();
		System.out.println("cat type: " + type);
		
		//calls non-abstract method in pet class
		//gets dogs current weight
		System.out.println("Dog's weight: "+ dog.getWeight());
		
		//create a pet food
		Food food = new Food (1000);
		
		//calls non-abstract method defined in pet class
		dog.eat(food);
		
		//get and print dogs new weight
		System.out.println("Dog's weight: "+ dog.getWeight());
	}
	
}
