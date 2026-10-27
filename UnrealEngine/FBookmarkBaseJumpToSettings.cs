using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008E3 RID: 2275
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/Engine.BookmarkBaseJumpToSettings")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FBookmarkBaseJumpToSettings : IEqualityOperators<FBookmarkBaseJumpToSettings, FBookmarkBaseJumpToSettings, bool>, IEquatable<FBookmarkBaseJumpToSettings>, IUnrealScriptStruct
	{
		// Token: 0x06007CDD RID: 31965 RVA: 0x000B30D8 File Offset: 0x000B12D8
		public unsafe static bool operator ==(FBookmarkBaseJumpToSettings left, FBookmarkBaseJumpToSettings right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06007CDE RID: 31966 RVA: 0x000B3104 File Offset: 0x000B1304
		public static bool operator !=(FBookmarkBaseJumpToSettings left, FBookmarkBaseJumpToSettings right)
		{
			return !(left == right);
		}

		// Token: 0x06007CDF RID: 31967 RVA: 0x000B3110 File Offset: 0x000B1310
		public bool Equals(FBookmarkBaseJumpToSettings other)
		{
			return this == other;
		}

		// Token: 0x06007CE0 RID: 31968 RVA: 0x000B3120 File Offset: 0x000B1320
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FBookmarkBaseJumpToSettings)
			{
				FBookmarkBaseJumpToSettings other = (FBookmarkBaseJumpToSettings)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06007CE1 RID: 31969 RVA: 0x000B3145 File Offset: 0x000B1345
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBookmarkBaseJumpToSettings._ScriptStructPtr != 0) ? FBookmarkBaseJumpToSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BookmarkBaseJumpToSettings", ref FBookmarkBaseJumpToSettings._ScriptStructPtr);
		}

		// Token: 0x04003BDB RID: 15323
		public const string __ObjectPath = "/Script/Engine.BookmarkBaseJumpToSettings";

		// Token: 0x04003BDC RID: 15324
		private static IntPtr _ScriptStructPtr;
	}
}
