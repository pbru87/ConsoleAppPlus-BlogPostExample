using Throw;

namespace ConsoleAppPlus.Utils.Extensions
{
    public static class DirectoryInfoExtensions
    {
        /// <summary>
        /// Gets the x-th parent directory of a specified subdirectory.
        /// </summary>
        /// <param name="dirInfo"></param>
        /// <param name="levels"></param>
        /// <returns></returns>
        public static DirectoryInfo? GetParent(this DirectoryInfo dirInfo, int levels)
        {
            // Guard Clauses
            levels.Throw().IfNegativeOrZero();

            DirectoryInfo newDirInfo = dirInfo;
            for (int i = 0; i < levels; i++)
            {
                if (newDirInfo.Parent == null) return null;
                newDirInfo = newDirInfo.Parent;
            }
            return newDirInfo;
        }
    }
}
