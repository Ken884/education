﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        Human konan = new Human("工藤新一", "せやかて工藤", 17);

        // ニックネーム、本名、年齢は自由に取り出せます
        Console.WriteLine(konan.Nickname); // -> せやかて工藤
        Console.WriteLine(konan.Realname); // -> 工藤新一
        Console.WriteLine(konan.Age); // -> 17

        // ニックネームと年齢は書き換えることができます。
        konan.Nickname = "江戸川コナン";
        konan.Age = 7;
        Console.WriteLine(konan.Nickname); // ->江戸川コナン
        Console.WriteLine(konan.Age); // ->7

        // ただし変な年齢を入れても無視されます
        konan.Age = -10000;
        Console.WriteLine(konan.Age); // ->7のまま

        // 本名を変えることはできません
        // konan.Realname = "江戸川コナン"; // そのプロパティはRead-Only専用と怒られる

        // じゃあコナン君、本名は？
        Console.WriteLine(konan.Realname); // ->工藤新一。あっ……やっぱり。
    }
}

class Human
{
    public string Realname { get; }
    public string Nickname { get; set; }
    private int age;
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value >= 0)
            {
                this.age = value;
            }
        }
    }

    public Human(string realname, string nickname, int age)
    {
        this.Realname = realname;
        this.Nickname = nickname;
        if (age >= 0)
        {
            this.Age = age;
        }
    }
}
