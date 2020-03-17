package quiz055;
import java.util.ArrayList;

public class Human {
	private String name;
	private int age;

	public Human(String name, int age){
		this.name = name;
		this.age = age;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getName() {
		return name;
	}

	public void printName() {
		System.out.println(name);
	}

	public static void main(String[] args) {
		Human one = new Human("James", 45);
		Human two = new Human("Cathy", 32);
		Human thr = new Human("George", 21);

		ArrayList<Human> humans = new ArrayList<Human>();

		humans.add(one);
		humans.add(two);
		humans.add(thr);

		for(int i = 0; i < humans.size(); i++) {
			System.out.print(i+1 + "番目に格納された人の名前は");
			humans.get(i).printName();
		}
	}

}
