// using System;
// using System.Windows.Forms;

// namespace MyWinFormsApp
// {
//     public partial class Form1 : Form
//     {
//         private Button helloButton;

//         public Form1()
//         {
//             InitializeComponent();

//             // Create a new button
//             helloButton = new Button();
//             helloButton.Text = "Click Me";
//             helloButton.Size = new System.Drawing.Size(100, 40);
//             helloButton.Location = new System.Drawing.Point(150, 100);

//             // Add Click event handler
//             helloButton.Click += HelloButton_Click;

//             // Add the button to the form
//             this.Controls.Add(helloButton);
//         }

//         private void HelloButton_Click(object sender, EventArgs e)
//         {
//             MessageBox.Show("Hello, World!");
//         }
//     }
// }


// using System;
// using System.Windows.Forms;

// namespace MyWinFormsApp
// {
//     public partial class Form1 : Form
//     {
//         public Form1()
//         {
//             InitializeComponent();

//             // Register the MouseClick event for the Form
//             this.MouseClick += Form1_MouseClick;
//         }

//         private void Form1_MouseClick(object sender, MouseEventArgs e)
//         {
//             MessageBox.Show("Hello, World!", "Mouse Click Event");
//         }
//     }
// }


using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Register the MouseDoubleClick event for the Form
            this.MouseDoubleClick += Form1_MouseDoubleClick;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Change the background color randomly
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

            // Display Hello World message
            MessageBox.Show("Hello, World!", "Mouse Double Click Event");
        }
    }
}
