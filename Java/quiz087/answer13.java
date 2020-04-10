package quiz087;

public class answer13 {
	public static void main(String[] args) throws Exception {
        new Child13();
    }
}

class Child13 extends Parent13{
    public Child13(){
        System.out.println("Child誕生");
        super("おぎゃあ");
    }
}

class Parent13{
    public Parent13(){
        System.out.println("Parent誕生");
    }

    public Parent13(String s){
        System.out.println(s);
    }

}

//スーパークラスのコンストラクタの呼び出しはコンストラクタ内の先頭行でなければいけないので
//コンパイルエラー。修正した場合、Parentの引数ありのコンストラクタが呼び出されるので
//"おぎゃあ"と"Child誕生"がコンソールに出力される。