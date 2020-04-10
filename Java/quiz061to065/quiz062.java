package quiz061to065;

import java.time.*;

public class quiz062 {
	public static void main(String[] args) {
		LocalDate date = LocalDate.now();
		DayOfWeek day= date.getDayOfWeek();

		System.out.print(date);
		System.out.println("("+ day + ")");

	}

}
