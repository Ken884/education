package quiz078;

public class Human {
	public static void main(String[] args) {

	}
	  public void run(){
	        System.out.println("走る");
	    }

}

class SuperHuman extends Human{

	public static void main(String[] args) {
		SuperHuman one = new SuperHuman();
		one.run();
	}

	public void sleep() {
		System.out.println("寝る");
	}

	public void fly() {
		System.out.println("飛ぶ");
	}

	public void run() {
		System.out.println("めっちゃ速く走る");
	}

}
