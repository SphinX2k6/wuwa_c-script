using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001770 RID: 6000
	[UnrealObjectPath("/Script/KuroComponent.TrackMoveData")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FTrackMoveData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601592A RID: 88362 RVA: 0x001FBD1F File Offset: 0x001F9F1F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTrackMoveData._ScriptStructPtr != 0) ? FTrackMoveData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComponent.TrackMoveData", ref FTrackMoveData._ScriptStructPtr);
		}

		// Token: 0x0601592B RID: 88363 RVA: 0x001FBD43 File Offset: 0x001F9F43
		public FTrackMoveData()
		{
		}

		// Token: 0x0601592C RID: 88364 RVA: 0x001FBD4B File Offset: 0x001F9F4B
		protected override IntPtr GetUStructPtr()
		{
			return FTrackMoveData.StaticStruct();
		}

		// Token: 0x0601592D RID: 88365 RVA: 0x001FBD57 File Offset: 0x001F9F57
		[NullableContext(2)]
		public FTrackMoveData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601592E RID: 88366 RVA: 0x001FBD61 File Offset: 0x001F9F61
		public FTrackMoveData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601592F RID: 88367 RVA: 0x001FBD6C File Offset: 0x001F9F6C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTrackMoveData(Pointer, false, true);
		}

		// Token: 0x06015930 RID: 88368 RVA: 0x001FBD76 File Offset: 0x001F9F76
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTrackMoveData(Pointer, MemoryOwner);
		}

		// Token: 0x0400BC53 RID: 48211
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComponent.TrackMoveData";

		// Token: 0x0400BC54 RID: 48212
		private static IntPtr _ScriptStructPtr;
	}
}
