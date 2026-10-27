using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003B9 RID: 953
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/AugmentedReality.ARPointUpdatePayload")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FARPointUpdatePayload : IEqualityOperators<FARPointUpdatePayload, FARPointUpdatePayload, bool>, IEquatable<FARPointUpdatePayload>, IUnrealScriptStruct
	{
		// Token: 0x060034E2 RID: 13538 RVA: 0x00050AF8 File Offset: 0x0004ECF8
		public unsafe static bool operator ==(FARPointUpdatePayload left, FARPointUpdatePayload right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x00050B24 File Offset: 0x0004ED24
		public static bool operator !=(FARPointUpdatePayload left, FARPointUpdatePayload right)
		{
			return !(left == right);
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x00050B30 File Offset: 0x0004ED30
		public bool Equals(FARPointUpdatePayload other)
		{
			return this == other;
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x00050B40 File Offset: 0x0004ED40
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FARPointUpdatePayload)
			{
				FARPointUpdatePayload other = (FARPointUpdatePayload)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x00050B65 File Offset: 0x0004ED65
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARPointUpdatePayload._ScriptStructPtr != 0) ? FARPointUpdatePayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARPointUpdatePayload", ref FARPointUpdatePayload._ScriptStructPtr);
		}

		// Token: 0x040016EC RID: 5868
		public const string __ObjectPath = "/Script/AugmentedReality.ARPointUpdatePayload";

		// Token: 0x040016ED RID: 5869
		private static IntPtr _ScriptStructPtr;
	}
}
