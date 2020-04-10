package quiz033;

public class quiz033 {
	public static void main(String[] args) {
		int a = getCustomerCode(15,7528);
		System.out.println(a);
	}

	public static int getCustomerCode(int customerKbnCode, int customerKbnInnerCode){
	    return customerKbnCode + customerKbnInnerCode;//戻り値intなので純粋な足し算になる
	}

}
