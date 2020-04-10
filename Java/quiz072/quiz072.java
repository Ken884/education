package quiz072;
import java.time.*;
import java.time.format.DateTimeFormatter;

public class quiz072 {
	public static void main(String[] args) {
		DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy/MM/d(E)");

		LocalDate date = LocalDate.now();
		String a = date.format(formatter);

		System.out.println(a);
	}

}
