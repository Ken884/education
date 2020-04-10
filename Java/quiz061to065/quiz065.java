package quiz061to065;
import java.time.*;

public class quiz065 {
	public static void main(String[] args) {
		LocalDate quakedate = LocalDate.of(2011, 03, 11);
		LocalTime quaketime = LocalTime.of(14, 46, 18);

		LocalDateTime quake = LocalDateTime.of(quakedate, quaketime);

		System.out.println("東北地方太平洋沖地震は" + quake + "に発生した。");
	}

}
