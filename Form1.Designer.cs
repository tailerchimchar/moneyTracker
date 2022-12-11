namespace moneyTracker;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1000, 800);
        this.Text = "Form1";
        InitializeControls();
        InitializeButtons();
    }

    private void InitializeButtons(){
        //button1
        Button button1 = new Button(){
            Location = new Point(50, 600),
            Text = "Submit"
        };
        button1.DialogResult = DialogResult.OK;
        button1.Size = new Size(150,40);

        // Add the buttons to the form.
        Controls.Add(button1);
    }


    private void InitializeControls(){
        //Date
        Label label1 = new Label() {
            Text = "&Date",
            Location = new Point(50, 50),
            TabIndex = 10
        };
        TextBox field1 = new TextBox(){
            Location = new Point(label1.Location.X, label1.Bounds.Bottom + Padding.Top + 15),
            TabIndex = 15
        };

        //Total Expenditure
        Label label2 = new Label() {
            Text = "&Total Expenditure",
            Location = new Point(50, 200),
            TabIndex = 10
        };
        TextBox field2 = new TextBox(){
            Location = new Point(label1.Location.X, label2.Bounds.Bottom + Padding.Top + 15),
            TabIndex = 15
        };

        //Total Expenditure
        Label label3 = new Label() {
            Text = "&Category",
            Location = new Point(50, 350),
            TabIndex = 10
        };
        TextBox field3 = new TextBox(){
            Location = new Point(label1.Location.X, label3.Bounds.Bottom + Padding.Top + 15),
            TabIndex = 15
        };

        //Optional Description
        Label label4= new Label() {
            Text = "&(Optional) Description",
            Location = new Point(50, 500),
            TabIndex = 10
        };
        TextBox field4 = new TextBox(){
            Location = new Point(label1.Location.X, label4.Bounds.Bottom + Padding.Top + 15),
            TabIndex = 15
        };


        
        Controls.Add(label1);
        Controls.Add(field1);
        Controls.Add(label2);
        Controls.Add(field2);
        Controls.Add(label3);
        Controls.Add(field3);
        Controls.Add(label4);
        Controls.Add(field4);
    }
    #endregion
}
