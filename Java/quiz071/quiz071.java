package quiz071;
import java.time.*;
import java.time.format.DateTimeFormatter;

public class quiz071 {
	public static void main(String[] args) {
		DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy/M/d");

		String date = "2020/12/20";

		LocalDate tgt = LocalDate.parse(date, formatter);

		System.out.println(tgt);


	}

}
