namespace Animais.Classes;

internal class Mamifero : Animal
{
    public override void EmitirSom()
    {
        base.EmitirSom();
        Console.WriteLine("AU AU!\n");
    }
}
