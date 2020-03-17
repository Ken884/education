package quiz068;

public class quiz068 {
	public static void main(String[] args) {
		try {
			double result;
			result= divide(8,0);
			System.out.println(result);
		}catch (ArithmeticException e){
			double result = 0;
			System.out.println(result);

		}
	}

	public static double divide(int a, int b)throws ArithmeticException{
        double ans = a / b;
        return ans;
    }

}
