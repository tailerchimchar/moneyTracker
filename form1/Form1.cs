using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace moneyTracker;

public partial class Form1 : Form
{
    private int counter;
    public Form1()
    {
        InitializeComponent();
        //submitOnClick();
    }

    private void Form1_Load(object sender, EventArgs e){
        counter = 0;
        
    }

    private void button1_click(object sender, EventArgs e){
        Console.WriteLine("HELLO!");
    }
    /*
    public void submitOnClick(){
        Button button = new Button(){
            Location = new Point(300,50),
            Text="HELLO"
        };
        button.Size = new Size(200,200);

        Controls.Add(button);
    }
    */
}
