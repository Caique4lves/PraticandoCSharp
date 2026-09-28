# Interface

Este repositório reúne exercícios sobre interface. Ao utilizar interface, as classes que utilizam a interface devem possuir os mesmos tipos de comportamentos que ela, é como se fosse um contrato entre classes e interfaces. 

Durante os exercícios, pratiquei e entendi:

- Quando utilizar interface, exemplo: Interface IForma, essa interface possui um método chamado CalcularForma para calcular uma forma geométrica, uma classe Triangulo que utiliza essa interface, deve utilizar o método CalcularForma e implementar de acordo com as fórmulas de cálculo do triângulo. Uma classe Circulo que utiliza essa interface, por sua vez, implementará o método e calculará com base nas fórmulas do círculo e assim por diante.
- Polimorfismo.
- Boas práticas com interface.
- Quando usar herança e quando usar interface. Herança quando minha subclasse faz parte da classe base (É um) e Interface quando quero definir um contrato de comportamento que classes diferentes devem implementar.

## Organização

```text
Interface
├── Armazenar
├── Formas
├── GestaoServicos
├── Notificacao
├── Pagamentos
├── PlataformaCursos
├── Sensores
├── Veiculos
└── README.md
```
