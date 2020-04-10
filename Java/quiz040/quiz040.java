package quiz040;

public class quiz040 {
	public static void main(String[] args) {
		String a = basePair("アデニン");
		String b = basePair('G');

		System.out.println(a);
		System.out.println(b);

	}

	public static String basePair(String base) {
		String atgc = base;
		String back  = null;
		String atgcBase[] = {"アデニン","チミン","グアニン","シトシン"};

		if (atgc.equals(atgcBase[0])) {
			back = atgcBase[1];
		}else if(atgc.equals(atgcBase[1])){
			back = atgcBase[0];
		}else if(atgc.equals(atgcBase[2])) {
			back = atgcBase[3];
		}else if(atgc.equals(atgcBase[3])) {
			back = atgcBase[2];
		}
		return back;
	}

	public static String basePair(char base) {
		char atgc = base;
		String back = null;
		char bases[] = {'A','T','G','C'};
		String atgcBase[] = {"アデニン","チミン","グアニン","シトシン"};

		if (atgc == bases[0]) {
			back = atgcBase[1];
		}else if(atgc == bases[1]){
			back = atgcBase[0];
		}else if(atgc == bases[2]) {
			back = atgcBase[3];
		}else if (atgc == bases[3]) {
			back = atgcBase[2];
		}
		return back;

	}

}
