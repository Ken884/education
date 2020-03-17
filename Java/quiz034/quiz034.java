package quiz034;

public class quiz034 {//quiz035に移行
	public static void main(String[] args) {
		String code = getCustomerCode(15,7528);
		System.out.println(code);
	}

	public static String getCustomerCode(int customerKbnCode, int customerKbnInnerCode){
	    return String.valueOf(customerKbnCode) + String.valueOf(customerKbnInnerCode);
	}//034のままでは戻り値はintに指定しているのにString型のデータを返しているからエラー

}
