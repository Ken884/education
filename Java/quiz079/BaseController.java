package quiz079;



public abstract class BaseController {
	protected DatabaseManager dbm;
	protected Table bindedTable;
	
	

	public void initialize(){
	    dbm = DatabaseManagerFactory.createDbm();
	    setTable();
	}

	abstract public void setTable();

}
