using System;

namespace GcdTask
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue]  by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int FindGcd(int a, int b)
        {
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.", nameof(a));
                throw new ArgumentException("Two numbers cannot be 0 at the same time.", nameof(b));
            }

            if (a == 0)
            {
                if (b < 0)
                {
                    return -1 * b;
                }
                else
                {
                    return b;
                }
            }

            if (b == 0)
            {
                if (a < 0)
                {
                    return -1 * a;
                }
                else
                {
                    return a;
                }
            }

            if (a < 0 && b < 0)
            {
                if (-1 * a <= -1 * b)
                {
                    for (int i = -1 * a; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            return i;
                        }
                    }
                }
                else
                {
                    for (int i = -1 * b; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            return i;
                        }
                    }
                }
            }
            else if (a < 0 && b > 0)
            {
                if (-1 * a <= b)
                {
                    for (int i = -1 * a; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            return i;
                        }
                    }
                }
                else
                {
                    for (int i = b; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            return i;
                        }
                    }
                }
            }
            else if (a > 0 && b < 0)
            {
                if (a <= -1 * b)
                {
                    for (int i = a; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            return i;
                        }
                    }
                }
                else
                {
                    for (int i = -1 * b; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            return i;
                        }
                    }
                }
            }
            else
            {
                if (a <= b)
                {
                    for (int i = a; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            return i;
                        }
                    }
                }
                else
                {
                    for (int i = b; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            return i;
                        }
                    }
                }
            }

            return 0;
        }
    }
}

