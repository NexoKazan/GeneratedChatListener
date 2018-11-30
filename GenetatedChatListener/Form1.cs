using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4;
using Antlr4.Runtime.Tree;

namespace GenetatedChatListener
{
    public partial class Form1 : Form
    {
        string output;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString = textBox1.Text;
            ICharStream inputStream = new AntlrInputStream(inputString.ToString());
            ITokenSource speakLexer = new SpeakLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(speakLexer);
            SpeakParser speakParser = new SpeakParser(commonTokenStream);
            speakParser.BuildParseTree = true;
            IParseTree tree = speakParser.chat();
            MyListener l = new MyListener();
            speakParser.line();        
            output = l.line;
            textBox1.Text = output;
        }
    }
}
