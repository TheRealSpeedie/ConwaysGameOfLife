using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConwaysGameOfLife
{
    public partial class Form1 : Form
    {
        private int _padding = 1;
        private bool _isRunning = false;
        private int _generationCount = 0;
        private double _changedCellsRate = 0;

        private GameOfLife _gameOfLife;
        public Form1()
        {
            InitializeComponent();
            _gameOfLife = new GameOfLife();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                _isRunning = false;
                btn_start.Text = "▶ START";
                btn_start.BackColor = Color.FromArgb(100, 60, 180);
                btn_start.FlatAppearance.BorderColor = Color.FromArgb(100, 60, 180);
                btn_start.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 40, 160);
                btn_start.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 80, 200);
                timer.Stop();
            }
            else if (!_isRunning)
            {
                _isRunning = true;
                btn_start.Text = "⏸ PAUSE";
                btn_start.BackColor = Color.FromArgb(180, 118, 60);
                btn_start.FlatAppearance.BorderColor = Color.FromArgb(180, 112, 60);
                btn_start.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 92, 40);
                btn_start.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 130, 80);
                timer.Start();
            }
        }
        private void CreateNextGeneration()
        {
            var amountChangedCells = _gameOfLife.NextGeneration();
            if (amountChangedCells == 0)
            {
                _changedCellsRate = 0;
            }
            else
            {
                _changedCellsRate = (amountChangedCells * 100.0) / _gameOfLife.cells.Length;
            }
            panel_field.Invalidate();
            _generationCount++;
            UpdateLabels();
        }

        private void btn_step_Click(object sender, EventArgs e)
        {
            CreateNextGeneration();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void btn_random_Click(object sender, EventArgs e)
        {
            Reset();
            double probability = 0.3;
            var rnd = new Random();

            for (int row = 0; row < _gameOfLife.numOfCells; row++)
            {
                for (int col = 0; col < _gameOfLife.numOfCells; col++)
                {
                    _gameOfLife.cells[row, col] = rnd.NextDouble() < probability;
                }
            }
            panel_field.Invalidate();
        }

        private void btn_template_glider_Click(object sender, EventArgs e)
        {
            Reset();
            _gameOfLife.SetAlive(20, 19);
            _gameOfLife.SetAlive(20, 21);
            _gameOfLife.SetAlive(21, 20);
            _gameOfLife.SetAlive(21, 21);
            _gameOfLife.SetAlive(19, 21);
            panel_field.Invalidate();
        }

        private void btn_template_blink_Click(object sender, EventArgs e)
        {
            Reset();
            _gameOfLife.SetAlive(20, 20);
            _gameOfLife.SetAlive(19, 20);
            _gameOfLife.SetAlive(21, 20);
            panel_field.Invalidate();
        }

        // Template von ChatGPT
        private void btn_template_gun_Click(object sender, EventArgs e)
        {
            Reset();
            var gun = new List<(int, int)>
            {
                (5,1),(5,2),(6,1),(6,2),
                (3,13),(3,14),(4,12),(4,16),(5,11),(5,17),(6,11),(6,15),(6,17),(6,18),(7,11),(7,17),(8,12),(8,16),(9,13),(9,14),
                (1,25),(2,23),(2,25),(3,21),(3,22),(4,21),(4,22),(5,21),(5,22),(6,23),(6,25),(7,25),
                (3,35),(3,36),(4,35),(4,36)
            };
            foreach (var (r, c) in gun)
            {
                _gameOfLife.SetAlive(r, c);
            }
            panel_field.Invalidate();
        }

        private void btn_template_block_Click(object sender, EventArgs e)
        {
            Reset();
            _gameOfLife.SetAlive(20, 20);
            _gameOfLife.SetAlive(20, 21);
            _gameOfLife.SetAlive(19, 20);
            _gameOfLife.SetAlive(19, 21);
            panel_field.Invalidate();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CreateNextGeneration();
        }
        private void UpdateLabels()
        {
            lbl_generation.Text = _generationCount.ToString();
            lbl_changedCells.Text = _changedCellsRate.ToString("0.00") + "%";
            lbl_amountAliveCells.Text = _gameOfLife.cells.Cast<bool>().Count(c => c).ToString();
        }
        private void panel_field_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(ColorTranslator.FromHtml("#C8B4FF"));

            for (int y = 0; y < _gameOfLife.numOfCells; y++)
            {
                for (int x = 0; x < _gameOfLife.numOfCells; x++)
                {
                    if (_gameOfLife.cells[y, x])
                    {
                        Brush brush = new SolidBrush(ColorTranslator.FromHtml("#C8B4FF"));
                        graphics.FillRectangle(brush,
                            x * _gameOfLife.cellSize + _padding,
                            y * _gameOfLife.cellSize + _padding,
                            _gameOfLife.cellSize - 2 * _padding,
                            _gameOfLife.cellSize - 2 * _padding);
                    }
                }
            }
        }
        private void panel_field_MouseClick(object sender, MouseEventArgs e)
        {
            if (!_isRunning)
            {
                int col = e.X / _gameOfLife.cellSize;
                int row = e.Y / _gameOfLife.cellSize;

                if (_gameOfLife.IsAlive(row, col))
                    _gameOfLife.SetDead(row, col);
                else
                    _gameOfLife.SetAlive(row, col);

                panel_field.Invalidate();
            }
        }
        private void Reset()
        {
            _gameOfLife.ResetField();
            panel_field.Invalidate();

            _changedCellsRate = 0;
            _generationCount = 0;
            UpdateLabels();
        }
        private void trackbar_speed_ValueChanged(object sender, EventArgs e)
        {
            AdjustTimerSpeed(trackbar_speed.Value);
        }
        private void AdjustTimerSpeed(int speed)
        {
            int minInterval = 100;
            int maxInterval = 1000;

            int interval = maxInterval - (speed * (maxInterval - minInterval) / 10);

            timer.Interval = interval;
        }
    }
}

