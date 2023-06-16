using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 a) A empresa deseja controlar os funcionários, sendo que cada funcionário possui: nome, CPF,
matrícula, data de nascimento, sexo, salário.
b) Médico é um tipo de funcionário que possui todos os atributos e métodos de funcionário além do
CRM (registro no conselho), valor de hora extra e especialidade. Os médicos recebem um benefício
de 20% sobre o salário de auxílio periculosidade (não é contabilizado para esse cálculo o valor da
hora extra).
c) Existe também os funcionários do administrativo que possui todos os atributos de funcionários
além da função. Esse tipo de funcionário tem no seu salário uma acréscimo de R$ 150 de vale
transporte e 15% a mais do salário de vale alimentação (sobre o salário sem conta o vale transporte).
d) Você também deve implementar a folha de pagamento que possui um mês correspondente, um
funcionário, valor de IPRF (calculado sobre o valor final), quantidade de horas extras trabalhadas e
calcular o valor de pagamento(salário mais benefícios).
Após o calculo desse valor, deve-se descontar 17% dos salários acima de R$ 5.000,00 referentes ao IPRF (esse cálculo não leva em
conta o valor de horas extras).

e) Faça uma interação com o usuário que pergunte quantos funcionários deseja cadastrar. Após isso,
leia essa quantidade de funcionário perguntado a cada funcionário se é Administrativo ou Médico e
criando a instância da classe folha de pagamento passando esse funcionário para a folha de
pagamento.
f) Para evitar que um usuário crie um funcionário sem um tipo, faça uma programação que evite
criar instâncias da classe funcionário.
g) Na folha de pagamento, crie um atributo estático para controlar o valor total de pagamento para
todos os funcionários.
h) Faça um método estático na classe folha de pagamento que receba como parâmetro uma lista de
folha de pagamento e um mês e retorne o valor gasto com pagamento no mês recebido por
parâmetro. Realize o teste do método usando os dados informados pelo usuário.
i) Realize o tratamento de exceções nas entradas do usuário para evitar que ocorra um erro no
sistema devido erro do usuário. Exemplo, no momento de inserir o valor do salário o usuário inserir
um texto. Caso você implementou algum downcasting, realize o tratamento de exceção pois se trata
de uma operação que não é segura (pode ocorrer erro).
j) Evite que a classe médico seja estendida, ou seja, a classe médico não pode possuir classes
derivadas.
Observações: todas as classes devem possuir construtores para os valores que devem ser
informados pelo usuário.*/


namespace Prova_15_06_2023
{
    internal class Adminstrativo:Funcionario
    {
        protected string funcao;

        public Adminstrativo(string nome, string cpf, int matricula, DateOnly data_nascimento, string sexo, double salario, string funcao ):base(nome, cpf, matricula, data_nascimento, sexo, salario) {

            this.funcao = funcao;

            this.salario = (salario * 1.15)+150;


            
        
        
        }


    }
}
