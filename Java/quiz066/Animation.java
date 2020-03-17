package quiz066;
import java.util.*;
import java.time.*;
import java.text.*;


public class Animation {
	public static void main(String[] args) {
		List<String> animes = getBroadcastedAnimes(LocalDate.of(1985,5,10));
		for(int i = 0; i < animes.size(); i++){
			System.out.println(animes.get(i));
		}


	}

	public static List<String> getBroadcastedAnimes(LocalDate date) {

		List<String> animes = new ArrayList<String>();

		if(date.isAfter(LocalDate.of(1992,4,13))) {
			animes.add("クレヨンしんちゃん");

		}
		if(date.isAfter(LocalDate.of(1990, 1, 7))){
			animes.add("ちびまる子ちゃん");

		}
		if(date.isAfter(LocalDate.of(1979, 4, 2))){
			animes.add("ドラえもん");
		}
		if(date.isAfter(LocalDate.of(1969, 10, 5))){
			animes.add("サザエさん");
		}

		return animes;

	}

}
//date=>int > date =>printanime