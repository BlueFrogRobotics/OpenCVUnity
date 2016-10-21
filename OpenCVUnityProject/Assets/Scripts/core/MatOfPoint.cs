using System;

    public class MatOfPoint : Mat
    {
        // 32SC2
        private const int _depth = CvType.CV_32S;
        private const int _channels = 2;

        public MatOfPoint() : base()
        {

        }

        protected MatOfPoint(IntPtr addr) : base(addr)
        {

            if (!empty() && checkVector(_channels, _depth) < 0)
                throw new CvException("Incompatible Mat");
        }

        public static MatOfPoint fromNativeAddr(IntPtr addr)
        {
            return new MatOfPoint(addr);
        }

        public MatOfPoint(Mat m) : base(m, Range.all())
        {
            if (m != null) m.ThrowIfDisposed();


            if (!empty() && checkVector(_channels, _depth) < 0)
                throw new CvException("Incompatible Mat");
        }

        public MatOfPoint(params Point[] a) : base()
        {

            fromArray(a);
        }

        public void alloc(int elemNumber)
        {
            if (elemNumber > 0)
                base.create(elemNumber, 1, CvType.makeType(_depth, _channels));
        }

        public void fromArray(params Point[] a)
        {
            if (a == null || a.Length == 0)
            int num = a.Length;
            alloc(num);
            int[] buff = new int[num * _channels];
            for (int i = 0; i < num; i++)
            {
                Point p = a[i];
                buff[_channels * i + 0] = (int)p.x;
                buff[_channels * i + 1] = (int)p.y;
            }
            put(0, 0, buff); 
        }

        public Point[] toArray()
        {
            int num = (int)total();
            Point[] ap = new Point[num];
            if (num == 0)
                return ap;
            int[] buff = new int[num * _channels];
            get(0, 0, buff); 
            for (int i = 0; i < num; i++)
                ap[i] = new Point(buff[i * _channels], buff[i * _channels + 1]);
            return ap;
        }

        public void fromList(List<Point> lp)
        {
            Point[] ap = lp.ToArray();
            fromArray(ap);
        }

        public List<Point> toList()
        {
            Point[] ap = toArray();
            return new List<Point>(ap);
        }
    }