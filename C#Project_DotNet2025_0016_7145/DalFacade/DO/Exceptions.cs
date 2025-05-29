

namespace DO;

[Serializable]
public class Dal_CodeNotFound : Exception {
    public Dal_CodeNotFound(string? message) : base(message)
     { 
     }
    
}
[Serializable]

public class Dal_IdIsExist: Exception
{
    public Dal_IdIsExist(string? message) : base(message) { }
}

[Serializable]

public class Dal_objectNotFound : Exception
{
    public Dal_objectNotFound(string? message) : base(message) { }
}

