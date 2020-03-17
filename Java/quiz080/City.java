package quiz080;
import java.util.*;

public class City implements Comparable<City>{
	private String name;
	private int population;

	@Override
	public int compareTo(City city) {

		return Integer.compare(this.population, city.population)*-1;

	}

	public City(String name, int population) {
		this.name = name;
		this.population = population;
	}

	public static void main(String[] args) {


		 List<City> cities = new ArrayList<>();
		 cities.add(new City("高槻市",351800));
		 cities.add(new City("茨木市",280000));
		 cities.add(new City("東大阪市",502800));
		 cities.add(new City("吹田市",374500));
		 cities.add(new City("豊中市",395500));
		 cities.add(new City("八尾市",268800));

		 Collections.sort(cities);


		 for(City city : cities) {
			 System.out.println(city.name);
		 }

	}



}
