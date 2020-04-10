package quiz087;

public class answer04 {
	public static void main(String[] args) throws Exception {
        Child c = new Child();
        Parent p = (Parent)c;


        p.foo();

        Parent p2 = new Child();
        p2.foo();
    }
}

class Child extends Parent{
    public void foo(){
        System.out.println("ChildFoo");
    }
}

class Parent{
    public void foo(){
        System.out.println("ParentFoo");

}
}
//子クラスのメソッドが優先して呼ばれる。
//Javaでは極力外側にあるインスタンス部分のメソッドが優先して呼び出される。