using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebTest.Interface;
using WebTest.Model;

namespace WebTest.Service
{
    public class PontoService : IPontoService
    {
        private readonly IPontoRepository _pontoRepository;

        public PontoService(IPontoRepository pontoRepository)
        {
            _pontoRepository = pontoRepository;
        }

        public async Task<bool> AdicionarPonto(string userId)
        {
            try
            {
                // Obtém o último ponto do usuário no dia atual
                Ponto ultimoPonto = await _pontoRepository.GetUltimoPontoByUserAndDay(userId, DateTime.Today);

                // Verifica se já existe um registro de entrada para o dia atual
                if (ultimoPonto == null)
                {
                    // Se não existe registro de entrada, cria um novo ponto com o horário de entrada
                    Ponto novoPonto = new Ponto
                    {
                        Dia = DateTime.Today,
                        HorarioEntrada = DateTime.Now.TimeOfDay,
                        AuthDbContextUserId = userId
                    };
                    await _pontoRepository.CreatePonto(novoPonto);
                }
                else if (ultimoPonto.HorarioSaida == null)
                {
                    // Se já existe um registro de entrada sem o horário de saída preenchido, atualiza o horário de saída
                    ultimoPonto.HorarioSaida = DateTime.Now.TimeOfDay;
                    await _pontoRepository.UpdatePonto(ultimoPonto);
                }
                else
                {
                    throw new Exception("Erro ao bater o ponto. Já bateu ponto de entrada e de saída hoje.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        // Implemente os outros métodos conforme necessário
    }
}
