using Godot;

public partial class paddle : RigidBody2D
{
	[Export]
	public Key UpKey { get; set; }

	[Export]
	public Key DownKey { get; set; }

	[Export]
	public int Speed { get; set; } = 500;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public override void _PhysicsProcess(double delta)
	{
		Move(delta);
	}

	private void Move(double delta)
	{
		if (Input.IsKeyPressed(UpKey) && !Input.IsKeyPressed(DownKey))
		{
			LinearVelocity = Vector2.Up * Speed;
		}
		else if (Input.IsKeyPressed(DownKey) && !Input.IsKeyPressed(UpKey))
		{
			LinearVelocity = Vector2.Down * Speed;
		}
		else
		{
			LinearVelocity = Vector2.Zero;
		}
	}
}
