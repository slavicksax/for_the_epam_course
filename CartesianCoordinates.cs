using System;

namespace GetNeighbors
{
    public static class CartesianCoordinates
    {
        /// <summary>
        /// Gets from a set of points only points that are h-neighbors for a point with integer coordinates x and y.
        /// </summary>
        /// <param name="point">Given point with integer coordinates x and y.</param>
        /// <param name="h">Distance around a given point.</param>
        /// <param name="points">A given set of points.</param>
        /// <returns>Only points that are h-neighbors for a point with integer coordinates x and y.</returns>
        /// <exception cref="ArgumentNullException">Throw when array points is null.</exception>
        /// <exception cref="ArgumentException">Throw when h-distance is less or equals zero.</exception>
        public static Point[] GetNeighbors(Point point, int h, params Point[]? points)
        {
            if (h <= 0)
            {
                throw new ArgumentException(" ");
            }

            if (points == null)
            {
                throw new ArgumentNullException(nameof(point));
            }

            Point[] answer = Array.Empty<Point>();
            Point[] temp;
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i].X <= point.X + h && points[i].X >= point.X - h && points[i].Y <= point.Y + h && points[i].Y >= point.Y - h)
                {
                    temp = new Point[answer.Length + 1];
                    for (int j = 0; j < answer.Length; j++)
                    {
                        temp[j] = answer[j];
                    }

                    temp[temp.Length - 1] = points[i];
                    answer = temp;
                }
            }

            return answer;
        }
    }
}
