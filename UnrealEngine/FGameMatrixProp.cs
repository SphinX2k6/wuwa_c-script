using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020012E7 RID: 4839
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/GameMatrix.GameMatrixProp")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FGameMatrixProp : IEqualityOperators<FGameMatrixProp, FGameMatrixProp, bool>, IEquatable<FGameMatrixProp>, IUnrealScriptStruct
	{
		// Token: 0x06011BCA RID: 72650 RVA: 0x001A08BC File Offset: 0x0019EABC
		public unsafe static bool operator ==(FGameMatrixProp left, FGameMatrixProp right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06011BCB RID: 72651 RVA: 0x001A08E8 File Offset: 0x0019EAE8
		public static bool operator !=(FGameMatrixProp left, FGameMatrixProp right)
		{
			return !(left == right);
		}

		// Token: 0x06011BCC RID: 72652 RVA: 0x001A08F4 File Offset: 0x0019EAF4
		public bool Equals(FGameMatrixProp other)
		{
			return this == other;
		}

		// Token: 0x06011BCD RID: 72653 RVA: 0x001A0904 File Offset: 0x0019EB04
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FGameMatrixProp)
			{
				FGameMatrixProp other = (FGameMatrixProp)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06011BCE RID: 72654 RVA: 0x001A0929 File Offset: 0x0019EB29
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameMatrixProp._ScriptStructPtr != 0) ? FGameMatrixProp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameMatrix.GameMatrixProp", ref FGameMatrixProp._ScriptStructPtr);
		}

		// Token: 0x04009852 RID: 38994
		public const string __ObjectPath = "/Script/GameMatrix.GameMatrixProp";

		// Token: 0x04009853 RID: 38995
		private static IntPtr _ScriptStructPtr;
	}
}
