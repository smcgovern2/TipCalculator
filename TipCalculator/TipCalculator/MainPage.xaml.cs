﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
    }



        void OnButtonClicked(){

            Value.Text = (Double.Parse(Bill.Text) * Double.Parse(Percent.Text) / 100).ToString("#.##") ;


        }
    }
}
