CREATE TABLE Entrevistados(
    Id INT IDENTITY PRIMARY KEY,
    Nome VARCHAR(200) NOT NULL,
    Idade INT NOT NULL,
    CPF VARCHAR(14) NOT NULL UNIQUE,
    EstaEmpregado BIT NOT NULL,
    DescricaoEmprego VARCHAR(200),
    MoraAluguel BIT NOT NULL,
    ValorAluguel DECIMAL(10,2),
    ContatoTelefonico VARCHAR(20) NOT NULL
);