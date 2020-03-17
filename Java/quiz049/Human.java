package quiz049;

public class Human {
	private String name;
	private int age;

	public Human(String name, int age) {
		this.name = name;
		this.age = age;
	}


	public static void main(String[] args) {

		Human h = new Human("ken", 25);


		System.out.println(h.name);
		System.out.println(h.age);
	}

}
