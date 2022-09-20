var numeroDaEntrada1 = CapturaValorDoUsuarioOuEncerraOPrograma("Insira o primeiro valor: ");

var numeroDaEntrada2 = CapturaValorDoUsuarioOuEncerraOPrograma("Insira o segundo valor: ");

var numeroDaEntrada3 = CapturaValorDoUsuarioOuEncerraOPrograma("Insira o terceiro valor: ");

var soma = numeroDaEntrada1 + numeroDaEntrada2 + numeroDaEntrada3;

Console.WriteLine($"A soma dos números foi: {soma}");


int CapturaValorDoUsuarioOuEncerraOPrograma(string messagemDeApresentacaoParaReceberOValorDoUsuario)
{
    Console.Write(messagemDeApresentacaoParaReceberOValorDoUsuario);
    var entradaDoUsuario = Console.ReadLine();
    var entradaDoUsuario1FoiBemSucedida = int.TryParse(entradaDoUsuario, out var numeroDaEntrada);
    if (!entradaDoUsuario1FoiBemSucedida)
    {
        Console.WriteLine("Nao consegui coverter o valor recebido, progrando encerrando.");
        Environment.Exit(0);
    }

    return numeroDaEntrada;
}