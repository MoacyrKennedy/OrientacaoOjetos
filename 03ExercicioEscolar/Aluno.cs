using System;

class Aluno
{
    //Atributos
    public string nome;
    public double nota1, nota2;

    //Média
    public double media()
    {
        return (nota1 + nota2) / 2;
    }

    //Situação
    public string Situação(double media)
    {
        return media >= 7 ? "aprovado" : " reprovado ";
    }
    
    //Mensagem
    public void Mensagem()
    {
        // Obter a média
        double obterMedia = media();

        //Obter a situação
        string obterSituacao = Situação(obterMedia);

        //Mensagem
        Console.WriteLine(nome+" está " +obterSituacao+" Com média "+obterMedia);
    }
}