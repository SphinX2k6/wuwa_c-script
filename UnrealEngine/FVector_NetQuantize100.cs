using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000C2 RID: 194
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/Engine.Vector_NetQuantize100")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FVector_NetQuantize100 : IVector, IVector2D, IEqualityOperators<FVector_NetQuantize100, FVector_NetQuantize100, bool>, IEquatable<FVector_NetQuantize100>, IUnrealScriptStruct
	{
		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x00019746 File Offset: 0x00017946
		// (set) Token: 0x06001116 RID: 4374 RVA: 0x0001974F File Offset: 0x0001794F
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

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x00019759 File Offset: 0x00017959
		// (set) Token: 0x06001118 RID: 4376 RVA: 0x00019762 File Offset: 0x00017962
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

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x0001976C File Offset: 0x0001796C
		// (set) Token: 0x0600111A RID: 4378 RVA: 0x00019775 File Offset: 0x00017975
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

		// Token: 0x0600111B RID: 4379 RVA: 0x0001977F File Offset: 0x0001797F
		public unsafe static implicit operator FVector(in FVector_NetQuantize100 a)
		{
			return *Unsafe.As<FVector_NetQuantize100, FVector>(Unsafe.AsRef<FVector_NetQuantize100>(ref a));
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00019791 File Offset: 0x00017991
		public FVector_NetQuantize100(float X, float Y, float Z)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x000197A8 File Offset: 0x000179A8
		public static bool operator ==(FVector_NetQuantize100 left, FVector_NetQuantize100 right)
		{
			return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x000197D6 File Offset: 0x000179D6
		public static bool operator !=(FVector_NetQuantize100 left, FVector_NetQuantize100 right)
		{
			return !(left == right);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x000197E2 File Offset: 0x000179E2
		public bool Equals(FVector_NetQuantize100 other)
		{
			return this == other;
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x000197F0 File Offset: 0x000179F0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FVector_NetQuantize100)
			{
				FVector_NetQuantize100 other = (FVector_NetQuantize100)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00019815 File Offset: 0x00017A15
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.X, this.Y, this.Z);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0001982E File Offset: 0x00017A2E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector_NetQuantize100._ScriptStructPtr != 0) ? FVector_NetQuantize100._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Vector_NetQuantize100", ref FVector_NetQuantize100._ScriptStructPtr);
		}

		// Token: 0x04000260 RID: 608
		[FieldOffset(0)]
		public float X;

		// Token: 0x04000261 RID: 609
		[FieldOffset(4)]
		public float Y;

		// Token: 0x04000262 RID: 610
		[FieldOffset(8)]
		public float Z;

		// Token: 0x04000263 RID: 611
		public const string __ObjectPath = "/Script/Engine.Vector_NetQuantize100";

		// Token: 0x04000264 RID: 612
		private static IntPtr _ScriptStructPtr;
	}
}
