using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002726 RID: 10022
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/SessionMessages.SessionServiceLogSubscribe")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FSessionServiceLogSubscribe : IEqualityOperators<FSessionServiceLogSubscribe, FSessionServiceLogSubscribe, bool>, IEquatable<FSessionServiceLogSubscribe>, IUnrealScriptStruct
	{
		// Token: 0x06025240 RID: 152128 RVA: 0x00370244 File Offset: 0x0036E444
		public unsafe static bool operator ==(FSessionServiceLogSubscribe left, FSessionServiceLogSubscribe right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06025241 RID: 152129 RVA: 0x00370270 File Offset: 0x0036E470
		public static bool operator !=(FSessionServiceLogSubscribe left, FSessionServiceLogSubscribe right)
		{
			return !(left == right);
		}

		// Token: 0x06025242 RID: 152130 RVA: 0x0037027C File Offset: 0x0036E47C
		public bool Equals(FSessionServiceLogSubscribe other)
		{
			return this == other;
		}

		// Token: 0x06025243 RID: 152131 RVA: 0x0037028C File Offset: 0x0036E48C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FSessionServiceLogSubscribe)
			{
				FSessionServiceLogSubscribe other = (FSessionServiceLogSubscribe)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06025244 RID: 152132 RVA: 0x003702B1 File Offset: 0x0036E4B1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSessionServiceLogSubscribe._ScriptStructPtr != 0) ? FSessionServiceLogSubscribe._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SessionMessages.SessionServiceLogSubscribe", ref FSessionServiceLogSubscribe._ScriptStructPtr);
		}

		// Token: 0x0401403B RID: 81979
		public const string __ObjectPath = "/Script/SessionMessages.SessionServiceLogSubscribe";

		// Token: 0x0401403C RID: 81980
		private static IntPtr _ScriptStructPtr;
	}
}
