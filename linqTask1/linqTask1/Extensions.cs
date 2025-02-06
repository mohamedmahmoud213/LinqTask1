using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqTask1
{
    internal static class Extensions
    {
        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            var result1 = new List<T>();
            foreach (var item in source)
            {

                if (predicate(item))
                {
                    result1.Add(item);
                }
            }

            return result1;
        }

        public static IEnumerable<T> CustomWhereWithIndex<T>(this IEnumerable<T> source, Func<T, int, bool> predicate)
        {

            var result1 = new List<T>();
            int index = 0;
            foreach (var item in source)
            {
                if (predicate(item, index))
                {
                    result1.Add(item);
                }
                index++;
            }

            return result1;

        }


        public static IEnumerable<TResult> CustomSelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            foreach (var item in source)
            {
                yield return selector(item);
            }
        }

        public static IEnumerable<TResult> CustomSelectIndex<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
        {


            int index = 0;
            foreach (var item in source)
            {
                yield return selector(item, index++);
            }

        }






        public static IEnumerable<T> CustomSkip<T>(this IEnumerable<T> source, int count)
        {
            var result1 = new List<T>();

            int index = 0;
            foreach (var item in source)
            {
                if (index++ >= count)
                {
                    result1.Add(item);
                }
            }
            return result1;



        }

        public static IEnumerable<T> CustomSkipLast<T>(this IEnumerable<T> source, int count)
        {
            var result1 = new List<T>();



            foreach (var item in source)
            {
                result1.Add(item);
                if (result1.Count > count)
                {
                    result1.Remove(item);
                }
            }
            return result1;

        }

        public static IEnumerable<T> CustomTake<T>(this IEnumerable<T> source, int count)
        {
            int taken = 0;
            foreach (var item in source)
            {
                if (taken++ < count)
                {
                    yield return item;
                }
                else
                {
                    yield break;
                }

            }
        }

        public static IEnumerable<T> CostomTakeLast<T>(this IEnumerable<T> source, int Index)
        {
            List<T> MyNums = new List<T>();

            int length = source.Count();

            int counter = 0;


            foreach (var item in source)
            {
                if ((length - counter) <= Index)
                {
                    MyNums.Add(item);
                }
                counter++;
            }

            return MyNums;


        }

        public static IEnumerable<T> CustomTakeWhile<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {


            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
                else
                {
                    yield break;
                }
            }





        }

        public static IEnumerable<T[]> CChunk<T>(this IEnumerable<T> source, int size)
        {

            List<T[]> part = new List<T[]>();

            List<T> FinalResult = new List<T>(size);

            foreach (var item in source)
            {
                FinalResult.Add(item);
                if (FinalResult.Count == size)
                {
                    part.Add(FinalResult.ToArray());
                    FinalResult.Clear();
                }
            }

            return part;
        }


        public static IEnumerable<T> CTakeWhile<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            List<T> MyNums = new List<T>();



            foreach (var item in source)
            {
                if (predicate(item))
                {
                    MyNums.Add(item);
                };

            }

            return MyNums;
        }

       
        public static IEnumerable<T> CSkipWhile<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            List<T> MyNums = new List<T>();



            foreach (var item in source)
            {
                if (predicate(item))
                {
                    continue;
                };
                MyNums.Add(item);

            }

            return MyNums;
        }

        
        public static T CFirst<T>(this IEnumerable<T> source)
        {

            foreach (var item in source)
            {
                return item;
            }

            throw new Exception("Sequence contains no elements.");
        }

     
        public static T CLast<T>(this IEnumerable<T> source)
        {

            int length = source.Count();

            int counter = 0;

            T last = default(T);

            foreach (var item in source)
            {
                if (counter == length)
                {
                    last = item;
                    break;
                }

                counter++;
            }

            return last;
        }

     
        public static T CFirstOrDefault<T>(this IEnumerable<T> source)
        {
            T first = default(T);

            foreach (var item in source)
            {
                return item;
            }

            return first;

        }

       
        public static T CLastOrDefault<T>(this IEnumerable<T> source)
        {

            int length = source.Count();

            int counter = 0;

            T last = default(T);

            foreach (var item in source)
            {
                if (counter == length)
                {
                    return item;

                }

                counter++;
            }

            return last;
        }

        
        public static T CSingle<T>(this IEnumerable<T> source)
        {

            T single = default(T);
            bool found = false;

            foreach (var item in source)
            {
                if (found)
                {
                    throw new Exception("Sequence contains more than one element.");
                }
                single = item;
                found = true;
            }


            return single;
        }

        
        public static T CSingleOrDefault<T>(this IEnumerable<T> source)
        {

            T single = default(T);

            bool found = false;

            foreach (var item in source)
            {
                if (found)
                {
                    throw new Exception("Sequence contains more than one element.");
                }
                single = item;
                found = true;
            }

            return single;
        }

        
        public static List<T> CDistinct<T>(this IEnumerable<T> source)
        {

            List<T> result = new List<T>();

            foreach (var item in source)
            {
                if (!result.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }


    }
    }  
 