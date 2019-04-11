namespace CamperBookingSystem
{
    partial class UserMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViewBookings = new System.Windows.Forms.Button();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.btnViewCampers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewBookings
            // 
            this.btnViewBookings.Location = new System.Drawing.Point(84, 90);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Size = new System.Drawing.Size(157, 44);
            this.btnViewBookings.TabIndex = 0;
            this.btnViewBookings.Text = "View Bookings";
            this.btnViewBookings.UseVisualStyleBackColor = true;
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Location = new System.Drawing.Point(84, 27);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(157, 44);
            this.btnCreateBooking.TabIndex = 1;
            this.btnCreateBooking.Text = "Create Booking";
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // btnViewCampers
            // 
            this.btnViewCampers.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnViewCampers.Location = new System.Drawing.Point(84, 152);
            this.btnViewCampers.Name = "btnViewCampers";
            this.btnViewCampers.Size = new System.Drawing.Size(157, 44);
            this.btnViewCampers.TabIndex = 2;
            this.btnViewCampers.Text = "View Campers";
            this.btnViewCampers.UseVisualStyleBackColor = true;
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 219);
            this.Controls.Add(this.btnViewCampers);
            this.Controls.Add(this.btnCreateBooking);
            this.Controls.Add(this.btnViewBookings);
            this.Name = "UserMenu";
            this.Text = "Main Menu - User";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewBookings;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Button btnViewCampers;
    }
}