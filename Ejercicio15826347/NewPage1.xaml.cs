namespace Ejercicio15826347;
/// <summary>
/// Captura 4 numeros y los coloca al inverso
/// </summary>
public partial class NewPage1 : ContentPage
{
    int paso = 0;
    List<string> listaNumeros = new List<string>();
    public NewPage1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (paso < 3)
        {
            // Guarda el número ingresado
            listaNumeros.Add(num1.Text);

            // Aumenta el paso y cambia el mensaje
            paso++;
            if (paso == 1)
                texto.Text = "Ingresa el Segundo número";
            else if (paso == 2)
                texto.Text = "Ingresa el Tercer número";
            else if (paso == 3)
                texto.Text = "Ingresa el Cuarto número";

            num1.Text = "";
        }
        else if (paso == 3)
        {
            // Guarda el cuarto número
            listaNumeros.Add(num1.Text);

            // Invertir la lista
            listaNumeros.Reverse();

            // Mostrar en reverso
            mostrar.Text = "Lista al reverso: " + string.Join(" ", listaNumeros);

            // Resetear
            paso = 0;
            listaNumeros.Clear();
            texto.Text = "Ingresa el primer número";
            num1.Text = "";
        }
    }
}