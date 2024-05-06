namespace BootsTrackr.Errors
{
    public class EmployeeDoesNotExist : Exception
    {
        public EmployeeDoesNotExist() : base("Employee does not exist.")
        {
            // You can add custom initialization logic here if needed
        }

        public EmployeeDoesNotExist(string message) : base(message)
        {
            // You can add custom initialization logic here if needed
        }

        public EmployeeDoesNotExist(string message, Exception innerException) : base(message, innerException)
        {
            // You can add custom initialization logic here if needed
        }
        
    }
}