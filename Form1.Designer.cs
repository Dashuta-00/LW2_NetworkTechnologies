
namespace ЛР2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.FIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carMark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stateSign = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parkingPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parkingCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parkingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.departureDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonFix = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FIO,
            this.carMark,
            this.carModel,
            this.stateSign,
            this.parkingPlace,
            this.parkingCost,
            this.parkingDate,
            this.departureDate});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 14);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1281, 437);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // FIO
            // 
            this.FIO.Text = "ФИО";
            this.FIO.Width = 200;
            // 
            // carMark
            // 
            this.carMark.Text = "Марка авто";
            this.carMark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.carMark.Width = 100;
            // 
            // carModel
            // 
            this.carModel.Text = "Модель авто";
            this.carModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.carModel.Width = 100;
            // 
            // stateSign
            // 
            this.stateSign.Text = "Гос. знак";
            this.stateSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stateSign.Width = 80;
            // 
            // parkingPlace
            // 
            this.parkingPlace.Text = "Место";
            this.parkingPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // parkingCost
            // 
            this.parkingCost.Text = "Стоимость";
            this.parkingCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // parkingDate
            // 
            this.parkingDate.Text = "Приезд";
            this.parkingDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.parkingDate.Width = 180;
            // 
            // departureDate
            // 
            this.departureDate.Text = "Отъезд";
            this.departureDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.departureDate.Width = 180;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(15, 457);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(424, 58);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonFix
            // 
            this.buttonFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFix.BackColor = System.Drawing.Color.Orange;
            this.buttonFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFix.Location = new System.Drawing.Point(444, 457);
            this.buttonFix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFix.Name = "buttonFix";
            this.buttonFix.Size = new System.Drawing.Size(424, 58);
            this.buttonFix.TabIndex = 1;
            this.buttonFix.Text = "Редактировать";
            this.buttonFix.UseVisualStyleBackColor = false;
            this.buttonFix.Click += new System.EventHandler(this.buttonFix_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDel.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(873, 457);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(424, 58);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1305, 528);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonFix);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonFix;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader FIO;
        private System.Windows.Forms.ColumnHeader carMark;
        private System.Windows.Forms.ColumnHeader carModel;
        private System.Windows.Forms.ColumnHeader stateSign;
        private System.Windows.Forms.ColumnHeader parkingPlace;
        private System.Windows.Forms.ColumnHeader parkingCost;
        private System.Windows.Forms.ColumnHeader parkingDate;
        private System.Windows.Forms.ColumnHeader departureDate;
    }
}

