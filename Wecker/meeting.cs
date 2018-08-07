using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wecker
{
    class Meeting
    {
        string title;
        int h;
        int m;

        public Meeting(string title, int h, int m)
        {
            this.title = title;
            this.h = h;
            this.m = m;
        }

        public override string ToString()
        {
            string s = h.ToString("D2") + ":" + m.ToString("D2") + " - " + title;
            return s;
            
        }

        public virtual void Wake()
        {
            

        }

    }

    class MeetingColor : Meeting
    {
        public MeetingColor(string title, int h, int m) : base(title, h, m)
        {
            
        }

        public override void Wake()
        {
            base.Wake();  //TODO FARBE ÄNDERN
        }

    }

    class MeetingSound : Meeting
    {
        public MeetingSound(string title, int h, int m) : base(title, h, m)
        {
        }

        public override void Wake()
        {
            System.Media.SystemSounds.Beep.Play();
        }
    }
}
