using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200167F RID: 5759
	[UnrealObjectPath("/Script/KuroAnim.SequenceSyncMarkerMapRule")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FSequenceSyncMarkerMapRule : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014E5E RID: 85598 RVA: 0x001EB914 File Offset: 0x001E9B14
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSequenceSyncMarkerMapRule._ScriptStructPtr != 0) ? FSequenceSyncMarkerMapRule._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.SequenceSyncMarkerMapRule", ref FSequenceSyncMarkerMapRule._ScriptStructPtr);
		}

		// Token: 0x170052CB RID: 21195
		// (get) Token: 0x06014E5F RID: 85599 RVA: 0x001EB938 File Offset: 0x001E9B38
		// (set) Token: 0x06014E60 RID: 85600 RVA: 0x001EB94C File Offset: 0x001E9B4C
		public unsafe FName MapFromGroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSequenceSyncMarkerMapRule.__PropertyOffset_MapFromGroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSequenceSyncMarkerMapRule.__PropertyOffset_MapFromGroupName) = value;
			}
		}

		// Token: 0x170052CC RID: 21196
		// (get) Token: 0x06014E61 RID: 85601 RVA: 0x001EB961 File Offset: 0x001E9B61
		// (set) Token: 0x06014E62 RID: 85602 RVA: 0x001EB975 File Offset: 0x001E9B75
		public unsafe FName PrevMarker
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSequenceSyncMarkerMapRule.__PropertyOffset_PrevMarker);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSequenceSyncMarkerMapRule.__PropertyOffset_PrevMarker) = value;
			}
		}

		// Token: 0x170052CD RID: 21197
		// (get) Token: 0x06014E63 RID: 85603 RVA: 0x001EB98A File Offset: 0x001E9B8A
		// (set) Token: 0x06014E64 RID: 85604 RVA: 0x001EB99E File Offset: 0x001E9B9E
		public unsafe FName NextMarker
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSequenceSyncMarkerMapRule.__PropertyOffset_NextMarker);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSequenceSyncMarkerMapRule.__PropertyOffset_NextMarker) = value;
			}
		}

		// Token: 0x170052CE RID: 21198
		// (get) Token: 0x06014E65 RID: 85605 RVA: 0x001EB9B3 File Offset: 0x001E9BB3
		// (set) Token: 0x06014E66 RID: 85606 RVA: 0x001EB9C3 File Offset: 0x001E9BC3
		public unsafe bool bRespectOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSequenceSyncMarkerMapRule.__PropertyOffset_bRespectOrder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSequenceSyncMarkerMapRule.__PropertyOffset_bRespectOrder) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014E67 RID: 85607 RVA: 0x001EB9D4 File Offset: 0x001E9BD4
		public FSequenceSyncMarkerMapRule()
		{
		}

		// Token: 0x06014E68 RID: 85608 RVA: 0x001EB9DC File Offset: 0x001E9BDC
		public FSequenceSyncMarkerMapRule(FName MapFromGroupName, FName PrevMarker, FName NextMarker, bool bRespectOrder)
		{
			this.MapFromGroupName = MapFromGroupName;
			this.PrevMarker = PrevMarker;
			this.NextMarker = NextMarker;
			this.bRespectOrder = bRespectOrder;
		}

		// Token: 0x06014E69 RID: 85609 RVA: 0x001EBA01 File Offset: 0x001E9C01
		protected override IntPtr GetUStructPtr()
		{
			return FSequenceSyncMarkerMapRule.StaticStruct();
		}

		// Token: 0x06014E6A RID: 85610 RVA: 0x001EBA0D File Offset: 0x001E9C0D
		[NullableContext(2)]
		public FSequenceSyncMarkerMapRule(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014E6B RID: 85611 RVA: 0x001EBA17 File Offset: 0x001E9C17
		public FSequenceSyncMarkerMapRule(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014E6C RID: 85612 RVA: 0x001EBA22 File Offset: 0x001E9C22
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSequenceSyncMarkerMapRule(Pointer, false, true);
		}

		// Token: 0x06014E6D RID: 85613 RVA: 0x001EBA2C File Offset: 0x001E9C2C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSequenceSyncMarkerMapRule(Pointer, MemoryOwner);
		}

		// Token: 0x0400B62D RID: 46637
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.SequenceSyncMarkerMapRule";

		// Token: 0x0400B62E RID: 46638
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B62F RID: 46639
		internal static int __PropertyOffset_MapFromGroupName;

		// Token: 0x0400B630 RID: 46640
		internal static int __PropertyOffset_PrevMarker;

		// Token: 0x0400B631 RID: 46641
		internal static int __PropertyOffset_NextMarker;

		// Token: 0x0400B632 RID: 46642
		internal static int __PropertyOffset_bRespectOrder;
	}
}
