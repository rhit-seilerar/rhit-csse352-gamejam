public class GameEventBus : EventBus<GameEventBus.Type>
{
    public enum Type
    {
        // Lifecycle
        Start,
        Update,
        Pause, // bool
        Stop,

        // Hovering
        HoverStart, // Hoverable
        HoverStop, // Hoverable
    }
}
