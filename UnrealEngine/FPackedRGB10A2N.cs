using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200013F RID: 319
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 4)]
	[UnrealObjectPath("/Script/CoreUObject.PackedRGB10A2N")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
	public struct FPackedRGB10A2N : IEqualityOperators<FPackedRGB10A2N, FPackedRGB10A2N, bool>, IEquatable<FPackedRGB10A2N>, IUnrealScriptStruct
	{
		// Token: 0x06001296 RID: 4758 RVA: 0x0001D6EC File Offset: 0x0001B8EC
		public FPackedRGB10A2N(int Packed)
		{
			this.Packed = Packed;
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x0001D6F5 File Offset: 0x0001B8F5
		public static bool operator ==(FPackedRGB10A2N left, FPackedRGB10A2N right)
		{
			return left.Packed == right.Packed;
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0001D705 File Offset: 0x0001B905
		public static bool operator !=(FPackedRGB10A2N left, FPackedRGB10A2N right)
		{
			return !(left == right);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0001D711 File Offset: 0x0001B911
		public bool Equals(FPackedRGB10A2N other)
		{
			return this == other;
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0001D720 File Offset: 0x0001B920
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FPackedRGB10A2N)
			{
				FPackedRGB10A2N other = (FPackedRGB10A2N)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0001D745 File Offset: 0x0001B945
		public override int GetHashCode()
		{
			return HashCode.Combine<int>(this.Packed);
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0001D752 File Offset: 0x0001B952
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPackedRGB10A2N._ScriptStructPtr != 0) ? FPackedRGB10A2N._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.PackedRGB10A2N", ref FPackedRGB10A2N._ScriptStructPtr);
		}

		// Token: 0x040005C3 RID: 1475
		[FieldOffset(0)]
		public int Packed;

		// Token: 0x040005C4 RID: 1476
		public const string __ObjectPath = "/Script/CoreUObject.PackedRGB10A2N";

		// Token: 0x040005C5 RID: 1477
		private static IntPtr _ScriptStructPtr;
	}
}
