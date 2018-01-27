public class DateResponse{
<<<<<<< HEAD
	public string ResponseText { get; set; }
	public Emotion DateEmotion { get; set; }
	public int Status { get; set; }
=======
    public string ResponseText { get, set }
    public Emotion DateEmotion { get, set }
    public int Status { get, set }
>>>>>>> e18970acc0a91dd1827291d9ba2d6279192f0b59
    
    public DateResponse(string responseText, Emotion emotion, int status){
		ResponseText = responseText;
		DateEmotion = emotion;
		Status = status;
    }
}