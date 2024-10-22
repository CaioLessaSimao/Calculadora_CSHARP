namespace Response
{
    public class ResponseDTO
    {

        private int result = 0;


        public ResponseDTO(int result)
        {
            this.result = result;
        }

        public int getResult()
        {
            return result;
        }

        public void setResult(int result)
        {
            this.result = result;
        }
    }
}