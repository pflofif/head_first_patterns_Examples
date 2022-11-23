using Command;
using Command.Commands;
using Command.Objects;

SimpleRemoteController controller = new();
Light light  = new();
var lightOn = new LightOnCommand(light);

controller.SetCommand(lightOn);
controller.BurronWasPressed();