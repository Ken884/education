package quiz073;
import java.util.*;
import java.time.*;
import java.time.format.DateTimeFormatter;

public class quiz073 {

	public static void main(String[] args) {
	DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy年M月d日");


	Map<String, LocalDate> vocaloidsBirthdayMap = new HashMap<>();

	vocaloidsBirthdayMap.put("初音ミク", LocalDate.of(2007, 8, 31));
	vocaloidsBirthdayMap.put("鏡音リン", LocalDate.of(2007, 12, 27));
	vocaloidsBirthdayMap.put("鏡音レン", LocalDate.of(2007, 12, 27));
	vocaloidsBirthdayMap.put("巡音ルカ", LocalDate.of(2009, 1, 30));

	for(String key : vocaloidsBirthdayMap.keySet()) {
		System.out.println(key);
	}

	for(LocalDate value : vocaloidsBirthdayMap.values()) {
		System.out.println(value);
	}

	for(Map.Entry<String, LocalDate> entry : vocaloidsBirthdayMap.entrySet()) {

		System.out.println(entry.getKey() + "の誕生日は" + entry.getValue().format(formatter)+ "です");
	}

	}
}
