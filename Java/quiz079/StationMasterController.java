package quiz079;
import quiz079.*;

public class StationMasterController extends BaseController{
	@Override
	public void setTable() {
		this.bindedTable = dbm.getTable("station_tbl");
	}

}
