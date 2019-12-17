using System;

namespace StoredBuild.Domain.Exceptions
{
  public class DomainException : Exception
  {
    public DomainException(string message) : base(message)
    {
    }

    public static void when(bool hasError, string message)
    {

      if (!hasError)
      {
        throw new DomainException(message);
      }

    }

  }
}