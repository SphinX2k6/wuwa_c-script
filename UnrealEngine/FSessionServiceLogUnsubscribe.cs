using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002727 RID: 10023
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/SessionMessages.SessionServiceLogUnsubscribe")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FSessionServiceLogUnsubscribe : IEqualityOperators<FSessionServiceLogUnsubscribe, FSessionServiceLogUnsubscribe, bool>, IEquatable<FSessionServiceLogUnsubscribe>, IUnrealScriptStruct
	{
		// Token: 0x06025245 RID: 152133 RVA: 0x003702D8 File Offset: 0x0036E4D8
		public unsafe static bool operator ==(FSessionServiceLogUnsubscribe left, FSessionServiceLogUnsubscribe right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06025246 RID: 152134 RVA: 0x00370304 File Offset: 0x0036E504
		public static bool operator !=(FSessionServiceLogUnsubscribe left, FSessionServiceLogUnsubscribe right)
		{
			return !(left == right);
		}

		// Token: 0x06025247 RID: 152135 RVA: 0x00370310 File Offset: 0x0036E510
		public bool Equals(FSessionServiceLogUnsubscribe other)
		{
			return this == other;
		}

		// Token: 0x06025248 RID: 152136 RVA: 0x00370320 File Offset: 0x0036E520
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FSessionServiceLogUnsubscribe)
			{
				FSessionServiceLogUnsubscribe other = (FSessionServiceLogUnsubscribe)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06025249 RID: 152137 RVA: 0x00370345 File Offset: 0x0036E545
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSessionServiceLogUnsubscribe._ScriptStructPtr != 0) ? FSessionServiceLogUnsubscribe._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SessionMessages.SessionServiceLogUnsubscribe", ref FSessionServiceLogUnsubscribe._ScriptStructPtr);
		}

		// Token: 0x0401403D RID: 81981
		public const string __ObjectPath = "/Script/SessionMessages.SessionServiceLogUnsubscribe";

		// Token: 0x0401403E RID: 81982
		private static IntPtr _ScriptStructPtr;
	}
}
