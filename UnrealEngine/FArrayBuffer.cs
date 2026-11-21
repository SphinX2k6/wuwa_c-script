using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200002A RID: 42
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/JsEnv.ArrayBuffer")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public struct FArrayBuffer : IEqualityOperators<FArrayBuffer, FArrayBuffer, bool>, IEquatable<FArrayBuffer>, IUnrealScriptStruct
	{
		// Token: 0x06000816 RID: 2070 RVA: 0x0000CFE8 File Offset: 0x0000B1E8
		public unsafe static bool operator ==(FArrayBuffer left, FArrayBuffer right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0000D014 File Offset: 0x0000B214
		public static bool operator !=(FArrayBuffer left, FArrayBuffer right)
		{
			return !(left == right);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0000D020 File Offset: 0x0000B220
		public bool Equals(FArrayBuffer other)
		{
			return this == other;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0000D030 File Offset: 0x0000B230
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FArrayBuffer)
			{
				FArrayBuffer other = (FArrayBuffer)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0000D055 File Offset: 0x0000B255
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FArrayBuffer._ScriptStructPtr != 0) ? FArrayBuffer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/JsEnv.ArrayBuffer", ref FArrayBuffer._ScriptStructPtr);
		}

		// Token: 0x040000F9 RID: 249
		[FieldOffset(0)]
		public unsafe void* Data;

		// Token: 0x040000FA RID: 250
		[FieldOffset(8)]
		public ulong Length;

		// Token: 0x040000FB RID: 251
		public const string __ObjectPath = "/Script/JsEnv.ArrayBuffer";

		// Token: 0x040000FC RID: 252
		private static IntPtr _ScriptStructPtr;
	}
}
