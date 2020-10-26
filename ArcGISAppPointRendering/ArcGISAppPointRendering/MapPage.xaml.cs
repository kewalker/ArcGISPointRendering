using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Portal;
using Esri.ArcGISRuntime.Security;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ArcGISAppPointRendering
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
            Startup();
        }

        private async void Startup()
        {
            var item = await PortalItem.CreateAsync(new Uri("https://latitudegeo.maps.arcgis.com/home/item.html?id=2655d105a5944426a4c48c044b93fdd1"));
            TheMap.Map = new Map(item);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var item = await PortalItem.CreateAsync(new Uri("https://latitudegeo.maps.arcgis.com/home/item.html?id=2655d105a5944426a4c48c044b93fdd1"));
            TheMap.Map = new Map(item);
        }
    }
}
