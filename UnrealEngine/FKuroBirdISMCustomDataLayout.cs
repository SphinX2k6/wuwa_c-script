using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001AB2 RID: 6834
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBirdISMCustomDataLayout")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FKuroBirdISMCustomDataLayout : IEqualityOperators<FKuroBirdISMCustomDataLayout, FKuroBirdISMCustomDataLayout, bool>, IEquatable<FKuroBirdISMCustomDataLayout>, IUnrealScriptStruct
	{
		// Token: 0x060195E1 RID: 103905 RVA: 0x00257B38 File Offset: 0x00255D38
		public unsafe static bool operator ==(FKuroBirdISMCustomDataLayout left, FKuroBirdISMCustomDataLayout right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x060195E2 RID: 103906 RVA: 0x00257B64 File Offset: 0x00255D64
		public static bool operator !=(FKuroBirdISMCustomDataLayout left, FKuroBirdISMCustomDataLayout right)
		{
			return !(left == right);
		}

		// Token: 0x060195E3 RID: 103907 RVA: 0x00257B70 File Offset: 0x00255D70
		public bool Equals(FKuroBirdISMCustomDataLayout other)
		{
			return this == other;
		}

		// Token: 0x060195E4 RID: 103908 RVA: 0x00257B80 File Offset: 0x00255D80
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FKuroBirdISMCustomDataLayout)
			{
				FKuroBirdISMCustomDataLayout other = (FKuroBirdISMCustomDataLayout)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060195E5 RID: 103909 RVA: 0x00257BA5 File Offset: 0x00255DA5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBirdISMCustomDataLayout._ScriptStructPtr != 0) ? FKuroBirdISMCustomDataLayout._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroBirdISMCustomDataLayout", ref FKuroBirdISMCustomDataLayout._ScriptStructPtr);
		}

		// Token: 0x0400DD32 RID: 56626
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBirdISMCustomDataLayout";

		// Token: 0x0400DD33 RID: 56627
		private static IntPtr _ScriptStructPtr;
	}
}
