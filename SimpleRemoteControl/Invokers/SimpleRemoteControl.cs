using SimpleRemoteControl.Commands;

namespace SimpleRemoteControl.Invokers
{
    //This is our invoker
    public class SimpleRemoteControl
    {
        public ICommand Command { private get; set; }
        public void ButtonWasPressed() => Command.Execute();
    }
}