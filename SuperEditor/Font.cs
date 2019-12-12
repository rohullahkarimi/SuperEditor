using System;

namespace NotePaadi1
{
    internal class Font
    {
        private string v1;
        private int v2;

        public Font(string v1, float v, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public static implicit operator double(Font v)
        {
            throw new NotImplementedException();
        }
    }
}