using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace mission5.Models
{
    public class Grade
    {
        // required values, with associated range 0-100
        [Required]
        [Range(0.0, 100.0, ErrorMessage = "Assignments must be between 0 and 100")]
        public double Assignments { get; set; }

        [Required]
        [Range(0.0, 100.0, ErrorMessage = "Group Projects must be between 0 and 100")]
        public double GroupProjects { get; set; }

        [Required]
        [Range(0.0, 100.0, ErrorMessage = "Quizzes must be between 0 and 100")]
        public double Quizzes { get; set; }

        [Required]
        [Range(0.0, 100.0, ErrorMessage = "Miderm must be between 0 and 100")]
        public double Midterm { get; set; }

        [Required]
        [Range(0.0, 100.0, ErrorMessage = "Final must be between 0 and 100")]
        public double Final { get; set; }

        [Required]
        [Range(0.0, 100.0, ErrorMessage = "Intex must be between 0 and 100")]
        public double Intex { get; set; }

        // get the numeric grade
        public double NumericGrade
        {
            get
            {
                double Score = (Assignments * 0.5) + (GroupProjects * 0.1) + (Quizzes * 0.1) + (Midterm * 0.1) + (Final * 0.1) + (Intex * 0.1);
                return Score;
            }
        }
        
        // get the letter grade
        public string LetterGrade
        {
            get
            {
                double A = 94.0;
                double Am = 90.0;
                double Bp = 87.0;
                double B = 84.0;
                double Bm = 80.0;
                double Cp = 77.0;
                double C = 74.0;
                double Cm = 70.0;
                double Dp = 67.0;
                double D = 64.0;
                double Dm = 60.0;
                double Score = NumericGrade;
                string LetterGrade;

                if (Score >= A)
                {
                    LetterGrade = "A";
                }
                else if (Score >= Am)
                {
                    LetterGrade = "A-";
                }
                else if (Score >= Bp)
                {
                    LetterGrade = "B+";
                }
                else if (Score >= B)
                {
                    LetterGrade = "B";
                }
                else if (Score >= Bm)
                {
                    LetterGrade = "B-";
                }
                else if (Score >= Cp)
                {
                    LetterGrade = "C+";
                }
                else if (Score >= C)
                {
                    LetterGrade = "C";
                }
                else if (Score >= Cm)
                {
                    LetterGrade = "C-";
                }
                else if (Score >= Dp)
                {
                    LetterGrade = "D+";
                }
                else if (Score >= D)
                {
                    LetterGrade = "D";
                }
                else if (Score >= Dm)
                {
                    LetterGrade = "D-";
                }
                else
                {
                    LetterGrade = "E";
                }

                return LetterGrade;
            }
        }
    }
}
