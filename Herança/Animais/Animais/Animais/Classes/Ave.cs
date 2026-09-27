namespace Animais.Classes;

internal class Ave : Animal
{
    public override void EmitirSom()
    {
        base.EmitirSom();
        Console.WriteLine("Piu Piu!\n");
    }
}
