package quiz061to065;
import java.time.*;

public class quiz063 {
	public static void main(String[] args) {
		LocalDate date = LocalDate.now();
		LocalDate ago = date.minusMonths(3);

		System.out.println(ago);
	}

}
