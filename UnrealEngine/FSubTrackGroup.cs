using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011BB RID: 4539
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SubTrackGroup")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FSubTrackGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010BC4 RID: 68548 RVA: 0x001890FD File Offset: 0x001872FD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSubTrackGroup._ScriptStructPtr != 0) ? FSubTrackGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SubTrackGroup", ref FSubTrackGroup._ScriptStructPtr);
		}

		// Token: 0x1700415B RID: 16731
		// (get) Token: 0x06010BC5 RID: 68549 RVA: 0x00189121 File Offset: 0x00187321
		// (set) Token: 0x06010BC6 RID: 68550 RVA: 0x00189135 File Offset: 0x00187335
		public unsafe string GroupName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSubTrackGroup.__PropertyOffset_GroupName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSubTrackGroup.__PropertyOffset_GroupName)), value);
			}
		}

		// Token: 0x1700415C RID: 16732
		// (get) Token: 0x06010BC7 RID: 68551 RVA: 0x0018914C File Offset: 0x0018734C
		// (set) Token: 0x06010BC8 RID: 68552 RVA: 0x0018918F File Offset: 0x0018738F
		public TArray<int> TrackIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._TrackIndices) == null)
				{
					result = (this._TrackIndices = new TArray<int>(base.NativePtr + (IntPtr)FSubTrackGroup.__PropertyOffset_TrackIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TrackIndices.CopyAssign(value);
			}
		}

		// Token: 0x1700415D RID: 16733
		// (get) Token: 0x06010BC9 RID: 68553 RVA: 0x0018919D File Offset: 0x0018739D
		// (set) Token: 0x06010BCA RID: 68554 RVA: 0x001891B6 File Offset: 0x001873B6
		public unsafe bool bIsCollapsed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSubTrackGroup.__PropertyOffset_bIsCollapsed) & FSubTrackGroup.__PropertyMask_bIsCollapsed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSubTrackGroup.__PropertyOffset_bIsCollapsed) = ((*(base.NativePtr + (IntPtr)FSubTrackGroup.__PropertyOffset_bIsCollapsed) & ~FSubTrackGroup.__PropertyMask_bIsCollapsed) | (value ? FSubTrackGroup.__PropertyMask_bIsCollapsed : 0));
			}
		}

		// Token: 0x1700415E RID: 16734
		// (get) Token: 0x06010BCB RID: 68555 RVA: 0x001891E6 File Offset: 0x001873E6
		// (set) Token: 0x06010BCC RID: 68556 RVA: 0x001891FF File Offset: 0x001873FF
		public unsafe bool bIsSelected
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSubTrackGroup.__PropertyOffset_bIsSelected) & FSubTrackGroup.__PropertyMask_bIsSelected) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSubTrackGroup.__PropertyOffset_bIsSelected) = ((*(base.NativePtr + (IntPtr)FSubTrackGroup.__PropertyOffset_bIsSelected) & ~FSubTrackGroup.__PropertyMask_bIsSelected) | (value ? FSubTrackGroup.__PropertyMask_bIsSelected : 0));
			}
		}

		// Token: 0x06010BCD RID: 68557 RVA: 0x0018922F File Offset: 0x0018742F
		public FSubTrackGroup()
		{
		}

		// Token: 0x06010BCE RID: 68558 RVA: 0x00189237 File Offset: 0x00187437
		public FSubTrackGroup(string GroupName, TArray<int> TrackIndices, bool bIsCollapsed, bool bIsSelected)
		{
			this.GroupName = GroupName;
			this.TrackIndices = TrackIndices;
			this.bIsCollapsed = bIsCollapsed;
			this.bIsSelected = bIsSelected;
		}

		// Token: 0x06010BCF RID: 68559 RVA: 0x0018925C File Offset: 0x0018745C
		protected override IntPtr GetUStructPtr()
		{
			return FSubTrackGroup.StaticStruct();
		}

		// Token: 0x06010BD0 RID: 68560 RVA: 0x00189268 File Offset: 0x00187468
		[NullableContext(2)]
		public FSubTrackGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010BD1 RID: 68561 RVA: 0x00189272 File Offset: 0x00187472
		public FSubTrackGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010BD2 RID: 68562 RVA: 0x0018927D File Offset: 0x0018747D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSubTrackGroup(Pointer, false, true);
		}

		// Token: 0x06010BD3 RID: 68563 RVA: 0x00189287 File Offset: 0x00187487
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSubTrackGroup(Pointer, MemoryOwner);
		}

		// Token: 0x04008F20 RID: 36640
		public const string __ObjectPath = "/Script/Engine.SubTrackGroup";

		// Token: 0x04008F21 RID: 36641
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008F22 RID: 36642
		internal static int __PropertyOffset_GroupName;

		// Token: 0x04008F23 RID: 36643
		internal static int __PropertyOffset_TrackIndices;

		// Token: 0x04008F24 RID: 36644
		[Nullable(2)]
		private TArray<int> _TrackIndices;

		// Token: 0x04008F25 RID: 36645
		internal static int __PropertyOffset_bIsCollapsed;

		// Token: 0x04008F26 RID: 36646
		internal static byte __PropertyMask_bIsCollapsed;

		// Token: 0x04008F27 RID: 36647
		internal static int __PropertyOffset_bIsSelected;

		// Token: 0x04008F28 RID: 36648
		internal static byte __PropertyMask_bIsSelected;
	}
}
