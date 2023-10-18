﻿using System;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шахматииии.Classes
{
    public int X { get; set;}
    public int Y { get; set; }
    public bool Select = false;
    public bool Black = false;
    public Grid Figure { get; set;  }
    public Pawn(int X, int Y, bool Black)
    {
        this.X = X;
        this.Y = Y;
        this.Black = Black;
    }
    public void SelectFigure(object sender, MousButtonEventArgs e)
    {
        bool atack = false;
        Pawn SelectPawn = MainWindow.mainWindow.Pawn.Find(AlignmentX => x.Select == true);
        if (SelectPawn != null)
        {
            if (this.Black && this.Y - 1 ==SelectPawn.Y && (this.X - 1 == SelectPawn.X || this.X == SelectPawn.X || this.X + 1 ==SelectPawn.X) || 
                !this.Black && this.Y + 1 == SelectPawn.Y && (this.X - 1 == SelectPawn.X || this.X == SelectPawn.X || this.X +1 ==SelectPawn.X))
            {
                MainWindow.mainWindow.gameBoard.Children.Remove(this.Figure);
                Grid.SetColumn(SelectPawn.Figure, this.X);
                Grid.SetRow(SelectPawn.Figure, this.Y);
                SelectPawn.X = this.X;
                SelectPawn.Y = this.Y;
                SelectPawn.SelectFigure(null, null);
                atack = true;
            }
        }
        if (!atack)
        {

        }
    }
}
