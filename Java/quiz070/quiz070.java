package quiz070;
import java.time.*;
import java.util.*;

public class quiz070 {


	public static void main(String[] args) {
		String name = "Name";
		LocalDate date = LocalDate.of(2012, 5, 21);

		System.out.println(fortuneMaker(name, date));
	}


	public static String fortuneMaker(String name, LocalDate date) {
		//localdate ==> 月と日で星座判定　変数zodiacに代入
		MonthDay md;
		md = MonthDay.from(date);
		String zodiac = null;

		if(md.isAfter(MonthDay.of(3, 20)) && md.isBefore(MonthDay.of(4, 20))){
			zodiac = "牡羊座";
		}else if(md.isAfter(MonthDay.of(4, 19)) && md.isBefore(MonthDay.of(5, 21))) {
			zodiac = "牡牛座";
		}else if(md.isAfter(MonthDay.of(5, 20)) && md.isBefore(MonthDay.of(6, 22))) {
			zodiac = "双子座";
		}else if(md.isAfter(MonthDay.of(6, 21)) && md.isBefore(MonthDay.of(7, 23))) {
			zodiac = "蟹座";
		}else if(md.isAfter(MonthDay.of(7, 22)) && md.isBefore(MonthDay.of(8, 23))) {
			zodiac = "獅子座";
		}else if(md.isAfter(MonthDay.of(8, 22)) && md.isBefore(MonthDay.of(9, 23))) {
			zodiac = "乙女座";
		}else if(md.isAfter(MonthDay.of(9, 22)) && md.isBefore(MonthDay.of(10, 24))) {
			zodiac = "天秤座";
		}else if(md.isAfter(MonthDay.of(10, 23)) && md.isBefore(MonthDay.of(11, 23))) {
			zodiac = "蠍座";
		}else if(md.isAfter(MonthDay.of(11, 24)) && md.isBefore(MonthDay.of(12, 22))) {
			zodiac = "射手座";
		}else if(md.isAfter(MonthDay.of(12, 21)) && md.isBefore(MonthDay.of(1, 20))) {
			zodiac = "山羊座";
		}else if(md.isAfter(MonthDay.of(1, 19)) && md.isBefore(MonthDay.of(2, 19))) {
			zodiac = "水瓶座";
		}else if(md.isAfter(MonthDay.of(2, 18)) && md.isBefore(MonthDay.of(3, 21))) {
			zodiac = "魚座";
		}



		//大吉中吉小吉凶の配列かリストからランダムに一個抽出する　変数luckに代入
		String luck = null;
		int [] kuji = new int [4];


		for(int i =0; i < kuji.length; i++) {
			kuji[i] = new Random().nextInt(4);

			switch(kuji[i]) {
			case 0 :
				luck = "凶";
				break;
			case 1 :
				luck = "小吉";
				break;
			case 2 :
				luck = "中吉";
				break;
			case 3 :
				luck = "大吉";
				break;
			}
		}




		//文を構築してStringで返す
		StringBuilder fortune = new StringBuilder();
		fortune.append("こんにちは");
		fortune.append(name);
		fortune.append("さん、");
		fortune.append(zodiac);
		fortune.append("のあなたの今日の運勢は");
		fortune.append(luck);
		fortune.append(",ラッキーアイテムはたわし！");
		String todays = fortune.toString();



		return todays;

	}
}
