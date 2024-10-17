using Calculadora.Services;

 CalculadoraImp calculadora = new CalculadoraImp("16/10/2024");

Console.WriteLine("Bem-vindo à Calculadora!");

    // Solicitar a data ao usuário
        Console.Write("Digite a data (ex: dd/MM/yyyy): ");
         string? data = Console.ReadLine();
         if(string.IsNullOrEmpty(data))
         {
            Console.WriteLine("A data não pode ser vazia. Por favor, insira uma data válida");
            return;
         }


             while (true)
             {
                 Console.WriteLine("\nEscolha uma operação:");
                 Console.WriteLine("1: Somar");
                 Console.WriteLine("2: Subtrair");
                 Console.WriteLine("3: Multiplicar");
                 Console.WriteLine("4: Dividir");
                 Console.WriteLine("5: Ver histórico");
                 Console.WriteLine("0: Sair");

                 string? opcao = Console.ReadLine();
                 if(string.IsNullOrEmpty(opcao))
                 {
                  Console.WriteLine("A data não pode ser vazia. Por favor, insira uma data válida");
                  return;
                 }

                 if (opcao == "0")
                 {
                     break;
                 }

                 int val1, val2;

                 switch (opcao)
                 {
                    case "1":
                     Console.Write("Digite o primeiro valor: ");
                     while (!int.TryParse(Console.ReadLine(), out val1))
                    {
                      Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                    }

                    Console.Write("Digite o segundo valor: ");
                    while (!int.TryParse(Console.ReadLine(), out val2))
                    {
                      Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                    }
        
                    Console.WriteLine("Resultado: " + calculadora.Somar(val1, val2));
                    break;

                    case "2":
                     Console.Write("Digite o primeiro valor: ");
                     while (!int.TryParse(Console.ReadLine(), out val1)) 
                     {
                       Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                     }

                     Console.Write("Digite o segundo valor: ");
                     while (!int.TryParse(Console.ReadLine(), out val2))
                     {
                       Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                     }

                     Console.WriteLine("Resultado: " + calculadora.Subtrair(val1, val2));
                     break;

                    case "3":
                     Console.Write("Digite o primeiro valor: ");
                     while (!int.TryParse(Console.ReadLine(), out val1)) 
                     {
                        Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                     }

                     Console.Write("Digite o segundo valor: ");
                     while (!int.TryParse(Console.ReadLine(), out val2)) 
                     {
                        Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                     }

                     Console.WriteLine("Resultado: " + calculadora.Multiplicar(val1, val2));
                     break;

                    case "4":
                    Console.Write("Digite o primeiro valor: ");
                    while (!int.TryParse(Console.ReadLine(), out val1)) 
                    {
                        Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                    }

                    Console.Write("Digite o segundo valor: ");
                    while (!int.TryParse(Console.ReadLine(), out val2)) 
                    {
                        Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                    }
                    if (val2 != 0)
                    {
                        Console.WriteLine("Resultado: " + calculadora.Dividir(val1, val2));
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;

                    case "5":
                    Console.WriteLine("Histórico:");
                    foreach (var item in calculadora.Historico())
                    {
                        Console.WriteLine(item);
                    }
                    break;

                    default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
                  }

                 Console.WriteLine("Obrigado por usar a calculadora!");}

    



