namespace SimpleCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.answer = new System.Windows.Forms.TextBox();
            this.ansBtn = new System.Windows.Forms.Button();
            this.adder = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiplier = new System.Windows.Forms.Button();
            this.divider = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)), true);
            this.answer.ForeColor = System.Drawing.Color.Brown;
            this.answer.Location = new System.Drawing.Point(12, 3);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(409, 127);
            this.answer.TabIndex = 0;
            // 
            // ansBtn
            // 
            this.ansBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ansBtn.Location = new System.Drawing.Point(336, 246);
            this.ansBtn.Name = "ansBtn";
            this.ansBtn.Size = new System.Drawing.Size(85, 182);
            this.ansBtn.TabIndex = 1;
            this.ansBtn.Text = " =";
            this.ansBtn.UseVisualStyleBackColor = true;
            this.ansBtn.Click += new System.EventHandler(this.AnsBtn_Click);
            // 
            // adder
            // 
            this.adder.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.adder.Location = new System.Drawing.Point(255, 340);
            this.adder.Name = "adder";
            this.adder.Size = new System.Drawing.Size(75, 88);
            this.adder.TabIndex = 2;
            this.adder.Text = " +";
            this.adder.UseVisualStyleBackColor = true;
            this.adder.Click += new System.EventHandler(this.Adder_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.minus.Location = new System.Drawing.Point(255, 261);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 71);
            this.minus.TabIndex = 3;
            this.minus.Text = " -";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // multiplier
            // 
            this.multiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.multiplier.Location = new System.Drawing.Point(336, 206);
            this.multiplier.Name = "multiplier";
            this.multiplier.Size = new System.Drawing.Size(85, 32);
            this.multiplier.TabIndex = 4;
            this.multiplier.Text = " *";
            this.multiplier.UseVisualStyleBackColor = true;
            this.multiplier.Click += new System.EventHandler(this.Multiplier_Click);
            // 
            // divider
            // 
            this.divider.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.divider.Location = new System.Drawing.Point(255, 206);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(75, 49);
            this.divider.TabIndex = 5;
            this.divider.Text = " /";
            this.divider.UseVisualStyleBackColor = true;
            this.divider.Click += new System.EventHandler(this.Divider_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clearBtn.Location = new System.Drawing.Point(336, 136);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(85, 64);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = " C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.backBtn.Location = new System.Drawing.Point(255, 136);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 64);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.zero.Location = new System.Drawing.Point(12, 357);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(156, 71);
            this.zero.TabIndex = 8;
            this.zero.Text = " 0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.one.Location = new System.Drawing.Point(12, 280);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 71);
            this.one.TabIndex = 9;
            this.one.Text = " 1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.One_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.two.Location = new System.Drawing.Point(93, 280);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 71);
            this.two.TabIndex = 10;
            this.two.Text = " 2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Two_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.three.Location = new System.Drawing.Point(174, 280);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 71);
            this.three.TabIndex = 11;
            this.three.Text = " 3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Three_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.four.Location = new System.Drawing.Point(12, 206);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 68);
            this.four.TabIndex = 12;
            this.four.Text = " 4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Four_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.five.Location = new System.Drawing.Point(93, 206);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 68);
            this.five.TabIndex = 13;
            this.five.Text = " 5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Five_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.six.Location = new System.Drawing.Point(174, 206);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 68);
            this.six.TabIndex = 14;
            this.six.Text = " 6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Six_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.seven.Location = new System.Drawing.Point(12, 136);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 64);
            this.seven.TabIndex = 15;
            this.seven.Text = " 7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.eight.Location = new System.Drawing.Point(93, 136);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(75, 64);
            this.eight.TabIndex = 16;
            this.eight.Text = " 8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nine.Location = new System.Drawing.Point(174, 136);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(75, 64);
            this.nine.TabIndex = 17;
            this.nine.Text = " 9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dot.Location = new System.Drawing.Point(174, 357);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(75, 71);
            this.dot.TabIndex = 18;
            this.dot.Text = " .";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 436);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.multiplier);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.adder);
            this.Controls.Add(this.ansBtn);
            this.Controls.Add(this.answer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button ansBtn;
        private System.Windows.Forms.Button adder;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiplier;
        private System.Windows.Forms.Button divider;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button dot;
    }
}

