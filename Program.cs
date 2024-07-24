using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe sua data de nascimento (dd/mm/aaaa):");
        string input = Console.ReadLine();
        DateTime dataNascimento;

        if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNascimento))
        {
            string signo = ObterSigno(dataNascimento);
            Console.WriteLine("Seu signo é: " + signo);
        }
        else
        {
            Console.WriteLine("Data de nascimento inválida.");
        }
    }

    static string ObterSigno(DateTime dataNascimento)
    {
        int dia = dataNascimento.Day;
        int mes = dataNascimento.Month;

        switch (mes)
        {
            case 1:
                return (dia <= 20) ? "Capricórnio" : "Aquário";
            case 2:
                return (dia <= 18) ? "Aquário" : "Peixes";
            case 3:
                return (dia <= 20) ? "Peixes" : "Áries";
            case 4:
                return (dia <= 20) ? "Áries" : "Touro";
            case 5:
                return (dia <= 20) ? "Touro" : "Gêmeos";
            case 6:
                return (dia <= 20) ? "Gêmeos" : "Câncer";
            case 7:
                return (dia <= 22) ? "Câncer" : "Leão";
            case 8:
                return (dia <= 22) ? "Leão" : "Virgem";
            case 9:
                return (dia <= 22) ? "Virgem" : "Libra";
            case 10:
                return (dia <= 22) ? "Libra" : "Escorpião";
            case 11:
                return (dia <= 21) ? "Escorpião" : "Sagitário";
            case 12:
                return (dia <= 21) ? "Sagitário" : "Capricórnio";
            default:
                return "Signo não encontrado.";
        }
    }
}
