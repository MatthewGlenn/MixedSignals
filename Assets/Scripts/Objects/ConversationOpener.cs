public class ConversationOpener{
<<<<<<< HEAD
	public string PlayerStatement { get; set; }
	public string GuyStatement { get; set; }
	public string GirlStatement { get; set; }
=======
    public string PlayerStatement = { get, set };
    public string GuyStatement = { get, set };
    public string GirlStatement = { get, set };
>>>>>>> e18970acc0a91dd1827291d9ba2d6279192f0b59

    public ConversationOpener(string playerStatement, string guyStatement, string girlStatement){
        PlayerStatement = playerStatement;
        GuyStatement = guyStatement;
        GirlStatement = girlStatement;
    }
}