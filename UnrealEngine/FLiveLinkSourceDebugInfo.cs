using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002215 RID: 8725
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkSourceDebugInfo")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FLiveLinkSourceDebugInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060213C9 RID: 136137 RVA: 0x0030FF64 File Offset: 0x0030E164
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkSourceDebugInfo._ScriptStructPtr != 0) ? FLiveLinkSourceDebugInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkSourceDebugInfo", ref FLiveLinkSourceDebugInfo._ScriptStructPtr);
		}

		// Token: 0x170081BF RID: 33215
		// (get) Token: 0x060213CA RID: 136138 RVA: 0x0030FF88 File Offset: 0x0030E188
		// (set) Token: 0x060213CB RID: 136139 RVA: 0x0030FFCB File Offset: 0x0030E1CB
		public FLiveLinkSubjectName SubjectName
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkSubjectName result;
				if ((result = this._SubjectName) == null)
				{
					result = (this._SubjectName = new FLiveLinkSubjectName(base.NativePtr + (IntPtr)FLiveLinkSourceDebugInfo.__PropertyOffset_SubjectName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkSubjectName.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkSourceDebugInfo.__PropertyOffset_SubjectName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170081C0 RID: 33216
		// (get) Token: 0x060213CC RID: 136140 RVA: 0x0030FFEC File Offset: 0x0030E1EC
		// (set) Token: 0x060213CD RID: 136141 RVA: 0x0030FFFC File Offset: 0x0030E1FC
		public unsafe int SnapshotIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceDebugInfo.__PropertyOffset_SnapshotIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceDebugInfo.__PropertyOffset_SnapshotIndex) = value;
			}
		}

		// Token: 0x170081C1 RID: 33217
		// (get) Token: 0x060213CE RID: 136142 RVA: 0x0031000D File Offset: 0x0030E20D
		// (set) Token: 0x060213CF RID: 136143 RVA: 0x0031001D File Offset: 0x0030E21D
		public unsafe int NumberOfBufferAtSnapshot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourceDebugInfo.__PropertyOffset_NumberOfBufferAtSnapshot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourceDebugInfo.__PropertyOffset_NumberOfBufferAtSnapshot) = value;
			}
		}

		// Token: 0x060213D0 RID: 136144 RVA: 0x0031002E File Offset: 0x0030E22E
		public FLiveLinkSourceDebugInfo()
		{
		}

		// Token: 0x060213D1 RID: 136145 RVA: 0x00310036 File Offset: 0x0030E236
		public FLiveLinkSourceDebugInfo(FLiveLinkSubjectName SubjectName, int SnapshotIndex, int NumberOfBufferAtSnapshot)
		{
			this.SubjectName = SubjectName;
			this.SnapshotIndex = SnapshotIndex;
			this.NumberOfBufferAtSnapshot = NumberOfBufferAtSnapshot;
		}

		// Token: 0x060213D2 RID: 136146 RVA: 0x00310053 File Offset: 0x0030E253
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkSourceDebugInfo.StaticStruct();
		}

		// Token: 0x060213D3 RID: 136147 RVA: 0x0031005F File Offset: 0x0030E25F
		[NullableContext(2)]
		public FLiveLinkSourceDebugInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060213D4 RID: 136148 RVA: 0x00310069 File Offset: 0x0030E269
		public FLiveLinkSourceDebugInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060213D5 RID: 136149 RVA: 0x00310074 File Offset: 0x0030E274
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkSourceDebugInfo(Pointer, false, true);
		}

		// Token: 0x060213D6 RID: 136150 RVA: 0x0031007E File Offset: 0x0030E27E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkSourceDebugInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04011BAB RID: 72619
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkSourceDebugInfo";

		// Token: 0x04011BAC RID: 72620
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011BAD RID: 72621
		internal static int __PropertyOffset_SubjectName;

		// Token: 0x04011BAE RID: 72622
		[Nullable(2)]
		private FLiveLinkSubjectName _SubjectName;

		// Token: 0x04011BAF RID: 72623
		internal static int __PropertyOffset_SnapshotIndex;

		// Token: 0x04011BB0 RID: 72624
		internal static int __PropertyOffset_NumberOfBufferAtSnapshot;
	}
}
