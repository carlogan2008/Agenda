namespace Agenda.DAL.Test
{
    public class ContatosTest
    {
        Contatos _contatos;

        [SetUp]
        public void Setup()
        {
            _contatos = new Contatos();
        }

        [Test]
        public void InluirContatoTest()
        {
            //Monta
            string id = Guid.NewGuid().ToString();
            string nome = "Carlos";

            //Executa
            var result = _contatos.Adicionar(id, nome);

            //Verifica
            Assert.That(result, Is.True);

        }

        //ObterContatoTest
        [Test]
        public void ObterContatoTest()
        {

        }
    }
}