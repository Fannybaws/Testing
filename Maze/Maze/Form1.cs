using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        // This SoundPlayer plays a sound whenever the player hits a wall.
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");

        // This SoundPlayer plays a sound when the player finishes the game.
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");

        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            // Show a congratulatory MessageBox, then close the form.
            finishSoundPlayer.Play();
            MessageBox.Show("Congratulations!");
            Close();

        }

        /// <summary>
        /// Move the pointer to a point 10 pixels down and to the right
        /// of the starting point in the upper-left corner of the maze.
        /// </summary>
        private void MoveToStart()
        {
            startSoundPlayer.Play();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            // When the mouse pointer hits a wall or enters the panel,
            // call the MoveToStart() method.
            MoveToStart();
        }
    }
}
