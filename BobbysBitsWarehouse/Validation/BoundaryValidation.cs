namespace BobbysBitsWarehouse.Validation
{
    public interface IBoundaryValidation
    {
        string ValidateBoundaryLimitPosition(int coordinate, string direction, int boundaryLimit);
        string ValidateBoundaryMinusPosition(int coordinate, string direction);
    }

    public class BoundaryValidation : IBoundaryValidation
    {
        public string ValidateBoundaryMinusPosition(int coordinate, string direction)
        {
            if (coordinate < 0)
            {
                return "Robot went out of bounds " + direction;
            }

            return "";
        }

        public string ValidateBoundaryLimitPosition(int coordinate, string direction, int boundaryLimit)
        {
            if (coordinate > boundaryLimit)
            {
                return "Robot went out of bounds " + direction;
            }

            return "";
        }
    }
}
