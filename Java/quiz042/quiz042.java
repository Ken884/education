package quiz042;

public class quiz042 {
	public static void main(String[] args) {
		String result = eraJudge("1989/01/06");
		System.out.println(result);
	}

	public static String eraJudge(String yyyymmdd) {
		String ymd = yyyymmdd;
		String result;
		String[] fulldate = ymd.split("/", 3);

		String trans = fulldate[0] + fulldate[1] + fulldate[2];
		int fd = Integer.parseInt(trans);



		if (fd >= 20190501) {
			result = "令和";
		} else if(fd >= 19890107) {
			result = "平成";
		}else {
			result = "平成以前";
		}
		return result;
	}

}

//Stringを分割split ==> Stringを整数変換parseInt ==> 条件分岐 ==>Stringで返す