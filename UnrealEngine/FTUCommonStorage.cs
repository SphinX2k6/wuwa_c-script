using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028F1 RID: 10481
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/TapCommon.TUCommonStorage")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FTUCommonStorage : IEqualityOperators<FTUCommonStorage, FTUCommonStorage, bool>, IEquatable<FTUCommonStorage>, IUnrealScriptStruct
	{
		// Token: 0x06026DFC RID: 159228 RVA: 0x003B4C9C File Offset: 0x003B2E9C
		public unsafe static bool operator ==(FTUCommonStorage left, FTUCommonStorage right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06026DFD RID: 159229 RVA: 0x003B4CC8 File Offset: 0x003B2EC8
		public static bool operator !=(FTUCommonStorage left, FTUCommonStorage right)
		{
			return !(left == right);
		}

		// Token: 0x06026DFE RID: 159230 RVA: 0x003B4CD4 File Offset: 0x003B2ED4
		public bool Equals(FTUCommonStorage other)
		{
			return this == other;
		}

		// Token: 0x06026DFF RID: 159231 RVA: 0x003B4CE4 File Offset: 0x003B2EE4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FTUCommonStorage)
			{
				FTUCommonStorage other = (FTUCommonStorage)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06026E00 RID: 159232 RVA: 0x003B4D09 File Offset: 0x003B2F09
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTUCommonStorage._ScriptStructPtr != 0) ? FTUCommonStorage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.TUCommonStorage", ref FTUCommonStorage._ScriptStructPtr);
		}

		// Token: 0x04015580 RID: 87424
		public const string __ObjectPath = "/Script/TapCommon.TUCommonStorage";

		// Token: 0x04015581 RID: 87425
		private static IntPtr _ScriptStructPtr;
	}
}
