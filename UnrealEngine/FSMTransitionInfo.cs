using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200289E RID: 10398
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.SMTransitionInfo")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FSMTransitionInfo : FSMInfo_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026906 RID: 157958 RVA: 0x003AD34C File Offset: 0x003AB54C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMTransitionInfo._ScriptStructPtr != 0) ? FSMTransitionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMTransitionInfo", ref FSMTransitionInfo._ScriptStructPtr);
		}

		// Token: 0x170094BB RID: 38075
		// (get) Token: 0x06026907 RID: 157959 RVA: 0x003AD370 File Offset: 0x003AB570
		// (set) Token: 0x06026908 RID: 157960 RVA: 0x003AD384 File Offset: 0x003AB584
		public unsafe FGuid FromStateGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMTransitionInfo.__PropertyOffset_FromStateGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMTransitionInfo.__PropertyOffset_FromStateGuid) = value;
			}
		}

		// Token: 0x170094BC RID: 38076
		// (get) Token: 0x06026909 RID: 157961 RVA: 0x003AD399 File Offset: 0x003AB599
		// (set) Token: 0x0602690A RID: 157962 RVA: 0x003AD3AD File Offset: 0x003AB5AD
		public unsafe FGuid ToStateGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMTransitionInfo.__PropertyOffset_ToStateGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMTransitionInfo.__PropertyOffset_ToStateGuid) = value;
			}
		}

		// Token: 0x170094BD RID: 38077
		// (get) Token: 0x0602690B RID: 157963 RVA: 0x003AD3C2 File Offset: 0x003AB5C2
		// (set) Token: 0x0602690C RID: 157964 RVA: 0x003AD3D2 File Offset: 0x003AB5D2
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMTransitionInfo.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMTransitionInfo.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x170094BE RID: 38078
		// (get) Token: 0x0602690D RID: 157965 RVA: 0x003AD3E4 File Offset: 0x003AB5E4
		// (set) Token: 0x0602690E RID: 157966 RVA: 0x003AD427 File Offset: 0x003AB627
		public FDateTime LastNetworkTimestamp
		{
			get
			{
				base.FastCheckIsValid();
				FDateTime result;
				if ((result = this._LastNetworkTimestamp) == null)
				{
					result = (this._LastNetworkTimestamp = new FDateTime(base.NativePtr + (IntPtr)FSMTransitionInfo.__PropertyOffset_LastNetworkTimestamp, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDateTime.StaticStruct(), base.NativePtr + (IntPtr)FSMTransitionInfo.__PropertyOffset_LastNetworkTimestamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602690F RID: 157967 RVA: 0x003AD448 File Offset: 0x003AB648
		public FSMTransitionInfo()
		{
		}

		// Token: 0x06026910 RID: 157968 RVA: 0x003AD450 File Offset: 0x003AB650
		public FSMTransitionInfo(FGuid FromStateGuid, FGuid ToStateGuid, int Priority, FDateTime LastNetworkTimestamp, string NodeName, FGuid Guid, FGuid OwnerGuid, FGuid NodeGuid, FGuid OwnerNodeGuid, USMNodeInstance NodeInstance)
		{
			this.FromStateGuid = FromStateGuid;
			this.ToStateGuid = ToStateGuid;
			this.Priority = Priority;
			this.LastNetworkTimestamp = LastNetworkTimestamp;
			base.NodeName = NodeName;
			base.Guid = Guid;
			base.OwnerGuid = OwnerGuid;
			base.NodeGuid = NodeGuid;
			base.OwnerNodeGuid = OwnerNodeGuid;
			base.NodeInstance = NodeInstance;
		}

		// Token: 0x06026911 RID: 157969 RVA: 0x003AD4B0 File Offset: 0x003AB6B0
		protected override IntPtr GetUStructPtr()
		{
			return FSMTransitionInfo.StaticStruct();
		}

		// Token: 0x06026912 RID: 157970 RVA: 0x003AD4BC File Offset: 0x003AB6BC
		[NullableContext(2)]
		public FSMTransitionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026913 RID: 157971 RVA: 0x003AD4C6 File Offset: 0x003AB6C6
		public FSMTransitionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026914 RID: 157972 RVA: 0x003AD4D1 File Offset: 0x003AB6D1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMTransitionInfo(Pointer, false, true);
		}

		// Token: 0x06026915 RID: 157973 RVA: 0x003AD4DB File Offset: 0x003AB6DB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMTransitionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040152EB RID: 86763
		public new const string __ObjectPath = "/Script/SMSystem.SMTransitionInfo";

		// Token: 0x040152EC RID: 86764
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040152ED RID: 86765
		internal static int __PropertyOffset_FromStateGuid;

		// Token: 0x040152EE RID: 86766
		internal static int __PropertyOffset_ToStateGuid;

		// Token: 0x040152EF RID: 86767
		internal static int __PropertyOffset_Priority;

		// Token: 0x040152F0 RID: 86768
		internal static int __PropertyOffset_LastNetworkTimestamp;

		// Token: 0x040152F1 RID: 86769
		[Nullable(2)]
		private FDateTime _LastNetworkTimestamp;
	}
}
