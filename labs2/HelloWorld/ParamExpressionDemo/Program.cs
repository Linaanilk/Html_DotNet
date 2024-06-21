using System.Linq.Expressions;

namespace ParamExpressionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //    ParameterExpression param = Expression.Parameter(typeof(int), "x");
            //    BinaryExpression addExpression = Expression.Add(param, Expression.Constant(8));
            //    Expression<Func<int, int>>lambda = Expression.Lambda<Func<int, int>>(addExpression, param);



            ConstantExpression constant=Expression.Constant(1);
            ParameterExpression parameter=Expression.Parameter(typeof(int),"x");

            BinaryExpression addExpression=Expression.Add(Expression.Parameter(typeof(int),"x"));

            Expression<Func<int,int>>lambda=Expression.Lambda<Func<int,int>>(addExpression, parameter);

                Func<int, int>addFunction=lambda.Compile();
            int result = addFunction(3);
            Console.WriteLine(result);
        }
        }
    }

