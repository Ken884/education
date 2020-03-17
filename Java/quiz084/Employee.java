package quiz084;

public class Employee {
	private String name;

	public Employee(String name) {
		this.name = name;
	}

	@Override
	public String toString() {
		return name;
	}
	public static void main(String[] args) {
		Employee e = new Employee("匿名太郎");

		System.out.println(e.toString());


	}

}
