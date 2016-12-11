using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace mv {
    public partial class MainForm : Form {

        private CubicSpline cs;             //Сплайн

        private double[][] source;          //Исходные координаты
        private double[][] result;          //Координаты интерполяции
        private double maxX;                //Максимальный X для масштабирования
        private double maxY;                //Максимальный Y для масштабирования

        private DataGridViewCell lastSelectedCell;



        public MainForm() {
            InitializeComponent();

            updateColumnCount();
            tblPoints.RowCount = 2;
            tblPoints.Rows[0].Cells[0].Value = "X";
            tblPoints.Rows[1].Cells[0].Value = "Y";

            tblPoints.Columns[0].ReadOnly = true;
            tblPoints.Columns[0].Frozen = true;
            tblPoints.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tblPoints.Columns[0].Width = 30;
            tblPoints.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tblPoints.Columns[0].DefaultCellStyle.Font = new Font(tblPoints.Font, FontStyle.Bold);
            tblPoints.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;

            cbSourceVisible.ForeColor = Settings.SourceLinePen.Color;
            cbSplineVisible.ForeColor = Settings.SplineLinePen.Color;
        }


        //Возвращает валидные данные из таблицы
        private double[][] getData() {
            List<double[]> data = new List<double[]>();

            double maxX = double.MinValue;

            for (int i = 1; i < tblPoints.ColumnCount; i++) {
                object x = tblPoints.Rows[0].Cells[i].Value;
                object y = tblPoints.Rows[1].Cells[i].Value;

                if (x == null || y == null || (double)x <= maxX) {
                    continue;
                }

                data.Add(new double[] { (double)x, (double)y });
            }

            return data.ToArray();
        }

        //Расчитывает сплайны
        private void updateSplines() {
            source = getData();

            if (source.Length == 0) {
                cs = null;
                return;
            }

            double[] x = new double[source.Length];
            double[] y = new double[source.Length];
            for (int i = 0; i < source.Length; i++) {
                x[i] = source[i][0];
                y[i] = source[i][1];
            }

            cs = new CubicSpline();
            cs.BuildSpline(x, y);
        }

        //Расчитывает координаты точек сплайнов
        private void updatePoints() {
            if (cs == null) {
                result = null;
                return;
            }

            //Получаем точки
            result = cs.GetPoints((int)nudSegmentation.Value);

            //Вычисляем максимальные координаты по модулю
            maxX = double.MinValue;
            maxY = double.MinValue;
            foreach (double[] row in result) {
                if (Math.Abs(row[0]) > maxX) {
                    maxX = Math.Abs(row[0]);
                }
                if (Math.Abs(row[1]) > maxY) {
                    maxY = Math.Abs(row[1]);
                }
            }
            maxX = Math.Ceiling(maxX);
            maxY = Math.Ceiling(maxY);

            //Выводим координаты в консоль
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++) {
                sb.Append("X: " + Math.Round(result[i][0], 3) + ";\tY: " + Math.Round(result[i][1], 3) + "\n");
            }
            rtbConsole.Text = sb.ToString();

            //Перерисовываем график
            pbView.Refresh();
        }



        //Задает количество столбцов
        private void updateColumnCount() {
            tblPoints.ColumnCount = (int)nudPointsCount.Value + 1;
            for (int i = 1; i < tblPoints.ColumnCount; i++) {
                tblPoints.Columns[i].MinimumWidth = 60;
            }
        }

        //Задает высоту строк таблицы
        private void updateRowsHeight() {
            int rowHeight = 30 + (tblPoints.ColumnCount - 1) * 60 > tblPoints.Width ? 19 : 28;
            foreach (DataGridViewRow row in tblPoints.Rows) {
                row.Height = rowHeight;
            }
        }

        //Проверяет и задает цвет ячеек таблицы
        private void updateCellErrors() {
            double maxX = double.MinValue;

            for (int i = 1; i < tblPoints.ColumnCount; i++) {
                object x = tblPoints.Rows[0].Cells[i].Value;

                if (x != null && (double)x <= maxX) {
                    tblPoints.Columns[i].DefaultCellStyle.BackColor = Settings.ErrorColor;
                } else {
                    tblPoints.Columns[i].DefaultCellStyle.BackColor = Color.White;
                    if (x != null) {
                        maxX = (double)x;
                    }
                }
            }
        }



        //Рисует координатные оси
        private void drawAxis(Graphics g, int width, int height, int padding) {
            //Центр отображения
            int centerX = width / 2;
            int centerY = height / 2;

            //Оси координат
            g.DrawLine(Settings.AxisPen, new Point(padding, centerY), new Point(width - padding, centerY));
            g.DrawLine(Settings.AxisPen, new Point(centerX, padding), new Point(centerX, height - padding));
        }

        //Рисует сетку
        private void drawNet(Graphics g, int width, int height, double maxX, double maxY, int padding) {
            //Центр отображения
            int centerX = width / 2;
            int centerY = height / 2;

            //Коэффициенты для масштабирования
            double kx = (centerX - padding) / maxX;
            double ky = (centerY - padding) / maxY;

            //Количество линий
            int countX = (int)Math.Ceiling(maxX);
            int countY = (int)Math.Ceiling(maxY);

            //Вертикальные линии
            for (int i = 0; i <= countX; i++) {
                int x = (int)(centerX + (i * kx));
                g.DrawLine(Settings.NetPen, new Point(x, padding), new Point(x, height - padding));
                x = (int)(centerX + (-i * kx));
                g.DrawLine(Settings.NetPen, new Point(x, padding), new Point(x, height - padding));
            }

            //Горизонтальные линии
            for (int i = 0; i <= countY; i++) {
                int y = (int)(centerY + (i * ky));
                g.DrawLine(Settings.NetPen, new Point(padding, y), new Point(width - padding, y));
                y = (int)(centerY + (-i * ky));
                g.DrawLine(Settings.NetPen, new Point(padding, y), new Point(width - padding, y));
            }
        }

        //Рисует кривую
        private void drawLine(double[][] values, Graphics g, Pen pen, int width, int height, double maxX, double maxY, int padding) {
            //Центр отображения
            int centerX = width / 2;
            int centerY = height / 2;

            //Коэффициенты для масштабирования
            double kx = (centerX - padding) / maxX;
            double ky = (centerY - padding) / maxY;

            //Создаем точки
            PointF[] points = new PointF[values.Length];
            for (int i = 0; i < values.Length; i++) {
                points[i] = new PointF(
                    (float)(centerX + values[i][0] * kx),
                    (float)(centerY - values[i][1] * ky)
                );
            }

            g.DrawLines(pen, points);
        }



        //Событие клика по кнопке Применить
        private void btnApplyPountsCount_Click(object sender, EventArgs e) {
            btnApplyPountsCount.Enabled = false;

            updateColumnCount();
            updateRowsHeight();
            updateSplines();
            updatePoints();
        }

        //Событие клика по кнопке Случайное заполнение
        private void btnRandom_Click(object sender, EventArgs e) {
            Random rand = new Random(7);
            Random markRandom = new Random(8);

            int x = -(tblPoints.ColumnCount - 1) / 2;
            if ((tblPoints.ColumnCount - 1) % 2 == 0)
                x++;

            for (int i = 1; i < tblPoints.ColumnCount; i++) {
                tblPoints.Rows[0].Cells[i].Value = (double)x;

                double y = rand.NextDouble() * 10;
                if (markRandom.Next() % 5 == 0) {
                    y = -y;
                }

                tblPoints.Rows[1].Cells[i].Value = y;

                x++;
            }

            updateSplines();
            updatePoints();
        }

        //Событие изменения значения сегментации
        private void nudSegmentation_ValueChanged(object sender, EventArgs e) {
            updatePoints();
        }

        //Событие изменения количества точек
        private void nudPointsCount_ValueChanged(object sender, EventArgs e) {
            btnApplyPountsCount.Enabled = nudPointsCount.Value != tblPoints.ColumnCount - 1;
        }

        //Событие отрисовки
        private void pbView_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            g.FillRectangle(Brushes.White, 0, 0, pbView.Width, pbView.Height);

            if (source == null || source.Length < 2) {
                drawAxis(g, pbView.Width, pbView.Height, Settings.ViewPadding);
                return;
            }

            drawNet(g, pbView.Width, pbView.Height, maxX, maxY, Settings.ViewPadding);
            drawAxis(g, pbView.Width, pbView.Height, Settings.ViewPadding);

            if (cbSourceVisible.Checked) {
                drawLine(source, g, Settings.SourceLinePen, pbView.Width, pbView.Height, maxX, maxY, Settings.ViewPadding);
            }
            if (cbSplineVisible.Checked) {
                drawLine(result, g, Settings.SplineLinePen, pbView.Width, pbView.Height, maxX, maxY, Settings.ViewPadding);
            }
        }



        //Событие выделения ячейки
        private void tblPoints_SelectionChanged(object sender, EventArgs e) {
            if (tblPoints.CurrentCell.ColumnIndex == 0) {
                tblPoints.CurrentCell.Selected = false;
                if (lastSelectedCell != null) {
                    tblPoints.CurrentCell = lastSelectedCell;
                    lastSelectedCell.Selected = true;
                }
            } else {
                lastSelectedCell = tblPoints.CurrentCell;
            }
        }

        //Событие открытия редактирования ячейки
        private void tblPoints_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
            DataGridView table = sender as DataGridView;
            e.Control.KeyPress -= new KeyPressEventHandler(tblPoints_KeyPress);
            TextBox tb = e.Control as TextBox;
            if (tb != null) {
                tb.KeyPress += new KeyPressEventHandler(tblPoints_KeyPress);
            }
        }

        //Событие нажатия клавиши при редактировании ячейки
        private void tblPoints_KeyPress(object sender, KeyPressEventArgs e) {
            TextBox tb = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                try {
                    double.Parse(tb.Text + e.KeyChar);
                } catch (Exception ext) {
                    e.Handled = true;
                }
            }
        }

        //Событие завершения редактирования ячейки
        private void tblPoints_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            DataGridViewCell cell = tblPoints.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value != null) {
                string value = cell.Value.ToString();
                if (value.Length != 0) {
                    cell.Value = double.Parse(value);
                }
            }

            updateCellErrors();
            updateSplines();
            updatePoints();
        }



        //Событие изменения размера формы
        private void MainForm_Resize(object sender, EventArgs e) {
            updateRowsHeight();
            pbView.Refresh();
        }

        //Событие изменения состояния флажков отображения
        private void cbVisible_CheckedChanged(object sender, EventArgs e) {
            if (!cbSourceVisible.Checked && !cbSplineVisible.Checked) {
                (sender as CheckBox).Checked = true;
            }
            pbView.Refresh();
        }
    }
}
