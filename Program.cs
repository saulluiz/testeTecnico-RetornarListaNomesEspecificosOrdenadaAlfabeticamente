/* Implementação em JS, PHP, Java ou C#. Receba uma lista contendo 10 nomes de pessoas, sexo (M ou F) e suas idades. Escreva um método que receba leia este arquivo e retorne:

- Todos os nomes que contêm “Maria” mas não contêm “Silva”, ordenados alfabeticamente.  */
class Program(){

static List<string> resposta(List<string> listaNomes){
    List<string> auxList=new List<string> ();
    foreach(var nome in listaNomes){
        if(nome.Contains("Maria") & !nome.Contains("Silva")){
            auxList.Add(nome);
        }
        
    }
     auxList.Sort();
    return auxList;
}


static void Main(string[] args)
{
    List<string> nomes=new List<string> ();
    nomes.Add("Saulo luiz");
    nomes.Add("Lauton luiz");
    nomes.Add("Maria Luiza");
    nomes.Add("Maria Luiza Silva");
    nomes.Add("Luiza Maria");
    List<string> novaLista=resposta(nomes);
    foreach(var x in novaLista){
        Console.WriteLine(x);
    }
}
}