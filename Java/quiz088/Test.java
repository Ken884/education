package quiz088;

public class Test {
	public static void main(String[] args) throws Exception {
	    try{
	        ex1();
	        System.out.print("a");
	    } catch(Exception e){
	        System.out.print("b");
	    }
	}

	public static void ex1() throws RuntimeException{
	    if((Math.random() * 10) > 5){
	        throw new RuntimeException();
	    }
	    ex2();
	    System.out.print("c");
	}

	public static void ex2(){
	    System.out.print("d");
	}

}
