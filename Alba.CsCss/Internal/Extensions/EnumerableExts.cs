using System;
using System.Collections.Generic;
using System.Linq;

namespace Alba.CsCss.Internal.Extensions
{
    internal static class EnumerableExts
    {
        public static IEnumerable<T> TraverseList<T> (this T root, Func<T, T> getNext) where T : class
        {
            for (T current = root; current != null; current = getNext(current))
                yield return current;
        }

        public static IEnumerable<T> TraverseTree<T> (this T root, Func<T, IEnumerable<T>> getChildren)
        {
            return TraverseTreeDepth(root, getChildren);
        }

        public static IEnumerable<T> TraverseTreeDepth<T> (this T root, Func<T, IEnumerable<T>> getChildren)
        {
            var stack = new Stack<T>();
            stack.Push(root);

            while (stack.Count != 0) {
                T item = stack.Pop();
                yield return item;
                foreach (var child in getChildren(item).Inverse())
                    stack.Push(child);
            }
        }

        public static IEnumerable<T> Inverse<T> (this IEnumerable<T> @this)
        {
            var list = @this as IList<T>;
            if (list != null) {
                for (int i = list.Count - 1; i >= 0; i--)
                    yield return list[i];
            }
            else {
                foreach (T item in @this.Reverse())
                    yield return item;
            }
        }

        public static Dictionary<string, int> ToCaseInsensitiveNameTable (this IEnumerable<string> @this)
        {
            var dic = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            int i = 0;
            foreach (string str in @this)
                dic.Add(str, i++);
            return dic;
        }

        public static bool IsEmpty<T> (this IEnumerable<T> @this)
        {
            return !@this.Any();
        }
    }
}