using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Informe um número: ");
    int num = int.Parse(Console.ReadLine());
    int qtdEspacos = num-1;
    int qtdZeros = 1;

    for(int linha=1; linha <= num; linha++){
       for(int espacos=1; espacos<=qtdEspacos; espacos++){
            Console.Write(" ");
       }
       for(int zeros=1; zeros<=qtdZeros; zeros++){
         if(linha%2==0)
            Console.Write("*");
         else
            Console.Write("#");          
       }
       Console.WriteLine();
       qtdEspacos--;
       qtdZeros +=2;       
    }


  }
}