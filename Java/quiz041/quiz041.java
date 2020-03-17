package quiz041;

public class quiz041 {
	public static void main(String[] args) {
		String level = quake(1.51);
		System.out.println(level);
	}

	public static String quake(double measuredSeismicIntensity) {
		double x = measuredSeismicIntensity;
		String level = null;
		if(x < .50) {
			level = "0";
		}else if (x < 1.50) {
			level = "1";
		}else if (x < 2.50) {
			level = "2";
		}else if (x < 3.50) {
			level ="3";
		}else if (x < 4.50) {
			level = "4";
		}else if (x < 5.00) {
			level = "5弱";
		}else if(x < 5.50){
			level = "5強";
		}else if (x < 6.00) {
			level = "6弱";
		}else if (x < 6.50) {
			level = "6強";
		}else if (x >= 6.50) {
			level = "7";
		}
		return level;
	}

}
