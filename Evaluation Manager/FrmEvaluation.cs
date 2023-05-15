using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager {
    public partial class FrmEvaluation : Form {
        public Student SelectedStudent { get => student; set => student; }

        public FrmEvaluation() {
            InitializeComponent();
        }

        private void FrmEvaluation_Load(object sender, EventArgs e) {

        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e) {

            var currentActivity = cboActivities.SelectedItem as Activity;
            txtActivityDescription.Text = currentActivity.Description;
            txtMinForGrade.Text = currentActivity.MinPointsForGrade + "/" + currentActivity;
            txtMinForSignature.Text = currentActivity.MinPointsForSignature + "/" + currentActivity;

            numPoints.Minimum = 0;
            numPoints.Maximum = currentActivity.MaxPoints;

            var evaluation = EvaluationRepository.GetEvaluation(SelectedStudent, currentActivity);
            if(evaluation != null) {
                txtTeacher.Text = evaluation.Evaluator.ToString();
                txtEvaluationDate = evaluation.EvaluationDate.ToString();
                numPoints.Value = evaluation.Points;
            }
            else {
                txtTeacher.Text = FrmLogin.LoggedTeacher.ToString();
                txtEvaluationDate.Text = "-";
                numPoints.Value = 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            var activity = cboActivities.SelectedItem as Activity;
            var teacher = FrmLogin.LoggedTeacher;

            int points = (int)numPoints.Value;

            teacher.PerformEvaluation(SelectedStudent, activity, points);
            Close();
        }
    }
}
