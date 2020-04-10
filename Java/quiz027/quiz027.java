package quiz027;

public class quiz027 {
	public static void main(String[] args) {
		weather("晴れ");
		weather("曇り");
		weather("雨");
		weather("雪");
		weather("霧");
	}
	public static void weather(String weather) {
		if(weather == "晴れ") {
			System.out.println("いい天気ですね");
		}else if(weather == "曇り") {
			System.out.println("どんよりしていますね");
		}else if(weather == "雨"){
			System.out.println("明日は晴れるといいですね");
		}else if(weather == "雪") {
			System.out.println("雪合戦しようぜ");
		}else {
			System.out.println("不正な入力です");
		}
	}

}
