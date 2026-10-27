using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002208 RID: 8712
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkLightBlueprintData")]
	[UnrealStructLayout(304, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 304)]
	public class FLiveLinkLightBlueprintData : FLiveLinkBaseBlueprintData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060212FD RID: 135933 RVA: 0x0030ED7D File Offset: 0x0030CF7D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkLightBlueprintData._ScriptStructPtr != 0) ? FLiveLinkLightBlueprintData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkLightBlueprintData", ref FLiveLinkLightBlueprintData._ScriptStructPtr);
		}

		// Token: 0x17008188 RID: 33160
		// (get) Token: 0x060212FE RID: 135934 RVA: 0x0030EDA4 File Offset: 0x0030CFA4
		// (set) Token: 0x060212FF RID: 135935 RVA: 0x0030EDE7 File Offset: 0x0030CFE7
		public FLiveLinkLightStaticData StaticData
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkLightStaticData result;
				if ((result = this._StaticData) == null)
				{
					result = (this._StaticData = new FLiveLinkLightStaticData(base.NativePtr + (IntPtr)FLiveLinkLightBlueprintData.__PropertyOffset_StaticData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkLightStaticData.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkLightBlueprintData.__PropertyOffset_StaticData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008189 RID: 33161
		// (get) Token: 0x06021300 RID: 135936 RVA: 0x0030EE08 File Offset: 0x0030D008
		// (set) Token: 0x06021301 RID: 135937 RVA: 0x0030EE4B File Offset: 0x0030D04B
		public FLiveLinkLightFrameData FrameData
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkLightFrameData result;
				if ((result = this._FrameData) == null)
				{
					result = (this._FrameData = new FLiveLinkLightFrameData(base.NativePtr + (IntPtr)FLiveLinkLightBlueprintData.__PropertyOffset_FrameData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkLightFrameData.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkLightBlueprintData.__PropertyOffset_FrameData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021302 RID: 135938 RVA: 0x0030EE6C File Offset: 0x0030D06C
		public FLiveLinkLightBlueprintData()
		{
		}

		// Token: 0x06021303 RID: 135939 RVA: 0x0030EE74 File Offset: 0x0030D074
		public FLiveLinkLightBlueprintData(FLiveLinkLightStaticData StaticData, FLiveLinkLightFrameData FrameData)
		{
			this.StaticData = StaticData;
			this.FrameData = FrameData;
		}

		// Token: 0x06021304 RID: 135940 RVA: 0x0030EE8A File Offset: 0x0030D08A
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkLightBlueprintData.StaticStruct();
		}

		// Token: 0x06021305 RID: 135941 RVA: 0x0030EE96 File Offset: 0x0030D096
		[NullableContext(2)]
		public FLiveLinkLightBlueprintData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021306 RID: 135942 RVA: 0x0030EEA0 File Offset: 0x0030D0A0
		public FLiveLinkLightBlueprintData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021307 RID: 135943 RVA: 0x0030EEAB File Offset: 0x0030D0AB
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkLightBlueprintData(Pointer, false, true);
		}

		// Token: 0x06021308 RID: 135944 RVA: 0x0030EEB5 File Offset: 0x0030D0B5
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkLightBlueprintData(Pointer, MemoryOwner);
		}

		// Token: 0x04011B49 RID: 72521
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkLightBlueprintData";

		// Token: 0x04011B4A RID: 72522
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B4B RID: 72523
		internal static int __PropertyOffset_StaticData;

		// Token: 0x04011B4C RID: 72524
		[Nullable(2)]
		private FLiveLinkLightStaticData _StaticData;

		// Token: 0x04011B4D RID: 72525
		internal static int __PropertyOffset_FrameData;

		// Token: 0x04011B4E RID: 72526
		[Nullable(2)]
		private FLiveLinkLightFrameData _FrameData;
	}
}
