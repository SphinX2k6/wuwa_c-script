using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000045 RID: 69
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/JsEnv.ArrayBuffer")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public struct FArrayBuffer : IEqualityOperators<FArrayBuffer, FArrayBuffer, bool>, IEquatable<FArrayBuffer>, IUnrealScriptStruct
	{
		// Token: 0x06000891 RID: 2193 RVA: 0x0001077C File Offset: 0x0000E97C
		public unsafe static bool operator ==(FArrayBuffer left, FArrayBuffer right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000107A8 File Offset: 0x0000E9A8
		public static bool operator !=(FArrayBuffer left, FArrayBuffer right)
		{
			return !(left == right);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x000107B4 File Offset: 0x0000E9B4
		public bool Equals(FArrayBuffer other)
		{
			return this == other;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000107C4 File Offset: 0x0000E9C4
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

		// Token: 0x06000895 RID: 2197 RVA: 0x000107E9 File Offset: 0x0000E9E9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FArrayBuffer._ScriptStructPtr != 0) ? FArrayBuffer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/JsEnv.ArrayBuffer", ref FArrayBuffer._ScriptStructPtr);
		}

		// Token: 0x04000140 RID: 320
		[FieldOffset(0)]
		public unsafe void* Data;

		// Token: 0x04000141 RID: 321
		[FieldOffset(8)]
		public ulong Length;

		// Token: 0x04000142 RID: 322
		public const string __ObjectPath = "/Script/JsEnv.ArrayBuffer";

		// Token: 0x04000143 RID: 323
		private static IntPtr _ScriptStructPtr;
	}
}
