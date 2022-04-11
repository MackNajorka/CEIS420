package pet;
//this represents generic food for a pet
public class Food {
	
	//instance variables
	//only accessible within this class
	private int calories;

	//constructor
	
	public Food(int calories) {
		this.calories = calories;
	}
	//getters and setters
	//gets calories
	public int getCalories() {
		return calories;
	}
	//sets calories
	public void setCalories(int calories) {
		this.calories = calories;
	}
}
