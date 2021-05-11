using ApCatalogoDeJogos.InputModel;
using ApCatalogoDeJogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApCatalogoDeJogos.Service
{
    public interface IJogoService
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualzar(Guid id, JogoInputModel jogo);
        Task Atualzar(Guid id, double preco);
        Task Remover(Guid id);
    }
}
