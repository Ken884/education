package quiz074and075;

public class Main {
	public static void main(String[] args) throws Exception {
        Human human = new Human();
        human.run(); //staticでないメソッドはクラス単位で使用できない
    }

}

class Human{
	public void run(){
		System.out.println("走る");
	}
}
/*static 静的メンバ
		new　でインスタンスを生成することなくメソッドを利用できる。
		private でアクセス制限されたクラスにおいて、インスタンスを生成する。
quiz045の場合はインスタンスの独立性のためにrunメソッドは静的メソッドにしないほうが好ましい。*/