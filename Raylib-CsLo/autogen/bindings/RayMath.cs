//# raylib 4.0 bindings.   MPL 2.0 Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using Raylib_CsLo.InternalHelpers;
using System.Numerics;

namespace Raylib_CsLo
{
    public static unsafe partial class RayMath
    {
        public static float Clamp(float value, float min, float max)
        {
            float result = (value < min) ? min : value;

            if (result > max)
            {
                result = max;
            }

            return result;
        }

        public static float Lerp(float start, float end, float amount)
        {
            float result = start + amount * (end - start);

            return result;
        }

        public static float Normalize(float value, float start, float end)
        {
            float result = (value - start) / (end - start);

            return result;
        }

        public static float Remap(float value, float inputStart, float inputEnd, float outputStart, float outputEnd)
        {
            float result = (value - inputStart) / (inputEnd - inputStart) * (outputEnd - outputStart) + outputStart;

            return result;
        }

        public static float Wrap(float value, float min, float max)
        {
            float result = value - (max - min) * floorf((value - min) / (max - min));

            return result;
        }

        public static int FloatEquals(float x, float y)
        {
            int result = ((fabsf(x - y)) <= (0.000001f * MathF.Max(1.0f, MathF.Max(fabsf(x), fabsf(y))))) ? 1 : 0;

            return result;
        }

        public static Vector2 Vector2Zero()
        {
            Vector2 result = new Vector2
            {
                X = 0.0f,
                Y = 0.0f,
            };

            return result;
        }

        public static Vector2 Vector2One()
        {
            Vector2 result = new Vector2
            {
                X = 1.0f,
                Y = 1.0f,
            };

            return result;
        }

        public static Vector2 Vector2Add(Vector2 v1, Vector2 v2)
        {
            Vector2 result = new Vector2
            {
                X = v1.X + v2.X,
                Y = v1.Y + v2.Y,
            };

            return result;
        }

        public static Vector2 Vector2AddValue(Vector2 v, float add)
        {
            Vector2 result = new Vector2
            {
                X = v.X + add,
                Y = v.Y + add,
            };

            return result;
        }

        public static Vector2 Vector2Subtract(Vector2 v1, Vector2 v2)
        {
            Vector2 result = new Vector2
            {
                X = v1.X - v2.X,
                Y = v1.Y - v2.Y,
            };

            return result;
        }

        public static Vector2 Vector2SubtractValue(Vector2 v, float sub)
        {
            Vector2 result = new Vector2
            {
                X = v.X - sub,
                Y = v.Y - sub,
            };

            return result;
        }

        public static float Vector2Length(Vector2 v)
        {
            float result = MathF.Sqrt((v.X * v.X) + (v.Y * v.Y));

            return result;
        }

        public static float Vector2LengthSqr(Vector2 v)
        {
            float result = (v.X * v.X) + (v.Y * v.Y);

            return result;
        }

        public static float Vector2DotProduct(Vector2 v1, Vector2 v2)
        {
            float result = (v1.X * v2.X + v1.Y * v2.Y);

            return result;
        }

        public static float Vector2Distance(Vector2 v1, Vector2 v2)
        {
            float result = MathF.Sqrt((v1.X - v2.X) * (v1.X - v2.X) + (v1.Y - v2.Y) * (v1.Y - v2.Y));

            return result;
        }

        public static float Vector2DistanceSqr(Vector2 v1, Vector2 v2)
        {
            float result = ((v1.X - v2.X) * (v1.X - v2.X) + (v1.Y - v2.Y) * (v1.Y - v2.Y));

            return result;
        }

        public static float Vector2Angle(Vector2 v1, Vector2 v2)
        {
            float result = MathF.Atan2(v2.Y, v2.X) - MathF.Atan2(v1.Y, v1.X);

            return result;
        }

        public static Vector2 Vector2Scale(Vector2 v, float scale)
        {
            Vector2 result = new Vector2
            {
                X = v.X * scale,
                Y = v.Y * scale,
            };

            return result;
        }

        public static Vector2 Vector2Multiply(Vector2 v1, Vector2 v2)
        {
            Vector2 result = new Vector2
            {
                X = v1.X * v2.X,
                Y = v1.Y * v2.Y,
            };

            return result;
        }

        public static Vector2 Vector2Negate(Vector2 v)
        {
            Vector2 result = new Vector2
            {
                X = -v.X,
                Y = -v.Y,
            };

            return result;
        }

        public static Vector2 Vector2Divide(Vector2 v1, Vector2 v2)
        {
            Vector2 result = new Vector2
            {
                X = v1.X / v2.X,
                Y = v1.Y / v2.Y,
            };

            return result;
        }

        public static Vector2 Vector2Normalize(Vector2 v)
        {
            Vector2 result = new Vector2
            {
                X = 0,
            };
            float length = MathF.Sqrt((v.X * v.X) + (v.Y * v.Y));

            if (length > 0)
            {
                float ilength = 1.0f / length;

                result.X = v.X * ilength;
                result.Y = v.Y * ilength;
            }

            return result;
        }

        public static Vector2 Vector2Transform(Vector2 v, [NativeTypeName("Matrix")] Matrix4x4 mat)
        {
            Vector2 result = new Vector2
            {
                X = 0,
            };
            float x = v.X;
            float y = v.Y;
            float z = 0;

            result.X = mat.M11 * x + mat.M21 * y + mat.M31 * z + mat.M41;
            result.Y = mat.M12 * x + mat.M22 * y + mat.M32 * z + mat.M42;
            return result;
        }

        public static Vector2 Vector2Lerp(Vector2 v1, Vector2 v2, float amount)
        {
            Vector2 result = new Vector2
            {
                X = 0,
            };

            result.X = v1.X + amount * (v2.X - v1.X);
            result.Y = v1.Y + amount * (v2.Y - v1.Y);
            return result;
        }

        public static Vector2 Vector2Reflect(Vector2 v, Vector2 normal)
        {
            Vector2 result = new Vector2
            {
                X = 0,
            };
            float dotProduct = (v.X * normal.X + v.Y * normal.Y);

            result.X = v.X - (2.0f * normal.X) * dotProduct;
            result.Y = v.Y - (2.0f * normal.Y) * dotProduct;
            return result;
        }

        public static Vector2 Vector2Rotate(Vector2 v, float angle)
        {
            Vector2 result = new Vector2
            {
                X = 0,
            };
            float cosres = MathF.Cos(angle);
            float sinres = MathF.Sin(angle);

            result.X = v.X * cosres - v.Y * sinres;
            result.Y = v.X * sinres + v.Y * cosres;
            return result;
        }

        public static Vector2 Vector2MoveTowards(Vector2 v, Vector2 target, float maxDistance)
        {
            Vector2 result = new Vector2
            {
                X = 0,
            };
            float dx = target.X - v.X;
            float dy = target.Y - v.Y;
            float value = (dx * dx) + (dy * dy);

            if ((value == 0) || ((maxDistance >= 0) && (value <= maxDistance * maxDistance)))
            {
                return target;
            }

            float dist = MathF.Sqrt(value);

            result.X = v.X + dx / dist * maxDistance;
            result.Y = v.Y + dy / dist * maxDistance;
            return result;
        }

        public static Vector2 Vector2Invert(Vector2 v)
        {
            Vector2 result = new Vector2
            {
                X = 1.0f / v.X,
                Y = 1.0f / v.Y,
            };

            return result;
        }

        public static Vector2 Vector2Clamp(Vector2 v, Vector2 min, Vector2 max)
        {
            Vector2 result = new Vector2
            {
                X = 0,
            };

            result.X = MathF.Min(max.X, MathF.Max(min.X, v.X));
            result.Y = MathF.Min(max.Y, MathF.Max(min.Y, v.Y));
            return result;
        }

        public static Vector2 Vector2ClampValue(Vector2 v, float min, float max)
        {
            Vector2 result = v;
            float length = (v.X * v.X) + (v.Y * v.Y);

            if (length > 0.0f)
            {
                length = MathF.Sqrt(length);
                if (length < min)
                {
                    float scale = min / length;

                    result.X = v.X * scale;
                    result.Y = v.Y * scale;
                }
                else if (length > max)
                {
                    float scale = max / length;

                    result.X = v.X * scale;
                    result.Y = v.Y * scale;
                }
            }

            return result;
        }

        public static int Vector2Equals(Vector2 p, Vector2 q)
        {
            int result = (((fabsf(p.X - q.X)) <= (0.000001f * MathF.Max(1.0f, MathF.Max(fabsf(p.X), fabsf(q.X))))) && ((fabsf(p.Y - q.Y)) <= (0.000001f * MathF.Max(1.0f, MathF.Max(fabsf(p.Y), fabsf(q.Y)))))) ? 1 : 0;

            return result;
        }

        public static Vector3 Vector3Zero()
        {
            Vector3 result = new Vector3
            {
                X = 0.0f,
                Y = 0.0f,
                Z = 0.0f,
            };

            return result;
        }

        public static Vector3 Vector3One()
        {
            Vector3 result = new Vector3
            {
                X = 1.0f,
                Y = 1.0f,
                Z = 1.0f,
            };

            return result;
        }

        public static Vector3 Vector3Add(Vector3 v1, Vector3 v2)
        {
            Vector3 result = new Vector3
            {
                X = v1.X + v2.X,
                Y = v1.Y + v2.Y,
                Z = v1.Z + v2.Z,
            };

            return result;
        }

        public static Vector3 Vector3AddValue(Vector3 v, float add)
        {
            Vector3 result = new Vector3
            {
                X = v.X + add,
                Y = v.Y + add,
                Z = v.Z + add,
            };

            return result;
        }

        public static Vector3 Vector3Subtract(Vector3 v1, Vector3 v2)
        {
            Vector3 result = new Vector3
            {
                X = v1.X - v2.X,
                Y = v1.Y - v2.Y,
                Z = v1.Z - v2.Z,
            };

            return result;
        }

        public static Vector3 Vector3SubtractValue(Vector3 v, float sub)
        {
            Vector3 result = new Vector3
            {
                X = v.X - sub,
                Y = v.Y - sub,
                Z = v.Z - sub,
            };

            return result;
        }

        public static Vector3 Vector3Scale(Vector3 v, float scalar)
        {
            Vector3 result = new Vector3
            {
                X = v.X * scalar,
                Y = v.Y * scalar,
                Z = v.Z * scalar,
            };

            return result;
        }

        public static Vector3 Vector3Multiply(Vector3 v1, Vector3 v2)
        {
            Vector3 result = new Vector3
            {
                X = v1.X * v2.X,
                Y = v1.Y * v2.Y,
                Z = v1.Z * v2.Z,
            };

            return result;
        }

        public static Vector3 Vector3CrossProduct(Vector3 v1, Vector3 v2)
        {
            Vector3 result = new Vector3
            {
                X = v1.Y * v2.Z - v1.Z * v2.Y,
                Y = v1.Z * v2.X - v1.X * v2.Z,
                Z = v1.X * v2.Y - v1.Y * v2.X,
            };

            return result;
        }

        public static Vector3 Vector3Perpendicular(Vector3 v)
        {
            Vector3 result = new Vector3
            {
                X = 0,
            };
            float min = (float)(MathF.Abs(v.X));
            Vector3 cardinalAxis = new Vector3
            {
                X = 1.0f,
                Y = 0.0f,
                Z = 0.0f,
            };

            if (fabsf(v.Y) < min)
            {
                min = (float)(MathF.Abs(v.Y));
                Vector3 tmp = new Vector3
                {
                    X = 0.0f,
                    Y = 1.0f,
                    Z = 0.0f,
                };

                cardinalAxis=(tmp);
            }

            if (fabsf(v.Z) < min)
            {
                Vector3 tmp = new Vector3
                {
                    X = 0.0f,
                    Y = 0.0f,
                    Z = 1.0f,
                };

                cardinalAxis=(tmp);
            }

            result.X = v.Y * cardinalAxis.Z - v.Z * cardinalAxis.Y;
            result.Y = v.Z * cardinalAxis.X - v.X * cardinalAxis.Z;
            result.Z = v.X * cardinalAxis.Y - v.Y * cardinalAxis.X;
            return result;
        }

        public static float Vector3Length([NativeTypeName("const Vector3")] Vector3 v)
        {
            float result = MathF.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);

            return result;
        }

        public static float Vector3LengthSqr([NativeTypeName("const Vector3")] Vector3 v)
        {
            float result = v.X * v.X + v.Y * v.Y + v.Z * v.Z;

            return result;
        }

        public static float Vector3DotProduct(Vector3 v1, Vector3 v2)
        {
            float result = (v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z);

            return result;
        }

        public static float Vector3Distance(Vector3 v1, Vector3 v2)
        {
            float result = 0.0f;
            float dx = v2.X - v1.X;
            float dy = v2.Y - v1.Y;
            float dz = v2.Z - v1.Z;

            result = MathF.Sqrt(dx * dx + dy * dy + dz * dz);
            return result;
        }

        public static float Vector3DistanceSqr(Vector3 v1, Vector3 v2)
        {
            float result = 0.0f;
            float dx = v2.X - v1.X;
            float dy = v2.Y - v1.Y;
            float dz = v2.Z - v1.Z;

            result = dx * dx + dy * dy + dz * dz;
            return result;
        }

        public static float Vector3Angle(Vector3 v1, Vector3 v2)
        {
            float result = 0.0f;
            Vector3 cross = new Vector3
            {
                X = v1.Y * v2.Z - v1.Z * v2.Y,
                Y = v1.Z * v2.X - v1.X * v2.Z,
                Z = v1.X * v2.Y - v1.Y * v2.X,
            };
            float len = MathF.Sqrt(cross.X * cross.X + cross.Y * cross.Y + cross.Z * cross.Z);
            float dot = (v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z);

            result = MathF.Atan2(len, dot);
            return result;
        }

        public static Vector3 Vector3Negate(Vector3 v)
        {
            Vector3 result = new Vector3
            {
                X = -v.X,
                Y = -v.Y,
                Z = -v.Z,
            };

            return result;
        }

        public static Vector3 Vector3Divide(Vector3 v1, Vector3 v2)
        {
            Vector3 result = new Vector3
            {
                X = v1.X / v2.X,
                Y = v1.Y / v2.Y,
                Z = v1.Z / v2.Z,
            };

            return result;
        }

        public static Vector3 Vector3Normalize(Vector3 v)
        {
            Vector3 result = v;
            float length = MathF.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);

            if (length == 0.0f)
            {
                length = 1.0f;
            }

            float ilength = 1.0f / length;

            result.X *= ilength;
            result.Y *= ilength;
            result.Z *= ilength;
            return result;
        }

        public static void Vector3OrthoNormalize(Vector3* v1, Vector3* v2)
        {
            float length = 0.0f;
            float ilength = 0.0f;
            Vector3 v = *v1;

            length = MathF.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
            if (length == 0.0f)
            {
                length = 1.0f;
            }

            ilength = 1.0f / length;
            v1->X *= ilength;
            v1->Y *= ilength;
            v1->Z *= ilength;
            Vector3 vn1 = new Vector3
            {
                X = v1->Y * v2->Z - v1->Z * v2->Y,
                Y = v1->Z * v2->X - v1->X * v2->Z,
                Z = v1->X * v2->Y - v1->Y * v2->X,
            };

            v=(vn1);
            length = MathF.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
            if (length == 0.0f)
            {
                length = 1.0f;
            }

            ilength = 1.0f / length;
            vn1.X *= ilength;
            vn1.Y *= ilength;
            vn1.Z *= ilength;
            Vector3 vn2 = new Vector3
            {
                X = vn1.Y * v1->Z - vn1.Z * v1->Y,
                Y = vn1.Z * v1->X - vn1.X * v1->Z,
                Z = vn1.X * v1->Y - vn1.Y * v1->X,
            };

            *v2=(vn2);
        }

        public static Vector3 Vector3Transform(Vector3 v, [NativeTypeName("Matrix")] Matrix4x4 mat)
        {
            Vector3 result = new Vector3
            {
                X = 0,
            };
            float x = v.X;
            float y = v.Y;
            float z = v.Z;

            result.X = mat.M11 * x + mat.M21 * y + mat.M31 * z + mat.M41;
            result.Y = mat.M12 * x + mat.M22 * y + mat.M32 * z + mat.M42;
            result.Z = mat.M13 * x + mat.M23 * y + mat.M33 * z + mat.M43;
            return result;
        }

        public static Vector3 Vector3RotateByQuaternion(Vector3 v, Quaternion q)
        {
            Vector3 result = new Vector3
            {
                X = 0,
            };

            result.X = v.X * (q.X * q.X + q.W * q.W - q.Y * q.Y - q.Z * q.Z) + v.Y * (2 * q.X * q.Y - 2 * q.W * q.Z) + v.Z * (2 * q.X * q.Z + 2 * q.W * q.Y);
            result.Y = v.X * (2 * q.W * q.Z + 2 * q.X * q.Y) + v.Y * (q.W * q.W - q.X * q.X + q.Y * q.Y - q.Z * q.Z) + v.Z * (-2 * q.W * q.X + 2 * q.Y * q.Z);
            result.Z = v.X * (-2 * q.W * q.Y + 2 * q.X * q.Z) + v.Y * (2 * q.W * q.X + 2 * q.Y * q.Z) + v.Z * (q.W * q.W - q.X * q.X - q.Y * q.Y + q.Z * q.Z);
            return result;
        }

        public static Vector3 Vector3RotateByAxisAngle(Vector3 v, Vector3 axis, float angle)
        {
            Vector3 result = v;
            float length = MathF.Sqrt(axis.X * axis.X + axis.Y * axis.Y + axis.Z * axis.Z);

            if (length == 0.0f)
            {
                length = 1.0f;
            }

            float ilength = 1.0f / length;

            axis.X *= ilength;
            axis.Y *= ilength;
            axis.Z *= ilength;
            angle /= 2.0f;
            float a = MathF.Sin(angle);
            float b = axis.X * a;
            float c = axis.Y * a;
            float d = axis.Z * a;

            a = MathF.Cos(angle);
            Vector3 w = new Vector3
            {
                X = b,
                Y = c,
                Z = d,
            };
            Vector3 wv = new Vector3
            {
                X = w.Y * v.Z - w.Z * v.Y,
                Y = w.Z * v.X - w.X * v.Z,
                Z = w.X * v.Y - w.Y * v.X,
            };
            Vector3 wwv = new Vector3
            {
                X = w.Y * wv.Z - w.Z * wv.Y,
                Y = w.Z * wv.X - w.X * wv.Z,
                Z = w.X * wv.Y - w.Y * wv.X,
            };

            a *= 2;
            wv.X *= a;
            wv.Y *= a;
            wv.Z *= a;
            wwv.X *= 2;
            wwv.Y *= 2;
            wwv.Z *= 2;
            result.X += wv.X;
            result.Y += wv.Y;
            result.Z += wv.Z;
            result.X += wwv.X;
            result.Y += wwv.Y;
            result.Z += wwv.Z;
            return result;
        }

        public static Vector3 Vector3Lerp(Vector3 v1, Vector3 v2, float amount)
        {
            Vector3 result = new Vector3
            {
                X = 0,
            };

            result.X = v1.X + amount * (v2.X - v1.X);
            result.Y = v1.Y + amount * (v2.Y - v1.Y);
            result.Z = v1.Z + amount * (v2.Z - v1.Z);
            return result;
        }

        public static Vector3 Vector3Reflect(Vector3 v, Vector3 normal)
        {
            Vector3 result = new Vector3
            {
                X = 0,
            };
            float dotProduct = (v.X * normal.X + v.Y * normal.Y + v.Z * normal.Z);

            result.X = v.X - (2.0f * normal.X) * dotProduct;
            result.Y = v.Y - (2.0f * normal.Y) * dotProduct;
            result.Z = v.Z - (2.0f * normal.Z) * dotProduct;
            return result;
        }

        public static Vector3 Vector3Min(Vector3 v1, Vector3 v2)
        {
            Vector3 result = new Vector3
            {
                X = 0,
            };

            result.X = MathF.Min(v1.X, v2.X);
            result.Y = MathF.Min(v1.Y, v2.Y);
            result.Z = MathF.Min(v1.Z, v2.Z);
            return result;
        }

        public static Vector3 Vector3Max(Vector3 v1, Vector3 v2)
        {
            Vector3 result = new Vector3
            {
                X = 0,
            };

            result.X = MathF.Max(v1.X, v2.X);
            result.Y = MathF.Max(v1.Y, v2.Y);
            result.Z = MathF.Max(v1.Z, v2.Z);
            return result;
        }

        public static Vector3 Vector3Barycenter(Vector3 p, Vector3 a, Vector3 b, Vector3 c)
        {
            Vector3 result = new Vector3
            {
                X = 0,
            };
            Vector3 v0 = new Vector3
            {
                X = b.X - a.X,
                Y = b.Y - a.Y,
                Z = b.Z - a.Z,
            };
            Vector3 v1 = new Vector3
            {
                X = c.X - a.X,
                Y = c.Y - a.Y,
                Z = c.Z - a.Z,
            };
            Vector3 v2 = new Vector3
            {
                X = p.X - a.X,
                Y = p.Y - a.Y,
                Z = p.Z - a.Z,
            };
            float d00 = (v0.X * v0.X + v0.Y * v0.Y + v0.Z * v0.Z);
            float d01 = (v0.X * v1.X + v0.Y * v1.Y + v0.Z * v1.Z);
            float d11 = (v1.X * v1.X + v1.Y * v1.Y + v1.Z * v1.Z);
            float d20 = (v2.X * v0.X + v2.Y * v0.Y + v2.Z * v0.Z);
            float d21 = (v2.X * v1.X + v2.Y * v1.Y + v2.Z * v1.Z);
            float denom = d00 * d11 - d01 * d01;

            result.Y = (d11 * d20 - d01 * d21) / denom;
            result.Z = (d00 * d21 - d01 * d20) / denom;
            result.X = 1.0f - (result.Z + result.Y);
            return result;
        }

        public static Vector3 Vector3Unproject(Vector3 source, [NativeTypeName("Matrix")] Matrix4x4 projection, [NativeTypeName("Matrix")] Matrix4x4 view)
        {
            Vector3 result = new Vector3
            {
                X = 0,
            };
            Matrix4x4 matViewProj = new Matrix4x4
            {
                M11 = view.M11 * projection.M11 + view.M12 * projection.M21 + view.M13 * projection.M31 + view.M14 * projection.M41,
                M21 = view.M11 * projection.M12 + view.M12 * projection.M22 + view.M13 * projection.M32 + view.M14 * projection.M42,
                M31 = view.M11 * projection.M13 + view.M12 * projection.M23 + view.M13 * projection.M33 + view.M14 * projection.M43,
                M41 = view.M11 * projection.M14 + view.M12 * projection.M24 + view.M13 * projection.M34 + view.M14 * projection.M44,
                M12 = view.M21 * projection.M11 + view.M22 * projection.M21 + view.M23 * projection.M31 + view.M24 * projection.M41,
                M22 = view.M21 * projection.M12 + view.M22 * projection.M22 + view.M23 * projection.M32 + view.M24 * projection.M42,
                M32 = view.M21 * projection.M13 + view.M22 * projection.M23 + view.M23 * projection.M33 + view.M24 * projection.M43,
                M42 = view.M21 * projection.M14 + view.M22 * projection.M24 + view.M23 * projection.M34 + view.M24 * projection.M44,
                M13 = view.M31 * projection.M11 + view.M32 * projection.M21 + view.M33 * projection.M31 + view.M34 * projection.M41,
                M23 = view.M31 * projection.M12 + view.M32 * projection.M22 + view.M33 * projection.M32 + view.M34 * projection.M42,
                M33 = view.M31 * projection.M13 + view.M32 * projection.M23 + view.M33 * projection.M33 + view.M34 * projection.M43,
                M43 = view.M31 * projection.M14 + view.M32 * projection.M24 + view.M33 * projection.M34 + view.M34 * projection.M44,
                M14 = view.M41 * projection.M11 + view.M42 * projection.M21 + view.M43 * projection.M31 + view.M44 * projection.M41,
                M24 = view.M41 * projection.M12 + view.M42 * projection.M22 + view.M43 * projection.M32 + view.M44 * projection.M42,
                M34 = view.M41 * projection.M13 + view.M42 * projection.M23 + view.M43 * projection.M33 + view.M44 * projection.M43,
                M44 = view.M41 * projection.M14 + view.M42 * projection.M24 + view.M43 * projection.M34 + view.M44 * projection.M44,
            };
            float a00 = matViewProj.M11, a01 = matViewProj.M12, a02 = matViewProj.M13, a03 = matViewProj.M14;
            float a10 = matViewProj.M21, a11 = matViewProj.M22, a12 = matViewProj.M23, a13 = matViewProj.M24;
            float a20 = matViewProj.M31, a21 = matViewProj.M32, a22 = matViewProj.M33, a23 = matViewProj.M34;
            float a30 = matViewProj.M41, a31 = matViewProj.M42, a32 = matViewProj.M43, a33 = matViewProj.M44;
            float b00 = a00 * a11 - a01 * a10;
            float b01 = a00 * a12 - a02 * a10;
            float b02 = a00 * a13 - a03 * a10;
            float b03 = a01 * a12 - a02 * a11;
            float b04 = a01 * a13 - a03 * a11;
            float b05 = a02 * a13 - a03 * a12;
            float b06 = a20 * a31 - a21 * a30;
            float b07 = a20 * a32 - a22 * a30;
            float b08 = a20 * a33 - a23 * a30;
            float b09 = a21 * a32 - a22 * a31;
            float b10 = a21 * a33 - a23 * a31;
            float b11 = a22 * a33 - a23 * a32;
            float invDet = 1.0f / (b00 * b11 - b01 * b10 + b02 * b09 + b03 * b08 - b04 * b07 + b05 * b06);
            Matrix4x4 matViewProjInv = new Matrix4x4
            {
                M11 = (a11 * b11 - a12 * b10 + a13 * b09) * invDet,
                M21 = (-a01 * b11 + a02 * b10 - a03 * b09) * invDet,
                M31 = (a31 * b05 - a32 * b04 + a33 * b03) * invDet,
                M41 = (-a21 * b05 + a22 * b04 - a23 * b03) * invDet,
                M12 = (-a10 * b11 + a12 * b08 - a13 * b07) * invDet,
                M22 = (a00 * b11 - a02 * b08 + a03 * b07) * invDet,
                M32 = (-a30 * b05 + a32 * b02 - a33 * b01) * invDet,
                M42 = (a20 * b05 - a22 * b02 + a23 * b01) * invDet,
                M13 = (a10 * b10 - a11 * b08 + a13 * b06) * invDet,
                M23 = (-a00 * b10 + a01 * b08 - a03 * b06) * invDet,
                M33 = (a30 * b04 - a31 * b02 + a33 * b00) * invDet,
                M43 = (-a20 * b04 + a21 * b02 - a23 * b00) * invDet,
                M14 = (-a10 * b09 + a11 * b07 - a12 * b06) * invDet,
                M24 = (a00 * b09 - a01 * b07 + a02 * b06) * invDet,
                M34 = (-a30 * b03 + a31 * b01 - a32 * b00) * invDet,
                M44 = (a20 * b03 - a21 * b01 + a22 * b00) * invDet,
            };
            Quaternion quat = new Quaternion
            {
                X = source.X,
                Y = source.Y,
                Z = source.Z,
                W = 1.0f,
            };
            Quaternion qtransformed = new Quaternion
            {
                X = matViewProjInv.M11 * quat.X + matViewProjInv.M21 * quat.Y + matViewProjInv.M31 * quat.Z + matViewProjInv.M41 * quat.W,
                Y = matViewProjInv.M12 * quat.X + matViewProjInv.M22 * quat.Y + matViewProjInv.M32 * quat.Z + matViewProjInv.M42 * quat.W,
                Z = matViewProjInv.M13 * quat.X + matViewProjInv.M23 * quat.Y + matViewProjInv.M33 * quat.Z + matViewProjInv.M43 * quat.W,
                W = matViewProjInv.M14 * quat.X + matViewProjInv.M24 * quat.Y + matViewProjInv.M34 * quat.Z + matViewProjInv.M44 * quat.W,
            };

            result.X = qtransformed.X / qtransformed.W;
            result.Y = qtransformed.Y / qtransformed.W;
            result.Z = qtransformed.Z / qtransformed.W;
            return result;
        }

        public static Vector3 Vector3Invert(Vector3 v)
        {
            Vector3 result = new Vector3
            {
                X = 1.0f / v.X,
                Y = 1.0f / v.Y,
                Z = 1.0f / v.Z,
            };

            return result;
        }

        public static Vector3 Vector3Clamp(Vector3 v, Vector3 min, Vector3 max)
        {
            Vector3 result = new Vector3
            {
                X = 0,
            };

            result.X = MathF.Min(max.X, MathF.Max(min.X, v.X));
            result.Y = MathF.Min(max.Y, MathF.Max(min.Y, v.Y));
            result.Z = MathF.Min(max.Z, MathF.Max(min.Z, v.Z));
            return result;
        }

        public static Vector3 Vector3ClampValue(Vector3 v, float min, float max)
        {
            Vector3 result = v;
            float length = (v.X * v.X) + (v.Y * v.Y) + (v.Z * v.Z);

            if (length > 0.0f)
            {
                length = MathF.Sqrt(length);
                if (length < min)
                {
                    float scale = min / length;

                    result.X = v.X * scale;
                    result.Y = v.Y * scale;
                    result.Z = v.Z * scale;
                }
                else if (length > max)
                {
                    float scale = max / length;

                    result.X = v.X * scale;
                    result.Y = v.Y * scale;
                    result.Z = v.Z * scale;
                }
            }

            return result;
        }

        public static int Vector3Equals(Vector3 p, Vector3 q)
        {
            int result = (((fabsf(p.X - q.X)) <= (0.000001f * MathF.Max(1.0f, MathF.Max(fabsf(p.X), fabsf(q.X))))) && ((fabsf(p.Y - q.Y)) <= (0.000001f * MathF.Max(1.0f, MathF.Max(fabsf(p.Y), fabsf(q.Y))))) && ((fabsf(p.Z - q.Z)) <= (0.000001f * MathF.Max(1.0f, MathF.Max(fabsf(p.Z), fabsf(q.Z)))))) ? 1 : 0;

            return result;
        }

        public static Vector3 Vector3Refract(Vector3 v, Vector3 n, float r)
        {
            Vector3 result = new Vector3
            {
                X = 0,
            };
            float dot = v.X * n.X + v.Y * n.Y + v.Z * n.Z;
            float d = 1.0f - r * r * (1.0f - dot * dot);

            if (d >= 0.0f)
            {
                d = MathF.Sqrt(d);
                v.X = r * v.X - (r * dot + d) * n.X;
                v.Y = r * v.Y - (r * dot + d) * n.Y;
                v.Z = r * v.Z - (r * dot + d) * n.Z;
                result=(v);
            }

            return result;
        }

        public static float MatrixDeterminant([NativeTypeName("Matrix")] Matrix4x4 mat)
        {
            float result = 0.0f;
            float a00 = mat.M11, a01 = mat.M12, a02 = mat.M13, a03 = mat.M14;
            float a10 = mat.M21, a11 = mat.M22, a12 = mat.M23, a13 = mat.M24;
            float a20 = mat.M31, a21 = mat.M32, a22 = mat.M33, a23 = mat.M34;
            float a30 = mat.M41, a31 = mat.M42, a32 = mat.M43, a33 = mat.M44;

            result = a30 * a21 * a12 * a03 - a20 * a31 * a12 * a03 - a30 * a11 * a22 * a03 + a10 * a31 * a22 * a03 + a20 * a11 * a32 * a03 - a10 * a21 * a32 * a03 - a30 * a21 * a02 * a13 + a20 * a31 * a02 * a13 + a30 * a01 * a22 * a13 - a00 * a31 * a22 * a13 - a20 * a01 * a32 * a13 + a00 * a21 * a32 * a13 + a30 * a11 * a02 * a23 - a10 * a31 * a02 * a23 - a30 * a01 * a12 * a23 + a00 * a31 * a12 * a23 + a10 * a01 * a32 * a23 - a00 * a11 * a32 * a23 - a20 * a11 * a02 * a33 + a10 * a21 * a02 * a33 + a20 * a01 * a12 * a33 - a00 * a21 * a12 * a33 - a10 * a01 * a22 * a33 + a00 * a11 * a22 * a33;
            return result;
        }

        public static float MatrixTrace([NativeTypeName("Matrix")] Matrix4x4 mat)
        {
            float result = (mat.M11 + mat.M22 + mat.M33 + mat.M44);

            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixTranspose([NativeTypeName("Matrix")] Matrix4x4 mat)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 0,
            };

            result.M11 = mat.M11;
            result.M12 = mat.M21;
            result.M13 = mat.M31;
            result.M14 = mat.M41;
            result.M21 = mat.M12;
            result.M22 = mat.M22;
            result.M23 = mat.M32;
            result.M24 = mat.M42;
            result.M31 = mat.M13;
            result.M32 = mat.M23;
            result.M33 = mat.M33;
            result.M34 = mat.M43;
            result.M41 = mat.M14;
            result.M42 = mat.M24;
            result.M43 = mat.M34;
            result.M44 = mat.M44;
            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixInvert([NativeTypeName("Matrix")] Matrix4x4 mat)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 0,
            };
            float a00 = mat.M11, a01 = mat.M12, a02 = mat.M13, a03 = mat.M14;
            float a10 = mat.M21, a11 = mat.M22, a12 = mat.M23, a13 = mat.M24;
            float a20 = mat.M31, a21 = mat.M32, a22 = mat.M33, a23 = mat.M34;
            float a30 = mat.M41, a31 = mat.M42, a32 = mat.M43, a33 = mat.M44;
            float b00 = a00 * a11 - a01 * a10;
            float b01 = a00 * a12 - a02 * a10;
            float b02 = a00 * a13 - a03 * a10;
            float b03 = a01 * a12 - a02 * a11;
            float b04 = a01 * a13 - a03 * a11;
            float b05 = a02 * a13 - a03 * a12;
            float b06 = a20 * a31 - a21 * a30;
            float b07 = a20 * a32 - a22 * a30;
            float b08 = a20 * a33 - a23 * a30;
            float b09 = a21 * a32 - a22 * a31;
            float b10 = a21 * a33 - a23 * a31;
            float b11 = a22 * a33 - a23 * a32;
            float invDet = 1.0f / (b00 * b11 - b01 * b10 + b02 * b09 + b03 * b08 - b04 * b07 + b05 * b06);

            result.M11 = (a11 * b11 - a12 * b10 + a13 * b09) * invDet;
            result.M12 = (-a01 * b11 + a02 * b10 - a03 * b09) * invDet;
            result.M13 = (a31 * b05 - a32 * b04 + a33 * b03) * invDet;
            result.M14 = (-a21 * b05 + a22 * b04 - a23 * b03) * invDet;
            result.M21 = (-a10 * b11 + a12 * b08 - a13 * b07) * invDet;
            result.M22 = (a00 * b11 - a02 * b08 + a03 * b07) * invDet;
            result.M23 = (-a30 * b05 + a32 * b02 - a33 * b01) * invDet;
            result.M24 = (a20 * b05 - a22 * b02 + a23 * b01) * invDet;
            result.M31 = (a10 * b10 - a11 * b08 + a13 * b06) * invDet;
            result.M32 = (-a00 * b10 + a01 * b08 - a03 * b06) * invDet;
            result.M33 = (a30 * b04 - a31 * b02 + a33 * b00) * invDet;
            result.M34 = (-a20 * b04 + a21 * b02 - a23 * b00) * invDet;
            result.M41 = (-a10 * b09 + a11 * b07 - a12 * b06) * invDet;
            result.M42 = (a00 * b09 - a01 * b07 + a02 * b06) * invDet;
            result.M43 = (-a30 * b03 + a31 * b01 - a32 * b00) * invDet;
            result.M44 = (a20 * b03 - a21 * b01 + a22 * b00) * invDet;
            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixIdentity()
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 1.0f,
                M21 = 0.0f,
                M31 = 0.0f,
                M41 = 0.0f,
                M12 = 0.0f,
                M22 = 1.0f,
                M32 = 0.0f,
                M42 = 0.0f,
                M13 = 0.0f,
                M23 = 0.0f,
                M33 = 1.0f,
                M43 = 0.0f,
                M14 = 0.0f,
                M24 = 0.0f,
                M34 = 0.0f,
                M44 = 1.0f,
            };

            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixAdd([NativeTypeName("Matrix")] Matrix4x4 left, [NativeTypeName("Matrix")] Matrix4x4 right)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 0,
            };

            result.M11 = left.M11 + right.M11;
            result.M12 = left.M12 + right.M12;
            result.M13 = left.M13 + right.M13;
            result.M14 = left.M14 + right.M14;
            result.M21 = left.M21 + right.M21;
            result.M22 = left.M22 + right.M22;
            result.M23 = left.M23 + right.M23;
            result.M24 = left.M24 + right.M24;
            result.M31 = left.M31 + right.M31;
            result.M32 = left.M32 + right.M32;
            result.M33 = left.M33 + right.M33;
            result.M34 = left.M34 + right.M34;
            result.M41 = left.M41 + right.M41;
            result.M42 = left.M42 + right.M42;
            result.M43 = left.M43 + right.M43;
            result.M44 = left.M44 + right.M44;
            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixSubtract([NativeTypeName("Matrix")] Matrix4x4 left, [NativeTypeName("Matrix")] Matrix4x4 right)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 0,
            };

            result.M11 = left.M11 - right.M11;
            result.M12 = left.M12 - right.M12;
            result.M13 = left.M13 - right.M13;
            result.M14 = left.M14 - right.M14;
            result.M21 = left.M21 - right.M21;
            result.M22 = left.M22 - right.M22;
            result.M23 = left.M23 - right.M23;
            result.M24 = left.M24 - right.M24;
            result.M31 = left.M31 - right.M31;
            result.M32 = left.M32 - right.M32;
            result.M33 = left.M33 - right.M33;
            result.M34 = left.M34 - right.M34;
            result.M41 = left.M41 - right.M41;
            result.M42 = left.M42 - right.M42;
            result.M43 = left.M43 - right.M43;
            result.M44 = left.M44 - right.M44;
            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixMultiply([NativeTypeName("Matrix")] Matrix4x4 left, [NativeTypeName("Matrix")] Matrix4x4 right)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 0,
            };

            result.M11 = left.M11 * right.M11 + left.M12 * right.M21 + left.M13 * right.M31 + left.M14 * right.M41;
            result.M12 = left.M11 * right.M12 + left.M12 * right.M22 + left.M13 * right.M32 + left.M14 * right.M42;
            result.M13 = left.M11 * right.M13 + left.M12 * right.M23 + left.M13 * right.M33 + left.M14 * right.M43;
            result.M14 = left.M11 * right.M14 + left.M12 * right.M24 + left.M13 * right.M34 + left.M14 * right.M44;
            result.M21 = left.M21 * right.M11 + left.M22 * right.M21 + left.M23 * right.M31 + left.M24 * right.M41;
            result.M22 = left.M21 * right.M12 + left.M22 * right.M22 + left.M23 * right.M32 + left.M24 * right.M42;
            result.M23 = left.M21 * right.M13 + left.M22 * right.M23 + left.M23 * right.M33 + left.M24 * right.M43;
            result.M24 = left.M21 * right.M14 + left.M22 * right.M24 + left.M23 * right.M34 + left.M24 * right.M44;
            result.M31 = left.M31 * right.M11 + left.M32 * right.M21 + left.M33 * right.M31 + left.M34 * right.M41;
            result.M32 = left.M31 * right.M12 + left.M32 * right.M22 + left.M33 * right.M32 + left.M34 * right.M42;
            result.M33 = left.M31 * right.M13 + left.M32 * right.M23 + left.M33 * right.M33 + left.M34 * right.M43;
            result.M34 = left.M31 * right.M14 + left.M32 * right.M24 + left.M33 * right.M34 + left.M34 * right.M44;
            result.M41 = left.M41 * right.M11 + left.M42 * right.M21 + left.M43 * right.M31 + left.M44 * right.M41;
            result.M42 = left.M41 * right.M12 + left.M42 * right.M22 + left.M43 * right.M32 + left.M44 * right.M42;
            result.M43 = left.M41 * right.M13 + left.M42 * right.M23 + left.M43 * right.M33 + left.M44 * right.M43;
            result.M44 = left.M41 * right.M14 + left.M42 * right.M24 + left.M43 * right.M34 + left.M44 * right.M44;
            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixTranslate(float x, float y, float z)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 1.0f,
                M21 = 0.0f,
                M31 = 0.0f,
                M41 = x,
                M12 = 0.0f,
                M22 = 1.0f,
                M32 = 0.0f,
                M42 = y,
                M13 = 0.0f,
                M23 = 0.0f,
                M33 = 1.0f,
                M43 = z,
                M14 = 0.0f,
                M24 = 0.0f,
                M34 = 0.0f,
                M44 = 1.0f,
            };

            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixRotate(Vector3 axis, float angle)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 0,
            };
            float x = axis.X, y = axis.Y, z = axis.Z;
            float lengthSquared = x * x + y * y + z * z;

            if ((lengthSquared != 1.0f) && (lengthSquared != 0.0f))
            {
                float ilength = 1.0f / MathF.Sqrt(lengthSquared);

                x *= ilength;
                y *= ilength;
                z *= ilength;
            }

            float sinres = MathF.Sin(angle);
            float cosres = MathF.Cos(angle);
            float t = 1.0f - cosres;

            result.M11 = x * x * t + cosres;
            result.M12 = y * x * t + z * sinres;
            result.M13 = z * x * t - y * sinres;
            result.M14 = 0.0f;
            result.M21 = x * y * t - z * sinres;
            result.M22 = y * y * t + cosres;
            result.M23 = z * y * t + x * sinres;
            result.M24 = 0.0f;
            result.M31 = x * z * t + y * sinres;
            result.M32 = y * z * t - x * sinres;
            result.M33 = z * z * t + cosres;
            result.M34 = 0.0f;
            result.M41 = 0.0f;
            result.M42 = 0.0f;
            result.M43 = 0.0f;
            result.M44 = 1.0f;
            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixRotateX(float angle)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 1.0f,
                M21 = 0.0f,
                M31 = 0.0f,
                M41 = 0.0f,
                M12 = 0.0f,
                M22 = 1.0f,
                M32 = 0.0f,
                M42 = 0.0f,
                M13 = 0.0f,
                M23 = 0.0f,
                M33 = 1.0f,
                M43 = 0.0f,
                M14 = 0.0f,
                M24 = 0.0f,
                M34 = 0.0f,
                M44 = 1.0f,
            };
            float cosres = MathF.Cos(angle);
            float sinres = MathF.Sin(angle);

            result.M22 = cosres;
            result.M23 = sinres;
            result.M32 = -sinres;
            result.M33 = cosres;
            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixRotateY(float angle)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 1.0f,
                M21 = 0.0f,
                M31 = 0.0f,
                M41 = 0.0f,
                M12 = 0.0f,
                M22 = 1.0f,
                M32 = 0.0f,
                M42 = 0.0f,
                M13 = 0.0f,
                M23 = 0.0f,
                M33 = 1.0f,
                M43 = 0.0f,
                M14 = 0.0f,
                M24 = 0.0f,
                M34 = 0.0f,
                M44 = 1.0f,
            };
            float cosres = MathF.Cos(angle);
            float sinres = MathF.Sin(angle);

            result.M11 = cosres;
            result.M13 = -sinres;
            result.M31 = sinres;
            result.M33 = cosres;
            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixRotateZ(float angle)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 1.0f,
                M21 = 0.0f,
                M31 = 0.0f,
                M41 = 0.0f,
                M12 = 0.0f,
                M22 = 1.0f,
                M32 = 0.0f,
                M42 = 0.0f,
                M13 = 0.0f,
                M23 = 0.0f,
                M33 = 1.0f,
                M43 = 0.0f,
                M14 = 0.0f,
                M24 = 0.0f,
                M34 = 0.0f,
                M44 = 1.0f,
            };
            float cosres = MathF.Cos(angle);
            float sinres = MathF.Sin(angle);

            result.M11 = cosres;
            result.M12 = sinres;
            result.M21 = -sinres;
            result.M22 = cosres;
            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixRotateXYZ(Vector3 angle)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 1.0f,
                M21 = 0.0f,
                M31 = 0.0f,
                M41 = 0.0f,
                M12 = 0.0f,
                M22 = 1.0f,
                M32 = 0.0f,
                M42 = 0.0f,
                M13 = 0.0f,
                M23 = 0.0f,
                M33 = 1.0f,
                M43 = 0.0f,
                M14 = 0.0f,
                M24 = 0.0f,
                M34 = 0.0f,
                M44 = 1.0f,
            };
            float cosz = MathF.Cos(-angle.Z);
            float sinz = MathF.Sin(-angle.Z);
            float cosy = MathF.Cos(-angle.Y);
            float siny = MathF.Sin(-angle.Y);
            float cosx = MathF.Cos(-angle.X);
            float sinx = MathF.Sin(-angle.X);

            result.M11 = cosz * cosy;
            result.M12 = (cosz * siny * sinx) - (sinz * cosx);
            result.M13 = (cosz * siny * cosx) + (sinz * sinx);
            result.M21 = sinz * cosy;
            result.M22 = (sinz * siny * sinx) + (cosz * cosx);
            result.M23 = (sinz * siny * cosx) - (cosz * sinx);
            result.M31 = -siny;
            result.M32 = cosy * sinx;
            result.M33 = cosy * cosx;
            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixRotateZYX(Vector3 angle)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 0,
            };
            float cz = MathF.Cos(angle.Z);
            float sz = MathF.Sin(angle.Z);
            float cy = MathF.Cos(angle.Y);
            float sy = MathF.Sin(angle.Y);
            float cx = MathF.Cos(angle.X);
            float sx = MathF.Sin(angle.X);

            result.M11 = cz * cy;
            result.M21 = cz * sy * sx - cx * sz;
            result.M31 = sz * sx + cz * cx * sy;
            result.M41 = 0;
            result.M12 = cy * sz;
            result.M22 = cz * cx + sz * sy * sx;
            result.M32 = cx * sz * sy - cz * sx;
            result.M42 = 0;
            result.M13 = -sy;
            result.M23 = cy * sx;
            result.M33 = cy * cx;
            result.M43 = 0;
            result.M14 = 0;
            result.M24 = 0;
            result.M34 = 0;
            result.M44 = 1;
            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixScale(float x, float y, float z)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = x,
                M21 = 0.0f,
                M31 = 0.0f,
                M41 = 0.0f,
                M12 = 0.0f,
                M22 = y,
                M32 = 0.0f,
                M42 = 0.0f,
                M13 = 0.0f,
                M23 = 0.0f,
                M33 = z,
                M43 = 0.0f,
                M14 = 0.0f,
                M24 = 0.0f,
                M34 = 0.0f,
                M44 = 1.0f,
            };

            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixFrustum(double left, double right, double bottom, double top, double near, double far)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 0,
            };
            float rl = (float)(right - left);
            float tb = (float)(top - bottom);
            float fn = (float)(far - near);

            result.M11 = ((float)(near) * 2.0f) / rl;
            result.M12 = 0.0f;
            result.M13 = 0.0f;
            result.M14 = 0.0f;
            result.M21 = 0.0f;
            result.M22 = ((float)(near) * 2.0f) / tb;
            result.M23 = 0.0f;
            result.M24 = 0.0f;
            result.M31 = ((float)(right) + (float)(left)) / rl;
            result.M32 = ((float)(top) + (float)(bottom)) / tb;
            result.M33 = -((float)(far) + (float)(near)) / fn;
            result.M34 = -1.0f;
            result.M41 = 0.0f;
            result.M42 = 0.0f;
            result.M43 = -((float)(far) * (float)(near) * 2.0f) / fn;
            result.M44 = 0.0f;
            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixPerspective(double fovy, double aspect, double near, double far)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 0,
            };
            double top = near * Math.Tan(fovy * 0.5);
            double bottom = -top;
            double right = top * aspect;
            double left = -right;
            float rl = (float)(right - left);
            float tb = (float)(top - bottom);
            float fn = (float)(far - near);

            result.M11 = ((float)(near) * 2.0f) / rl;
            result.M22 = ((float)(near) * 2.0f) / tb;
            result.M31 = ((float)(right) + (float)(left)) / rl;
            result.M32 = ((float)(top) + (float)(bottom)) / tb;
            result.M33 = -((float)(far) + (float)(near)) / fn;
            result.M34 = -1.0f;
            result.M43 = -((float)(far) * (float)(near) * 2.0f) / fn;
            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixOrtho(double left, double right, double bottom, double top, double near, double far)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 0,
            };
            float rl = (float)(right - left);
            float tb = (float)(top - bottom);
            float fn = (float)(far - near);

            result.M11 = 2.0f / rl;
            result.M12 = 0.0f;
            result.M13 = 0.0f;
            result.M14 = 0.0f;
            result.M21 = 0.0f;
            result.M22 = 2.0f / tb;
            result.M23 = 0.0f;
            result.M24 = 0.0f;
            result.M31 = 0.0f;
            result.M32 = 0.0f;
            result.M33 = -2.0f / fn;
            result.M34 = 0.0f;
            result.M41 = -((float)(left) + (float)(right)) / rl;
            result.M42 = -((float)(top) + (float)(bottom)) / tb;
            result.M43 = -((float)(far) + (float)(near)) / fn;
            result.M44 = 1.0f;
            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 MatrixLookAt(Vector3 eye, Vector3 target, Vector3 up)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 0,
            };
            float length = 0.0f;
            float ilength = 0.0f;
            Vector3 vz = new Vector3
            {
                X = eye.X - target.X,
                Y = eye.Y - target.Y,
                Z = eye.Z - target.Z,
            };
            Vector3 v = vz;

            length = MathF.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
            if (length == 0.0f)
            {
                length = 1.0f;
            }

            ilength = 1.0f / length;
            vz.X *= ilength;
            vz.Y *= ilength;
            vz.Z *= ilength;
            Vector3 vx = new Vector3
            {
                X = up.Y * vz.Z - up.Z * vz.Y,
                Y = up.Z * vz.X - up.X * vz.Z,
                Z = up.X * vz.Y - up.Y * vz.X,
            };

            v=(vx);
            length = MathF.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
            if (length == 0.0f)
            {
                length = 1.0f;
            }

            ilength = 1.0f / length;
            vx.X *= ilength;
            vx.Y *= ilength;
            vx.Z *= ilength;
            Vector3 vy = new Vector3
            {
                X = vz.Y * vx.Z - vz.Z * vx.Y,
                Y = vz.Z * vx.X - vz.X * vx.Z,
                Z = vz.X * vx.Y - vz.Y * vx.X,
            };

            result.M11 = vx.X;
            result.M12 = vy.X;
            result.M13 = vz.X;
            result.M14 = 0.0f;
            result.M21 = vx.Y;
            result.M22 = vy.Y;
            result.M23 = vz.Y;
            result.M24 = 0.0f;
            result.M31 = vx.Z;
            result.M32 = vy.Z;
            result.M33 = vz.Z;
            result.M34 = 0.0f;
            result.M41 = -(vx.X * eye.X + vx.Y * eye.Y + vx.Z * eye.Z);
            result.M42 = -(vy.X * eye.X + vy.Y * eye.Y + vy.Z * eye.Z);
            result.M43 = -(vz.X * eye.X + vz.Y * eye.Y + vz.Z * eye.Z);
            result.M44 = 1.0f;
            return result;
        }

        public static Quaternion QuaternionAdd(Quaternion q1, Quaternion q2)
        {
            Quaternion result = new Quaternion
            {
                X = q1.X + q2.X,
                Y = q1.Y + q2.Y,
                Z = q1.Z + q2.Z,
                W = q1.W + q2.W,
            };

            return result;
        }

        public static Quaternion QuaternionAddValue(Quaternion q, float add)
        {
            Quaternion result = new Quaternion
            {
                X = q.X + add,
                Y = q.Y + add,
                Z = q.Z + add,
                W = q.W + add,
            };

            return result;
        }

        public static Quaternion QuaternionSubtract(Quaternion q1, Quaternion q2)
        {
            Quaternion result = new Quaternion
            {
                X = q1.X - q2.X,
                Y = q1.Y - q2.Y,
                Z = q1.Z - q2.Z,
                W = q1.W - q2.W,
            };

            return result;
        }

        public static Quaternion QuaternionSubtractValue(Quaternion q, float sub)
        {
            Quaternion result = new Quaternion
            {
                X = q.X - sub,
                Y = q.Y - sub,
                Z = q.Z - sub,
                W = q.W - sub,
            };

            return result;
        }

        public static Quaternion QuaternionIdentity()
        {
            Quaternion result = new Quaternion
            {
                X = 0.0f,
                Y = 0.0f,
                Z = 0.0f,
                W = 1.0f,
            };

            return result;
        }

        public static float QuaternionLength(Quaternion q)
        {
            float result = MathF.Sqrt(q.X * q.X + q.Y * q.Y + q.Z * q.Z + q.W * q.W);

            return result;
        }

        public static Quaternion QuaternionNormalize(Quaternion q)
        {
            Quaternion result = new Quaternion
            {
                X = 0,
            };
            float length = MathF.Sqrt(q.X * q.X + q.Y * q.Y + q.Z * q.Z + q.W * q.W);

            if (length == 0.0f)
            {
                length = 1.0f;
            }

            float ilength = 1.0f / length;

            result.X = q.X * ilength;
            result.Y = q.Y * ilength;
            result.Z = q.Z * ilength;
            result.W = q.W * ilength;
            return result;
        }

        public static Quaternion QuaternionInvert(Quaternion q)
        {
            Quaternion result = q;
            float lengthSq = q.X * q.X + q.Y * q.Y + q.Z * q.Z + q.W * q.W;

            if (lengthSq != 0.0f)
            {
                float invLength = 1.0f / lengthSq;

                result.X *= -invLength;
                result.Y *= -invLength;
                result.Z *= -invLength;
                result.W *= invLength;
            }

            return result;
        }

        public static Quaternion QuaternionMultiply(Quaternion q1, Quaternion q2)
        {
            Quaternion result = new Quaternion
            {
                X = 0,
            };
            float qax = q1.X, qay = q1.Y, qaz = q1.Z, qaw = q1.W;
            float qbx = q2.X, qby = q2.Y, qbz = q2.Z, qbw = q2.W;

            result.X = qax * qbw + qaw * qbx + qay * qbz - qaz * qby;
            result.Y = qay * qbw + qaw * qby + qaz * qbx - qax * qbz;
            result.Z = qaz * qbw + qaw * qbz + qax * qby - qay * qbx;
            result.W = qaw * qbw - qax * qbx - qay * qby - qaz * qbz;
            return result;
        }

        public static Quaternion QuaternionScale(Quaternion q, float mul)
        {
            Quaternion result = new Quaternion
            {
                X = 0,
            };

            result.X = q.X * mul;
            result.Y = q.Y * mul;
            result.Z = q.Z * mul;
            result.W = q.W * mul;
            return result;
        }

        public static Quaternion QuaternionDivide(Quaternion q1, Quaternion q2)
        {
            Quaternion result = new Quaternion
            {
                X = q1.X / q2.X,
                Y = q1.Y / q2.Y,
                Z = q1.Z / q2.Z,
                W = q1.W / q2.W,
            };

            return result;
        }

        public static Quaternion QuaternionLerp(Quaternion q1, Quaternion q2, float amount)
        {
            Quaternion result = new Quaternion
            {
                X = 0,
            };

            result.X = q1.X + amount * (q2.X - q1.X);
            result.Y = q1.Y + amount * (q2.Y - q1.Y);
            result.Z = q1.Z + amount * (q2.Z - q1.Z);
            result.W = q1.W + amount * (q2.W - q1.W);
            return result;
        }

        public static Quaternion QuaternionNlerp(Quaternion q1, Quaternion q2, float amount)
        {
            Quaternion result = new Quaternion
            {
                X = 0,
            };

            result.X = q1.X + amount * (q2.X - q1.X);
            result.Y = q1.Y + amount * (q2.Y - q1.Y);
            result.Z = q1.Z + amount * (q2.Z - q1.Z);
            result.W = q1.W + amount * (q2.W - q1.W);
            Quaternion q = result;
            float length = MathF.Sqrt(q.X * q.X + q.Y * q.Y + q.Z * q.Z + q.W * q.W);

            if (length == 0.0f)
            {
                length = 1.0f;
            }

            float ilength = 1.0f / length;

            result.X = q.X * ilength;
            result.Y = q.Y * ilength;
            result.Z = q.Z * ilength;
            result.W = q.W * ilength;
            return result;
        }

        public static Quaternion QuaternionSlerp(Quaternion q1, Quaternion q2, float amount)
        {
            Quaternion result = new Quaternion
            {
                X = 0,
            };
            float cosHalfTheta = q1.X * q2.X + q1.Y * q2.Y + q1.Z * q2.Z + q1.W * q2.W;

            if (cosHalfTheta < 0)
            {
                q2.X = -q2.X;
                q2.Y = -q2.Y;
                q2.Z = -q2.Z;
                q2.W = -q2.W;
                cosHalfTheta = -cosHalfTheta;
            }

            if (fabsf(cosHalfTheta) >= 1.0f)
            {
                result=(q1);
            }
            else if (cosHalfTheta > 0.95f)
            {
                result=(QuaternionNlerp(q1, q2, amount));
            }
            else
            {
                float halfTheta = MathF.Acos(cosHalfTheta);
                float sinHalfTheta = MathF.Sqrt(1.0f - cosHalfTheta * cosHalfTheta);

                if (fabsf(sinHalfTheta) < 0.001f)
                {
                    result.X = (q1.X * 0.5f + q2.X * 0.5f);
                    result.Y = (q1.Y * 0.5f + q2.Y * 0.5f);
                    result.Z = (q1.Z * 0.5f + q2.Z * 0.5f);
                    result.W = (q1.W * 0.5f + q2.W * 0.5f);
                }
                else
                {
                    float ratioA = MathF.Sin((1 - amount) * halfTheta) / sinHalfTheta;
                    float ratioB = MathF.Sin(amount * halfTheta) / sinHalfTheta;

                    result.X = (q1.X * ratioA + q2.X * ratioB);
                    result.Y = (q1.Y * ratioA + q2.Y * ratioB);
                    result.Z = (q1.Z * ratioA + q2.Z * ratioB);
                    result.W = (q1.W * ratioA + q2.W * ratioB);
                }
            }

            return result;
        }

        public static Quaternion QuaternionFromVector3ToVector3(Vector3 from, Vector3 to)
        {
            Quaternion result = new Quaternion
            {
                X = 0,
            };
            float cos2Theta = (from.X * to.X + from.Y * to.Y + from.Z * to.Z);
            Vector3 cross = new Vector3
            {
                X = from.Y * to.Z - from.Z * to.Y,
                Y = from.Z * to.X - from.X * to.Z,
                Z = from.X * to.Y - from.Y * to.X,
            };

            result.X = cross.X;
            result.Y = cross.Y;
            result.Z = cross.Z;
            result.W = 1.0f + cos2Theta;
            Quaternion q = result;
            float length = MathF.Sqrt(q.X * q.X + q.Y * q.Y + q.Z * q.Z + q.W * q.W);

            if (length == 0.0f)
            {
                length = 1.0f;
            }

            float ilength = 1.0f / length;

            result.X = q.X * ilength;
            result.Y = q.Y * ilength;
            result.Z = q.Z * ilength;
            result.W = q.W * ilength;
            return result;
        }

        public static Quaternion QuaternionFromMatrix([NativeTypeName("Matrix")] Matrix4x4 mat)
        {
            Quaternion result = new Quaternion
            {
                X = 0,
            };
            float fourWSquaredMinus1 = mat.M11 + mat.M22 + mat.M33;
            float fourXSquaredMinus1 = mat.M11 - mat.M22 - mat.M33;
            float fourYSquaredMinus1 = mat.M22 - mat.M11 - mat.M33;
            float fourZSquaredMinus1 = mat.M33 - mat.M11 - mat.M22;
            int biggestIndex = 0;
            float fourBiggestSquaredMinus1 = fourWSquaredMinus1;

            if (fourXSquaredMinus1 > fourBiggestSquaredMinus1)
            {
                fourBiggestSquaredMinus1 = fourXSquaredMinus1;
                biggestIndex = 1;
            }

            if (fourYSquaredMinus1 > fourBiggestSquaredMinus1)
            {
                fourBiggestSquaredMinus1 = fourYSquaredMinus1;
                biggestIndex = 2;
            }

            if (fourZSquaredMinus1 > fourBiggestSquaredMinus1)
            {
                fourBiggestSquaredMinus1 = fourZSquaredMinus1;
                biggestIndex = 3;
            }

            float biggestVal = MathF.Sqrt(fourBiggestSquaredMinus1 + 1.0f) * 0.5f;
            float mult = 0.25f / biggestVal;

            switch (biggestIndex)
            {
                case 0:
                {
                    result.W = biggestVal;
                }

                result.X = (mat.M23 - mat.M32) * mult;
                result.Y = (mat.M31 - mat.M13) * mult;
                result.Z = (mat.M12 - mat.M21) * mult;
                break;
                case 1:
                {
                    result.X = biggestVal;
                }

                result.W = (mat.M23 - mat.M32) * mult;
                result.Y = (mat.M12 + mat.M21) * mult;
                result.Z = (mat.M31 + mat.M13) * mult;
                break;
                case 2:
                {
                    result.Y = biggestVal;
                }

                result.W = (mat.M31 - mat.M13) * mult;
                result.X = (mat.M12 + mat.M21) * mult;
                result.Z = (mat.M23 + mat.M32) * mult;
                break;
                case 3:
                {
                    result.Z = biggestVal;
                }

                result.W = (mat.M12 - mat.M21) * mult;
                result.X = (mat.M31 + mat.M13) * mult;
                result.Y = (mat.M23 + mat.M32) * mult;
                break;
            }

            return result;
        }

        [return: NativeTypeName("Matrix")]
        public static Matrix4x4 QuaternionToMatrix(Quaternion q)
        {
            Matrix4x4 result = new Matrix4x4
            {
                M11 = 1.0f,
                M21 = 0.0f,
                M31 = 0.0f,
                M41 = 0.0f,
                M12 = 0.0f,
                M22 = 1.0f,
                M32 = 0.0f,
                M42 = 0.0f,
                M13 = 0.0f,
                M23 = 0.0f,
                M33 = 1.0f,
                M43 = 0.0f,
                M14 = 0.0f,
                M24 = 0.0f,
                M34 = 0.0f,
                M44 = 1.0f,
            };
            float a2 = q.X * q.X;
            float b2 = q.Y * q.Y;
            float c2 = q.Z * q.Z;
            float ac = q.X * q.Z;
            float ab = q.X * q.Y;
            float bc = q.Y * q.Z;
            float ad = q.W * q.X;
            float bd = q.W * q.Y;
            float cd = q.W * q.Z;

            result.M11 = 1 - 2 * (b2 + c2);
            result.M12 = 2 * (ab + cd);
            result.M13 = 2 * (ac - bd);
            result.M21 = 2 * (ab - cd);
            result.M22 = 1 - 2 * (a2 + c2);
            result.M23 = 2 * (bc + ad);
            result.M31 = 2 * (ac + bd);
            result.M32 = 2 * (bc - ad);
            result.M33 = 1 - 2 * (a2 + b2);
            return result;
        }

        public static Quaternion QuaternionFromAxisAngle(Vector3 axis, float angle)
        {
            Quaternion result = new Quaternion
            {
                X = 0.0f,
                Y = 0.0f,
                Z = 0.0f,
                W = 1.0f,
            };
            float axisLength = MathF.Sqrt(axis.X * axis.X + axis.Y * axis.Y + axis.Z * axis.Z);

            if (axisLength != 0.0f)
            {
                angle *= 0.5f;
                float length = 0.0f;
                float ilength = 0.0f;
                Vector3 v = axis;

                length = MathF.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
                if (length == 0.0f)
                {
                    length = 1.0f;
                }

                ilength = 1.0f / length;
                axis.X *= ilength;
                axis.Y *= ilength;
                axis.Z *= ilength;
                float sinres = MathF.Sin(angle);
                float cosres = MathF.Cos(angle);

                result.X = axis.X * sinres;
                result.Y = axis.Y * sinres;
                result.Z = axis.Z * sinres;
                result.W = cosres;
                Quaternion q = result;

                length = MathF.Sqrt(q.X * q.X + q.Y * q.Y + q.Z * q.Z + q.W * q.W);
                if (length == 0.0f)
                {
                    length = 1.0f;
                }

                ilength = 1.0f / length;
                result.X = q.X * ilength;
                result.Y = q.Y * ilength;
                result.Z = q.Z * ilength;
                result.W = q.W * ilength;
            }

            return result;
        }

        public static void QuaternionToAxisAngle(Quaternion q, Vector3* outAxis, float* outAngle)
        {
            if (fabsf(q.W) > 1.0f)
            {
                float length = MathF.Sqrt(q.X * q.X + q.Y * q.Y + q.Z * q.Z + q.W * q.W);

                if (length == 0.0f)
                {
                    length = 1.0f;
                }

                float ilength = 1.0f / length;

                q.X = q.X * ilength;
                q.Y = q.Y * ilength;
                q.Z = q.Z * ilength;
                q.W = q.W * ilength;
            }

            Vector3 resAxis = new Vector3
            {
                X = 0.0f,
                Y = 0.0f,
                Z = 0.0f,
            };
            float resAngle = 2.0f * MathF.Acos(q.W);
            float den = MathF.Sqrt(1.0f - q.W * q.W);

            if (den > 0.0001f)
            {
                resAxis.X = q.X / den;
                resAxis.Y = q.Y / den;
                resAxis.Z = q.Z / den;
            }
            else
            {
                resAxis.X = 1.0f;
            }

            *outAxis=(resAxis);
            *outAngle = resAngle;
        }

        public static Quaternion QuaternionFromEuler(float pitch, float yaw, float roll)
        {
            Quaternion result = new Quaternion
            {
                X = 0,
            };
            float x0 = MathF.Cos(pitch * 0.5f);
            float x1 = MathF.Sin(pitch * 0.5f);
            float y0 = MathF.Cos(yaw * 0.5f);
            float y1 = MathF.Sin(yaw * 0.5f);
            float z0 = MathF.Cos(roll * 0.5f);
            float z1 = MathF.Sin(roll * 0.5f);

            result.X = x1 * y0 * z0 - x0 * y1 * z1;
            result.Y = x0 * y1 * z0 + x1 * y0 * z1;
            result.Z = x0 * y0 * z1 - x1 * y1 * z0;
            result.W = x0 * y0 * z0 + x1 * y1 * z1;
            return result;
        }

        public static Vector3 QuaternionToEuler(Quaternion q)
        {
            Vector3 result = new Vector3
            {
                X = 0,
            };
            float x0 = 2.0f * (q.W * q.X + q.Y * q.Z);
            float x1 = 1.0f - 2.0f * (q.X * q.X + q.Y * q.Y);

            result.X = MathF.Atan2(x0, x1);
            float y0 = 2.0f * (q.W * q.Y - q.Z * q.X);

            y0 = y0 > 1.0f ? 1.0f : y0;
            y0 = y0 < -1.0f ? -1.0f : y0;
            result.Y = MathF.Asin(y0);
            float z0 = 2.0f * (q.W * q.Z + q.X * q.Y);
            float z1 = 1.0f - 2.0f * (q.Y * q.Y + q.Z * q.Z);

            result.Z = MathF.Atan2(z0, z1);
            return result;
        }

        public static Quaternion QuaternionTransform(Quaternion q, [NativeTypeName("Matrix")] Matrix4x4 mat)
        {
            Quaternion result = new Quaternion
            {
                X = 0,
            };

            result.X = mat.M11 * q.X + mat.M21 * q.Y + mat.M31 * q.Z + mat.M41 * q.W;
            result.Y = mat.M12 * q.X + mat.M22 * q.Y + mat.M32 * q.Z + mat.M42 * q.W;
            result.Z = mat.M13 * q.X + mat.M23 * q.Y + mat.M33 * q.Z + mat.M43 * q.W;
            result.W = mat.M14 * q.X + mat.M24 * q.Y + mat.M34 * q.Z + mat.M44 * q.W;
            return result;
        }

        public static int QuaternionEquals(Quaternion p, Quaternion q)
        {
            int result = ((((fabsf(p.X - q.X)) <= (0.000001f * MathF.Max(1.0f, MathF.Max(fabsf(p.X), fabsf(q.X))))) && ((fabsf(p.Y - q.Y)) <= (0.000001f * MathF.Max(1.0f, MathF.Max(fabsf(p.Y), fabsf(q.Y))))) && ((fabsf(p.Z - q.Z)) <= (0.000001f * MathF.Max(1.0f, MathF.Max(fabsf(p.Z), fabsf(q.Z))))) && ((fabsf(p.W - q.W)) <= (0.000001f * MathF.Max(1.0f, MathF.Max(fabsf(p.W), fabsf(q.W)))))) || (((fabsf(p.X + q.X)) <= (0.000001f * MathF.Max(1.0f, MathF.Max(fabsf(p.X), fabsf(q.X))))) && ((fabsf(p.Y + q.Y)) <= (0.000001f * MathF.Max(1.0f, MathF.Max(fabsf(p.Y), fabsf(q.Y))))) && ((fabsf(p.Z + q.Z)) <= (0.000001f * MathF.Max(1.0f, MathF.Max(fabsf(p.Z), fabsf(q.Z))))) && ((fabsf(p.W + q.W)) <= (0.000001f * MathF.Max(1.0f, MathF.Max(fabsf(p.W), fabsf(q.W))))))) ? 1 : 0;

            return result;
        }

        [NativeTypeName("#define PI 3.14159265358979323846f")]
        public const float PI = 3.14159265358979323846f;

        [NativeTypeName("#define EPSILON 0.000001f")]
        public const float EPSILON = 0.000001f;

        [NativeTypeName("#define DEG2RAD (PI/180.0f)")]
        public const float DEG2RAD = (3.14159265358979323846f / 180.0f);

        [NativeTypeName("#define RAD2DEG (180.0f/PI)")]
        public const float RAD2DEG = (180.0f / 3.14159265358979323846f);
    }
}
