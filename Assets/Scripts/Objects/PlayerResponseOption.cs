public class PlayerResponse {
    public string ResponseText = { get; private set };
    public DateResponse GuyResponse = { get; private set };
    public DateResponse GirlResponse = { get; private set };

    public PlayerResponse (string responseText, DateResponse guyResponse, DateResponse girlResponse){
        ResponseText = responseText;
        GuyResponse = guyResponse;
        GirlResponse = girlResponse;
    }
}