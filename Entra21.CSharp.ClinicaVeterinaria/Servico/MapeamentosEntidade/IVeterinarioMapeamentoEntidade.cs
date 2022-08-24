using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModels.Veterinarios;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico.MapeamentosEntidade
{
    public interface IVeterinarioMapeamentoEntidade
    {
        Veterinario ConstruirCom(VeterinarioCadastrarViewModel viewModel);
    }
}