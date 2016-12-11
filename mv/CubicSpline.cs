using System;
using System.Collections.Generic;

namespace mv {
    public class CubicSpline {
        private SplineTuple[] splines;  //Отрезки сплайна
        private double[] xOriginal;     //Оригинальные x координаты
        private double[] yOriginal;     //Оригинальные y координаты



        //Структура, описывающая сплайн на каждом сегменте сетки
        private struct SplineTuple {
            public double a, b, c, d, x;
        }



        //Строит сплайн
        public void BuildSpline(double[] x, double[] y) {
            xOriginal = x;
            yOriginal = y;

            int n = x.Length;

            //Инициализация массива сплайнов
            splines = new SplineTuple[n];
            for (int i = 0; i < n; ++i) {
                splines[i].x = x[i];
                splines[i].a = y[i];
            }

            //Вычисление прогоночных коэффициентов - прямой ход метода прогонки
            double[] alpha = new double[n - 1];
            double[] beta = new double[n - 1];
            for (int i = 1; i < n - 1; i++) {
                double hi = x[i] - x[i - 1];
                double hi1 = x[i + 1] - x[i];
                double A = hi;
                double C = 2.0 * (hi + hi1);
                double B = hi1;
                double F = 6.0 * ((y[i + 1] - y[i]) / hi1 - (y[i] - y[i - 1]) / hi);
                double z = (A * alpha[i - 1] + C);
                alpha[i] = -B / z;
                beta[i] = (F - A * beta[i - 1]) / z;
            }

            //Нахождение решения - обратный ход метода прогонки
            for (int i = n - 2; i > 0; i--) {
                splines[i].c = alpha[i] * splines[i + 1].c + beta[i];
            }

            //По известным коэффициентам c[i] находим значения b[i] и d[i]
            for (int i = n - 1; i > 0; i--) {
                double hi = x[i] - x[i - 1];
                splines[i].d = (splines[i].c - splines[i - 1].c) / hi;
                splines[i].b = hi * (2.0 * splines[i].c + splines[i - 1].c) / 6.0 + (y[i] - y[i - 1]) / hi;
            }
        }

        //Возвращает значение интерполированной функции в переданной точке
        public double Interpolate(double x) {
            if (splines == null) {
                return double.NaN; //Если сплайны ещё не построены - возвращаем NaN
            }

            int n = splines.Length;
            SplineTuple s;

            if (x <= splines[0].x) {
                s = splines[0];
            } else if (x >= splines[n - 1].x) {
                s = splines[n - 1];
            } else {
                //Бинарный поиск сплайна
                int i = 0;
                int j = n - 1;
                while (i + 1 < j) {
                    int k = i + (j - i) / 2;
                    if (x <= splines[k].x) {
                        j = k;
                    } else {
                        i = k;
                    }
                }
                s = splines[j];
            }

            //Вычисляем значение сплайна в заданной точке
            double dx = x - s.x;
            return s.a + s.b * dx + s.c / 2 * Math.Pow(dx, 2) + s.d / 6 * Math.Pow(dx, 3);
        }

        //Возвращает миссив координат
        public double[][] GetPoints(int pointsPerUnit) {
            double start = xOriginal[0];
            double end = xOriginal[xOriginal.Length - 1];

            int xStart = (int)((start * pointsPerUnit) + 1);
            int xEnd = (int)((end * pointsPerUnit) - 1);

            List<double[]> result = new List<double[]>();
            result.Add(new double[] { start, Interpolate(start) });
            for (int i = xStart; i <= xEnd; i++) {
                double x = (double)i / pointsPerUnit;
                double y = Interpolate(x);
                result.Add(new double[] { x, y });
            }
            result.Add(new double[] { end, Interpolate(end) });

            return result.ToArray();
        }
    }
}
