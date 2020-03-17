package quiz026;

public class another {
	public static void main(String[] args) {

		int[] list1 = {1,2,3,4,5,6,7,8,9};
		int[] list2 = {1,2,3,4,5,6,7,8,9};
		for(int value1: list1) {
			for (int value2 : list2) {

				System.out.printf(" %2d", value1 * value2);

			}
			System.out.println();
		}


	}
}
