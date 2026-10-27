using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000C0 RID: 192
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/Engine.Vector_NetQuantize")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FVector_NetQuantize : IVector, IVector2D, IEqualityOperators<FVector_NetQuantize, FVector_NetQuantize, bool>, IEquatable<FVector_NetQuantize>, IUnrealScriptStruct
	{
		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0001952E File Offset: 0x0001772E
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x00019537 File Offset: 0x00017737
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

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x00019541 File Offset: 0x00017741
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x0001954A File Offset: 0x0001774A
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

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x00019554 File Offset: 0x00017754
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x0001955D File Offset: 0x0001775D
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

		// Token: 0x060010FF RID: 4351 RVA: 0x00019567 File Offset: 0x00017767
		public unsafe static implicit operator FVector(in FVector_NetQuantize a)
		{
			return *Unsafe.As<FVector_NetQuantize, FVector>(Unsafe.AsRef<FVector_NetQuantize>(ref a));
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00019579 File Offset: 0x00017779
		public FVector_NetQuantize(float X, float Y, float Z)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00019590 File Offset: 0x00017790
		public static bool operator ==(FVector_NetQuantize left, FVector_NetQuantize right)
		{
			return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x000195BE File Offset: 0x000177BE
		public static bool operator !=(FVector_NetQuantize left, FVector_NetQuantize right)
		{
			return !(left == right);
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x000195CA File Offset: 0x000177CA
		public bool Equals(FVector_NetQuantize other)
		{
			return this == other;
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x000195D8 File Offset: 0x000177D8
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

		// Token: 0x06001105 RID: 4357 RVA: 0x000195FD File Offset: 0x000177FD
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.X, this.Y, this.Z);
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00019616 File Offset: 0x00017816
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector_NetQuantize._ScriptStructPtr != 0) ? FVector_NetQuantize._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Vector_NetQuantize", ref FVector_NetQuantize._ScriptStructPtr);
		}

		// Token: 0x04000256 RID: 598
		[FieldOffset(0)]
		public float X;

		// Token: 0x04000257 RID: 599
		[FieldOffset(4)]
		public float Y;

		// Token: 0x04000258 RID: 600
		[FieldOffset(8)]
		public float Z;

		// Token: 0x04000259 RID: 601
		public const string __ObjectPath = "/Script/Engine.Vector_NetQuantize";

		// Token: 0x0400025A RID: 602
		private static IntPtr _ScriptStructPtr;
	}
}
