package quiz067;

public class quiz067 {

	public static void main(String[] args) {
		double result;
		result= divide(8,0);
		System.out.println(result);
	}

	public static double divide(int a, int b){
		try {
        double ans = a / b;
        return ans;
		}catch(ArithmeticException e) {
			return 0;
		}
    }

}
