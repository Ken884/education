package quiz083;
import java.util.*;
import java.util.stream.*;
import java.util.function.*;


public class Human {
	private String name;
	private String sex;
	private double height;

	public Human(String name, String sex, double height){
		this.name = name;
		this.sex = sex;
		this.height = height;
	}

	public void setSex(String sex) {
		this.sex = sex;
	}

	public String getSex() {
		return sex;
	}

	public void setHeight(double height) {
		this.height = height;
	}

	public double getHeight() {
		return height;
	}

	public static void main(String[] args) {
		List<Human> humans = new ArrayList<>();
		humans.add(new Human("太郎","男",170.2));
		humans.add(new Human("次郎","男",168.9));
		humans.add(new Human("花子","女",150.2));
		humans.add(new Human("良子","女",155.4));
		humans.add(new Human("三郎","男",171.8));
		humans.add(new Human("順子","女",149.7));

		OptionalDouble stream = humans.stream()
									  .filter(human -> human.getSex().equals("女"))
									  .mapToDouble(human -> human.getHeight())
									  .average();
		System.out.println(stream.getAsDouble());



	}

}
