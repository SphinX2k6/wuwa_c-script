using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200001A RID: 26
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(60, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 60)]
	[UnrealObjectPath("/Script/CoreUObject.OrientedBox")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 60)]
	public struct FOrientedBox : IEquatable<FOrientedBox>, IEqualityOperators<FOrientedBox, FOrientedBox, bool>, IUnrealScriptStruct
	{
		// Token: 0x0600029C RID: 668 RVA: 0x00005FE0 File Offset: 0x000041E0
		public FOrientedBox()
		{
			this = FOrientedBox.UnitBox;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00005FF0 File Offset: 0x000041F0
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(71, 7);
			defaultInterpolatedStringHandler.AppendLiteral("Center=");
			defaultInterpolatedStringHandler.AppendFormatted<FVector>(this.Center);
			defaultInterpolatedStringHandler.AppendLiteral(", AxisX=(");
			defaultInterpolatedStringHandler.AppendFormatted<FVector>(this.AxisX);
			defaultInterpolatedStringHandler.AppendLiteral("), ExtentX=(");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.ExtentX);
			defaultInterpolatedStringHandler.AppendLiteral("), AxisY=(");
			defaultInterpolatedStringHandler.AppendFormatted<FVector>(this.AxisY);
			defaultInterpolatedStringHandler.AppendLiteral("), ExtentY=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.ExtentY);
			defaultInterpolatedStringHandler.AppendLiteral(", AxisZ=(");
			defaultInterpolatedStringHandler.AppendFormatted<FVector>(this.AxisZ);
			defaultInterpolatedStringHandler.AppendLiteral("), ExtentZ=(");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.ExtentZ);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000060CC File Offset: 0x000042CC
		public static bool operator ==(FOrientedBox left, FOrientedBox right)
		{
			return left.Center == right.Center && left.AxisX == right.AxisX && left.AxisY == right.AxisY && left.AxisZ == right.AxisZ && left.ExtentX == right.ExtentX && left.ExtentY == right.ExtentY && left.ExtentZ == right.ExtentZ;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00006151 File Offset: 0x00004351
		public static bool operator !=(FOrientedBox left, FOrientedBox right)
		{
			return !(left == right);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00006160 File Offset: 0x00004360
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FOrientedBox)
			{
				FOrientedBox right = (FOrientedBox)obj;
				return this == right;
			}
			return false;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000618A File Offset: 0x0000438A
		public readonly bool Equals(FOrientedBox other)
		{
			return this == other;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00006198 File Offset: 0x00004398
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<FVector, FVector, FVector, FVector, float, float, float>(this.Center, this.AxisX, this.AxisY, this.AxisZ, this.ExtentX, this.ExtentY, this.ExtentZ);
		}

		// Token: 0x060002A3 RID: 675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FOrientedBox a);

		// Token: 0x060002A4 RID: 676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void Internal_CalcVertices_float(in FOrientedBox a, float* outVerts);

		// Token: 0x060002A5 RID: 677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern bool Internal_CalcVertices(in FOrientedBox a, FVector* outVertices);

		// Token: 0x060002A6 RID: 678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FFloatInterval Internal_Project(in FOrientedBox a, in FVector axis);

		// Token: 0x060002A7 RID: 679 RVA: 0x000061CC File Offset: 0x000043CC
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FOrientedBox* ptr = &this)
			{
				return FOrientedBox.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000061E4 File Offset: 0x000043E4
		public unsafe readonly void CalcVertices(Span<float> verts)
		{
			if (verts.Length < 24)
			{
				throw new ArgumentException("Output array must have at least 24 elements", "verts");
			}
			fixed (FOrientedBox* ptr = &this)
			{
				fixed (float* pinnableReference = verts.GetPinnableReference())
				{
					float* outVerts = pinnableReference;
					FOrientedBox.Internal_CalcVertices_float(this, outVerts);
				}
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00006228 File Offset: 0x00004428
		public unsafe readonly void CalcVertices(Span<FVector> verts)
		{
			if (verts.Length < 8)
			{
				throw new ArgumentException("Output array must have at least 8 elements", "verts");
			}
			fixed (FOrientedBox* ptr = &this)
			{
				fixed (FVector* pinnableReference = verts.GetPinnableReference())
				{
					FVector* outVertices = pinnableReference;
					FOrientedBox.Internal_CalcVertices(this, outVertices);
				}
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000626C File Offset: 0x0000446C
		public unsafe readonly FFloatInterval Project(in FVector axis)
		{
			fixed (FOrientedBox* ptr = &this)
			{
				fixed (FVector* ptr2 = &axis)
				{
					return FOrientedBox.Internal_Project(this, axis);
				}
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00006288 File Offset: 0x00004488
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOrientedBox._ScriptStructPtr != 0) ? FOrientedBox._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.OrientedBox", ref FOrientedBox._ScriptStructPtr);
		}

		// Token: 0x04000087 RID: 135
		public static readonly FOrientedBox UnitBox = new FOrientedBox
		{
			Center = FVector.ZeroVector,
			AxisX = new FVector(1f, 0f, 0f),
			AxisY = new FVector(0f, 1f, 0f),
			AxisZ = new FVector(0f, 0f, 1f),
			ExtentX = 1f,
			ExtentY = 1f,
			ExtentZ = 1f
		};

		// Token: 0x04000088 RID: 136
		[FieldOffset(0)]
		public FVector Center;

		// Token: 0x04000089 RID: 137
		[FieldOffset(12)]
		public FVector AxisX;

		// Token: 0x0400008A RID: 138
		[FieldOffset(24)]
		public FVector AxisY;

		// Token: 0x0400008B RID: 139
		[FieldOffset(36)]
		public FVector AxisZ;

		// Token: 0x0400008C RID: 140
		[FieldOffset(48)]
		public float ExtentX;

		// Token: 0x0400008D RID: 141
		[FieldOffset(52)]
		public float ExtentY;

		// Token: 0x0400008E RID: 142
		[FieldOffset(56)]
		public float ExtentZ;

		// Token: 0x0400008F RID: 143
		public const string __ObjectPath = "/Script/CoreUObject.OrientedBox";

		// Token: 0x04000090 RID: 144
		private static IntPtr _ScriptStructPtr;
	}
}
