﻿using System.Globalization;

namespace Empreendimento_Turistico
{
    internal class Program
    {

        static double custoApart(double dias, double apart)
        {
            double custo = dias*apart;
            return custo;
        }


        static void escreverNoHistorico(string caminho)
        {
            if (File.Exists(caminho))
            {
                Console.WriteLine("Registo histórico vai ser actualizado ");
            }
            else
            {
                string conteudo1 = "Registo Histórico de Clientes \n\n ---------------------------------------";
                File.WriteAllText(caminho, conteudo1);
            }

        }

        static void anexarHistorico(string caminho, 
            string nomeHospede, 
            int numeroDias, 
            string apartamentoSelecionado, 
            double precoPagarApart, 
            double valorTotalEstadia, 
            double ConsumoInterno, 
            double subTotal, 
            double taxaServico, 
            double totalgeral, 
            string review)  
        {
           
            
            string date = $"{DateTime.Now.ToString("dd/MM/yyyy-HH:m")}";

            
            string content = "\nNome: " + nomeHospede 
                + "\nNr Dias:" + numeroDias 
                + "\n" + "Alojamento: " + apartamentoSelecionado 
                + "\n" + "Preço noite: " + precoPagarApart 
                + "\n" + "Valor Estadia: " + valorTotalEstadia 
                + "\n" + "Consumo Interno: " + ConsumoInterno 
                + "\n" + "SubTotal: " + subTotal 
                + "\n" + "Taxa Serviço: " + taxaServico 
                + "\n" + "TotalGeral: " + totalgeral
                + "\n" + "Avaliação/Comentário: " + review
                + "\n"  + date + "\n";
            string separator2 = "***********************************************************";


            File.AppendAllText(caminho, content + separator2);

        }




        static void Main(string[] args)
        {
            string[,] tipoApart =
           {
            {"Apartamento A","150.00" },
            {"Apartamento B","75.00" },
            {"Apartamento C","100.00" },
            {"Apartamento D","150.00" },
            };

            string[,] artigosBar =
            {
            {"1","Café","1.00" },
            {"2","Chá","1.00" },
            {"3","Água","1.00" },
            {"4","Leite","1.20" },
            {"5","Iogurte","0.7" },
            {"6","Sumo","1.5" }
            };

            double precoPagarApart = 0;
            int numeroDias = 0;


            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("--------------------- Empreendimentos Boa Vida, SA --------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------");

            Console.WriteLine("Qual o nome do Hospede?");
            string nomeHospede = Console.ReadLine();
         
          
            Console.Clear();
            Console.WriteLine("Quantos dias quer ficar hospedado");
            numeroDias = int.Parse(Console.ReadLine());
            
           

            Console.Clear();
            for (int i = 0; i < tipoApart.GetLength(0); i++) 
            {
                Console.WriteLine(String.Format("{0,-5} | {1, 10}", tipoApart[i, 0], tipoApart[i, 1]));
            }

            string apartamentoSelecionado = "";
            int escolhaApartamentoFlag = 1;
            while (escolhaApartamentoFlag == 1)
            {

                Console.WriteLine("Que tipo de Apartamento gostaria de escolher [A] a [D]");
                string escolhaApartamento = Console.ReadLine().ToUpper();


                switch (escolhaApartamento)
                {

                    case "A":
                        Console.Clear();
                        Console.WriteLine("Escolheu o " + tipoApart[0, 0] + " com preço de " + tipoApart[0, 1]);
                        precoPagarApart = double.Parse(tipoApart[0, 1], CultureInfo.InvariantCulture);
                        apartamentoSelecionado = tipoApart[0, 0];
                        escolhaApartamentoFlag = 0;

                        break;
                    case "B":
                        Console.Clear();
                        Console.WriteLine("Escolheu o " + tipoApart[1, 0] + " com preço de " + tipoApart[1, 1]);
                        precoPagarApart = double.Parse(tipoApart[1, 1], CultureInfo.InvariantCulture);
                        apartamentoSelecionado = tipoApart[1, 0];
                        escolhaApartamentoFlag = 0;

                        break;
                    case "C":
                        Console.Clear();
                        Console.WriteLine("Escolheu o " + tipoApart[2, 0] + " com preço de " + tipoApart[2, 1]);
                        precoPagarApart = double.Parse(tipoApart[2, 1], CultureInfo.InvariantCulture);
                        apartamentoSelecionado = tipoApart[2, 0];
                        escolhaApartamentoFlag = 0;

                        break;
                    case "D":
                        Console.Clear();
                        Console.WriteLine("Escolheu o " + tipoApart[3, 0] + " com preço de " + tipoApart[3, 1]);
                        precoPagarApart = double.Parse(tipoApart[3, 1], CultureInfo.InvariantCulture);
                        apartamentoSelecionado = tipoApart[3, 0];
                        escolhaApartamentoFlag = 0;

                        break;
                    case "X":
                        Console.Clear();
                        Console.WriteLine("Obrigado");
                        escolhaApartamentoFlag = 0;
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("escolha inválida");
                        continue;
                }

            }


            Console.Clear();
            double valorTotalEstadia = custoApart(numeroDias, precoPagarApart);
            Console.WriteLine("Obrigado pela confiança. Diga-nos o que achou da estadia.");
            string review = Console.ReadLine();


            // ----------------------------- Minibar ----------------------------------------------------------
            double custoArt1 = 0;
            double custoArt2 = 0;
            double custoArt3 = 0;
            double custoArt4 = 0;
            double custoArt5 = 0;
            double custoArt6 = 0;
            int qtdArt1 = 0;
            int qtdArt2 = 0;
            int qtdArt3 = 0;
            int qtdArt4 = 0;
            int qtdArt5 = 0;
            int qtdArt6 = 0;

            double consumoInterno = 0;

            Console.Clear();
            Console.WriteLine("O cliente consumiu MiniBar S/N");
            string questaoConsumo = Console.ReadLine().ToUpper();
            
            Console.Clear();

            if (questaoConsumo == "S")
                {

                int escolhaArtigo = 0;
                int consumoMiniBarFlag = 1;
                

                while (consumoMiniBarFlag==1) 
                {

                    Console.WriteLine(consumoInterno);

                    Console.Clear();

                    try
                    {
                        for (int i = 0; i < artigosBar.GetLength(0); i++)
                        {
                            Console.WriteLine(String.Format("[{0,2}] {1,10} | {2, 10}", artigosBar[i, 0], artigosBar[i, 1], artigosBar[i,2]));
                        }

                        Console.WriteLine("[1] a [6] Selecionar artigo");
                        Console.WriteLine("[7] para finalizar");
                        escolhaArtigo = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Apenas valores de 1 a 7 são válidos");
                        continue;
                    }

                    switch (escolhaArtigo)
                        {

                            case 1:
                                Console.WriteLine("Que quantidade consumiu de " + artigosBar[0, 1]);
                                qtdArt1 = int.Parse(Console.ReadLine());
                                custoArt1 = double.Parse(artigosBar[0, 2], CultureInfo.InvariantCulture);
                                consumoInterno = qtdArt1 * custoArt1 + consumoInterno;
 

                            break;
                            case 2:
                                Console.WriteLine("Que quantidade consumiu de " + artigosBar[1, 1]);
                                qtdArt2 = int.Parse(Console.ReadLine());
                                custoArt2 = double.Parse(artigosBar[1, 2], CultureInfo.InvariantCulture);
                                consumoInterno = qtdArt2 * custoArt2 + consumoInterno;
                               

                                break;
                            case 3:
                                Console.WriteLine("Que quantidade consumiu de " + artigosBar[2, 1]);
                                qtdArt3 = int.Parse(Console.ReadLine());
                                custoArt3 = double.Parse(artigosBar[2, 2], CultureInfo.InvariantCulture);
                                consumoInterno = qtdArt3 * custoArt3 + consumoInterno;
                           

                                break;
                            case 4:
                                Console.WriteLine("Que quantidade consumiu de " + artigosBar[3, 1]);
                                qtdArt4 = int.Parse(Console.ReadLine());
                                custoArt4 = double.Parse(artigosBar[3, 2], CultureInfo.InvariantCulture);
                                consumoInterno = qtdArt4 * custoArt4 + consumoInterno;

                            break;
                            case 5:
                                Console.WriteLine("Que quantidade consumiu de " + artigosBar[4, 1]);
                                qtdArt5 = int.Parse(Console.ReadLine());
                                custoArt5 = double.Parse(artigosBar[4, 2], CultureInfo.InvariantCulture);
                                consumoInterno = qtdArt5 * custoArt5 + consumoInterno;
                           

                                break;
                            case 6:
                                Console.WriteLine("Que quantidade consumiu de " + artigosBar[5, 1]);
                                qtdArt6 = int.Parse(Console.ReadLine());
                                custoArt6 = double.Parse(artigosBar[5, 2], CultureInfo.InvariantCulture);
                                consumoInterno = qtdArt6 * custoArt6 + consumoInterno;
                            

                                break;
                            case 7:
                                Console.WriteLine("Obrigado");
                                consumoMiniBarFlag = 0;

                                continue;

                        }
                } 
                }
                else if (questaoConsumo == "N")
                {
                    Console.WriteLine("Obrigado");
                }
                else
                {
                    Console.WriteLine("Apenas S e N são opções válidas");
                }

            //double consumoInterno = custoArt1 + custoArt2 + custoArt3 + custoArt4 + custoArt5 + custoArt6;
            
            double subTotal = valorTotalEstadia + consumoInterno;

            double percentagemTaxaServico = 0.1;
            double taxaServico = subTotal * percentagemTaxaServico;

            double totalGeral = subTotal + taxaServico;


            //--------------------------------------------- Relatório Final ----------------------------------------------------------
            Console.WriteLine("---------------------------- Recibo Estadia ---------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Nome: " + nomeHospede);
            Console.WriteLine();
            Console.WriteLine("Número de Noites: "+numeroDias);
            Console.WriteLine();
            Console.WriteLine("Tipo: " + apartamentoSelecionado);
            Console.WriteLine();
            Console.WriteLine("Valor Unitário diária: "+precoPagarApart);
            Console.WriteLine("");
            Console.WriteLine("Total diárias: " + valorTotalEstadia.ToString("F"));
            Console.WriteLine();
            Console.WriteLine("Consumo Interno: " + consumoInterno.ToString("F"));
            Console.WriteLine();
            Console.WriteLine("Subtotal: "+ subTotal.ToString("F"));
            Console.WriteLine("");
            Console.WriteLine("Taxa de Serviço: " + taxaServico.ToString("F"));
            Console.WriteLine();
            Console.WriteLine("Total Geral: "+ totalGeral.ToString("F"));

            string caminho = "Historico_clientes.txt";

            //junto ao executável

            escreverNoHistorico(caminho);

            anexarHistorico(caminho, nomeHospede, numeroDias, apartamentoSelecionado, precoPagarApart, valorTotalEstadia, consumoInterno, subTotal, taxaServico, totalGeral, review);



          




        }
    }
}

