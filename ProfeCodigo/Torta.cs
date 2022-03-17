
class Torta
{

	private string pan;
	private string frijoles;
	private string queso;
	private string[] ingredientes;

	public Torta (string pan, string frijoles, string queso, string[] ingredientes)
    {
		this.pan = pan;
		this.frijoles = frijoles;
		this.queso = queso;
		this.ingredientes = ingredientes;
    }

	public string getPan()
    {
		return pan;
    }

	public string getFrijoles()
    {
		return frijoles;
    }

	public string getQueso()
    {
		return queso;
    }

	public string[] getIngredientes()
    {
		return ingredientes;
    }

	/*
	public string setPan(string pan)
	{
		this.pan = pan;
		return this.pan;
	}

	public string setFrijoles(string frijoles)
	{
		this.frijoles = frijoles;
		return this.frijoles;
	}

	public string setQueso(string queso)
	{
		this.queso = queso;
		return this.queso;
	}

	public string[] setIngredientes(string [] ingredientes)
	{
		this.ingredientes = ingredientes;
		return this.ingredientes;
	}

*/
	public void preparar() {
		string str_salida = $"Sale una torta hecha con {this.pan}, frijoles {this.frijoles}, queso {this.queso}";

		foreach (string ingrediente in this.ingredientes)
        {
			str_salida += $", {ingrediente}";
        }

		Console.WriteLine(str_salida);

	}
}