package quiz087;

public class Test {
	String hoge;
	public Test() {
		this("hoge");
		System.out.println("hage");
	}

	public Test(String hoge) {
		this.hoge = hoge;
		System.out.println("hoge");
	}

	public static void main(String[] args) {
		Test test = new Test();
		System.out.println();
	}

}
