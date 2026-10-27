using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000035 RID: 53
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(60, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 60)]
	[UnrealObjectPath("/Script/CoreUObject.OrientedBox")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 60)]
	public struct FOrientedBox : IEquatable<FOrientedBox>, IEqualityOperators<FOrientedBox, FOrientedBox, bool>, IUnrealScriptStruct
	{
		// Token: 0x06000317 RID: 791 RVA: 0x00009774 File Offset: 0x00007974
		public FOrientedBox()
		{
			this = FOrientedBox.UnitBox;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00009784 File Offset: 0x00007984
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

		// Token: 0x06000319 RID: 793 RVA: 0x00009860 File Offset: 0x00007A60
		public static bool operator ==(FOrientedBox left, FOrientedBox right)
		{
			return left.Center == right.Center && left.AxisX == right.AxisX && left.AxisY == right.AxisY && left.AxisZ == right.AxisZ && left.ExtentX == right.ExtentX && left.ExtentY == right.ExtentY && left.ExtentZ == right.ExtentZ;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000098E5 File Offset: 0x00007AE5
		public static bool operator !=(FOrientedBox left, FOrientedBox right)
		{
			return !(left == right);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000098F4 File Offset: 0x00007AF4
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

		// Token: 0x0600031C RID: 796 RVA: 0x0000991E File Offset: 0x00007B1E
		public readonly bool Equals(FOrientedBox other)
		{
			return this == other;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000992C File Offset: 0x00007B2C
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<FVector, FVector, FVector, FVector, float, float, float>(this.Center, this.AxisX, this.AxisY, this.AxisZ, this.ExtentX, this.ExtentY, this.ExtentZ);
		}

		// Token: 0x0600031E RID: 798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FOrientedBox a);

		// Token: 0x0600031F RID: 799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void Internal_CalcVertices_float(in FOrientedBox a, float* outVerts);

		// Token: 0x06000320 RID: 800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern bool Internal_CalcVertices(in FOrientedBox a, FVector* outVertices);

		// Token: 0x06000321 RID: 801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FFloatInterval Internal_Project(in FOrientedBox a, in FVector axis);

		// Token: 0x06000322 RID: 802 RVA: 0x00009960 File Offset: 0x00007B60
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FOrientedBox* ptr = &this)
			{
				return FOrientedBox.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00009978 File Offset: 0x00007B78
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

		// Token: 0x06000324 RID: 804 RVA: 0x000099BC File Offset: 0x00007BBC
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

		// Token: 0x06000325 RID: 805 RVA: 0x00009A00 File Offset: 0x00007C00
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

		// Token: 0x06000326 RID: 806 RVA: 0x00009A1C File Offset: 0x00007C1C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOrientedBox._ScriptStructPtr != 0) ? FOrientedBox._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.OrientedBox", ref FOrientedBox._ScriptStructPtr);
		}

		// Token: 0x040000CE RID: 206
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

		// Token: 0x040000CF RID: 207
		[FieldOffset(0)]
		public FVector Center;

		// Token: 0x040000D0 RID: 208
		[FieldOffset(12)]
		public FVector AxisX;

		// Token: 0x040000D1 RID: 209
		[FieldOffset(24)]
		public FVector AxisY;

		// Token: 0x040000D2 RID: 210
		[FieldOffset(36)]
		public FVector AxisZ;

		// Token: 0x040000D3 RID: 211
		[FieldOffset(48)]
		public float ExtentX;

		// Token: 0x040000D4 RID: 212
		[FieldOffset(52)]
		public float ExtentY;

		// Token: 0x040000D5 RID: 213
		[FieldOffset(56)]
		public float ExtentZ;

		// Token: 0x040000D6 RID: 214
		public const string __ObjectPath = "/Script/CoreUObject.OrientedBox";

		// Token: 0x040000D7 RID: 215
		private static IntPtr _ScriptStructPtr;
	}
}
