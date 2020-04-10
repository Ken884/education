package quiz034;

public class quiz035 {
	public static void main(String[] args) {
		int code = getCustomerCode(15,7528);
		System.out.println(code);
	}

	public static int getCustomerCode(int customerKbnCode, int customerKbnInnerCode){
	    String str= String.valueOf(customerKbnCode) + String.valueOf(customerKbnInnerCode);
	    int num = Integer.parseInt(str);
	    return num;
	}

}
