using Godot;
using System;

public partial class TestProp : PropBase //, Node (through PropBase)
{
    public override float MaxHitPoints => 10f;
    private float hitPoints;

    public override void _Ready()
    {
        hitPoints = MaxHitPoints;
    }

    public override void Hurt(float hurtPoints)
    {
        hitPoints -= hurtPoints;

        if (hitPoints <= 0f)
        {
            Break();
        }
    }

}
// bleh