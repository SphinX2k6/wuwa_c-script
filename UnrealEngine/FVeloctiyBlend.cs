using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000308 RID: 776
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/KuroAnim.VeloctiyBlend")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FVeloctiyBlend : IEqualityOperators<FVeloctiyBlend, FVeloctiyBlend, bool>, IEquatable<FVeloctiyBlend>, IUnrealScriptStruct
	{
		// Token: 0x0600531E RID: 21278 RVA: 0x00074352 File Offset: 0x00072552
		public FVeloctiyBlend(float Forward, float Backward, float Left, float Right)
		{
			this.Forward = Forward;
			this.Backward = Backward;
			this.Left = Left;
			this.Right = Right;
		}

		// Token: 0x0600531F RID: 21279 RVA: 0x00074371 File Offset: 0x00072571
		public static bool operator ==(FVeloctiyBlend left, FVeloctiyBlend right)
		{
			return left.Forward == right.Forward && left.Backward == right.Backward && left.Left == right.Left && left.Right == right.Right;
		}

		// Token: 0x06005320 RID: 21280 RVA: 0x000743AD File Offset: 0x000725AD
		public static bool operator !=(FVeloctiyBlend left, FVeloctiyBlend right)
		{
			return !(left == right);
		}

		// Token: 0x06005321 RID: 21281 RVA: 0x000743B9 File Offset: 0x000725B9
		public bool Equals(FVeloctiyBlend other)
		{
			return this == other;
		}

		// Token: 0x06005322 RID: 21282 RVA: 0x000743C8 File Offset: 0x000725C8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FVeloctiyBlend)
			{
				FVeloctiyBlend other = (FVeloctiyBlend)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06005323 RID: 21283 RVA: 0x000743ED File Offset: 0x000725ED
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.Forward, this.Backward, this.Left, this.Right);
		}

		// Token: 0x06005324 RID: 21284 RVA: 0x0007440C File Offset: 0x0007260C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVeloctiyBlend._ScriptStructPtr != 0) ? FVeloctiyBlend._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.VeloctiyBlend", ref FVeloctiyBlend._ScriptStructPtr);
		}

		// Token: 0x040021EE RID: 8686
		[FieldOffset(0)]
		public float Forward;

		// Token: 0x040021EF RID: 8687
		[FieldOffset(4)]
		public float Backward;

		// Token: 0x040021F0 RID: 8688
		[FieldOffset(8)]
		public float Left;

		// Token: 0x040021F1 RID: 8689
		[FieldOffset(12)]
		public float Right;

		// Token: 0x040021F2 RID: 8690
		public const string __ObjectPath = "/Script/KuroAnim.VeloctiyBlend";

		// Token: 0x040021F3 RID: 8691
		private static IntPtr _ScriptStructPtr;
	}
}
