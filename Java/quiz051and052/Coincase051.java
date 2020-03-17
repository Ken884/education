package quiz051and052;

public class Coincase051 {
	private int ein;
	private int funf;
	private int zien;
	private int fzig;
	private int hund;
	private int fhun;


	public Coincase051(int ein, int funf, int zien, int fzig, int hund, int fhun) {
		this.ein = ein;
		this.funf = funf;
		this.zien = zien;
		this.fzig = fzig;
		this.hund = hund;
		this.fhun = fhun;
	}

	public int addCoins() {
		int coins = ein + funf + zien + fzig + hund + fhun;
		return coins;
	}

	public int addValue() {
		int value = ein + (5 * funf) + (10 * zien) + (50 * fzig) + (100 * hund) + (500 * fhun);
		return value;
	}

	public static void main(String[] args) {
		Coincase051 c = new Coincase051(1,2,4,0,8,0);

		System.out.println(c.addCoins());
		System.out.println(c.addValue());
	}

}
