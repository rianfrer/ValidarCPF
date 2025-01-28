class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o CPF para validacao (apenas numeros):");
        string cpf = Console.ReadLine(); //Lendo o que o usuario digitou

        if (cpf.Length != 11)
        {
            Console.WriteLine("CPF inválido! Necessario 11 dígitos.");
            return;
        }

        if (VerificarSeDigitosSaoIguais(cpf))
        {
            Console.WriteLine("CPF inválido! Não pode ter todos os dígitos iguais.");
            return;
        }

        int primeiroDigito = CalcularPrimeiroDigito(cpf);
        int segundoDigito = CalcularSegundoDigito(cpf, primeiroDigito);

        if (primeiroDigito == (cpf[9] - '0') && segundoDigito == cpf[10] - '0') // Compara os dígitos calculados com os fornecidos no CPF (posição 10 e 11).
        {
            Console.WriteLine("CPF valido!");
        }
        else { Console.WriteLine("CFP invalido!"); }
    }
    static bool VerificarSeDigitosSaoIguais(string cpf)
    {
        // Compara cada dígito com o primeiro
        for (int i = 1; i < cpf.Length; i++)
        {
            if (cpf[i] != cpf[0])
            {
                return false; // Achou um diferente, então não são todos iguais
            }
        }
        return true; // Todos os dígitos são iguais
    }

    static int CalcularPrimeiroDigito(string cpf)
    {
        int soma = 0;
        int peso = 10;

        for (int i = 0; i < 9; i++) // 9 primeiros dígitos
        {
            soma += (cpf[i] - '0') * peso;
            peso--;
        }

        int resto = soma % 11;
        if (resto < 2)
        {
            return 0;
        }
        else
        {
            return 11 - resto;
        }
    }

    static int CalcularSegundoDigito(string cpf, int primeiroDigito)
    {
        int soma = 0;
        int peso = 11;

        for (int i = 0; i < 9; i++) // 9 primeiros dígitos
        {
            soma += (cpf[i] - '0') * peso;
            peso--;
        }

        soma += primeiroDigito * 2;

        int resto = soma % 11;
        if (resto < 2)
        {
            return 0;
        }
        else
        {
            return 11 - resto;
        }
    }
}