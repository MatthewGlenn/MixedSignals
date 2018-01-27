public class PlayerResponse {
    public string ResponseText = { get, set };
    public DateResponse GuyResponse = { get, set };
    public DateResponse GirlResponse = { get, set };

    public PlayerResponse (string responseText, DateResponse guyResponse, DateResponse girlResponse){
        ResponseText = responseText;
        GuyResponse = guyResponse;
        GirlResponse = girlResponse;
    }
}