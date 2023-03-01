namespace Builder._1_RepresentarUmSoldado
{
    /*
     *  Primeiro,vamos criar uma classe abstrata para representar todos os tipos de soldado
     *  sendo que todos deveram Ter:
     *  - Arma 
     *  - Transporte
     *  - Foco de Ataque
     */
    public abstract class Soldado
    {
        public string Arma { get; protected set; }
        public string Transporte { get; protected set; }
        public string Foco { get; protected set; }

        public abstract void EscolherArmar(string arma);
        public abstract void EscolherTransporte(string transporte);
        public abstract void DefinirFoco(string foco);
    }
}
