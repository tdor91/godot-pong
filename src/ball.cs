using Godot;
using System;

public partial class ball : RigidBody2D
{
	[Export] public int Speed { get; set; } = 700;

	private Vector2 direction = Vector2.Left;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		LinearVelocity = direction;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

    public override void _PhysicsProcess(double delta)
    {
		base._PhysicsProcess(delta);

		LinearVelocity =  LinearVelocity.Normalized() * (float)(Speed * delta);

		var collisionInfo = MoveAndCollide(LinearVelocity);
		if (collisionInfo is not null) {
			LinearVelocity = LinearVelocity.Bounce(collisionInfo.GetNormal());
		}
    }
}
