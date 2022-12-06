using Command;
using Command.Objects;

SimpleRemoteController controller = new(8);
Light light  = new();
Tv tv = new();
controller.SetCommand(0 , () => light.On(), () => light.Off());
controller.SetCommand(1 , () => tv.On(), () => tv.Off());

controller.OnBurronWasPressed(1);
controller.OffBurronWasPressed(1);
controller.OnBurronWasPressed(0);
controller.OffBurronWasPressed(0);