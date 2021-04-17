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
            //arrays equipamento
            string[] nome = new string[99];
            string[] precoAquisicao = new string[99];
            string[] nSerie = new string[99];
            string[] data = new string[99];
            string[] fabricante = new string[99];
            int[] idEquipamentos = new int[99];
            
            //arrays chamado
            string[] tituloChamado = new string[99];
            string[] descricaoChamado = new string[99];
            string[] nomeEquiChamado = new string[99];
            string[] dataChamado = new string[99];
            int[] idChamados = new int[99];

            //variaveis equipamentos
            int contEquipamentos = 0;
            int idEquipamento = 1;

            
            //Variaveis chamado
            int idChamado = 1;
            int contChamados = 0;

            while (true)
            {
                MenuPrincipal();

                string opcaoMenuPrincipal = Console.ReadLine();
                Console.Clear();

                if (opcaoMenuPrincipal.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                switch (opcaoMenuPrincipal)
                {
                    case "1":
                        MenuEquipamentos();
                        string opcaoMenuEquipamentos = Console.ReadLine();

                        Console.Clear();

                        switch (opcaoMenuEquipamentos)
                        {
                            case "1":

                                string nomeDigitado = VerificaNomeValido();
                                nome[contEquipamentos] = nomeDigitado;

                                Console.WriteLine("Insira o preço de aquisição: ");
                                precoAquisicao[contEquipamentos] = Console.ReadLine();
                                Console.WriteLine("Insira o número de série: ");
                                nSerie[contEquipamentos] = Console.ReadLine();
                                Console.WriteLine("Insira a data: ");
                                data[contEquipamentos] = Console.ReadLine();
                                Console.WriteLine("Insira o fabricante: ");
                                fabricante[contEquipamentos] = Console.ReadLine();
                                idEquipamentos[contEquipamentos] = idEquipamento; 
                                contEquipamentos++;
                                idEquipamento++;
                                break;

                            case "2":
                                    for (int i = 0; i <= contEquipamentos; i++)
                                    {
                                        if (nome[i] != null && precoAquisicao[i] != null && nSerie[i] != null && data[i] != null && fabricante[i] != null)
                                        {
                                            Console.WriteLine($"Id do equipamento {idEquipamentos[i]}");
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
                                for (int i = 0; i <= contEquipamentos; i++)
                                {
                                    if (nome[i] != null && precoAquisicao[i] != null && nSerie[i] != null && data[i] != null && fabricante[i] != null)
                                    {
                                        Console.WriteLine($"Id do equipamento {idEquipamentos[i]}");
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

                                string nomeEditado;
                                Console.WriteLine("Insira o nome do equipamento: ");
                                nomeEditado = Console.ReadLine();
                                while (nomeEditado.Length < 6)
                                {
                                    Console.WriteLine("Nome inválido, digite novamente, no minimo 6 caracteres.");
                                    Console.WriteLine("Insira o nome do equipamento: ");
                                    nomeEditado = Console.ReadLine();
                                }

                                Console.WriteLine("Insira o preço de aquisição: ");
                                string precoAquisicaoEditado = Console.ReadLine();
                                Console.WriteLine("Insira o número de série: ");
                                string nSerieEditado = Console.ReadLine();
                                //data
                                Console.WriteLine("Insira a data: ");
                                string dataEditado = Console.ReadLine();
                                Console.WriteLine("Insira o fabricante: ");
                                string fabricanteEditado = Console.ReadLine();

                                for (int i = 0; i < contEquipamentos; i++)
                                {
                                    if (nome[i] != null && precoAquisicao[i] != null && nSerie[i] != null && data[i] != null && fabricante[i] != null)
                                    {
                                        if (idEquipamentos[i] == idEditar)
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
                                    for (int i = 0; i <= contEquipamentos; i++)
                                    {
                                        if (nome[i] != null && precoAquisicao[i] != null && nSerie[i] != null && data[i] != null && fabricante[i] != null)
                                        {
                                            Console.WriteLine($"Id do equipamento {idEquipamentos[i]}");
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

                                for (int i = 0; i < contEquipamentos; i++)
                                {
                                    if (nome[i] != null && precoAquisicao[i] != null && nSerie[i] != null && data[i] != null && fabricante[i] != null)
                                    {
                                        if (idEquipamentos[i] == idExcluir)
                                        {
                                            nome = nome.Where(val => val != nome[i]).ToArray();
                                            precoAquisicao = precoAquisicao.Where(val => val != precoAquisicao[i]).ToArray();
                                            nSerie = nSerie.Where(val => val != nSerie[i]).ToArray();
                                            data = data.Where(val => val != data[i]).ToArray();
                                            fabricante = fabricante.Where(val => val != fabricante[i]).ToArray();
                                            idEquipamentos = idEquipamentos.Where(val => val != idEquipamentos[i]).ToArray();
                                            contEquipamentos--;
                                        }
                                    }
                                }

                                Console.ReadLine();
                                Console.Clear();
                                break;

                            default: break;
                        }
                    break;
                    case "2":
                        //Menu chamados
                        Console.WriteLine("MENU CHAMADOS DE REGISTRO: ");
                        Console.WriteLine("------escolha uma opção------");

                        Console.WriteLine("1 - registrar chamado;");
                        Console.WriteLine("2 - visualizar todos os chamados;");
                        Console.WriteLine("3 - editar chamado;");
                        Console.WriteLine("4 - excluir chamado;");


                        Console.WriteLine("Digite a opção escolhida: ");
                        string opcaoMenuChamados = Console.ReadLine();

                        Console.Clear();

                        switch (opcaoMenuChamados)
                        {
                            case "1":
                                for (int i = 0; i <= contEquipamentos; i++)
                                {
                                    if (nome[i] != null && precoAquisicao[i] != null && nSerie[i] != null && data[i] != null && fabricante[i] != null)
                                    {
                                        Console.WriteLine($"Id do equipamento {idEquipamentos[i]}");
                                        Console.WriteLine("Nome: " + nome[i]);
                                        Console.WriteLine("Preço: " + precoAquisicao[i]);
                                        Console.WriteLine("Número de série: " + nSerie[i]);
                                        Console.WriteLine("Data de fabricação: " + data[i]);
                                        Console.WriteLine("Fabricante: " + fabricante[i]);
                                        Console.WriteLine(" ");

                                    }
                                }

                                Console.WriteLine("Digite o id do equipamento que deseja realizar o chamado: ");
                                int idDigitadoChamado = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                //////
                                for (int i = 0; i < contEquipamentos; i++)
                                {
                                    if (nome[i] != null && precoAquisicao[i] != null && nSerie[i] != null && data[i] != null && fabricante[i] != null)
                                    {
                                       if(idDigitadoChamado == idEquipamentos[i])
                                        {
                                            nomeEquiChamado[contChamados] = nome[i];
                                        }

                                    }
                                }
                                Console.WriteLine("Titulo do chamado: ");
                                tituloChamado[contChamados] = Console.ReadLine();
                                Console.WriteLine("Descrição do chamado: ");
                                descricaoChamado[contChamados] = Console.ReadLine();
                                Console.WriteLine("Data de abertura do chamado: ");
                                dataChamado[contChamados] = Console.ReadLine();
                                idChamados[contChamados] = idChamado;
                                contChamados++;
                                idChamado++;
                                Console.Clear();
                              break;

                            case "2":
                                int diasChamado;
                                for (int i = 0; i <= contChamados; i++)
                                {
                                    if (tituloChamado[i] != null && descricaoChamado[i] != null && dataChamado[i] != null)
                                    {
                                        diasChamado = VerificaDataChamado(dataChamado[i]);
                                        Console.WriteLine($"Id do chamado {idChamados[i]}");
                                        Console.WriteLine("Titulo do chamado: " + tituloChamado[i]);
                                        Console.WriteLine("Equipamento: " + nomeEquiChamado[i]);
                                        Console.WriteLine("Data de abertura chamado: " + dataChamado[i]);
                                        Console.WriteLine("Dias que o equioamento está no chamado: " + diasChamado);
                                        Console.WriteLine(" ");

                                    }
                                }

                                Console.ReadLine();
                                Console.Clear();
                            break;

                            case "3":
                                for (int i = 0; i <= contChamados; i++)
                                {
                                    if (tituloChamado[i] != null && descricaoChamado[i] != null && dataChamado[i] != null)
                                    {
                                        
                                        Console.WriteLine($"Id do chamado {idChamados[i]}");
                                        Console.WriteLine("Titulo do chamado: " + tituloChamado[i]);
                                        Console.WriteLine("Nome do equipamento no chamado: " + nomeEquiChamado[i]);
                                        Console.WriteLine("Descrição do chamado: " + descricaoChamado[i]);
                                        Console.WriteLine("Data do chamado: " + dataChamado[i]);
                                       
                                        Console.WriteLine(" ");
                                       
                                    }
                                }

                                Console.WriteLine("Digite o id do chamado que deseja editar: ");
                                int idEditar = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                Console.WriteLine("EDITAR CHAMADO: ");
                                Console.WriteLine("Titulo do chamado: ");
                                string tituloChamadoEditado = Console.ReadLine();
                                Console.WriteLine("Descrição do chamado: ");
                                string descricaoChamadoEditado = Console.ReadLine();
                                Console.WriteLine("Data de abertura do chamado: ");
                                string dataChamadoEditado = Console.ReadLine();
                                Console.Clear();

                                for (int i = 0; i < contEquipamentos; i++)
                                {
                                    if (tituloChamado[i] != null && descricaoChamado[i] != null && dataChamado[i] != null)
                                    {
                                        if (idChamados[i] == idEditar)
                                        {
                                            tituloChamado.SetValue(tituloChamadoEditado, i);
                                            descricaoChamado.SetValue(descricaoChamadoEditado, i);
                                            dataChamado.SetValue(dataChamadoEditado, i);
                                        }
                                    }
                                }
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "4":
                                for (int i = 0; i <= contChamados; i++)
                                {
                                    if (tituloChamado[i] != null && descricaoChamado[i] != null && dataChamado[i] != null)
                                    {
                                        Console.WriteLine($"Id do chamado {idChamados[i]}");
                                        Console.WriteLine("Titulo do chamado: " + tituloChamado[i]);
                                        Console.WriteLine("Nome do equipamento no chamado: " + nomeEquiChamado[i]);
                                        Console.WriteLine("Descrição do chamado: " + descricaoChamado[i]);
                                        Console.WriteLine("Data do chamado: " + descricaoChamado[i]);
                                        Console.WriteLine(" ");
                                    }
                                }

                                Console.WriteLine("Digite o id o chamado que deseja excluir: ");
                                int idExcluir = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                for (int i = 0; i < contChamados; i++)
                                {
                                    if (tituloChamado[i] != null && descricaoChamado[i] != null && dataChamado[i] != null)
                                    {
                                        if(idChamados[i] == idExcluir)
                                        {

                                            tituloChamado = tituloChamado.Where(val => val != tituloChamado[i]).ToArray();
                                            descricaoChamado = descricaoChamado.Where(val => val != descricaoChamado[i]).ToArray();
                                            dataChamado = dataChamado.Where(val => val != dataChamado[i]).ToArray();
                                            idChamados = idChamados.Where(val => val != idChamados[i]).ToArray();
                                            contChamados--;

                                        }
                                    }
                                }

                                Console.ReadLine();
                                Console.Clear();
                                break;

                        }
                        break;
                    default: break;
                    }
            }
        }

        public static int VerificaDataChamado(string dataAbertura)
        {
          


            DateTime data = Convert.ToDateTime(dataAbertura);
            DateTime dataAtual = DateTime.Now;

            TimeSpan diferenca = dataAtual.Subtract(data);

            int totalDias = Convert.ToInt32(diferenca.TotalDays);

            return totalDias - 1;

        }

        public static void MenuPrincipal()
        {
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("------escolha uma opção------");
            Console.WriteLine("1 - Acessar menu equipamentos;");
            Console.WriteLine("2 - Acessar menu manutenção;");
            Console.WriteLine("s - para sair do menu;");

            Console.WriteLine("------Digite a opção escolhida------");
        }

        public static void MenuEquipamentos()
        {
            Console.WriteLine("MENU EQUIPAMENTOS: ");
            Console.WriteLine("------escolha uma opção------");

            Console.WriteLine("1 - registrar equipamento;");
            Console.WriteLine("2 - visualizar todos os equipamentos registrados no inventário;");
            Console.WriteLine("3 - editar um equipamento;");
            Console.WriteLine("4 - excluir um equipamento;");


            Console.WriteLine("Digite a opção escolhida: ");
        }

        public static string VerificaNomeValido()
        {
            string nomeDigitado;

            Console.WriteLine("Insira o nome do equipamento: ");
            nomeDigitado = Console.ReadLine();

            while (nomeDigitado.Length < 6)
            {
                Console.WriteLine("Nome inválido, digite novamente, no minimo 6 caracteres.");
                Console.WriteLine("Insira o nome do equipamento: ");
                nomeDigitado = Console.ReadLine();
            }

            return nomeDigitado;
        }
    }

    
}
