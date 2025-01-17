﻿using Kanban.Dto;
using Kanban.Models;

namespace Kanban.Services.Atividade
{
    public interface IAtividadeInterface
    {
        Task<List<AtividadeModel>> BuscarAtividades();
        Task<List<StatusModel>> BuscarStatus();
        Task<AtividadeModel> CadastrarAtividade(CadastroAtividadeDto cadastroAtividadeDto);

        Task<AtividadeModel> MudarCard(int atividadeId);
        Task<AtividadeModel> MudarCardAnterior(int atividadeId);
        Task<AtividadeModel> Deletar(int atividadeId);
    }
}
