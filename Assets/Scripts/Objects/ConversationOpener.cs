public class ConversationOpener{
    public string PlayerStatement = { get; private set };
    public string GuyStatement = { get; private set };
    public string GirlStatement = { get; private set };

    public ConversationOpener(string playerStatement, string guyStatement, string girlStatement){
        PlayerStatement = playerStatement;
        GuyStatement = guyStatement;
        GirlStatement = girlStatement;
    }
}