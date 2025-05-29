
namespace BO
{
        [Serializable]
        public class BL_CodeNotFound : Exception
        {
            public BL_CodeNotFound(string? message) : base(message) { }
            public BL_CodeNotFound(string message, Exception innerException)
                : base(message, innerException) { }
        }
        [Serializable]
        public class BL_IdIsExist : Exception
        {
            public BL_IdIsExist(string? message) : base(message) { }
            public BL_IdIsExist(string message, Exception innerException)
            : base(message, innerException) { }
        }

        [Serializable]

        public class BL_objectNotFound : Exception
        {
            public BL_objectNotFound(string? message) : base(message) { }
            public BL_objectNotFound(string message, Exception innerException)
            : base(message, innerException) { }
        }
        public class BL_InputNotCorrect : Exception
        {
            public BL_InputNotCorrect(string? message) : base(message) { }
            public BL_InputNotCorrect(string message, Exception innerException) :base(message,innerException) { }

        }
    }

