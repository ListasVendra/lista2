class Obra {
    //Atributos e Propriedades
}

class DisposicaoObra {
    private List<DisposicaoObra> listDisposicao = new List<DisposicaoObra>();
    private string local;
    public string Local {
        get { return local; }
        set { local = value; }
    }

    public virtual void add(DisposicaoObra d) {

    }
}