using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000A5 RID: 165
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/Engine.Vector_NetQuantize")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FVector_NetQuantize : IVector, IVector2D, IEqualityOperators<FVector_NetQuantize, FVector_NetQuantize, bool>, IEquatable<FVector_NetQuantize>, IUnrealScriptStruct
	{
		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00014252 File Offset: 0x00012452
		// (set) Token: 0x06000C8D RID: 3213 RVA: 0x0001425B File Offset: 0x0001245B
		double IVector2D.X
		{
			get
			{
				return (double)this.X;
			}
			set
			{
				this.X = (float)value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00014265 File Offset: 0x00012465
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x0001426E File Offset: 0x0001246E
		double IVector2D.Y
		{
			get
			{
				return (double)this.Y;
			}
			set
			{
				this.Y = (float)value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00014278 File Offset: 0x00012478
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00014281 File Offset: 0x00012481
		double IVector.Z
		{
			get
			{
				return (double)this.Z;
			}
			set
			{
				this.Z = (float)value;
			}
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0001428B File Offset: 0x0001248B
		public unsafe static implicit operator FVector(in FVector_NetQuantize a)
		{
			return *Unsafe.As<FVector_NetQuantize, FVector>(Unsafe.AsRef<FVector_NetQuantize>(ref a));
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0001429D File Offset: 0x0001249D
		public FVector_NetQuantize(float X, float Y, float Z)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x000142B4 File Offset: 0x000124B4
		public static bool operator ==(FVector_NetQuantize left, FVector_NetQuantize right)
		{
			return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x000142E2 File Offset: 0x000124E2
		public static bool operator !=(FVector_NetQuantize left, FVector_NetQuantize right)
		{
			return !(left == right);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x000142EE File Offset: 0x000124EE
		public bool Equals(FVector_NetQuantize other)
		{
			return this == other;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x000142FC File Offset: 0x000124FC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FVector_NetQuantize)
			{
				FVector_NetQuantize other = (FVector_NetQuantize)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00014321 File Offset: 0x00012521
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.X, this.Y, this.Z);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x0001433A File Offset: 0x0001253A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector_NetQuantize._ScriptStructPtr != 0) ? FVector_NetQuantize._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Vector_NetQuantize", ref FVector_NetQuantize._ScriptStructPtr);
		}

		// Token: 0x0400020F RID: 527
		[FieldOffset(0)]
		public float X;

		// Token: 0x04000210 RID: 528
		[FieldOffset(4)]
		public float Y;

		// Token: 0x04000211 RID: 529
		[FieldOffset(8)]
		public float Z;

		// Token: 0x04000212 RID: 530
		public const string __ObjectPath = "/Script/Engine.Vector_NetQuantize";

		// Token: 0x04000213 RID: 531
		private static IntPtr _ScriptStructPtr;
	}
}
