using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000C1 RID: 193
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/Engine.Vector_NetQuantize10")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FVector_NetQuantize10 : IVector, IVector2D, IEqualityOperators<FVector_NetQuantize10, FVector_NetQuantize10, bool>, IEquatable<FVector_NetQuantize10>, IUnrealScriptStruct
	{
		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x0001963A File Offset: 0x0001783A
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x00019643 File Offset: 0x00017843
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

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x0001964D File Offset: 0x0001784D
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x00019656 File Offset: 0x00017856
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

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x00019660 File Offset: 0x00017860
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x00019669 File Offset: 0x00017869
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

		// Token: 0x0600110D RID: 4365 RVA: 0x00019673 File Offset: 0x00017873
		public unsafe static implicit operator FVector(in FVector_NetQuantize10 a)
		{
			return *Unsafe.As<FVector_NetQuantize10, FVector>(Unsafe.AsRef<FVector_NetQuantize10>(ref a));
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00019685 File Offset: 0x00017885
		public FVector_NetQuantize10(float X, float Y, float Z)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x0001969C File Offset: 0x0001789C
		public static bool operator ==(FVector_NetQuantize10 left, FVector_NetQuantize10 right)
		{
			return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x000196CA File Offset: 0x000178CA
		public static bool operator !=(FVector_NetQuantize10 left, FVector_NetQuantize10 right)
		{
			return !(left == right);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x000196D6 File Offset: 0x000178D6
		public bool Equals(FVector_NetQuantize10 other)
		{
			return this == other;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x000196E4 File Offset: 0x000178E4
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

		// Token: 0x06001113 RID: 4371 RVA: 0x00019709 File Offset: 0x00017909
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.X, this.Y, this.Z);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00019722 File Offset: 0x00017922
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector_NetQuantize10._ScriptStructPtr != 0) ? FVector_NetQuantize10._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Vector_NetQuantize10", ref FVector_NetQuantize10._ScriptStructPtr);
		}

		// Token: 0x0400025B RID: 603
		[FieldOffset(0)]
		public float X;

		// Token: 0x0400025C RID: 604
		[FieldOffset(4)]
		public float Y;

		// Token: 0x0400025D RID: 605
		[FieldOffset(8)]
		public float Z;

		// Token: 0x0400025E RID: 606
		public const string __ObjectPath = "/Script/Engine.Vector_NetQuantize10";

		// Token: 0x0400025F RID: 607
		private static IntPtr _ScriptStructPtr;
	}
}
