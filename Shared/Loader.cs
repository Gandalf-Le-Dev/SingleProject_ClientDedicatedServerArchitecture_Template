using System;
using Godot;

namespace SingleProject_ClientDedicatedServerArchitecture_Template.Shared;

public partial class Loader : Node
{
	public override void _Ready()
	{
		GD.Print("Loader._Ready()");
		// If in standalone mode (that is, exported binary), load the actual resource data pack
		if (OS.HasFeature("standalone"))
		{
			// Load the resource pack file named data.pck. The second argument is set to false in order to avoid
			// any existing resource to be overwritten by the contents of this pack.
			// NOTE: ideally this should check the return value and because this basically contains the core of the
			// game logic, if failed then a message box should be displayed and then quit the app/game
			try
			{
				GD.Print("try to load resource pack");
				if (ProjectSettings.LoadResourcePack("data.pck"))
				{
					GD.Print("resource pack loaded");
				}
				else
				{
					GD.Print("resource pack not loaded");
				}
			}
			catch (Exception e)
			{
				GD.Print("Error: " + e);
				throw;
			}
		}
	}

}