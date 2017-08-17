using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Linlin Han
 * Date: Aug 17, 2017
 * StudentID: 300883493
 * Description: This is the ScoreBoard class
 * Version: 0.1-Create the ScoreBoard class
 */

namespace COMP123_S2017FinalExam_300883493
{
    public class ScoreBoard
    {
        // PRIVATE INSTANCE VARIABLES
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        // PUBLIC PROPERTIES
        public TextBox FinalScoreTextBox {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox =value;
            }
        }

        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                ScoreTextBox.Text = this._score.ToString();
                FinalScoreTextBox.Text = this._score.ToString();

            }
        }

        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }

        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                TimeTextBox.Text = this._time.ToString();

            }
        }

        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }

        // CONSTRUCTORS
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }

        // PUBLIC METHODS
        /// <summary>
        /// this method update the time value
        /// </summary>
        public void UpdateTime()
        {
            this.Time = int.Parse(TimeTextBox.Text) - 1;
            TimeTextBox.Text = this.Time.ToString();
        }
    }
}
