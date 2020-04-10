package quiz087;

public class answer10 {
	public static void main(String[] args) throws Exception {
        new Child10();
    }
}

class Child10 extends Parent10{
    public Child10(){
        System.out.println("Child誕生");
    }
}

class Parent10{
    public Parent10(){
        System.out.println("Parent誕生");
    }

}
/*子クラスのコンストラクタを呼び出す際は、必ず親クラスのコンストラクタを呼び出してから呼び出すので
  実行結果には"Parent誕生"の後に"Child誕生"がコンソールに出力される。*/