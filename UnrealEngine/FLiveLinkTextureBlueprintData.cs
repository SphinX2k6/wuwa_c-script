using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200221F RID: 8735
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkTextureBlueprintData")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 304)]
	public class FLiveLinkTextureBlueprintData : FLiveLinkBaseBlueprintData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021442 RID: 136258 RVA: 0x00310989 File Offset: 0x0030EB89
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkTextureBlueprintData._ScriptStructPtr != 0) ? FLiveLinkTextureBlueprintData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkTextureBlueprintData", ref FLiveLinkTextureBlueprintData._ScriptStructPtr);
		}

		// Token: 0x170081D9 RID: 33241
		// (get) Token: 0x06021443 RID: 136259 RVA: 0x003109B0 File Offset: 0x0030EBB0
		// (set) Token: 0x06021444 RID: 136260 RVA: 0x003109F3 File Offset: 0x0030EBF3
		public FLiveLinkTextureStaticData StaticData
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkTextureStaticData result;
				if ((result = this._StaticData) == null)
				{
					result = (this._StaticData = new FLiveLinkTextureStaticData(base.NativePtr + (IntPtr)FLiveLinkTextureBlueprintData.__PropertyOffset_StaticData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkTextureStaticData.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkTextureBlueprintData.__PropertyOffset_StaticData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170081DA RID: 33242
		// (get) Token: 0x06021445 RID: 136261 RVA: 0x00310A14 File Offset: 0x0030EC14
		// (set) Token: 0x06021446 RID: 136262 RVA: 0x00310A57 File Offset: 0x0030EC57
		public FLiveLinkTextureFrameData FrameData
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkTextureFrameData result;
				if ((result = this._FrameData) == null)
				{
					result = (this._FrameData = new FLiveLinkTextureFrameData(base.NativePtr + (IntPtr)FLiveLinkTextureBlueprintData.__PropertyOffset_FrameData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkTextureFrameData.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkTextureBlueprintData.__PropertyOffset_FrameData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021447 RID: 136263 RVA: 0x00310A78 File Offset: 0x0030EC78
		public FLiveLinkTextureBlueprintData()
		{
		}

		// Token: 0x06021448 RID: 136264 RVA: 0x00310A80 File Offset: 0x0030EC80
		public FLiveLinkTextureBlueprintData(FLiveLinkTextureStaticData StaticData, FLiveLinkTextureFrameData FrameData)
		{
			this.StaticData = StaticData;
			this.FrameData = FrameData;
		}

		// Token: 0x06021449 RID: 136265 RVA: 0x00310A96 File Offset: 0x0030EC96
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkTextureBlueprintData.StaticStruct();
		}

		// Token: 0x0602144A RID: 136266 RVA: 0x00310AA2 File Offset: 0x0030ECA2
		[NullableContext(2)]
		public FLiveLinkTextureBlueprintData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602144B RID: 136267 RVA: 0x00310AAC File Offset: 0x0030ECAC
		public FLiveLinkTextureBlueprintData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602144C RID: 136268 RVA: 0x00310AB7 File Offset: 0x0030ECB7
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkTextureBlueprintData(Pointer, false, true);
		}

		// Token: 0x0602144D RID: 136269 RVA: 0x00310AC1 File Offset: 0x0030ECC1
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkTextureBlueprintData(Pointer, MemoryOwner);
		}

		// Token: 0x04011BE4 RID: 72676
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkTextureBlueprintData";

		// Token: 0x04011BE5 RID: 72677
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011BE6 RID: 72678
		internal static int __PropertyOffset_StaticData;

		// Token: 0x04011BE7 RID: 72679
		[Nullable(2)]
		private FLiveLinkTextureStaticData _StaticData;

		// Token: 0x04011BE8 RID: 72680
		internal static int __PropertyOffset_FrameData;

		// Token: 0x04011BE9 RID: 72681
		[Nullable(2)]
		private FLiveLinkTextureFrameData _FrameData;
	}
}
