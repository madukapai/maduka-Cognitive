using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CognitiveModels
    {

        public class Error
        {
            public string code { get; set; }
            public string message { get; set; }
        }


        public class FaceDetection
        {
            public string status { get; set; }
            public float progress { get; set; }
            public DateTime createdDateTime { get; set; }
            public DateTime lastActionDateTime { get; set; }
            public string processingResult { get; set; }
        }


        public class FaceDetectionResult
        {
            public int version { get; set; }
            public int timescale { get; set; }
            public int offset { get; set; }
            public decimal framerate { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public Fragment[] fragments { get; set; }
            public Facesdetected[] facesDetected { get; set; }

            public class Fragment
            {
                public int start { get; set; }
                public int duration { get; set; }
                public int interval { get; set; }
                public Event[][] events { get; set; }
            }

            public class Event
            {
                public int id { get; set; }
                public float x { get; set; }
                public float y { get; set; }
                public float width { get; set; }
                public float height { get; set; }
            }

            public class Facesdetected
            {
                public int faceId { get; set; }
            }
        }

        public class FaceDetectionEvent
        {
            public int start { get; set; }
            public int duration { get; set; }
            public int interval { get; set; }
            public int id { get; set; }
            public float x { get; set; }
            public float y { get; set; }
            public float width { get; set; }
            public float height { get; set; }
        }
    }
}
