using Godot;

namespace Embers;

public partial class Game : Node3D
{
    public override void _Ready()
    {
        GD.Print("Hello, Godot!");
    }
}