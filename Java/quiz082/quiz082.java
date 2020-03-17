package quiz082;
import java.util.*;

public class quiz082 {
	public static void main(String[] args) {
		for(int i = 0; i<10; i++) {
			System.out.println(getOptionalNumber().orElse(-1));
		}

	}

	public static Optional<Integer> getOptionalNumber(){
	    Random random = new Random();
	    Integer randomValue = random.nextInt(100);
	    return randomValue >= 50 ? Optional.empty() : Optional.of(randomValue);
	}

}
