namespace Core.Models;

public class BaseModel<T>
{
    public T Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
}

//donot add properties/fields/methods to this class. Do that in the above class.
public class BaseModel : BaseModel<int> { }

