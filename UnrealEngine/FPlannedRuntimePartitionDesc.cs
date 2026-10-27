using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FF3 RID: 4083
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PlannedRuntimePartitionDesc")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FPlannedRuntimePartitionDesc : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DD2E RID: 56622 RVA: 0x00145A6E File Offset: 0x00143C6E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPlannedRuntimePartitionDesc._ScriptStructPtr != 0) ? FPlannedRuntimePartitionDesc._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PlannedRuntimePartitionDesc", ref FPlannedRuntimePartitionDesc._ScriptStructPtr);
		}

		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x0600DD2F RID: 56623 RVA: 0x00145A92 File Offset: 0x00143C92
		// (set) Token: 0x0600DD30 RID: 56624 RVA: 0x00145AA6 File Offset: 0x00143CA6
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlannedRuntimePartitionDesc.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlannedRuntimePartitionDesc.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x0600DD31 RID: 56625 RVA: 0x00145ABC File Offset: 0x00143CBC
		// (set) Token: 0x0600DD32 RID: 56626 RVA: 0x00145AFF File Offset: 0x00143CFF
		public TArray<UPlannedRuntimePartitionFilter> Filters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPlannedRuntimePartitionFilter> result;
				if ((result = this._Filters) == null)
				{
					result = (this._Filters = new TArray<UPlannedRuntimePartitionFilter>(base.NativePtr + (IntPtr)FPlannedRuntimePartitionDesc.__PropertyOffset_Filters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Filters.CopyAssign(value);
			}
		}

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x0600DD33 RID: 56627 RVA: 0x00145B10 File Offset: 0x00143D10
		// (set) Token: 0x0600DD34 RID: 56628 RVA: 0x00145B53 File Offset: 0x00143D53
		public TArray<URuntimePartitionTemplate> MainLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<URuntimePartitionTemplate> result;
				if ((result = this._MainLayers) == null)
				{
					result = (this._MainLayers = new TArray<URuntimePartitionTemplate>(base.NativePtr + (IntPtr)FPlannedRuntimePartitionDesc.__PropertyOffset_MainLayers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MainLayers.CopyAssign(value);
			}
		}

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x0600DD35 RID: 56629 RVA: 0x00145B64 File Offset: 0x00143D64
		// (set) Token: 0x0600DD36 RID: 56630 RVA: 0x00145BA7 File Offset: 0x00143DA7
		public TArray<FPlannedRuntimePartitionHLODSetup> HLODSetups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPlannedRuntimePartitionHLODSetup> result;
				if ((result = this._HLODSetups) == null)
				{
					result = (this._HLODSetups = new TArray<FPlannedRuntimePartitionHLODSetup>(base.NativePtr + (IntPtr)FPlannedRuntimePartitionDesc.__PropertyOffset_HLODSetups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HLODSetups.CopyAssign(value);
			}
		}

		// Token: 0x0600DD37 RID: 56631 RVA: 0x00145BB5 File Offset: 0x00143DB5
		public FPlannedRuntimePartitionDesc()
		{
		}

		// Token: 0x0600DD38 RID: 56632 RVA: 0x00145BBD File Offset: 0x00143DBD
		public FPlannedRuntimePartitionDesc(FName Name, TArray<UPlannedRuntimePartitionFilter> Filters, TArray<URuntimePartitionTemplate> MainLayers, TArray<FPlannedRuntimePartitionHLODSetup> HLODSetups)
		{
			this.Name = Name;
			this.Filters = Filters;
			this.MainLayers = MainLayers;
			this.HLODSetups = HLODSetups;
		}

		// Token: 0x0600DD39 RID: 56633 RVA: 0x00145BE2 File Offset: 0x00143DE2
		protected override IntPtr GetUStructPtr()
		{
			return FPlannedRuntimePartitionDesc.StaticStruct();
		}

		// Token: 0x0600DD3A RID: 56634 RVA: 0x00145BEE File Offset: 0x00143DEE
		[NullableContext(2)]
		public FPlannedRuntimePartitionDesc(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DD3B RID: 56635 RVA: 0x00145BF8 File Offset: 0x00143DF8
		public FPlannedRuntimePartitionDesc(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DD3C RID: 56636 RVA: 0x00145C03 File Offset: 0x00143E03
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPlannedRuntimePartitionDesc(Pointer, false, true);
		}

		// Token: 0x0600DD3D RID: 56637 RVA: 0x00145C0D File Offset: 0x00143E0D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPlannedRuntimePartitionDesc(Pointer, MemoryOwner);
		}

		// Token: 0x0400778E RID: 30606
		public const string __ObjectPath = "/Script/Engine.PlannedRuntimePartitionDesc";

		// Token: 0x0400778F RID: 30607
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007790 RID: 30608
		internal static int __PropertyOffset_Name;

		// Token: 0x04007791 RID: 30609
		internal static int __PropertyOffset_Filters;

		// Token: 0x04007792 RID: 30610
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPlannedRuntimePartitionFilter> _Filters;

		// Token: 0x04007793 RID: 30611
		internal static int __PropertyOffset_MainLayers;

		// Token: 0x04007794 RID: 30612
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<URuntimePartitionTemplate> _MainLayers;

		// Token: 0x04007795 RID: 30613
		internal static int __PropertyOffset_HLODSetups;

		// Token: 0x04007796 RID: 30614
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPlannedRuntimePartitionHLODSetup> _HLODSetups;
	}
}
