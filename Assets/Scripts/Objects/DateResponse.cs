public class DateResponse{
    public string ResponseText { get, set }
    public Emotion DateEmotion { get, set }
    public int Status { get, set }
    
    public DateResponse(string responseText, Emotion emotion, int status){
        ResponseText =  response
        DateEmotion = emotion
        Status = status
    }
}