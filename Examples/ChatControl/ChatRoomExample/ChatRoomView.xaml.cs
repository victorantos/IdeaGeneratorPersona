using Telerik.Maui.Controls;

namespace IdeaGeneratorPersona.Examples.ChatControl.ChatRoomExample;

public partial class ChatRoomView : RadContentView
{
    public ChatRoomView()
    {
        InitializeComponent();
    }

    private void chat_Loaded(object sender, System.EventArgs e)
    {
        ((ChatRoomViewModel)this.BindingContext).StartService();
    }

    private void chat_Unloaded(object sender, System.EventArgs e)
    {
        ((ChatRoomViewModel)this.BindingContext).StopService();
    }
}