using Godot;
using System;

public abstract partial class PropBase : Node
{
    public abstract float MaxHitPoints { get; }

    public virtual void Hurt(float hurtPoints)
    {
        GD.Print("ow (implement this you buffoon)");
    }

    public virtual void Break()
    {
        GD.Print("bleh ded (implement this you buffoon)");
    }

}

// me on my way to watch the basic piloting tutorial while piloting the General Dynamic F-16 Fighting Falcon (i have no idea how i took off)
// I say this because it is literally my first time using abstract classes, i could use interface which i've worked with before... nah