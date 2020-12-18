namespace Aula_POO_Interface.Classes
{
    public interface ICarinho
    {
        void Listar();

        void Cadastrar( Produto produto );

        void Alterar( int _codigo, Produto produto );

        void Deletar( Produto produto );
    }
}