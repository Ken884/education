package quiz076;
import java.util.*;

class Sample{
	private static int counter = 0;

	public Sample(){}

	public Sample(int i){
		if(i >= 50) {
			counter += 1;
		}
	}

	public int getCounter(){
		return counter;
	}
}

public class Main {
	public static void main(String[] args) throws Exception {
		Random rd = new Random();
		List<Sample> list = new ArrayList<>();
		for(int i = 0; i < 100; i++){
			list.add(new Sample(rd.nextInt(100)));
		}
		System.out.println((new Sample()).getCounter());


		for(int i = 0; i < list.size(); i++){
			System.out.println(list.get(i).getCounter());
		}

    }

}
