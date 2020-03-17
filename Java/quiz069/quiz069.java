package quiz069;

public class quiz069 {

	public static void main(String[] args) {
		double result;
		result= divide(8,0);
		System.out.println(result);
	}

	public static double divide(int a, int b){
		if(b == 0) {
			throw new ArithmeticException();
		}


		double ans = a / b;
        return ans;


	}


}


