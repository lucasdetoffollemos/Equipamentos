using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipamentosApp
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] nome = new string[99];
            string[] precoAquisicao = new string[99];
            string[] nSerie = new string[99];
            string[] data = new string[99];
            string[] fabricante = new string[99];
            int[] id = new int[99];

            int cont = 0;
            int idEquipamento = 1;

            while (true)
            {
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("------escolha uma opção------");
                Console.WriteLine("1 - Acessar menu equipamentos;");
                Console.WriteLine("2 - Acessar menu manutenção;");
                Console.WriteLine("s - para sair do menu;");

                Console.WriteLine("------Digite a opção escolhida------");
                string opcaoMenuPrincipal = Console.ReadLine();

                Console.Clear();

                if (opcaoMenuPrincipal.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                switch (opcaoMenuPrincipal)
                {

                    case "1":
                        //Menu equipamentos
                        Console.WriteLine("MENU EQUIPAMENTOS: ");
                        Console.WriteLine("------escolha uma opção------");

                        Console.WriteLine("1 - registrar equipamento;");
                        Console.WriteLine("2 - visualizar todos os equipamentos registrados no inventário;");
                        Console.WriteLine("3 - editar um equipamento;");
                        Console.WriteLine("4 - excluir um equipamento;");


                        Console.WriteLine("Digite a opção escolhida: ");
                        string opcaoMenuEquipamentos = Console.ReadLine();

                        Console.Clear();

                        switch (opcaoMenuEquipamentos)
                        {
                            case "1":
                                Console.WriteLine("REGISTRAR EQUIPAMENTOS: ");
                                Console.WriteLine("Insira o nome do equipamento: ");
                                nome[cont] = Console.ReadLine();
                                Console.WriteLine("Insira o preço de aquisição: ");
                                precoAquisicao[cont] = Console.ReadLine();
                                Console.WriteLine("Insira o número de série: ");
                                nSerie[cont] = Console.ReadLine();
                                //data
                                Console.WriteLine("Insira a data: ");
                                data[cont] = Console.ReadLine();
                                Console.WriteLine("Insira o fabricante: ");
                                fabricante[cont] = Console.ReadLine();
                                id[cont] = idEquipamento;
                                cont++;
                                idEquipamento++;
                                break;

                            case "2":
                              
                                    for (int i = 0; i <= cont; i++)
                                    {
                                        if (nome[i] != null && precoAquisicao[i] != null && nSerie[i] != null && data[i] != null && fabricante[i] != null)
                                        {
                                            Console.WriteLine($"Id do equipamento {id[i]}");
                                            Console.WriteLine("Nome: " + nome[i]);
                                            Console.WriteLine("Preço: " + precoAquisicao[i]);
                                            Console.WriteLine("Número de série: " + nSerie[i]);
                                            Console.WriteLine("Data de fabricação: " + data[i]);
                                            Console.WriteLine("Fabricante: " + fabricante[i]);
                                            Console.WriteLine(" ");
                                        }
                                    }
                                
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            //editar equipamneto
                            case "3":
                                for (int i = 0; i <= cont; i++)
                                {
                                    if (nome[i] != null && precoAquisicao[i] != null && nSerie[i] != null && data[i] != null && fabricante[i] != null)
                                    {
                                        Console.WriteLine($"Id do equipamento {id[i]}");
                                        Console.WriteLine("Nome: " + nome[i]);
                                        Console.WriteLine("Preço: " + precoAquisicao[i]);
                                        Console.WriteLine("Número de série: " + nSerie[i]);
                                        Console.WriteLine("Data de fabricação: " + data[i]);
                                        Console.WriteLine("Fabricante: " + fabricante[i]);
                                        Console.WriteLine(" ");

                                    }
                                }

                                Console.WriteLine("Digite o id do equipamento que deseja editar: ");
                                int idEditar = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                Console.WriteLine("EDITAR EQUIPAMENTOS: ");
                                Console.WriteLine("Insira o nome do equipamento: ");
                                string nomeEditado = Console.ReadLine();
                                Console.WriteLine("Insira o preço de aquisição: ");
                                string precoAquisicaoEditado = Console.ReadLine();
                                Console.WriteLine("Insira o número de série: ");
                                string nSerieEditado = Console.ReadLine();
                                //data
                                Console.WriteLine("Insira a data: ");
                                string dataEditado = Console.ReadLine();
                                Console.WriteLine("Insira o fabricante: ");
                                string fabricanteEditado = Console.ReadLine();

                                for (int i = 0; i < cont; i++)
                                {
                                    if (nome[i] != null && precoAquisicao[i] != null && nSerie[i] != null && data[i] != null && fabricante[i] != null)
                                    {
                                        if (id[i] == idEditar)
                                        {
                                            nome.SetValue(nomeEditado, i);
                                            precoAquisicao.SetValue(precoAquisicaoEditado, i);
                                            nSerie.SetValue(nSerieEditado, i);
                                            data.SetValue(dataEditado, i);
                                            fabricante.SetValue(fabricanteEditado, i);
                                        }
                                    }
                                }

                                Console.ReadLine();
                                Console.Clear();
                              break;

                            //excluir
                            case "4":
                                    for (int i = 0; i <= cont; i++)
                                    {
                                        if (nome[i] != null && precoAquisicao[i] != null && nSerie[i] != null && data[i] != null && fabricante[i] != null)
                                        {
                                            Console.WriteLine($"Id do equipamento {id[i]}");
                                            Console.WriteLine("Nome: " + nome[i]);
                                            Console.WriteLine("Preço: " + precoAquisicao[i]);
                                            Console.WriteLine("Número de série: " + nSerie[i]);
                                            Console.WriteLine("Data de fabricação: " + data[i]);
                                            Console.WriteLine("Fabricante: " + fabricante[i]);
                                            Console.WriteLine(" ");

                                        }
                                    }

                                Console.WriteLine("Digite o id do equipamento que deseja excluir: ");
                                int idExcluir = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                for (int i = 0; i < cont; i++)
                                {
                                    if (nome[i] != null && precoAquisicao[i] != null && nSerie[i] != null && data[i] != null && fabricante[i] != null)
                                    {
                                        if (id[i] == idExcluir)
                                        {
                                            nome = nome.Where(val => val != nome[i]).ToArray();
                                            precoAquisicao = precoAquisicao.Where(val => val != precoAquisicao[i]).ToArray();
                                            nSerie = nSerie.Where(val => val != nSerie[i]).ToArray();
                                            data = data.Where(val => val != data[i]).ToArray();
                                            fabricante = fabricante.Where(val => val != fabricante[i]).ToArray();
                                            id = id.Where(val => val != id[i]).ToArray();
                                            cont--;
                                        }
                                    }
                                }

                                Console.ReadLine();
                                Console.Clear();
                                break;

                            default: break;
                        }

                     break;

                }
            }
        }
    }
}
