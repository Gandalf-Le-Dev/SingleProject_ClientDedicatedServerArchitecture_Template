using System.Linq;
using Godot;

namespace SingleProject_ClientDedicatedServerArchitecture_Template.Shared;

public partial class Entry : Node
{
	// By default open the client main menu
	private string _scenePath = "res://Client/main_client.tscn";

	public override void _Ready()
	{
		GD.Print("Entry._Ready()");
		// If we are requesting a server by adding the argument "--server" to the command line or if the export features contains dedicated_server
		if (OS.GetCmdlineArgs().Contains("--server") || OS.HasFeature("dedicated_server"))
		{
			GD.Print("Starting server");
			// Set the scene path to the server scene
			_scenePath = "res://Server/main_server.tscn";
		}
		
		// Load the scene
		GetTree().ChangeSceneToFile(_scenePath);
	}
}