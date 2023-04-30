using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryCode : ContentPage
    {
        public EntryCode()
        {
            InitializeComponent();
            StackLayout stack = new StackLayout();
            var entry = new Editor { Text = "This is a read-only Entry" };
            stack.Children.Add(entry);
            Content = stack;
        }
    }
}