using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Internals;

namespace Ejercicio03
{
    [Preserve(AllMembers = true)]
    [ContentProperty(nameof(Source))]
    public partial class ImageResourceExtension : ContentPage
    {
        public ImageResourceExtension()
        {
            InitializeComponent();
        }
    }
}