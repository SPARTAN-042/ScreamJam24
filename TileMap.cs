using Godot;
using System;
using System.Linq;


public partial class TileMap : Godot.TileMap
{


	enum layers
	{
		level0 = 0,
		level1 = 1,
		level2 = 2,
	}


	Vector2I greenBlockAtlasPos = new Vector2I(0, 0);
	Vector2I redBlockAtlasPos = new Vector2I(0, 1);  
	Vector2I whiteBlockAtlasPos = new Vector2I(0, 2);
	const int mainSource = 0;



	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		foreach (int i in Enumerable.Range(0, 3))
		{
			foreach (int j in Enumerable.Range(0, 3))
			{
				SetCell((int)layers.level0, new Vector2I(2, -1 - j), mainSource, greenBlockAtlasPos);
			}
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
