class Obra {
    //Atributos e Propriedades
}

//Component do Composite
class DisposicaoObra {
    protected List<DisposicaoObra> listDisposicao = new List<DisposicaoObra>();
    private string local;
    public string Local {
        get { return local; }
        set { local = value; }
    }

    public virtual void Add(DisposicaoObra d) {
        listDisposicao.Add(d);
    }

    public virtual void Remove(DisposicaoObra d) {
        listDisposicao.Remove(d);
    }

    public virtual void ValidarLocal() {
        //Valida das filhas
        foreach (var item in listDisposicao)
        {
            item.ValidarLocal();
        }
        //Valida o local atual desse componente
    }
}

//A Folha do Composite
class Quadro : DisposicaoObra {
    public override void ValidarLocal() {
        //Valida o local atual desse componente
    }
}

//Um composite
class Pedestal : DisposicaoObra {
    public override void ValidarLocal() {
        //Valida das filhas
        foreach (var item in listDisposicao)
        {
            item.ValidarLocal();
        }
        //Valida o local atual desse componente
    }
}