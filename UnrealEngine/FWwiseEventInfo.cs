using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A82 RID: 10882
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseEventInfo")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FWwiseEventInfo : FWwiseObjectInfo, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060281D4 RID: 164308 RVA: 0x003D0C90 File Offset: 0x003CEE90
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseEventInfo._ScriptStructPtr != 0) ? FWwiseEventInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseEventInfo", ref FWwiseEventInfo._ScriptStructPtr);
		}

		// Token: 0x1700992A RID: 39210
		// (get) Token: 0x060281D5 RID: 164309 RVA: 0x003D0CB4 File Offset: 0x003CEEB4
		// (set) Token: 0x060281D6 RID: 164310 RVA: 0x003D0CC4 File Offset: 0x003CEEC4
		public unsafe EWwiseEventSwitchContainerLoading SwitchContainerLoading
		{
			get
			{
				return (EWwiseEventSwitchContainerLoading)(*(base.NativePtr + (IntPtr)FWwiseEventInfo.__PropertyOffset_SwitchContainerLoading));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseEventInfo.__PropertyOffset_SwitchContainerLoading) = (byte)value;
			}
		}

		// Token: 0x1700992B RID: 39211
		// (get) Token: 0x060281D7 RID: 164311 RVA: 0x003D0CD5 File Offset: 0x003CEED5
		// (set) Token: 0x060281D8 RID: 164312 RVA: 0x003D0CE5 File Offset: 0x003CEEE5
		public unsafe EWwiseEventDestroyOptions DestroyOptions
		{
			get
			{
				return (EWwiseEventDestroyOptions)(*(base.NativePtr + (IntPtr)FWwiseEventInfo.__PropertyOffset_DestroyOptions));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseEventInfo.__PropertyOffset_DestroyOptions) = (byte)value;
			}
		}

		// Token: 0x060281D9 RID: 164313 RVA: 0x003D0CF6 File Offset: 0x003CEEF6
		public FWwiseEventInfo()
		{
		}

		// Token: 0x060281DA RID: 164314 RVA: 0x003D0CFE File Offset: 0x003CEEFE
		public FWwiseEventInfo(EWwiseEventSwitchContainerLoading SwitchContainerLoading, EWwiseEventDestroyOptions DestroyOptions, FGuid WwiseGuid, uint WwiseShortId, FName WwiseName, uint HardCodedSoundBankShortId)
		{
			this.SwitchContainerLoading = SwitchContainerLoading;
			this.DestroyOptions = DestroyOptions;
			base.WwiseGuid = WwiseGuid;
			base.WwiseShortId = WwiseShortId;
			base.WwiseName = WwiseName;
			base.HardCodedSoundBankShortId = HardCodedSoundBankShortId;
		}

		// Token: 0x060281DB RID: 164315 RVA: 0x003D0D33 File Offset: 0x003CEF33
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseEventInfo.StaticStruct();
		}

		// Token: 0x060281DC RID: 164316 RVA: 0x003D0D3F File Offset: 0x003CEF3F
		[NullableContext(2)]
		public FWwiseEventInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060281DD RID: 164317 RVA: 0x003D0D49 File Offset: 0x003CEF49
		public FWwiseEventInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060281DE RID: 164318 RVA: 0x003D0D54 File Offset: 0x003CEF54
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseEventInfo(Pointer, false, true);
		}

		// Token: 0x060281DF RID: 164319 RVA: 0x003D0D5E File Offset: 0x003CEF5E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseEventInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401603A RID: 90170
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseEventInfo";

		// Token: 0x0401603B RID: 90171
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401603C RID: 90172
		internal static int __PropertyOffset_SwitchContainerLoading;

		// Token: 0x0401603D RID: 90173
		internal static int __PropertyOffset_DestroyOptions;
	}
}
