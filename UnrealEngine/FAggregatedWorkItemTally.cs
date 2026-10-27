using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200147B RID: 5243
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.AggregatedWorkItemTally")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FAggregatedWorkItemTally : FWorkItemTallyBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060131BE RID: 78270 RVA: 0x001C1BAE File Offset: 0x001BFDAE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAggregatedWorkItemTally._ScriptStructPtr != 0) ? FAggregatedWorkItemTally._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.AggregatedWorkItemTally", ref FAggregatedWorkItemTally._ScriptStructPtr);
		}

		// Token: 0x17004A38 RID: 19000
		// (get) Token: 0x060131BF RID: 78271 RVA: 0x001C1BD2 File Offset: 0x001BFDD2
		// (set) Token: 0x060131C0 RID: 78272 RVA: 0x001C1BE2 File Offset: 0x001BFDE2
		public unsafe int TotalWorkItems
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAggregatedWorkItemTally.__PropertyOffset_TotalWorkItems);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAggregatedWorkItemTally.__PropertyOffset_TotalWorkItems) = value;
			}
		}

		// Token: 0x17004A39 RID: 19001
		// (get) Token: 0x060131C1 RID: 78273 RVA: 0x001C1BF3 File Offset: 0x001BFDF3
		// (set) Token: 0x060131C2 RID: 78274 RVA: 0x001C1C03 File Offset: 0x001BFE03
		public unsafe int WaitingWorkItems
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAggregatedWorkItemTally.__PropertyOffset_WaitingWorkItems);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAggregatedWorkItemTally.__PropertyOffset_WaitingWorkItems) = value;
			}
		}

		// Token: 0x17004A3A RID: 19002
		// (get) Token: 0x060131C3 RID: 78275 RVA: 0x001C1C14 File Offset: 0x001BFE14
		// (set) Token: 0x060131C4 RID: 78276 RVA: 0x001C1C24 File Offset: 0x001BFE24
		public unsafe int ScheduledWorkItems
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAggregatedWorkItemTally.__PropertyOffset_ScheduledWorkItems);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAggregatedWorkItemTally.__PropertyOffset_ScheduledWorkItems) = value;
			}
		}

		// Token: 0x17004A3B RID: 19003
		// (get) Token: 0x060131C5 RID: 78277 RVA: 0x001C1C35 File Offset: 0x001BFE35
		// (set) Token: 0x060131C6 RID: 78278 RVA: 0x001C1C45 File Offset: 0x001BFE45
		public unsafe int CookingWorkItems
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAggregatedWorkItemTally.__PropertyOffset_CookingWorkItems);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAggregatedWorkItemTally.__PropertyOffset_CookingWorkItems) = value;
			}
		}

		// Token: 0x17004A3C RID: 19004
		// (get) Token: 0x060131C7 RID: 78279 RVA: 0x001C1C56 File Offset: 0x001BFE56
		// (set) Token: 0x060131C8 RID: 78280 RVA: 0x001C1C66 File Offset: 0x001BFE66
		public unsafe int CookedWorkItems
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAggregatedWorkItemTally.__PropertyOffset_CookedWorkItems);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAggregatedWorkItemTally.__PropertyOffset_CookedWorkItems) = value;
			}
		}

		// Token: 0x17004A3D RID: 19005
		// (get) Token: 0x060131C9 RID: 78281 RVA: 0x001C1C77 File Offset: 0x001BFE77
		// (set) Token: 0x060131CA RID: 78282 RVA: 0x001C1C87 File Offset: 0x001BFE87
		public unsafe int ErroredWorkItems
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAggregatedWorkItemTally.__PropertyOffset_ErroredWorkItems);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAggregatedWorkItemTally.__PropertyOffset_ErroredWorkItems) = value;
			}
		}

		// Token: 0x17004A3E RID: 19006
		// (get) Token: 0x060131CB RID: 78283 RVA: 0x001C1C98 File Offset: 0x001BFE98
		// (set) Token: 0x060131CC RID: 78284 RVA: 0x001C1CA8 File Offset: 0x001BFEA8
		public unsafe int CookCancelledWorkItems
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAggregatedWorkItemTally.__PropertyOffset_CookCancelledWorkItems);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAggregatedWorkItemTally.__PropertyOffset_CookCancelledWorkItems) = value;
			}
		}

		// Token: 0x060131CD RID: 78285 RVA: 0x001C1CB9 File Offset: 0x001BFEB9
		public FAggregatedWorkItemTally()
		{
		}

		// Token: 0x060131CE RID: 78286 RVA: 0x001C1CC1 File Offset: 0x001BFEC1
		public FAggregatedWorkItemTally(int TotalWorkItems, int WaitingWorkItems, int ScheduledWorkItems, int CookingWorkItems, int CookedWorkItems, int ErroredWorkItems, int CookCancelledWorkItems)
		{
			this.TotalWorkItems = TotalWorkItems;
			this.WaitingWorkItems = WaitingWorkItems;
			this.ScheduledWorkItems = ScheduledWorkItems;
			this.CookingWorkItems = CookingWorkItems;
			this.CookedWorkItems = CookedWorkItems;
			this.ErroredWorkItems = ErroredWorkItems;
			this.CookCancelledWorkItems = CookCancelledWorkItems;
		}

		// Token: 0x060131CF RID: 78287 RVA: 0x001C1CFE File Offset: 0x001BFEFE
		protected override IntPtr GetUStructPtr()
		{
			return FAggregatedWorkItemTally.StaticStruct();
		}

		// Token: 0x060131D0 RID: 78288 RVA: 0x001C1D0A File Offset: 0x001BFF0A
		[NullableContext(2)]
		public FAggregatedWorkItemTally(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060131D1 RID: 78289 RVA: 0x001C1D14 File Offset: 0x001BFF14
		public FAggregatedWorkItemTally(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060131D2 RID: 78290 RVA: 0x001C1D1F File Offset: 0x001BFF1F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAggregatedWorkItemTally(Pointer, false, true);
		}

		// Token: 0x060131D3 RID: 78291 RVA: 0x001C1D29 File Offset: 0x001BFF29
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAggregatedWorkItemTally(Pointer, MemoryOwner);
		}

		// Token: 0x0400A402 RID: 41986
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.AggregatedWorkItemTally";

		// Token: 0x0400A403 RID: 41987
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A404 RID: 41988
		internal static int __PropertyOffset_TotalWorkItems;

		// Token: 0x0400A405 RID: 41989
		internal static int __PropertyOffset_WaitingWorkItems;

		// Token: 0x0400A406 RID: 41990
		internal static int __PropertyOffset_ScheduledWorkItems;

		// Token: 0x0400A407 RID: 41991
		internal static int __PropertyOffset_CookingWorkItems;

		// Token: 0x0400A408 RID: 41992
		internal static int __PropertyOffset_CookedWorkItems;

		// Token: 0x0400A409 RID: 41993
		internal static int __PropertyOffset_ErroredWorkItems;

		// Token: 0x0400A40A RID: 41994
		internal static int __PropertyOffset_CookCancelledWorkItems;
	}
}
