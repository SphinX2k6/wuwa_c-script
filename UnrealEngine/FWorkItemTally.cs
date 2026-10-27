using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200150E RID: 5390
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.WorkItemTally")]
	[UnrealStructLayout(568, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 568)]
	public class FWorkItemTally : FWorkItemTallyBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060139E3 RID: 80355 RVA: 0x001CD045 File Offset: 0x001CB245
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorkItemTally._ScriptStructPtr != 0) ? FWorkItemTally._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.WorkItemTally", ref FWorkItemTally._ScriptStructPtr);
		}

		// Token: 0x17004CDE RID: 19678
		// (get) Token: 0x060139E4 RID: 80356 RVA: 0x001CD06C File Offset: 0x001CB26C
		// (set) Token: 0x060139E5 RID: 80357 RVA: 0x001CD0AF File Offset: 0x001CB2AF
		public TSet<int> AllWorkItems
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._AllWorkItems) == null)
				{
					result = (this._AllWorkItems = new TSet<int>(base.NativePtr + (IntPtr)FWorkItemTally.__PropertyOffset_AllWorkItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AllWorkItems.CopyAssign(value);
			}
		}

		// Token: 0x17004CDF RID: 19679
		// (get) Token: 0x060139E6 RID: 80358 RVA: 0x001CD0C0 File Offset: 0x001CB2C0
		// (set) Token: 0x060139E7 RID: 80359 RVA: 0x001CD103 File Offset: 0x001CB303
		public TSet<int> WaitingWorkItems
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._WaitingWorkItems) == null)
				{
					result = (this._WaitingWorkItems = new TSet<int>(base.NativePtr + (IntPtr)FWorkItemTally.__PropertyOffset_WaitingWorkItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.WaitingWorkItems.CopyAssign(value);
			}
		}

		// Token: 0x17004CE0 RID: 19680
		// (get) Token: 0x060139E8 RID: 80360 RVA: 0x001CD114 File Offset: 0x001CB314
		// (set) Token: 0x060139E9 RID: 80361 RVA: 0x001CD157 File Offset: 0x001CB357
		public TSet<int> ScheduledWorkItems
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._ScheduledWorkItems) == null)
				{
					result = (this._ScheduledWorkItems = new TSet<int>(base.NativePtr + (IntPtr)FWorkItemTally.__PropertyOffset_ScheduledWorkItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ScheduledWorkItems.CopyAssign(value);
			}
		}

		// Token: 0x17004CE1 RID: 19681
		// (get) Token: 0x060139EA RID: 80362 RVA: 0x001CD168 File Offset: 0x001CB368
		// (set) Token: 0x060139EB RID: 80363 RVA: 0x001CD1AB File Offset: 0x001CB3AB
		public TSet<int> CookingWorkItems
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._CookingWorkItems) == null)
				{
					result = (this._CookingWorkItems = new TSet<int>(base.NativePtr + (IntPtr)FWorkItemTally.__PropertyOffset_CookingWorkItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CookingWorkItems.CopyAssign(value);
			}
		}

		// Token: 0x17004CE2 RID: 19682
		// (get) Token: 0x060139EC RID: 80364 RVA: 0x001CD1BC File Offset: 0x001CB3BC
		// (set) Token: 0x060139ED RID: 80365 RVA: 0x001CD1FF File Offset: 0x001CB3FF
		public TSet<int> CookedWorkItems
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._CookedWorkItems) == null)
				{
					result = (this._CookedWorkItems = new TSet<int>(base.NativePtr + (IntPtr)FWorkItemTally.__PropertyOffset_CookedWorkItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CookedWorkItems.CopyAssign(value);
			}
		}

		// Token: 0x17004CE3 RID: 19683
		// (get) Token: 0x060139EE RID: 80366 RVA: 0x001CD210 File Offset: 0x001CB410
		// (set) Token: 0x060139EF RID: 80367 RVA: 0x001CD253 File Offset: 0x001CB453
		public TSet<int> ErroredWorkItems
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._ErroredWorkItems) == null)
				{
					result = (this._ErroredWorkItems = new TSet<int>(base.NativePtr + (IntPtr)FWorkItemTally.__PropertyOffset_ErroredWorkItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ErroredWorkItems.CopyAssign(value);
			}
		}

		// Token: 0x17004CE4 RID: 19684
		// (get) Token: 0x060139F0 RID: 80368 RVA: 0x001CD264 File Offset: 0x001CB464
		// (set) Token: 0x060139F1 RID: 80369 RVA: 0x001CD2A7 File Offset: 0x001CB4A7
		public TSet<int> CookCancelledWorkItems
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._CookCancelledWorkItems) == null)
				{
					result = (this._CookCancelledWorkItems = new TSet<int>(base.NativePtr + (IntPtr)FWorkItemTally.__PropertyOffset_CookCancelledWorkItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CookCancelledWorkItems.CopyAssign(value);
			}
		}

		// Token: 0x060139F2 RID: 80370 RVA: 0x001CD2B5 File Offset: 0x001CB4B5
		public FWorkItemTally()
		{
		}

		// Token: 0x060139F3 RID: 80371 RVA: 0x001CD2BD File Offset: 0x001CB4BD
		public FWorkItemTally(TSet<int> AllWorkItems, TSet<int> WaitingWorkItems, TSet<int> ScheduledWorkItems, TSet<int> CookingWorkItems, TSet<int> CookedWorkItems, TSet<int> ErroredWorkItems, TSet<int> CookCancelledWorkItems)
		{
			this.AllWorkItems = AllWorkItems;
			this.WaitingWorkItems = WaitingWorkItems;
			this.ScheduledWorkItems = ScheduledWorkItems;
			this.CookingWorkItems = CookingWorkItems;
			this.CookedWorkItems = CookedWorkItems;
			this.ErroredWorkItems = ErroredWorkItems;
			this.CookCancelledWorkItems = CookCancelledWorkItems;
		}

		// Token: 0x060139F4 RID: 80372 RVA: 0x001CD2FA File Offset: 0x001CB4FA
		protected override IntPtr GetUStructPtr()
		{
			return FWorkItemTally.StaticStruct();
		}

		// Token: 0x060139F5 RID: 80373 RVA: 0x001CD306 File Offset: 0x001CB506
		[NullableContext(2)]
		public FWorkItemTally(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060139F6 RID: 80374 RVA: 0x001CD310 File Offset: 0x001CB510
		public FWorkItemTally(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060139F7 RID: 80375 RVA: 0x001CD31B File Offset: 0x001CB51B
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorkItemTally(Pointer, false, true);
		}

		// Token: 0x060139F8 RID: 80376 RVA: 0x001CD325 File Offset: 0x001CB525
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorkItemTally(Pointer, MemoryOwner);
		}

		// Token: 0x0400A98B RID: 43403
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.WorkItemTally";

		// Token: 0x0400A98C RID: 43404
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A98D RID: 43405
		internal static int __PropertyOffset_AllWorkItems;

		// Token: 0x0400A98E RID: 43406
		[Nullable(2)]
		private TSet<int> _AllWorkItems;

		// Token: 0x0400A98F RID: 43407
		internal static int __PropertyOffset_WaitingWorkItems;

		// Token: 0x0400A990 RID: 43408
		[Nullable(2)]
		private TSet<int> _WaitingWorkItems;

		// Token: 0x0400A991 RID: 43409
		internal static int __PropertyOffset_ScheduledWorkItems;

		// Token: 0x0400A992 RID: 43410
		[Nullable(2)]
		private TSet<int> _ScheduledWorkItems;

		// Token: 0x0400A993 RID: 43411
		internal static int __PropertyOffset_CookingWorkItems;

		// Token: 0x0400A994 RID: 43412
		[Nullable(2)]
		private TSet<int> _CookingWorkItems;

		// Token: 0x0400A995 RID: 43413
		internal static int __PropertyOffset_CookedWorkItems;

		// Token: 0x0400A996 RID: 43414
		[Nullable(2)]
		private TSet<int> _CookedWorkItems;

		// Token: 0x0400A997 RID: 43415
		internal static int __PropertyOffset_ErroredWorkItems;

		// Token: 0x0400A998 RID: 43416
		[Nullable(2)]
		private TSet<int> _ErroredWorkItems;

		// Token: 0x0400A999 RID: 43417
		internal static int __PropertyOffset_CookCancelledWorkItems;

		// Token: 0x0400A99A RID: 43418
		[Nullable(2)]
		private TSet<int> _CookCancelledWorkItems;
	}
}
