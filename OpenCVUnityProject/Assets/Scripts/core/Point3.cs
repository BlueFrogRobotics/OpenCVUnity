using System;using UnityEngine;namespace OpenCVUnity{
    /// <summary>template<typename _Tp> class CV_EXPORTS Point3_ <code></summary>
    ///
    /// <p>// C++ code:</p>
    ///
    ///
    /// <p>public:</p>
    ///
    /// <p>typedef _Tp value_type;</p>
    ///
    /// <p>// various constructors</p>
    ///
    /// <p>Point3_();</p>
    ///
    /// <p>Point3_(_Tp _x, _Tp _y, _Tp _z);</p>
    ///
    /// <p>Point3_(const Point3_& pt);</p>
    ///
    /// <p>explicit Point3_(const Point_<_Tp>& pt);</p>
    ///
    /// <p>Point3_(const CvPoint3D32f& pt);</p>
    ///
    /// <p>Point3_(const Vec<_Tp, 3>& v);</p>
    ///
    /// <p>Point3_& operator = (const Point3_& pt);</p>
    ///
    /// <p>//! conversion to another data type</p>
    ///
    /// <p>template<typename _Tp2> operator Point3_<_Tp2>() const;</p>
    ///
    /// <p>//! conversion to the old-style CvPoint...</p>
    ///
    /// <p>operator CvPoint3D32f() const;</p>
    ///
    /// <p>//! conversion to cv.Vec<></p>
    ///
    /// <p>operator Vec<_Tp, 3>() const;</p>
    ///
    /// <p>//! dot product</p>
    ///
    /// <p>_Tp dot(const Point3_& pt) const;</p>
    ///
    /// <p>//! dot product computed in double-precision arithmetics</p>
    ///
    /// <p>double ddot(const Point3_& pt) const;</p>
    ///
    /// <p>//! cross product of the 2 3D points</p>
    ///
    /// <p>Point3_ cross(const Point3_& pt) const;</p>
    ///
    /// <p>_Tp x, y, z; //< the point coordinates</p>
    ///
    /// <p>};</p>
    ///
    /// <p>Template class for 3D points specified by its coordinates </code></p>
    ///
    /// <p><em>x</em>, <em>y</em> and <em>z</em>.
    /// An instance of the class is interchangeable with the C structure
    /// <code>CvPoint2D32f</code>. Similarly to <code>Point_</code>, the coordinates
    /// of 3D points can be converted to another type. The vector arithmetic and
    /// comparison operations are also supported.
    /// The following <code>Point3_<></code> aliases are available: <code></p>
    ///
    /// <p>// C++ code:</p>
    ///
    /// <p>typedef Point3_<int> Point3i;</p>
    ///
    /// <p>typedef Point3_<float> Point3f;</p>
    ///
    /// <p>typedef Point3_<double> Point3d;</p>
    ///
    /// <a href="http://docs.opencv.org/modules/core/doc/basic_structures.html#point3">org.opencv.core.Point3_</a>
    public class Point3
    {
        public double x, y, z;

        public Point3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point3(Vector3 iPoint) : this(iPoint.x, iPoint.y, iPoint.z)
        {
        }

        public Point3(Vector2 iPoint) : this(iPoint.x, iPoint.y, 0D)
        {
        }

        public Point3() : this(0D, 0D, 0D)
        {
        }

        public Point3(Point p)
        {
            x = p.x;
            y = p.y;
            z = 0;
        }

        public Point3(double[] vals) : this()
        {
            set(vals);
        }

        public Point3(float[] vals) : this()
        {
            set(vals);
        }

        public void set(double[] vals)
        {
            if (vals != null) {
                x = vals.Length > 0 ? vals[0] : 0;
                y = vals.Length > 1 ? vals[1] : 0;
                z = vals.Length > 2 ? vals[2] : 0;
            } else {
                x = 0;
                y = 0;
                z = 0;
            }
        }

        public void set(float[] vals)
        {
            if (vals != null) {
                x = vals.Length > 0 ? vals[0] : 0;
                y = vals.Length > 1 ? vals[1] : 0;
                z = vals.Length > 2 ? vals[2] : 0;
            } else {
                x = 0;
                y = 0;
                z = 0;
            }
        }

        public Point3 clone()
        {
            return new Point3(x, y, z);
        }

        public Vector2 toVector2()
        {
            return new Vector2((float)x, (float)y);
        }

        public Vector3 toVector3()
        {
            return new Vector3((float)x, (float)y, 0F);
        }

        public double dot(Point3 p)
        {
            return x * p.x + y * p.y + z * p.z;
        }

        public Point3 cross(Point3 p)
        {
            return new Point3(y * p.z - z * p.y, z * p.x - x * p.z, x * p.y - y * p.x);
        }

        public double dot(Vector3 p)
        {
            return x * p.x + y * p.y + z * p.z;
        }

        public Point3 cross(Vector3 p)
        {
            return new Point3(y * p.z - z * p.y, z * p.x - x * p.z, x * p.y - y * p.x);
        }

        public static bool operator !=(Point3 p1, Point3 p2)
        {
            return p1.x != p2.x && p1.y != p2.y;
        }

        public static bool operator !=(Point3 p1, Vector3 p2)
        {
            return p1.x != p2.x && p1.y != p2.y;
        }

        public static bool operator !=(Vector3 p1, Point3 p2)
        {
            return p1.x != p2.x && p1.y != p2.y;
        }

        public static bool operator ==(Point3 p1, Point3 p2)
        {
            return p1.x == p2.x && p1.y == p2.y;
        }

        public static bool operator ==(Point3 p1, Vector3 p2)
        {
            return p1.x == p2.x && p1.y == p2.y;
        }

        public static bool operator ==(Vector3 p1, Point3 p2)
        {
            return p1.x == p2.x && p1.y == p2.y;
        }

        public static Point3 operator -(Point3 p1)
        {
            return new Point3(p1.x * -1, p1.y * -1, p1.z * -1);
        }

        public static Point3 operator -(Point3 p1, Point3 p2)
        {
            return new Point3(p1.x - p2.x, p1.y - p2.y, p1.z - p2.z);
        }

        public static Point3 operator -(Point3 p1, Vector3 p2)
        {
            return new Point3(p1.x - p2.x, p1.y - p2.y, p1.z - p2.z);
        }

        public static Point3 operator -(Vector3 p1, Point3 p2)
        {
            return new Point3(p1.x - p2.x, p1.y - p2.y, p1.z - p2.z);
        }

        public static Point3 operator +(Point3 p1, Point3 p2)
        {
            return new Point3(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
        }

        public static Point3 operator +(Point3 p1, Vector3 p2)
        {
            return new Point3(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
        }

        public static Point3 operator +(Vector3 p1, Point3 p2)
        {
            return new Point3(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
        }

        public static Point3 operator *(Point3 p, float v)
        {
            return new Point3(p.x * v, p.y * v, p.z * v);
        }

        public static Point3 operator *(Point3 p, double v)
        {
            return new Point3(p.x * v, p.y * v, p.z * v);
        }

        public static Point3 operator *(float v, Point3 p)
        {
            return new Point3(p.x * v, p.y * v, p.z * v);
        }

        public static Point3 operator *(double v, Point3 p)
        {
            return new Point3(p.x * v, p.y * v, p.z * v);
        }

        public static Point3 operator /(Point3 p, float v)
        {
            return new Point3(p.x / v, p.y / v, p.z / v);
        }

        public static Point3 operator /(Point3 p, double v)
        {
            return new Point3(p.x / v, p.y / v, p.z / v);
        }

        public override int GetHashCode()
        {
            const int prime = 31;
            int result = 1;
            long temp;
            temp = BitConverter.DoubleToInt64Bits(x);
            result = prime * result + (int)(temp ^ (Hash.URShift(temp, 32)));
            temp = BitConverter.DoubleToInt64Bits(y);
            result = prime * result + (int)(temp ^ (Hash.URShift(temp, 32)));
            temp = BitConverter.DoubleToInt64Bits(z);
            result = prime * result + (int)(temp ^ (Hash.URShift(temp, 32)));
            return result;
        }

        public override bool Equals(System.Object obj)
        {
            if (this == obj) return true;
            if (!(obj is Point3)) return false;
            Point3 it = (Point3)obj;
            return x == it.x && y == it.y && z == it.z;
        }

        public override string ToString()
        {
            return "{" + x + ", " + y + ", " + z + "}";
        }
    }}