public class Exchange {
	public ConversationOpener Opener { get; set; }
	public PlayerResponse PlayerResponse1 { get; set; }
	public PlayerResponse PlayerResponse2 { get; set; }
	public PlayerResponse PlayerResponse3 { get; set; }

    public Exchange (ConversationOpener opener, PlayerResponse response1, PlayerResponse response2, PlayerResponse response3) {
        Opener = opener;
        PlayerResponse1 = response1;
        PlayerResponse2 = response2;
        PlayerResponse3 = response3;
    }
}