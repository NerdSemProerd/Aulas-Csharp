using System;
class Aula06{
    static void Main(){
        double valorcompra=5.50;
        double valorvenda;
        double lucro=0;
        string produto="Pastel";

        valorvenda=valorcompra+(valorcompra*lucro);

        Console.WriteLine("Produto.......:{0,15}", produto);
        Console.WriteLine("Val.Compra....:{0,15:c}", valorcompra);
        Console.WriteLine("Lucro.........:{0,15:p}", lucro);
        Console.WriteLine("Val.Venda.....:{0,15:p}", valorvenda);
    }
}