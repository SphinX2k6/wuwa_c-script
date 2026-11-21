using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000A6 RID: 166
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/Engine.Vector_NetQuantize10")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FVector_NetQuantize10 : IVector, IVector2D, IEqualityOperators<FVector_NetQuantize10, FVector_NetQuantize10, bool>, IEquatable<FVector_NetQuantize10>, IUnrealScriptStruct
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x0001435E File Offset: 0x0001255E
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x00014367 File Offset: 0x00012567
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

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x00014371 File Offset: 0x00012571
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x0001437A File Offset: 0x0001257A
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

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00014384 File Offset: 0x00012584
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x0001438D File Offset: 0x0001258D
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

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00014397 File Offset: 0x00012597
		public unsafe static implicit operator FVector(in FVector_NetQuantize10 a)
		{
			return *Unsafe.As<FVector_NetQuantize10, FVector>(Unsafe.AsRef<FVector_NetQuantize10>(ref a));
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x000143A9 File Offset: 0x000125A9
		public FVector_NetQuantize10(float X, float Y, float Z)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000143C0 File Offset: 0x000125C0
		public static bool operator ==(FVector_NetQuantize10 left, FVector_NetQuantize10 right)
		{
			return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x000143EE File Offset: 0x000125EE
		public static bool operator !=(FVector_NetQuantize10 left, FVector_NetQuantize10 right)
		{
			return !(left == right);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x000143FA File Offset: 0x000125FA
		public bool Equals(FVector_NetQuantize10 other)
		{
			return this == other;
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00014408 File Offset: 0x00012608
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FVector_NetQuantize10)
			{
				FVector_NetQuantize10 other = (FVector_NetQuantize10)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0001442D File Offset: 0x0001262D
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.X, this.Y, this.Z);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00014446 File Offset: 0x00012646
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector_NetQuantize10._ScriptStructPtr != 0) ? FVector_NetQuantize10._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Vector_NetQuantize10", ref FVector_NetQuantize10._ScriptStructPtr);
		}

		// Token: 0x04000214 RID: 532
		[FieldOffset(0)]
		public float X;

		// Token: 0x04000215 RID: 533
		[FieldOffset(4)]
		public float Y;

		// Token: 0x04000216 RID: 534
		[FieldOffset(8)]
		public float Z;

		// Token: 0x04000217 RID: 535
		public const string __ObjectPath = "/Script/Engine.Vector_NetQuantize10";

		// Token: 0x04000218 RID: 536
		private static IntPtr _ScriptStructPtr;
	}
}
