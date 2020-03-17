package quiz009;

public class quiz09 {
	public static void main(String[] args) {
		int year = 2004;

		if(year % 4 != 0 || year % 100 == 0 && year % 400 != 0) {
			System.out.println("うるう年じゃないです");
		}else {
			System.out.println("うるう年です");
	}
	}

}
