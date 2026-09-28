namespace Animais.Classes;

internal class Peixe : Animal
{
    public override void EmitirSom()
    {
        base.EmitirSom();
        Console.WriteLine("Splash Splash!\n");
    }
}
