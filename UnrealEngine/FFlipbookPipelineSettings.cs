using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027AE RID: 10158
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.FlipbookPipelineSettings")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 296)]
	public class FFlipbookPipelineSettings : FSimplygonPipelineSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025DA5 RID: 155045 RVA: 0x00396395 File Offset: 0x00394595
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFlipbookPipelineSettings._ScriptStructPtr != 0) ? FFlipbookPipelineSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.FlipbookPipelineSettings", ref FFlipbookPipelineSettings._ScriptStructPtr);
		}

		// Token: 0x170091DB RID: 37339
		// (get) Token: 0x06025DA6 RID: 155046 RVA: 0x003963BC File Offset: 0x003945BC
		// (set) Token: 0x06025DA7 RID: 155047 RVA: 0x003963FF File Offset: 0x003945FF
		public FFlipbookSettings FlipbookSettings
		{
			get
			{
				base.FastCheckIsValid();
				FFlipbookSettings result;
				if ((result = this._FlipbookSettings) == null)
				{
					result = (this._FlipbookSettings = new FFlipbookSettings(base.NativePtr + (IntPtr)FFlipbookPipelineSettings.__PropertyOffset_FlipbookSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFlipbookSettings.StaticStruct(), base.NativePtr + (IntPtr)FFlipbookPipelineSettings.__PropertyOffset_FlipbookSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170091DC RID: 37340
		// (get) Token: 0x06025DA8 RID: 155048 RVA: 0x00396420 File Offset: 0x00394620
		// (set) Token: 0x06025DA9 RID: 155049 RVA: 0x00396463 File Offset: 0x00394663
		public FAttributeTessellationSettings AttributeTessellationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAttributeTessellationSettings result;
				if ((result = this._AttributeTessellationSettings) == null)
				{
					result = (this._AttributeTessellationSettings = new FAttributeTessellationSettings(base.NativePtr + (IntPtr)FFlipbookPipelineSettings.__PropertyOffset_AttributeTessellationSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAttributeTessellationSettings.StaticStruct(), base.NativePtr + (IntPtr)FFlipbookPipelineSettings.__PropertyOffset_AttributeTessellationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170091DD RID: 37341
		// (get) Token: 0x06025DAA RID: 155050 RVA: 0x00396484 File Offset: 0x00394684
		// (set) Token: 0x06025DAB RID: 155051 RVA: 0x003964C7 File Offset: 0x003946C7
		public FMappingImageSettings MappingImageSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMappingImageSettings result;
				if ((result = this._MappingImageSettings) == null)
				{
					result = (this._MappingImageSettings = new FMappingImageSettings(base.NativePtr + (IntPtr)FFlipbookPipelineSettings.__PropertyOffset_MappingImageSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMappingImageSettings.StaticStruct(), base.NativePtr + (IntPtr)FFlipbookPipelineSettings.__PropertyOffset_MappingImageSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170091DE RID: 37342
		// (get) Token: 0x06025DAC RID: 155052 RVA: 0x003964E8 File Offset: 0x003946E8
		// (set) Token: 0x06025DAD RID: 155053 RVA: 0x0039652B File Offset: 0x0039472B
		public TArray<USimplygonMaterialCaster> MaterialPropertyCasters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USimplygonMaterialCaster> result;
				if ((result = this._MaterialPropertyCasters) == null)
				{
					result = (this._MaterialPropertyCasters = new TArray<USimplygonMaterialCaster>(base.NativePtr + (IntPtr)FFlipbookPipelineSettings.__PropertyOffset_MaterialPropertyCasters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialPropertyCasters.CopyAssign(value);
			}
		}

		// Token: 0x06025DAE RID: 155054 RVA: 0x00396539 File Offset: 0x00394739
		public FFlipbookPipelineSettings()
		{
		}

		// Token: 0x06025DAF RID: 155055 RVA: 0x00396541 File Offset: 0x00394741
		public FFlipbookPipelineSettings(FFlipbookSettings FlipbookSettings, FAttributeTessellationSettings AttributeTessellationSettings, FMappingImageSettings MappingImageSettings, TArray<USimplygonMaterialCaster> MaterialPropertyCasters)
		{
			this.FlipbookSettings = FlipbookSettings;
			this.AttributeTessellationSettings = AttributeTessellationSettings;
			this.MappingImageSettings = MappingImageSettings;
			this.MaterialPropertyCasters = MaterialPropertyCasters;
		}

		// Token: 0x06025DB0 RID: 155056 RVA: 0x00396566 File Offset: 0x00394766
		protected override IntPtr GetUStructPtr()
		{
			return FFlipbookPipelineSettings.StaticStruct();
		}

		// Token: 0x06025DB1 RID: 155057 RVA: 0x00396572 File Offset: 0x00394772
		[NullableContext(2)]
		public FFlipbookPipelineSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025DB2 RID: 155058 RVA: 0x0039657C File Offset: 0x0039477C
		public FFlipbookPipelineSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025DB3 RID: 155059 RVA: 0x00396587 File Offset: 0x00394787
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFlipbookPipelineSettings(Pointer, false, true);
		}

		// Token: 0x06025DB4 RID: 155060 RVA: 0x00396591 File Offset: 0x00394791
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFlipbookPipelineSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014A91 RID: 84625
		public new const string __ObjectPath = "/Script/SimplygonUObjects.FlipbookPipelineSettings";

		// Token: 0x04014A92 RID: 84626
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014A93 RID: 84627
		internal static int __PropertyOffset_FlipbookSettings;

		// Token: 0x04014A94 RID: 84628
		[Nullable(2)]
		private FFlipbookSettings _FlipbookSettings;

		// Token: 0x04014A95 RID: 84629
		internal static int __PropertyOffset_AttributeTessellationSettings;

		// Token: 0x04014A96 RID: 84630
		[Nullable(2)]
		private FAttributeTessellationSettings _AttributeTessellationSettings;

		// Token: 0x04014A97 RID: 84631
		internal static int __PropertyOffset_MappingImageSettings;

		// Token: 0x04014A98 RID: 84632
		[Nullable(2)]
		private FMappingImageSettings _MappingImageSettings;

		// Token: 0x04014A99 RID: 84633
		internal static int __PropertyOffset_MaterialPropertyCasters;

		// Token: 0x04014A9A RID: 84634
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USimplygonMaterialCaster> _MaterialPropertyCasters;
	}
}
