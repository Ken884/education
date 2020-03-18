package quiz086;
import java.util.*;
import java.util.regex.*;
import java.math.*;

public class quiz086 {
	public static int f(char d) {
		return d - 'A';
	}

	public static void main(String[] args) {
		System.out.println(getRowColumn("AA23"));
		System.out.println(getAone("R16384C12"));
	}


	//引数String二つのメソッド int x, int yを取得しStringBuildしてStringを返す
	public static String getRowColumn(String rowColumn){
		//文字列を分解->アルファベット部分を10進数に直して値を文字列変換、数字部分の値を取り出して文字列変換する
		String pattern = "([A-Z]+)([0-9]+)";
		Pattern p = Pattern.compile(pattern);

		Matcher m = p.matcher(rowColumn);
		m.find();

		String row = m.group(1);

		int x = 0;
		for (int i = 0; i < row.length(); i++) {
			x += (f(row.charAt(row.length()- 1 - i)) + 1) * Math.pow(26, i);
		}


		String r = String.valueOf(x);
		String c = m.group(2);

		String result = "R" + r + "C" +c;

		return result;

	}

	//引数Stringのメソッド文字列分解C以前の数値の値をA1に直して返す、C以下の数の値をそのまま文字列にして返す
	public static String getAone(String aOne){
		String pattern = "R([0-9]+)C([0-9]+)";
		Pattern p = Pattern.compile(pattern);

		Matcher m = p.matcher(aOne);
		m.find();

		String row = m.group(1);
		String column =m.group(2);

		int r = Integer.parseInt(row);



        StringBuilder ret = new StringBuilder();
        for (; r > 0; r = (r - 1) / 26) {
            ret.append((char) ('A' + (r - 1) % 26));
            ;
        }
        return ret.reverse().toString() + column;
	}


}
