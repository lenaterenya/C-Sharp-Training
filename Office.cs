namespace HW7
{
    class Office
    {
        internal object roomSpare;

        public string Address { get; private set; }
        public int Length { get; private set; }
        public int Width { get; private set; }
        public Office(string address, int length, int width)
        {
            Address = address;
            Length = length;
            Width = width;
        }
        public string GetFullOfficeInfo()
        {
            return Address + ", " + "Length: " + Length.ToString() + " " + "Width: " + Width.ToString() + " " + "Room Spare: " + Length*Width + '\n';
        }

    }
}

