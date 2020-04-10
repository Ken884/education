package quiz085;
import java.math.*;

public class quiz085 {
	public static void main(String[] args) {
		BigDecimal x = BigDecimal.valueOf(4.1);
		BigDecimal y = BigDecimal.valueOf(93.03);

		System.out.println(x.multiply(y));

		BigDecimal a = BigDecimal.valueOf(1.0);
		BigDecimal b = BigDecimal.valueOf(3.0);
		BigDecimal result = a.divide(b, 3, RoundingMode.HALF_UP);


		System.out.println(result);
	}

}
