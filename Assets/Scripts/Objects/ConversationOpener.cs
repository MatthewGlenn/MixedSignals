public class ConversationOpener{
    public string PlayerStatement = { get, set };
    public string GuyStatement = { get, set };
    public string GirlStatement = { get, set };

    public ConversationOpener(string playerStatement, string guyStatement, string girlStatement){
        PlayerStatement = playerStatement;
        GuyStatement = guyStatement;
        GirlStatement = girlStatement;
    }
}