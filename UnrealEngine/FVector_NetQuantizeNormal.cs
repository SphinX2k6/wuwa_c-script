using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000BF RID: 191
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/Engine.Vector_NetQuantizeNormal")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FVector_NetQuantizeNormal : IVector, IVector2D, IEqualityOperators<FVector_NetQuantizeNormal, FVector_NetQuantizeNormal, bool>, IEquatable<FVector_NetQuantizeNormal>, IUnrealScriptStruct
	{
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x0001941F File Offset: 0x0001761F
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x00019428 File Offset: 0x00017628
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

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x00019432 File Offset: 0x00017632
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x0001943B File Offset: 0x0001763B
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

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x00019445 File Offset: 0x00017645
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x0001944E File Offset: 0x0001764E
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

		// Token: 0x060010F1 RID: 4337 RVA: 0x00019458 File Offset: 0x00017658
		public unsafe static implicit operator FVector(in FVector_NetQuantizeNormal a)
		{
			return *Unsafe.As<FVector_NetQuantizeNormal, FVector>(Unsafe.AsRef<FVector_NetQuantizeNormal>(ref a));
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0001946A File Offset: 0x0001766A
		public FVector_NetQuantizeNormal(float X, float Y, float Z)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00019481 File Offset: 0x00017681
		public static bool operator ==(FVector_NetQuantizeNormal left, FVector_NetQuantizeNormal right)
		{
			return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x000194AF File Offset: 0x000176AF
		public static bool operator !=(FVector_NetQuantizeNormal left, FVector_NetQuantizeNormal right)
		{
			return !(left == right);
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x000194BB File Offset: 0x000176BB
		public bool Equals(FVector_NetQuantizeNormal other)
		{
			return this == other;
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x000194CC File Offset: 0x000176CC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FVector_NetQuantizeNormal)
			{
				FVector_NetQuantizeNormal other = (FVector_NetQuantizeNormal)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x000194F1 File Offset: 0x000176F1
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.X, this.Y, this.Z);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0001950A File Offset: 0x0001770A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector_NetQuantizeNormal._ScriptStructPtr != 0) ? FVector_NetQuantizeNormal._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Vector_NetQuantizeNormal", ref FVector_NetQuantizeNormal._ScriptStructPtr);
		}

		// Token: 0x04000251 RID: 593
		[FieldOffset(0)]
		public float X;

		// Token: 0x04000252 RID: 594
		[FieldOffset(4)]
		public float Y;

		// Token: 0x04000253 RID: 595
		[FieldOffset(8)]
		public float Z;

		// Token: 0x04000254 RID: 596
		public const string __ObjectPath = "/Script/Engine.Vector_NetQuantizeNormal";

		// Token: 0x04000255 RID: 597
		private static IntPtr _ScriptStructPtr;
	}
}
