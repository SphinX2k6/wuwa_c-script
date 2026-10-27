using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000771 RID: 1905
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/CoreUObject.UniqueNetIdWrapper")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FUniqueNetIdWrapper : IEqualityOperators<FUniqueNetIdWrapper, FUniqueNetIdWrapper, bool>, IEquatable<FUniqueNetIdWrapper>, IUnrealScriptStruct
	{
		// Token: 0x060063E6 RID: 25574 RVA: 0x0008F708 File Offset: 0x0008D908
		public unsafe static bool operator ==(FUniqueNetIdWrapper left, FUniqueNetIdWrapper right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x0008F734 File Offset: 0x0008D934
		public static bool operator !=(FUniqueNetIdWrapper left, FUniqueNetIdWrapper right)
		{
			return !(left == right);
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x0008F740 File Offset: 0x0008D940
		public bool Equals(FUniqueNetIdWrapper other)
		{
			return this == other;
		}

		// Token: 0x060063E9 RID: 25577 RVA: 0x0008F750 File Offset: 0x0008D950
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FUniqueNetIdWrapper)
			{
				FUniqueNetIdWrapper other = (FUniqueNetIdWrapper)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060063EA RID: 25578 RVA: 0x0008F775 File Offset: 0x0008D975
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUniqueNetIdWrapper._ScriptStructPtr != 0) ? FUniqueNetIdWrapper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.UniqueNetIdWrapper", ref FUniqueNetIdWrapper._ScriptStructPtr);
		}

		// Token: 0x04002FE7 RID: 12263
		public const string __ObjectPath = "/Script/CoreUObject.UniqueNetIdWrapper";

		// Token: 0x04002FE8 RID: 12264
		private static IntPtr _ScriptStructPtr;
	}
}
