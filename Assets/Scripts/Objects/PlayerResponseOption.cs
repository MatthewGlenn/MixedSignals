public class PlayerResponse {
<<<<<<< HEAD
	public string ResponseText { get; set; }
	public DateResponse GuyResponse { get; set; }
	public DateResponse GirlResponse { get; set; }
=======
    public string ResponseText = { get, set };
    public DateResponse GuyResponse = { get, set };
    public DateResponse GirlResponse = { get, set };
>>>>>>> e18970acc0a91dd1827291d9ba2d6279192f0b59

    public PlayerResponse (string responseText, DateResponse guyResponse, DateResponse girlResponse){
        ResponseText = responseText;
        GuyResponse = guyResponse;
        GirlResponse = girlResponse;
    }
}