using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000A4 RID: 164
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/Engine.Vector_NetQuantizeNormal")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FVector_NetQuantizeNormal : IVector, IVector2D, IEqualityOperators<FVector_NetQuantizeNormal, FVector_NetQuantizeNormal, bool>, IEquatable<FVector_NetQuantizeNormal>, IUnrealScriptStruct
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x00014143 File Offset: 0x00012343
		// (set) Token: 0x06000C7F RID: 3199 RVA: 0x0001414C File Offset: 0x0001234C
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00014156 File Offset: 0x00012356
		// (set) Token: 0x06000C81 RID: 3201 RVA: 0x0001415F File Offset: 0x0001235F
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00014169 File Offset: 0x00012369
		// (set) Token: 0x06000C83 RID: 3203 RVA: 0x00014172 File Offset: 0x00012372
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

		// Token: 0x06000C84 RID: 3204 RVA: 0x0001417C File Offset: 0x0001237C
		public unsafe static implicit operator FVector(in FVector_NetQuantizeNormal a)
		{
			return *Unsafe.As<FVector_NetQuantizeNormal, FVector>(Unsafe.AsRef<FVector_NetQuantizeNormal>(ref a));
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0001418E File Offset: 0x0001238E
		public FVector_NetQuantizeNormal(float X, float Y, float Z)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x000141A5 File Offset: 0x000123A5
		public static bool operator ==(FVector_NetQuantizeNormal left, FVector_NetQuantizeNormal right)
		{
			return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x000141D3 File Offset: 0x000123D3
		public static bool operator !=(FVector_NetQuantizeNormal left, FVector_NetQuantizeNormal right)
		{
			return !(left == right);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000141DF File Offset: 0x000123DF
		public bool Equals(FVector_NetQuantizeNormal other)
		{
			return this == other;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000141F0 File Offset: 0x000123F0
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

		// Token: 0x06000C8A RID: 3210 RVA: 0x00014215 File Offset: 0x00012415
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.X, this.Y, this.Z);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0001422E File Offset: 0x0001242E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector_NetQuantizeNormal._ScriptStructPtr != 0) ? FVector_NetQuantizeNormal._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Vector_NetQuantizeNormal", ref FVector_NetQuantizeNormal._ScriptStructPtr);
		}

		// Token: 0x0400020A RID: 522
		[FieldOffset(0)]
		public float X;

		// Token: 0x0400020B RID: 523
		[FieldOffset(4)]
		public float Y;

		// Token: 0x0400020C RID: 524
		[FieldOffset(8)]
		public float Z;

		// Token: 0x0400020D RID: 525
		public const string __ObjectPath = "/Script/Engine.Vector_NetQuantizeNormal";

		// Token: 0x0400020E RID: 526
		private static IntPtr _ScriptStructPtr;
	}
}
