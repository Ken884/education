package quiz087;
//次のコードは何がまずいでしょう。
public class answer08 {
	public static void main(String[] args) throws Exception {
        Parent08 p = new Child08();
        p.bar();//Parentクラスではbarメソッドを定義していないのでChildクラスでインスタンス化しても参照できない。
    }
}

class Child08 extends Parent08{
    public void foo(){
        System.out.println("ChildFoo");
    }

    public void bar(){
        System.out.println("ChildBar");
    }
}

class Parent08{
    public void foo(){
        System.out.println("ParentFoo");
    }
}