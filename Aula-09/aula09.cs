using System;
class Aula08{
    static void Main(){
        int n1, n2, n3, media;
        media=(n1+n2+n3)/3;
        if(media>=6){
          Console.WriteLine("Você passou sua media é {0}", media);  
        };
        else(media>6){
            Console.WriteLine("Você está de recuperação sua media é {0}", media);
        };
    }
}