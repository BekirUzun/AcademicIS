﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AcademicIS {
    public partial class MainForm : Form {

        #region fix for draggable window variables
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        #endregion
        LoginForm loginForm;
        SearchForm searchForm;
        ProfileForm profileForm;
        ProfileEditForm addForm;
        bool isAdminLoggedIn;
        bool isLoading;

        public MainForm() {
            InitializeComponent();
            menu.Renderer = new CustomRenderer(); // appyle custom styles to menu
            spinner.Image = AcademicIS.Properties.Resources.spinner2;
            isLoading = true;
            isAdminLoggedIn = false;

            loadingText.Hide();
            loading.SetVisible(false);
            spinner.Hide();
            spinner.SendToBack();
            loadingText.SendToBack();
            isLoading = false;

            //ShowLoading();
            searchForm = new SearchForm();
            ActivateChildForm(searchForm, false);
            //ActivateChildForm(new ProfileForm());
            //ActivateChildForm(new ProfileEditForm());
            //FadeOutLoading(1000);

            //search form will call FadeOutLoading when its completely loaded.

        }

        #region fix for draggable window functions
        private void MainForm_MouseDown(object sender, MouseEventArgs e) {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e) {
            if (dragging) {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e) {
            dragging = false;
        }
        #endregion

        #region menu styling classes
        private class CustomRenderer : ToolStripProfessionalRenderer {
            public CustomRenderer() : base(new CustomColorTable()) { }
        }

        private class CustomColorTable : ProfessionalColorTable {
            public override Color MenuItemSelectedGradientBegin {
                get { return Color.FromArgb(39, 174, 96); }
            }
            public override Color MenuItemSelectedGradientEnd {
                get { return Color.FromArgb(30, 150, 78); }
            }
            public override Color MenuItemBorder {
                get { return Color.Transparent; }
            }
        }
        #endregion

        /// <summary>
        /// Fadeout loading screen with default delay (timeout) 
        /// </summary>
        public void FadeOutLoading() {
            FadeOutLoading(200);
        }

        /// <summary>
        /// Fadeout loading screen with custom delay
        /// </summary>
        /// <param name="msDelay">timeout in miliseconds to start fading out</param>
        private void FadeOutLoading(int msDelay) {
            if (isLoading) {
                delay.Interval = msDelay;
                delay.Start();
            }
        }

        /// <summary>
        /// Fade outs loading screen. Intented to use with delay.
        /// Do not use this directly. It may cause visual glitchs.
        /// </summary>
        private void StartFadeOut() {
            spinner.Hide();
            spinner.SendToBack();
            loadingText.Hide();
            loadingText.SendToBack();
            loading.FadeOut(false);
            isLoading = false;
        }

        /// <summary>
        /// Instantly shows loading page.
        /// </summary>
        private void ShowLoading() {
            if (!isLoading) {
                loadingText.Show();
                loading.SetVisible(true);
                spinner.Show();
                spinner.BringToFront();
                loadingText.BringToFront();
                isLoading = true;
            }
        }

        /// <summary>
        /// Activates child form and closes other forms.
        /// </summary>
        /// <param name="_newChildForm"></param>
        /// <param name="dispose">true if we want to dispose other child forms</param>
        private void ActivateChildForm(Form _newChildForm, bool dispose) {
            foreach (Form frm in this.MdiChildren) {
                if (frm.Text != _newChildForm.Text) {
                    if (dispose) {
                        frm.Close();
                        frm.Dispose();
                    }
                    else {
                        frm.Hide();
                    }
                }
            }
            _newChildForm.MdiParent = this;
            _newChildForm.StartPosition = FormStartPosition.Manual;
            _newChildForm.Location = new Point(0, 70); //offset for custom header
            _newChildForm.Show();
            _newChildForm.Activate();
        }

        private void menuSearch_Click(object sender, EventArgs e) {
            ShowLoading();
            if (searchForm == null || searchForm.IsDisposed) {
                //search form is not initialized yet or its closed
                searchForm = new SearchForm();
                ActivateChildForm(searchForm, true);
                //search form will call FadeOutLoading when its completely loaded.
            }
            else {
                ActivateChildForm(searchForm, true);

                //search form wont call FadeOutLoading because its allready loaded!
                //so lets call it manually.
                FadeOutLoading();
            }
            
        }

        private void menuLogin_Click(object sender, EventArgs e) {

            if (!isAdminLoggedIn)
            {
                ShowLoading();
                loginForm = new LoginForm();
                ActivateChildForm(loginForm, false);
                FadeOutLoading();
            }
        }

        private void delay_Tick(object sender, EventArgs e) {
            StartFadeOut();
            delay.Stop();
        }

        private void addAcademcian_Click(object sender, EventArgs e)
        {
            ShowLoading();
            addForm = new ProfileEditForm();
            ActivateChildForm(addForm, false); //other forms wont be disposed
            FadeOutLoading();
        }

        /// <summary>
        /// This function will be called from LoginForm after admin
        /// succesfully logged in.
        /// </summary>
        public void HideLoginButton()
        {
            ShowLoading();
            isAdminLoggedIn = true;
            menuLogin.Visible = false;
            menuLogin.Enabled = false;
            menuLogin.Dispose();
            addAcademcian.Visible = true;
            addForm = new ProfileEditForm();

            //all other forms will be disposed.
            //because we have to recreate them for administration options.
            ActivateChildForm(addForm, true); 

            FadeOutLoading();
        }

        /// <summary>
        /// Opens academician profile with given academician id
        /// </summary>
        /// <param name="id">identifier of academician</param>
        public void ShowProfileForm(int id) {
            ShowLoading();
            profileForm = new ProfileForm(id);

            //search form wont be disposed. because we want to keep last search
            ActivateChildForm(profileForm, false); 

            FadeOutLoading();

        }

    }
}
