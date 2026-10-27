using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200168A RID: 5770
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/KuroAnim.VeloctiyBlend")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FVeloctiyBlend : IEqualityOperators<FVeloctiyBlend, FVeloctiyBlend, bool>, IEquatable<FVeloctiyBlend>, IUnrealScriptStruct
	{
		// Token: 0x06014F1B RID: 85787 RVA: 0x001EC9A8 File Offset: 0x001EABA8
		public FVeloctiyBlend(float Forward, float Backward, float Left, float Right)
		{
			this.Forward = Forward;
			this.Backward = Backward;
			this.Left = Left;
			this.Right = Right;
		}

		// Token: 0x06014F1C RID: 85788 RVA: 0x001EC9C7 File Offset: 0x001EABC7
		public static bool operator ==(FVeloctiyBlend left, FVeloctiyBlend right)
		{
			return left.Forward == right.Forward && left.Backward == right.Backward && left.Left == right.Left && left.Right == right.Right;
		}

		// Token: 0x06014F1D RID: 85789 RVA: 0x001ECA03 File Offset: 0x001EAC03
		public static bool operator !=(FVeloctiyBlend left, FVeloctiyBlend right)
		{
			return !(left == right);
		}

		// Token: 0x06014F1E RID: 85790 RVA: 0x001ECA0F File Offset: 0x001EAC0F
		public bool Equals(FVeloctiyBlend other)
		{
			return this == other;
		}

		// Token: 0x06014F1F RID: 85791 RVA: 0x001ECA20 File Offset: 0x001EAC20
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

		// Token: 0x06014F20 RID: 85792 RVA: 0x001ECA45 File Offset: 0x001EAC45
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.Forward, this.Backward, this.Left, this.Right);
		}

		// Token: 0x06014F21 RID: 85793 RVA: 0x001ECA64 File Offset: 0x001EAC64
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVeloctiyBlend._ScriptStructPtr != 0) ? FVeloctiyBlend._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.VeloctiyBlend", ref FVeloctiyBlend._ScriptStructPtr);
		}

		// Token: 0x0400B689 RID: 46729
		[FieldOffset(0)]
		public float Forward;

		// Token: 0x0400B68A RID: 46730
		[FieldOffset(4)]
		public float Backward;

		// Token: 0x0400B68B RID: 46731
		[FieldOffset(8)]
		public float Left;

		// Token: 0x0400B68C RID: 46732
		[FieldOffset(12)]
		public float Right;

		// Token: 0x0400B68D RID: 46733
		public const string __ObjectPath = "/Script/KuroAnim.VeloctiyBlend";

		// Token: 0x0400B68E RID: 46734
		private static IntPtr _ScriptStructPtr;
	}
}
