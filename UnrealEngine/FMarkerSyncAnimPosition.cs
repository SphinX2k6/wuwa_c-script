using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D75 RID: 3445
	[UnrealObjectPath("/Script/Engine.MarkerSyncAnimPosition")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FMarkerSyncAnimPosition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600BA79 RID: 47737 RVA: 0x001090D4 File Offset: 0x001072D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMarkerSyncAnimPosition._ScriptStructPtr != 0) ? FMarkerSyncAnimPosition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MarkerSyncAnimPosition", ref FMarkerSyncAnimPosition._ScriptStructPtr);
		}

		// Token: 0x17002AC5 RID: 10949
		// (get) Token: 0x0600BA7A RID: 47738 RVA: 0x001090F8 File Offset: 0x001072F8
		// (set) Token: 0x0600BA7B RID: 47739 RVA: 0x0010910C File Offset: 0x0010730C
		public unsafe FName PreviousMarkerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarkerSyncAnimPosition.__PropertyOffset_PreviousMarkerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarkerSyncAnimPosition.__PropertyOffset_PreviousMarkerName) = value;
			}
		}

		// Token: 0x17002AC6 RID: 10950
		// (get) Token: 0x0600BA7C RID: 47740 RVA: 0x00109121 File Offset: 0x00107321
		// (set) Token: 0x0600BA7D RID: 47741 RVA: 0x00109135 File Offset: 0x00107335
		public unsafe FName NextMarkerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarkerSyncAnimPosition.__PropertyOffset_NextMarkerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarkerSyncAnimPosition.__PropertyOffset_NextMarkerName) = value;
			}
		}

		// Token: 0x17002AC7 RID: 10951
		// (get) Token: 0x0600BA7E RID: 47742 RVA: 0x0010914A File Offset: 0x0010734A
		// (set) Token: 0x0600BA7F RID: 47743 RVA: 0x0010915A File Offset: 0x0010735A
		public unsafe float PositionBetweenMarkers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarkerSyncAnimPosition.__PropertyOffset_PositionBetweenMarkers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarkerSyncAnimPosition.__PropertyOffset_PositionBetweenMarkers) = value;
			}
		}

		// Token: 0x0600BA80 RID: 47744 RVA: 0x0010916B File Offset: 0x0010736B
		public FMarkerSyncAnimPosition()
		{
		}

		// Token: 0x0600BA81 RID: 47745 RVA: 0x00109173 File Offset: 0x00107373
		public FMarkerSyncAnimPosition(FName PreviousMarkerName, FName NextMarkerName, float PositionBetweenMarkers)
		{
			this.PreviousMarkerName = PreviousMarkerName;
			this.NextMarkerName = NextMarkerName;
			this.PositionBetweenMarkers = PositionBetweenMarkers;
		}

		// Token: 0x0600BA82 RID: 47746 RVA: 0x00109190 File Offset: 0x00107390
		protected override IntPtr GetUStructPtr()
		{
			return FMarkerSyncAnimPosition.StaticStruct();
		}

		// Token: 0x0600BA83 RID: 47747 RVA: 0x0010919C File Offset: 0x0010739C
		[NullableContext(2)]
		public FMarkerSyncAnimPosition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BA84 RID: 47748 RVA: 0x001091A6 File Offset: 0x001073A6
		public FMarkerSyncAnimPosition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BA85 RID: 47749 RVA: 0x001091B1 File Offset: 0x001073B1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMarkerSyncAnimPosition(Pointer, false, true);
		}

		// Token: 0x0600BA86 RID: 47750 RVA: 0x001091BB File Offset: 0x001073BB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMarkerSyncAnimPosition(Pointer, MemoryOwner);
		}

		// Token: 0x04006197 RID: 24983
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MarkerSyncAnimPosition";

		// Token: 0x04006198 RID: 24984
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006199 RID: 24985
		internal static int __PropertyOffset_PreviousMarkerName;

		// Token: 0x0400619A RID: 24986
		internal static int __PropertyOffset_NextMarkerName;

		// Token: 0x0400619B RID: 24987
		internal static int __PropertyOffset_PositionBetweenMarkers;
	}
}
