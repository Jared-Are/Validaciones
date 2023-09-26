using System;
using System.Text.RegularExpressions;



//solo letras consola

/*
class Program
{
    static void Main()
    {
        Console.WriteLine("Por favor, ingrese una palabra o frase:");

        while (true)
        {
            string input = Console.ReadLine();

            if (SonSoloLetras(input))
            {
                Console.WriteLine($"Entrada válida: {input}");
                break; // Salir del bucle si se ingresaron solo letras
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese solo letras:");
            }
        }

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }

    static bool SonSoloLetras(string input)
    {
        // Verificar si la entrada contiene solo letras
        foreach (char c in input)
        {
            if (!char.IsLetter(c))
            {
                return false;
            }
        }
        return true;
    }
}
*/




//solo numeros consola

/*
class Program
{
    static void Main()
    {
        Console.WriteLine("Por favor, ingrese un número:");

        while (true)
        {
            string input = Console.ReadLine();

            if (EsNumero(input))
            {
                int numero = Convert.ToInt32(input);
                Console.WriteLine($"Número ingresado: {numero}");
                break; // Salir del bucle si se ingresó un número válido
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor\n ingrese un número:");
            }
        }

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }

    static bool EsNumero(string input)
    {
        // Intentar convertir la entrada a un número entero
        // Si se puede convertir, es un número válido
        return int.TryParse(input, out _);
    }
}
*/





//solo numeros windows forms

/*
namespace BloquearCaracteresNoNumericos
{
public partial class MainForm : Form
{

public MainForm()
{
    InitializeComponent();

    // Asociar el evento KeyPress al cuadro de texto (TextBox)
    textBox1.KeyPress += textBox1_KeyPress;
}

private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
{
    // Verificar si el carácter ingresado no es un número ni una tecla de control
    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
    {
        // Si no es un número ni una tecla de control, evitar que se ingrese
        e.Handled = true;
    }
}

// Puedes agregar más lógica aquí para manejar los números ingresados
}
}

*/



//solo letras windiws form

/*
using System;
using System.Windows.Forms;

namespace BloquearCaracteresNoLetras
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Asociar el evento KeyPress al cuadro de texto (textBox1)
            textBox1.KeyPress += textBox1_KeyPress;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es una letra ni una tecla de control
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra ni una tecla de control, evitar que se ingrese
                e.Handled = true;
            }
        }

        // Puedes agregar más lógica aquí para manejar las letras ingresadas
    }
}
*/