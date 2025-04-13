using System;
using System.Drawing;
using System.Windows.Forms;

public class BlockGameApp : Form
{
    private Button[] blocks = new Button[5];
    private Button restartButton;
    private int[] blockValues = new int[5]; // 1 for correct, 0 for wrong
    private int correctClicks = 0;

    public BlockGameApp()
    {
        this.Text = "Block Game";
        this.Size = new Size(400, 300);

        InitializeGame();
    }

    private void InitializeGame()
    {
        RandomizeBlocks();

        for (int i = 0; i < 5; i++)
        {
            blocks[i] = new Button
            {
                Size = new Size(60, 60),
                Location = new Point(50 + (i * 70), 80),
                BackColor = Color.Gray,
                Tag = i
            };
            blocks[i].Click += Block_Click;
            this.Controls.Add(blocks[i]);
        }

        restartButton = new Button
        {
            Text = "Restart",
            Size = new Size(80, 40),
            Location = new Point(150, 180)
        };
        restartButton.Click += (s, e) => ResetGame();
        this.Controls.Add(restartButton);
    }

    private void RandomizeBlocks()
    {
        Random rnd = new Random();
        blockValues = new int[5];
        int wrongIndex = rnd.Next(5);
        blockValues[wrongIndex] = 0; // Assign wrong block
        int count = 0;
        for (int i = 0; i < 5; i++)
        {
            if (i != wrongIndex)
            {
                blockValues[i] = 1;
                count++;
                if (count == 4) break;
            }
        }
    }

    private void Block_Click(object sender, EventArgs e)
    {
        Button clickedButton = sender as Button;
        int index = (int)clickedButton.Tag;

        if (blockValues[index] == 1)
        {
            clickedButton.BackColor = Color.Green;
            correctClicks++;
            if (correctClicks == 4)
            {
                MessageBox.Show("Wow! You won!");
                ResetGame();
            }
        }
        else
        {
            clickedButton.BackColor = Color.Red;
            MessageBox.Show("Game Over! You clicked the wrong block.");
            ResetGame();
        }
    }

    private void ResetGame()
    {
        correctClicks = 0;
        RandomizeBlocks();
        foreach (var btn in blocks)
        {
            btn.BackColor = Color.Gray;
        }
    }

    [STAThread]
    public static void Main()
    {
        Application.Run(new BlockGameApp());
    }
}
