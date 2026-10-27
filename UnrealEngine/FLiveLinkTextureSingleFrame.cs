using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002222 RID: 8738
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkTextureSingleFrame")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FLiveLinkTextureSingleFrame : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021479 RID: 136313 RVA: 0x00310EB6 File Offset: 0x0030F0B6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkTextureSingleFrame._ScriptStructPtr != 0) ? FLiveLinkTextureSingleFrame._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkTextureSingleFrame", ref FLiveLinkTextureSingleFrame._ScriptStructPtr);
		}

		// Token: 0x170081EA RID: 33258
		// (get) Token: 0x0602147A RID: 136314 RVA: 0x00310EDC File Offset: 0x0030F0DC
		// (set) Token: 0x0602147B RID: 136315 RVA: 0x00310F1F File Offset: 0x0030F11F
		public TArray<FVector> PositionData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PositionData) == null)
				{
					result = (this._PositionData = new TArray<FVector>(base.NativePtr + (IntPtr)FLiveLinkTextureSingleFrame.__PropertyOffset_PositionData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PositionData.CopyAssign(value);
			}
		}

		// Token: 0x0602147C RID: 136316 RVA: 0x00310F2D File Offset: 0x0030F12D
		public FLiveLinkTextureSingleFrame()
		{
		}

		// Token: 0x0602147D RID: 136317 RVA: 0x00310F35 File Offset: 0x0030F135
		public FLiveLinkTextureSingleFrame(TArray<FVector> PositionData)
		{
			this.PositionData = PositionData;
		}

		// Token: 0x0602147E RID: 136318 RVA: 0x00310F44 File Offset: 0x0030F144
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkTextureSingleFrame.StaticStruct();
		}

		// Token: 0x0602147F RID: 136319 RVA: 0x00310F50 File Offset: 0x0030F150
		[NullableContext(2)]
		public FLiveLinkTextureSingleFrame(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021480 RID: 136320 RVA: 0x00310F5A File Offset: 0x0030F15A
		public FLiveLinkTextureSingleFrame(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021481 RID: 136321 RVA: 0x00310F65 File Offset: 0x0030F165
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkTextureSingleFrame(Pointer, false, true);
		}

		// Token: 0x06021482 RID: 136322 RVA: 0x00310F6F File Offset: 0x0030F16F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkTextureSingleFrame(Pointer, MemoryOwner);
		}

		// Token: 0x04011C00 RID: 72704
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkTextureSingleFrame";

		// Token: 0x04011C01 RID: 72705
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011C02 RID: 72706
		internal static int __PropertyOffset_PositionData;

		// Token: 0x04011C03 RID: 72707
		[Nullable(2)]
		private TArray<FVector> _PositionData;
	}
}
