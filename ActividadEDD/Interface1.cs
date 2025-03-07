using Gtk;
using System;

public class Interface1 : Window
{
    private Entry inputEntryCorreo;
    private Entry inputEntryContrasena;

    public Interface1() : base("Alison Vásquez")
    {
        SetDefaultSize(300, 200);
        SetPosition(WindowPosition.Center);

        VBox vbox = new VBox(5);

        Label label = new Label("Correo:");
        vbox.PackStart(label, false, false, 0);

        inputEntryCorreo = new Entry();
        vbox.PackStart(inputEntryCorreo, false, false, 0);

        Label label1 = new Label("Contraseña:");
        vbox.PackStart(label1, false, false, 0);

        inputEntryContrasena = new Entry();
        vbox.PackStart(inputEntryContrasena, false, false, 0);

        Button showButton = new Button("Mostrar en consola");
        showButton.Clicked += OnShowButtonClicked;
        vbox.PackStart(showButton, false, false, 0);

        Add(vbox);
        ShowAll();
    }

    private void OnShowButtonClicked(object sender, EventArgs e)
    {
        string inputTextCorreo = inputEntryCorreo.Text;
        string inputTextContrasena = inputEntryContrasena.Text;

        Console.WriteLine("Correo ingresado: " + inputTextCorreo);
        Console.WriteLine("Contraseña ingresada: " + inputTextContrasena);
    }
}