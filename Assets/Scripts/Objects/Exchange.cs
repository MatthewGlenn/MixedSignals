public class Exchange {
    public ConversationOpener Opener = { get; private set };
    public PlayerResponse PlayerResponse1 = { get; private set };
    public PlayerResponse PlayerResponse2 = { get; private set };
    public PlayerResponse PlayerResponse3 = { get; private set };

    public Exchange (ConversationOpener opener, PlayerResponse response1, PlayerResponse response2, PlayerResponse response3) {
        Opener = opener;
        PlayerResponse1 = response1;
        PlayerResponse2 = response2;
        PlayerResponse3 = response3;
    }
}