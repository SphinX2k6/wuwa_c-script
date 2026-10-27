using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200080D RID: 2061
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/Engine.AnimInstanceSubsystemData")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FAnimInstanceSubsystemData : IEqualityOperators<FAnimInstanceSubsystemData, FAnimInstanceSubsystemData, bool>, IEquatable<FAnimInstanceSubsystemData>, IUnrealScriptStruct
	{
		// Token: 0x06006EAB RID: 28331 RVA: 0x0009EB58 File Offset: 0x0009CD58
		public unsafe static bool operator ==(FAnimInstanceSubsystemData left, FAnimInstanceSubsystemData right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06006EAC RID: 28332 RVA: 0x0009EB84 File Offset: 0x0009CD84
		public static bool operator !=(FAnimInstanceSubsystemData left, FAnimInstanceSubsystemData right)
		{
			return !(left == right);
		}

		// Token: 0x06006EAD RID: 28333 RVA: 0x0009EB90 File Offset: 0x0009CD90
		public bool Equals(FAnimInstanceSubsystemData other)
		{
			return this == other;
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x0009EBA0 File Offset: 0x0009CDA0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FAnimInstanceSubsystemData)
			{
				FAnimInstanceSubsystemData other = (FAnimInstanceSubsystemData)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x0009EBC5 File Offset: 0x0009CDC5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimInstanceSubsystemData._ScriptStructPtr != 0) ? FAnimInstanceSubsystemData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimInstanceSubsystemData", ref FAnimInstanceSubsystemData._ScriptStructPtr);
		}

		// Token: 0x04003522 RID: 13602
		public const string __ObjectPath = "/Script/Engine.AnimInstanceSubsystemData";

		// Token: 0x04003523 RID: 13603
		private static IntPtr _ScriptStructPtr;
	}
}
