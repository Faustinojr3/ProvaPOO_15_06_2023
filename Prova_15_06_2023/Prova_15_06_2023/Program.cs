/* 1. A empresa GuruDev solicitou para que você implemente o controle de funcionário de uma
empresa cliente com as seguintes especificações.

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
calcular o valor de pagamento(salário mais benefícios). Após o calculo desse valor, deve-se
descontar 17% dos salários acima de R$ 5.000,00 referentes ao IPRF (esse cálculo não leva em
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

using Prova_15_06_2023;




    int qtd = 0;
    int i = 0;

    Console.WriteLine("Quantos funcionarios você deseja cadastrar? ");
    qtd = Convert.ToInt32(Console.ReadLine());

    do
    {
        Console.WriteLine("Insira o nome do funcionario:");
        string nome = Console.ReadLine();
        Console.WriteLine("Insira o CPF:");
        string CPF = Console.ReadLine();
        Console.WriteLine("Insira a matrícula:");
        int matricula = Convert.ToInt32(Console.ReadLine);
        Console.WriteLine("Insira a data de nascimeto: formato mm/dd/aaaa");
        //DateOnly data_de_nascimento = (Console.ReadLine()).DateOnly; ------> não consegui implementar a conversão para dateOnly
        Console.WriteLine("Insira o sexo:");
        string sexo = Console.ReadLine();
        Console.WriteLine("Insira o salario:");
        double salario = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qual o tipo de fúncionario? \r\n Digite: \r\n 1 - Administrativo \r\n 2 - Medico ");
        int tipo = Convert.ToInt32(Console.ReadLine());

        if (tipo == 1)
        {
            Console.WriteLine("Insira o CRM:");
            string crm = Console.ReadLine();
            Console.WriteLine("Insira a especialidade");
            string especialidade = Console.ReadLine();
            Console.WriteLine("Insira o valor da hora extra");
            double valor_hora_ext = Convert.ToDouble(Console.ReadLine());
            Medico medico = new Medico(nome, CPF, matricula, sexo, salario, crm, especialidade, valor_hora_ext);



        }
        if (tipo == 2)
        {
            Console.WriteLine("Insira a função:");
            string funcao = Console.ReadLine();

            Adminstrativo adminstrativo = new Adminstrativo(nome, CPF, matricula, sexo, salario, funcao);





        }
       // List<> list = new List<>();
        i++;
    } while (qtd != i);

