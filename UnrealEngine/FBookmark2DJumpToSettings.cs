using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008E1 RID: 2273
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/Engine.Bookmark2DJumpToSettings")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FBookmark2DJumpToSettings : IEqualityOperators<FBookmark2DJumpToSettings, FBookmark2DJumpToSettings, bool>, IEquatable<FBookmark2DJumpToSettings>, IUnrealScriptStruct
	{
		// Token: 0x06007CD4 RID: 31956 RVA: 0x000B2FF8 File Offset: 0x000B11F8
		public unsafe static bool operator ==(FBookmark2DJumpToSettings left, FBookmark2DJumpToSettings right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06007CD5 RID: 31957 RVA: 0x000B3024 File Offset: 0x000B1224
		public static bool operator !=(FBookmark2DJumpToSettings left, FBookmark2DJumpToSettings right)
		{
			return !(left == right);
		}

		// Token: 0x06007CD6 RID: 31958 RVA: 0x000B3030 File Offset: 0x000B1230
		public bool Equals(FBookmark2DJumpToSettings other)
		{
			return this == other;
		}

		// Token: 0x06007CD7 RID: 31959 RVA: 0x000B3040 File Offset: 0x000B1240
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FBookmark2DJumpToSettings)
			{
				FBookmark2DJumpToSettings other = (FBookmark2DJumpToSettings)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06007CD8 RID: 31960 RVA: 0x000B3065 File Offset: 0x000B1265
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBookmark2DJumpToSettings._ScriptStructPtr != 0) ? FBookmark2DJumpToSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Bookmark2DJumpToSettings", ref FBookmark2DJumpToSettings._ScriptStructPtr);
		}

		// Token: 0x04003BD6 RID: 15318
		public const string __ObjectPath = "/Script/Engine.Bookmark2DJumpToSettings";

		// Token: 0x04003BD7 RID: 15319
		private static IntPtr _ScriptStructPtr;
	}
}
