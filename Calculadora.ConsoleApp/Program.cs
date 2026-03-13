

//requisito 1 : Nossa calculadora deve permitir a soma de dois números
//requisito 2 : Nossa calculadora deve permitir a subtração de dois números
//requisito 3 : Nossa calculadora deve permitir a multiplicação de dois números
//requisito 4 : Nossa calculadora deve permitir a divisão de dois números

bool deveContinuar = true; // atribuição

while (deveContinuar == true) // condição
{
   //Console.Clear();

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Calculadora 2026");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("1 - soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("S-sair");

        Console.Write("Selecione uma opção válida: ");
        string operacaoSelecionada = Console.ReadLine();

        if (operacaoSelecionada == "S")
        {
             deveContinuar = false;

           continue;
        }

        Console.Write("Digite o primeiro número: ");
        string strPrimeiroNumero = Console.ReadLine();

        Console.Write("Digite o segundo número: ");
        string strSegundoNumero= Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("o primeiro número digitado foi:"+ strPrimeiroNumero);
        Console.WriteLine("o segundo número digitado foi:"+ strSegundoNumero);

        Console.WriteLine();

        // int = número inteiro
        double primeiroNumero = Convert.ToDouble(strPrimeiroNumero);
        double segundoNumero  = Convert.ToDouble(strSegundoNumero);

        double resultado;

        if(operacaoSelecionada == "1")
        {
        resultado = primeiroNumero + segundoNumero; 
        }

        else if (operacaoSelecionada == "2")
        {
        resultado = primeiroNumero - segundoNumero; 
        }

        else if (operacaoSelecionada == "3")
        {
            resultado = primeiroNumero * segundoNumero;
        }

        else
        {
        if (segundoNumero == 0)
            {
                Console.WriteLine("não é possivel fazer uma divisão por zero. Tente novamente");
                
                return;
            }
            
                resultado = primeiroNumero / segundoNumero; 
            
        
        }




        Console.WriteLine("A operação dos dois números resulta em: " + resultado);

        Console.ReadLine(); 
}



