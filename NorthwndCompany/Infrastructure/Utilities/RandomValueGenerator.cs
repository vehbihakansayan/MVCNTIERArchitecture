using System;

namespace NorthwndCompany.Infrastructure.Utilities
{
    public static class RandomValueGenerator
    {
        public static string GenerateFileName(string extension)
        {
            return Guid.NewGuid().ToString().Replace("-", "") + extension;
        }
    }
}
