using System.Collections.Generic;
using System;

namespace SERIES
{
    public class Catalogo
    {
        List<Filme> filmes = new List<Filme>();

        public Catalogo()
        {
            Filme f1 = new Filme(ProximoId(), Genero.Drama, "O impossível", "Baseado em fatos reais, este drama retrata as experiências terríveis de uma família durante o caos gerado pelo tsunami que atingiu o sudoeste da Ásia em 2004.", 2012);
            filmes.Add(f1);

            Filme f2 = new Filme(ProximoId(), Genero.Comedia, "Norbit", "Depois de ser forçado a se casar com uma mulher controladora, o bem-educado Norbit conhece a garota de seus sonhos nesta comédia romântica.", 2007);
            filmes.Add(f2);

            Filme f3 = new Filme(ProximoId(), Genero.Terror, "Livrai-nos do Mal", "Durante uma investigação, um policial de Nova York conhece um padre que o convence de que o caso está ligado a uma possessão demoníaca.", 2014);
            filmes.Add(f3);

            Filme f4 = new Filme(ProximoId(), Genero.Drama, "À prova de fogo", "Bombeiro dedicado enfrenta um possível divórcio. Quando toda esperança parece acabar, seu pai religioso intervém.", 2008);
            filmes.Add(f4);

            Filme f5 = new Filme(ProximoId(), Genero.Aventura, "Minions", "Eles são os lacaios amarelos e inconfundíveis de Meu Malvado Favorito. Neste filme, veja a história de sua devoção por vilões desde o início.", 2015);
            filmes.Add(f5);

            Filme f6 = new Filme(ProximoId(), Genero.Ficcao_Cientifica, "O Preço do Amanhã", "Em um futuro próximo, quando ninguém envelhece e o tempo é a nova moeda, um homem se torna suspeito ao herdar várias décadas de uma vítima de assassinato muito rica.", 2011);
            filmes.Add(f6);
        }
        public void InserirFilme()
        {
            Console.WriteLine("Inserir novo Filme");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme novaSerie = new Filme(id: ProximoId(),
                                          genero: (Genero)entradaGenero,
                                          titulo: entradaTitulo,
                                          ano: entradaAno,
                                          descricao: entradaDescricao);
            filmes.Add(novaSerie);
        }
        public int ProximoId()
        {
            return filmes.Count;
        }
        public void AtualizarFilme()
        {
            Console.Write("Digite o id do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            Console.Write("Digite o Ano do Filme que deseja atualizar: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do Filme que deseja atualizar: ");
            string entradaDescricao = Console.ReadLine();

            filmes[indiceFilme].Ano = entradaAno;
            filmes[indiceFilme].Descricao = entradaDescricao;

        }
        
        public void ExcluirFilmes()
        {
            if (filmes.Count <= 0)
            {
                Console.WriteLine("Não existe filmes na lista para ser removido");
                return;
            }
            Console.Write("Digite o id do filme: ");
            int indiceFilmes = int.Parse(Console.ReadLine());


            if (indiceFilmes > filmes.Count - 1 || indiceFilmes < 0)
            {
                Console.WriteLine("O id não existe!");
                return;
            }
            filmes[indiceFilmes].Exclui();

        }

        public void VisualizarFilmes()
        {
            Console.Write("Digite o id do filme: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        public Filme RetornaPorId(int id)
        {
            return filmes[id];

        }

        public void ListarFilmes()
        {
            Console.WriteLine("Listar filmes");

            foreach (var filme in filmes)
            {
                var excluido = filme.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "Excluido*" : ""));
            }
        }
    }
}

