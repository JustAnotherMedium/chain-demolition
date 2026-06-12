using Godot;
using Godot.Collections;
using System;

public partial class Axe : Node2D
{
	private Area2D hitBox;
	private CharacterBody2D player;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		hitBox = GetNode<Area2D>("HitBox");
		player = GetNode<CharacterBody2D>("../Player");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Transform = RotateTo(Transform, GetAngleBetween(Transform.Origin, GetViewport().GetMousePosition()));

		if (Input.IsActionJustPressed(""))



		if (hitBox.HasOverlappingAreas())
		{
			GD.Print("hit!");
			Array<Area2D> furniture = hitBox.GetOverlappingAreas();
			PropBase testProp = furniture[0].GetParent<PropBase>();
			if (testProp != null)
				GD.Print("found it!");
		}
	}

	private float GetAngleBetween(Vector2 home, Vector2 dest)
	{
		float deltaX = dest.X - home.X;
		float deltaY = dest.Y - home.Y;

		float theta = Mathf.Atan2(deltaY, deltaX) + (Mathf.Pi / 2f);
		
		return theta;
	}
	// theta reference

	// Takes an angle in radians and rotates the transform to that angle
	private Transform2D RotateTo(Transform2D transform, float rot)
	{
		transform.X.X = transform.Y.Y = Mathf.Cos(rot);
		transform.X.Y = transform.Y.X = Mathf.Sin(rot);
		transform.Y.X *= -1;

		return transform;
	}
	
}
