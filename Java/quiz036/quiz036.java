package quiz036;

public class quiz036 {
	public static void main(String[] args) {
		String time = setTime(5,46);

		System.out.println(time);

	}

	public static String setTime(int hour, int minute) {
		String str;

		if(minute<10) {
			str = String.valueOf(hour)+":"+"0"+String.valueOf(minute);
		}else if(hour>24 || minute>59){
			str = "Error";

		}else {
			str = String.valueOf(hour) + ":" + String.valueOf(minute);
		}
		return str;
	}

}
