using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000722 RID: 1826
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/CoreUObject.FallbackStruct")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FFallbackStruct : IEqualityOperators<FFallbackStruct, FFallbackStruct, bool>, IEquatable<FFallbackStruct>, IUnrealScriptStruct
	{
		// Token: 0x060061B0 RID: 25008 RVA: 0x0008C10C File Offset: 0x0008A30C
		public unsafe static bool operator ==(FFallbackStruct left, FFallbackStruct right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x060061B1 RID: 25009 RVA: 0x0008C138 File Offset: 0x0008A338
		public static bool operator !=(FFallbackStruct left, FFallbackStruct right)
		{
			return !(left == right);
		}

		// Token: 0x060061B2 RID: 25010 RVA: 0x0008C144 File Offset: 0x0008A344
		public bool Equals(FFallbackStruct other)
		{
			return this == other;
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x0008C154 File Offset: 0x0008A354
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FFallbackStruct)
			{
				FFallbackStruct other = (FFallbackStruct)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060061B4 RID: 25012 RVA: 0x0008C179 File Offset: 0x0008A379
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFallbackStruct._ScriptStructPtr != 0) ? FFallbackStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FallbackStruct", ref FFallbackStruct._ScriptStructPtr);
		}

		// Token: 0x04002EA2 RID: 11938
		public const string __ObjectPath = "/Script/CoreUObject.FallbackStruct";

		// Token: 0x04002EA3 RID: 11939
		private static IntPtr _ScriptStructPtr;
	}
}
