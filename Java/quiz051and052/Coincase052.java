package quiz051and052;

public class Coincase052 {
	private int ein;
	private int funf;
	private int zien;
	private int fzig;
	private int hund;
	private int fhun;
	int[] lots = {1, 5, 10, 100};

	public Coincase052(int ein, int funf, int zien, int fzig, int hund, int fhun) {
		this.ein = ein;
		this.funf = funf;
		this.zien = zien;
		this.fzig = fzig;
		this.hund = hund;
		this.fhun = fhun;
	}


	public int getCoins() {
		int coins = ein + funf + zien + fzig + hund + fhun;
		return coins;
	}

	public int getValue() {
		int value = ein + 5 * funf + 10 * zien + 50 * fzig + 100 * hund + 500 * fhun;
		return value;
	}

	public void insertCoins(int[] lots) {
		for(int coin : lots) {
			switch(coin) {
			case 1 :
				this.ein += 1;
				break;
			case 5 :
				this.funf += 1;
				break;
			case 10 :
				this.zien += 1;
				break;
			case 50 :
				this.fzig += 1;
				break;
			case 100 :
				this.hund += 1;
				break;
			case 500 :
				this.fhun += 1;
				break;
			}
		}
	}

	public static void main(String[] args) {
		Coincase052 c = new Coincase052(1,2,4,0,8,0);

		System.out.println(c.getCoins());
		System.out.println(c.getValue());

		c.insertCoins(new int[] {10,5,100,1});

		System.out.println(c.getCoins());
		System.out.println(c.getValue());



	}

}
