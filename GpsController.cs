using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Device.Location;

namespace RedSocial
{
    public class GpsController
    {

        private static GeoCoordinateWatcher geoWatcher;
        public delegate void LocationHandler
            (object sender, 
            GeoCoordinate myArgs);
        public static event LocationHandler OnLocationChanged;

        public static void initializeGps()
        {
            geoWatcher = new GeoCoordinateWatcher();
            geoWatcher.PositionChanged += 
                new EventHandler
                    <GeoPositionChangedEventArgs
                    <GeoCoordinate>>
                    (geoWatcher_PositionChanged);
            geoWatcher.MovementThreshold = 5;
        }

        public static void startThread()
        {
            if (geoWatcher == null)
            {
                initializeGps();
            }
            geoWatcher.Start();
        }

        public static void stopThread()
        {
            if (geoWatcher != null)
            {
                geoWatcher.Stop();
            }
        }

        static void geoWatcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            OnLocationChanged(sender, e.Position.Location);
        }


    }
}
