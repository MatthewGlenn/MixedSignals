public class DateResponse{
    public string ResponseText { get; private set }
    public Emotion DateEmotion { get; private set }
    public int Status { get; private set }
    
    public DateResponse(string responseText, Emotion emotion, int status){
        ResponseText =  response
        DateEmotion = emotion
        Status = status
    }
}