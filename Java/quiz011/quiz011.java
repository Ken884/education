package quiz011;
import java.util.Random;

public class quiz011 {
	public static void main(String[] args) {

		Random rnd = new Random();

		int ltr = rnd.nextInt(4)+1;

		switch(ltr) {

		case 1:
			System.out.println("大吉");
			break;
		case 2:
			System.out.println("中吉");
			break;
		case 3:
			System.out.println("小吉");
			break;
		case 4:
			System.out.println("凶");
			break;
		}
	}

}
