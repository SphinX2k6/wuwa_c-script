using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021F8 RID: 8696
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkCameraBlueprintData")]
	[UnrealStructLayout(288, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class FLiveLinkCameraBlueprintData : FLiveLinkBaseBlueprintData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021253 RID: 135763 RVA: 0x0030DFF2 File Offset: 0x0030C1F2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkCameraBlueprintData._ScriptStructPtr != 0) ? FLiveLinkCameraBlueprintData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkCameraBlueprintData", ref FLiveLinkCameraBlueprintData._ScriptStructPtr);
		}

		// Token: 0x17008168 RID: 33128
		// (get) Token: 0x06021254 RID: 135764 RVA: 0x0030E018 File Offset: 0x0030C218
		// (set) Token: 0x06021255 RID: 135765 RVA: 0x0030E05B File Offset: 0x0030C25B
		public FLiveLinkCameraStaticData StaticData
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkCameraStaticData result;
				if ((result = this._StaticData) == null)
				{
					result = (this._StaticData = new FLiveLinkCameraStaticData(base.NativePtr + (IntPtr)FLiveLinkCameraBlueprintData.__PropertyOffset_StaticData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkCameraStaticData.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkCameraBlueprintData.__PropertyOffset_StaticData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008169 RID: 33129
		// (get) Token: 0x06021256 RID: 135766 RVA: 0x0030E07C File Offset: 0x0030C27C
		// (set) Token: 0x06021257 RID: 135767 RVA: 0x0030E0BF File Offset: 0x0030C2BF
		public FLiveLinkCameraFrameData FrameData
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkCameraFrameData result;
				if ((result = this._FrameData) == null)
				{
					result = (this._FrameData = new FLiveLinkCameraFrameData(base.NativePtr + (IntPtr)FLiveLinkCameraBlueprintData.__PropertyOffset_FrameData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkCameraFrameData.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkCameraBlueprintData.__PropertyOffset_FrameData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021258 RID: 135768 RVA: 0x0030E0E0 File Offset: 0x0030C2E0
		public FLiveLinkCameraBlueprintData()
		{
		}

		// Token: 0x06021259 RID: 135769 RVA: 0x0030E0E8 File Offset: 0x0030C2E8
		public FLiveLinkCameraBlueprintData(FLiveLinkCameraStaticData StaticData, FLiveLinkCameraFrameData FrameData)
		{
			this.StaticData = StaticData;
			this.FrameData = FrameData;
		}

		// Token: 0x0602125A RID: 135770 RVA: 0x0030E0FE File Offset: 0x0030C2FE
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkCameraBlueprintData.StaticStruct();
		}

		// Token: 0x0602125B RID: 135771 RVA: 0x0030E10A File Offset: 0x0030C30A
		[NullableContext(2)]
		public FLiveLinkCameraBlueprintData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602125C RID: 135772 RVA: 0x0030E114 File Offset: 0x0030C314
		public FLiveLinkCameraBlueprintData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602125D RID: 135773 RVA: 0x0030E11F File Offset: 0x0030C31F
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkCameraBlueprintData(Pointer, false, true);
		}

		// Token: 0x0602125E RID: 135774 RVA: 0x0030E129 File Offset: 0x0030C329
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkCameraBlueprintData(Pointer, MemoryOwner);
		}

		// Token: 0x04011AFB RID: 72443
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkCameraBlueprintData";

		// Token: 0x04011AFC RID: 72444
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011AFD RID: 72445
		internal static int __PropertyOffset_StaticData;

		// Token: 0x04011AFE RID: 72446
		[Nullable(2)]
		private FLiveLinkCameraStaticData _StaticData;

		// Token: 0x04011AFF RID: 72447
		internal static int __PropertyOffset_FrameData;

		// Token: 0x04011B00 RID: 72448
		[Nullable(2)]
		private FLiveLinkCameraFrameData _FrameData;
	}
}
