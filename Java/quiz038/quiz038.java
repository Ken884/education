package quiz038;

public class quiz038 {
	public static void main(String[] args) {
		String anima = yearAnimal(2020);
		System.out.println(anima);
	}

	public static String yearAnimal(int year) {

		String[] anima = {"申","酉","戌","亥","子","丑","寅","卯","辰","巳","午","未"};
		int x = year % 12;
		String animal;
		switch(x) {
		case 0:
			animal = anima[0];
			break;
		case 1:
			animal = anima[1];
			break;
		case 2:
			animal = anima[2];
			break;
		case 3:
			animal = anima[3];
			break;
		case 4:
			animal = anima[4];
			break;
		case 5:
			animal = anima[5];
			break;
		case 6:
			animal = anima[6];
			break;
		case 7:
			animal = anima[7];
			break;
		case 8:
			animal = anima[8];
			break;
		case 9:
			animal = anima[9];
			break;
		case 10:
			animal = anima[10];
			break;
		case 11:
			animal = anima[11];
			break;
		default :
			animal = "Error";

		}
		return animal;
	}

}
