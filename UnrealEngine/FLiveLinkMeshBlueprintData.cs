using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200220C RID: 8716
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkMeshBlueprintData")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 296)]
	public class FLiveLinkMeshBlueprintData : FLiveLinkBaseBlueprintData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021342 RID: 136002 RVA: 0x0030F348 File Offset: 0x0030D548
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkMeshBlueprintData._ScriptStructPtr != 0) ? FLiveLinkMeshBlueprintData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkMeshBlueprintData", ref FLiveLinkMeshBlueprintData._ScriptStructPtr);
		}

		// Token: 0x1700819C RID: 33180
		// (get) Token: 0x06021343 RID: 136003 RVA: 0x0030F36C File Offset: 0x0030D56C
		// (set) Token: 0x06021344 RID: 136004 RVA: 0x0030F3AF File Offset: 0x0030D5AF
		public FLiveLinkMeshStaticData StaticData
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkMeshStaticData result;
				if ((result = this._StaticData) == null)
				{
					result = (this._StaticData = new FLiveLinkMeshStaticData(base.NativePtr + (IntPtr)FLiveLinkMeshBlueprintData.__PropertyOffset_StaticData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkMeshStaticData.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkMeshBlueprintData.__PropertyOffset_StaticData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700819D RID: 33181
		// (get) Token: 0x06021345 RID: 136005 RVA: 0x0030F3D0 File Offset: 0x0030D5D0
		// (set) Token: 0x06021346 RID: 136006 RVA: 0x0030F413 File Offset: 0x0030D613
		public FLiveLinkMeshFrameData FrameData
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkMeshFrameData result;
				if ((result = this._FrameData) == null)
				{
					result = (this._FrameData = new FLiveLinkMeshFrameData(base.NativePtr + (IntPtr)FLiveLinkMeshBlueprintData.__PropertyOffset_FrameData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkMeshFrameData.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkMeshBlueprintData.__PropertyOffset_FrameData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021347 RID: 136007 RVA: 0x0030F434 File Offset: 0x0030D634
		public FLiveLinkMeshBlueprintData()
		{
		}

		// Token: 0x06021348 RID: 136008 RVA: 0x0030F43C File Offset: 0x0030D63C
		public FLiveLinkMeshBlueprintData(FLiveLinkMeshStaticData StaticData, FLiveLinkMeshFrameData FrameData)
		{
			this.StaticData = StaticData;
			this.FrameData = FrameData;
		}

		// Token: 0x06021349 RID: 136009 RVA: 0x0030F452 File Offset: 0x0030D652
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkMeshBlueprintData.StaticStruct();
		}

		// Token: 0x0602134A RID: 136010 RVA: 0x0030F45E File Offset: 0x0030D65E
		[NullableContext(2)]
		public FLiveLinkMeshBlueprintData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602134B RID: 136011 RVA: 0x0030F468 File Offset: 0x0030D668
		public FLiveLinkMeshBlueprintData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602134C RID: 136012 RVA: 0x0030F473 File Offset: 0x0030D673
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkMeshBlueprintData(Pointer, false, true);
		}

		// Token: 0x0602134D RID: 136013 RVA: 0x0030F47D File Offset: 0x0030D67D
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkMeshBlueprintData(Pointer, MemoryOwner);
		}

		// Token: 0x04011B68 RID: 72552
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkMeshBlueprintData";

		// Token: 0x04011B69 RID: 72553
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B6A RID: 72554
		internal static int __PropertyOffset_StaticData;

		// Token: 0x04011B6B RID: 72555
		[Nullable(2)]
		private FLiveLinkMeshStaticData _StaticData;

		// Token: 0x04011B6C RID: 72556
		internal static int __PropertyOffset_FrameData;

		// Token: 0x04011B6D RID: 72557
		[Nullable(2)]
		private FLiveLinkMeshFrameData _FrameData;
	}
}
