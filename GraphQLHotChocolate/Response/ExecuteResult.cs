namespace GraphQLHotChocolate.Response
{
    public class ExecuteResult
    {
        public ResponseStatus Status {get; set; }
        public string  Message{get; set; }
    }

    public enum ResponseStatus
    {

    Success, Failure }
    
}
