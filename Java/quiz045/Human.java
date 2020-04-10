package quiz045;

public class Human {
	private String name;
	private int age;

	public static void main(String[] args) {
		Human h = new Human();

		h.name = "ken";
		h.age = 25;

		System.out.println(h.getName());
		System.out.println(h.getAge());

	}

	public void setName(String name){
		this.name = name;
	}

	public String getName(){
		return name;
	}

	public void setAge(int age){
		this.age = age;
	}

	public int getAge(){
		return age;
	}






}
