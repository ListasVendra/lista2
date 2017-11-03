//CLASSES GERENTE ATENDENTE E FUNCIONARIO
class Gerente {
    //Outros atributos e propriedades
    public float CalcularSalario() {
        //Calculo pelo Gerente
    }
}

class Atendente {
    //Outros atributos e propriedades
    public float CalcularSalario() {
        //Calculo pelo Atendente
    }
}

class Funcionario {
    private Gerente gerente;
    private Atendente atendente;
    //Outros atributos e propriedades
    public void DefinirGerente() {
        gerente = new Gerente();
    }
    public void DefinirAtendente() {
        atendente = new Atendente();
    }
    public float CalcularSalarioPorAtendente() {
        return atendente.CalcularSalario();
    }
    public float CalcularSalarioPorGerente() {
        return gerente.CalcularSalario();
    }
}


//CLASSES OBRAS
class Obra {
    //Atributos e propriedades
}

class Escultura {
    private Obra obra;
    //Outros atributos e propriedades
    public Escultura() {
        obra = new Obra();
    }
}

class DocumentoHistorico {
    private Obra obra;
    //Outros atributos e propriedades
    public DocumentoHistorico() {
        obra = new Obra();
    }
}