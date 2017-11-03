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

//
// O que mudou aqui é que o Gerente e Atendente podem ser instanciados
// por meio de propriedades (setters)
//
class Funcionario {
    private Gerente gerente;
    public Gerente Gerente {
        get { return gerente; }
        set { gerente = value; }
    }
    private Atendente atendente;
    public Atendente Atendente {
        get { return atendente; }
        set { atendente = value; }
    }
    //Outros atributos e propriedades
    public float CalcularSalarioPorAtendente() {
        return atendente.CalcularSalario();
    }
    public float CalcularSalarioPorGerente() {
        return gerente.CalcularSalario();
    }
}


//CLASSES OBRAS
//
// O que mudou aqui é que a obra agora pode ser enviado por
// meio de propriedades
// 
class Obra {
    //Atributos e propriedades
}

class Escultura {
    private Obra obra;
    public Obra Obra {
        get { return atendente; }
        set 
        {
            if(value == null)
                throw new NullReferenceException();
             obra = value; 
        }
    }
    //Outros atributos e propriedades
}

class DocumentoHistorico {
    private Obra obra;
    public Obra Obra {
        get { return atendente; }
        set 
        {
            if(value == null)
                throw new NullReferenceException();
             obra = value; 
        }
    }
    //Outros atributos e propriedades
}