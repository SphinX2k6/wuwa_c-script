using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000A7 RID: 167
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/Engine.Vector_NetQuantize100")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FVector_NetQuantize100 : IVector, IVector2D, IEqualityOperators<FVector_NetQuantize100, FVector_NetQuantize100, bool>, IEquatable<FVector_NetQuantize100>, IUnrealScriptStruct
	{
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x0001446A File Offset: 0x0001266A
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x00014473 File Offset: 0x00012673
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

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x0001447D File Offset: 0x0001267D
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x00014486 File Offset: 0x00012686
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

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00014490 File Offset: 0x00012690
		// (set) Token: 0x06000CAD RID: 3245 RVA: 0x00014499 File Offset: 0x00012699
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

		// Token: 0x06000CAE RID: 3246 RVA: 0x000144A3 File Offset: 0x000126A3
		public unsafe static implicit operator FVector(in FVector_NetQuantize100 a)
		{
			return *Unsafe.As<FVector_NetQuantize100, FVector>(Unsafe.AsRef<FVector_NetQuantize100>(ref a));
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x000144B5 File Offset: 0x000126B5
		public FVector_NetQuantize100(float X, float Y, float Z)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x000144CC File Offset: 0x000126CC
		public static bool operator ==(FVector_NetQuantize100 left, FVector_NetQuantize100 right)
		{
			return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x000144FA File Offset: 0x000126FA
		public static bool operator !=(FVector_NetQuantize100 left, FVector_NetQuantize100 right)
		{
			return !(left == right);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00014506 File Offset: 0x00012706
		public bool Equals(FVector_NetQuantize100 other)
		{
			return this == other;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00014514 File Offset: 0x00012714
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

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00014539 File Offset: 0x00012739
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.X, this.Y, this.Z);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00014552 File Offset: 0x00012752
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector_NetQuantize100._ScriptStructPtr != 0) ? FVector_NetQuantize100._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Vector_NetQuantize100", ref FVector_NetQuantize100._ScriptStructPtr);
		}

		// Token: 0x04000219 RID: 537
		[FieldOffset(0)]
		public float X;

		// Token: 0x0400021A RID: 538
		[FieldOffset(4)]
		public float Y;

		// Token: 0x0400021B RID: 539
		[FieldOffset(8)]
		public float Z;

		// Token: 0x0400021C RID: 540
		public const string __ObjectPath = "/Script/Engine.Vector_NetQuantize100";

		// Token: 0x0400021D RID: 541
		private static IntPtr _ScriptStructPtr;
	}
}
