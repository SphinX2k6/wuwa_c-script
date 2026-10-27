using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000791 RID: 1937
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/EngineMessages.EngineServicePing")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FEngineServicePing : IEqualityOperators<FEngineServicePing, FEngineServicePing, bool>, IEquatable<FEngineServicePing>, IUnrealScriptStruct
	{
		// Token: 0x060064E5 RID: 25829 RVA: 0x00090B48 File Offset: 0x0008ED48
		public unsafe static bool operator ==(FEngineServicePing left, FEngineServicePing right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x00090B74 File Offset: 0x0008ED74
		public static bool operator !=(FEngineServicePing left, FEngineServicePing right)
		{
			return !(left == right);
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x00090B80 File Offset: 0x0008ED80
		public bool Equals(FEngineServicePing other)
		{
			return this == other;
		}

		// Token: 0x060064E8 RID: 25832 RVA: 0x00090B90 File Offset: 0x0008ED90
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FEngineServicePing)
			{
				FEngineServicePing other = (FEngineServicePing)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060064E9 RID: 25833 RVA: 0x00090BB5 File Offset: 0x0008EDB5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEngineServicePing._ScriptStructPtr != 0) ? FEngineServicePing._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/EngineMessages.EngineServicePing", ref FEngineServicePing._ScriptStructPtr);
		}

		// Token: 0x040030E3 RID: 12515
		public const string __ObjectPath = "/Script/EngineMessages.EngineServicePing";

		// Token: 0x040030E4 RID: 12516
		private static IntPtr _ScriptStructPtr;
	}
}
