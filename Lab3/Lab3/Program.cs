using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Point
    {
        int x;
        int y;
        char sym;

        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                this.x = 0;
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                this.y = 0;
        }
        public void SetSym(char symbol)
        {
            sym = symbol;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point line = new Point();
            line.SetX(6);
            line.SetY(1);
            line.SetSym('*');
            line.Draw();

            ///////////1/////////////

            line.SetX(5);
            line.SetY(2);
            line.SetSym('/');
            line.Draw();

            line.SetX(6);
            line.SetY(2);
            line.SetSym('|');
            line.Draw();
            
            line.SetX(7);
            line.SetY(2);
            line.SetSym('\\');
            line.Draw();

            ///////////2////////////////////

            line.SetX(4);
            line.SetY(3);
            line.SetSym('/');
            line.Draw();

            line.SetX(5);
            line.SetY(3);
            line.SetSym('@');
            line.Draw();

            line.SetX(6);
            line.SetY(3);
            line.SetSym('|');
            line.Draw();

            line.SetX(7);
            line.SetY(3);
            line.SetSym('\\');
            line.Draw();

            line.SetX(8);
            line.Draw();
           
            ////////3//////////////////


            line.SetX(4);
            line.SetY(4);
            line.SetSym('/');
            line.Draw();

            line.SetX(3);
            line.Draw();  
            
            line.SetX(5);
            line.Draw();

            line.SetX(6);
            line.SetY(4);
            line.SetSym('|');
            line.Draw();

            line.SetX(7);
            line.SetY(4);
            line.SetSym('\\');
            line.Draw();

            line.SetX(9);
            line.Draw();

            line.SetX(8);
            line.SetY(4);
            line.SetSym('@');
            line.Draw();

            ////////4/////////

            line.SetX(2);
            line.SetY(5);
            line.SetSym('@');
            line.Draw();
            
            line.SetX(3);
            line.SetY(5);
            line.SetSym('/');
            line.Draw();

            line.SetX(4);
            line.Draw();

            line.SetX(5);
            line.Draw();

            line.SetX(6);
            line.SetY(5);
            line.SetSym('|');
            line.Draw();

            line.SetX(7);
            line.SetY(5);
            line.SetSym('\\');
            line.Draw();

            line.SetX(8);
            line.Draw();

            line.SetX(9);
            line.Draw();

            line.SetX(10);
            line.Draw();

            ////////5////////////

            line.SetX(1);
            line.SetY(6);
            line.SetSym('/');
            line.Draw();

            line.SetX(2);
            line.Draw();

            line.SetX(3);
            line.Draw();

            line.SetX(4);
            line.Draw();

            line.SetX(5);
            line.Draw();

            line.SetX(6);
            line.SetY(6);
            line.SetSym('|');
            line.Draw();

            line.SetX(7);
            line.SetY(6);
            line.SetSym('\\');
            line.Draw();

            line.SetX(8);
            line.Draw();

            line.SetX(10);
            line.Draw();

            line.SetX(11);
            line.Draw();

            line.SetX(9);
            line.SetY(6);
            line.SetSym('@');
            line.Draw();

            /////////6//////////

            line.SetX(6);
            line.SetY(7);
            line.SetSym('|');
            line.Draw();

            line.SetX(3);
            line.SetY(8);
            line.SetSym('$');
            line.Draw();

            line.SetX(4);
            line.Draw();

            line.SetX(3);
            line.SetY(7);
            line.SetSym('_');
            line.Draw();

            line.SetX(4);
            line.Draw();

            line.SetX(6);
            line.SetY(8);
            line.SetSym('|');
            line.Draw();

            line.SetX(8);
            line.SetY(8);
            line.SetSym('$');
            line.Draw();

            line.SetX(9);
            line.Draw();

            line.SetX(8);
            line.SetY(7);
            line.SetSym('_');
            line.Draw();

            line.SetX(9);
            line.Draw();

            /////////78/////////

            line.SetX(0);
            line.SetY(9);
            line.SetSym('*');
            line.Draw();

            line.SetX(1);
            line.Draw();

            line.SetX(2);
            line.Draw();

            line.SetX(3);
            line.Draw();

            line.SetX(4);
            line.Draw();

            line.SetX(5);
            line.Draw();

            line.SetX(6);
            line.Draw();

            line.SetX(7);
            line.Draw();

            line.SetX(8);
            line.Draw();

            line.SetX(9);
            line.Draw();

            line.SetX(10);
            line.Draw();

            line.SetX(11);
            line.Draw();

            line.SetX(12);
            line.Draw();
            Console.ReadKey();

        }
    }
}
