class Exposicao {
    private Set<Sala> salas = new HashSet<Sala>();
    private Set<Obra> obras = new HashSet<Obra>();
    //Outros Atributos...
    public Set<Sala> Salas {
        get { return salas; }
        set { salas = value; }
    }
    public Set<Sala> Obras {
        get { return obras; }
        set { obras = value; }
    }
    //Outras Propriedades (getters e setters)...
}

class Souvenir {
    private Set<Estoque> estoque = new HashSet<Estoque>();
    //Outros Atributos...
    public Set<Estoque> Estoque {
        get { return estoque; }
        set { estoque = value; }
    }
    //Outras Propriedades (getters e setters)...
}