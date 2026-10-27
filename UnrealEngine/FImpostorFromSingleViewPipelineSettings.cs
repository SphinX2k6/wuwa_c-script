using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027B7 RID: 10167
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.ImpostorFromSingleViewPipelineSettings")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class FImpostorFromSingleViewPipelineSettings : FSimplygonPipelineSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025E6A RID: 155242 RVA: 0x00397580 File Offset: 0x00395780
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FImpostorFromSingleViewPipelineSettings._ScriptStructPtr != 0) ? FImpostorFromSingleViewPipelineSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.ImpostorFromSingleViewPipelineSettings", ref FImpostorFromSingleViewPipelineSettings._ScriptStructPtr);
		}

		// Token: 0x1700921B RID: 37403
		// (get) Token: 0x06025E6B RID: 155243 RVA: 0x003975A4 File Offset: 0x003957A4
		// (set) Token: 0x06025E6C RID: 155244 RVA: 0x003975E7 File Offset: 0x003957E7
		public FImpostorFromSingleViewSettings ImpostorFromSingleViewSettings
		{
			get
			{
				base.FastCheckIsValid();
				FImpostorFromSingleViewSettings result;
				if ((result = this._ImpostorFromSingleViewSettings) == null)
				{
					result = (this._ImpostorFromSingleViewSettings = new FImpostorFromSingleViewSettings(base.NativePtr + (IntPtr)FImpostorFromSingleViewPipelineSettings.__PropertyOffset_ImpostorFromSingleViewSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FImpostorFromSingleViewSettings.StaticStruct(), base.NativePtr + (IntPtr)FImpostorFromSingleViewPipelineSettings.__PropertyOffset_ImpostorFromSingleViewSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700921C RID: 37404
		// (get) Token: 0x06025E6D RID: 155245 RVA: 0x00397608 File Offset: 0x00395808
		// (set) Token: 0x06025E6E RID: 155246 RVA: 0x0039764B File Offset: 0x0039584B
		public FAttributeTessellationSettings AttributeTessellationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAttributeTessellationSettings result;
				if ((result = this._AttributeTessellationSettings) == null)
				{
					result = (this._AttributeTessellationSettings = new FAttributeTessellationSettings(base.NativePtr + (IntPtr)FImpostorFromSingleViewPipelineSettings.__PropertyOffset_AttributeTessellationSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAttributeTessellationSettings.StaticStruct(), base.NativePtr + (IntPtr)FImpostorFromSingleViewPipelineSettings.__PropertyOffset_AttributeTessellationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700921D RID: 37405
		// (get) Token: 0x06025E6F RID: 155247 RVA: 0x0039766C File Offset: 0x0039586C
		// (set) Token: 0x06025E70 RID: 155248 RVA: 0x003976AF File Offset: 0x003958AF
		public FMappingImageSettings MappingImageSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMappingImageSettings result;
				if ((result = this._MappingImageSettings) == null)
				{
					result = (this._MappingImageSettings = new FMappingImageSettings(base.NativePtr + (IntPtr)FImpostorFromSingleViewPipelineSettings.__PropertyOffset_MappingImageSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMappingImageSettings.StaticStruct(), base.NativePtr + (IntPtr)FImpostorFromSingleViewPipelineSettings.__PropertyOffset_MappingImageSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700921E RID: 37406
		// (get) Token: 0x06025E71 RID: 155249 RVA: 0x003976D0 File Offset: 0x003958D0
		// (set) Token: 0x06025E72 RID: 155250 RVA: 0x00397713 File Offset: 0x00395913
		public TArray<USimplygonMaterialCaster> MaterialPropertyCasters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USimplygonMaterialCaster> result;
				if ((result = this._MaterialPropertyCasters) == null)
				{
					result = (this._MaterialPropertyCasters = new TArray<USimplygonMaterialCaster>(base.NativePtr + (IntPtr)FImpostorFromSingleViewPipelineSettings.__PropertyOffset_MaterialPropertyCasters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialPropertyCasters.CopyAssign(value);
			}
		}

		// Token: 0x06025E73 RID: 155251 RVA: 0x00397721 File Offset: 0x00395921
		public FImpostorFromSingleViewPipelineSettings()
		{
		}

		// Token: 0x06025E74 RID: 155252 RVA: 0x00397729 File Offset: 0x00395929
		public FImpostorFromSingleViewPipelineSettings(FImpostorFromSingleViewSettings ImpostorFromSingleViewSettings, FAttributeTessellationSettings AttributeTessellationSettings, FMappingImageSettings MappingImageSettings, TArray<USimplygonMaterialCaster> MaterialPropertyCasters)
		{
			this.ImpostorFromSingleViewSettings = ImpostorFromSingleViewSettings;
			this.AttributeTessellationSettings = AttributeTessellationSettings;
			this.MappingImageSettings = MappingImageSettings;
			this.MaterialPropertyCasters = MaterialPropertyCasters;
		}

		// Token: 0x06025E75 RID: 155253 RVA: 0x0039774E File Offset: 0x0039594E
		protected override IntPtr GetUStructPtr()
		{
			return FImpostorFromSingleViewPipelineSettings.StaticStruct();
		}

		// Token: 0x06025E76 RID: 155254 RVA: 0x0039775A File Offset: 0x0039595A
		[NullableContext(2)]
		public FImpostorFromSingleViewPipelineSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025E77 RID: 155255 RVA: 0x00397764 File Offset: 0x00395964
		public FImpostorFromSingleViewPipelineSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025E78 RID: 155256 RVA: 0x0039776F File Offset: 0x0039596F
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FImpostorFromSingleViewPipelineSettings(Pointer, false, true);
		}

		// Token: 0x06025E79 RID: 155257 RVA: 0x00397779 File Offset: 0x00395979
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FImpostorFromSingleViewPipelineSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014AF7 RID: 84727
		public new const string __ObjectPath = "/Script/SimplygonUObjects.ImpostorFromSingleViewPipelineSettings";

		// Token: 0x04014AF8 RID: 84728
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014AF9 RID: 84729
		internal static int __PropertyOffset_ImpostorFromSingleViewSettings;

		// Token: 0x04014AFA RID: 84730
		[Nullable(2)]
		private FImpostorFromSingleViewSettings _ImpostorFromSingleViewSettings;

		// Token: 0x04014AFB RID: 84731
		internal static int __PropertyOffset_AttributeTessellationSettings;

		// Token: 0x04014AFC RID: 84732
		[Nullable(2)]
		private FAttributeTessellationSettings _AttributeTessellationSettings;

		// Token: 0x04014AFD RID: 84733
		internal static int __PropertyOffset_MappingImageSettings;

		// Token: 0x04014AFE RID: 84734
		[Nullable(2)]
		private FMappingImageSettings _MappingImageSettings;

		// Token: 0x04014AFF RID: 84735
		internal static int __PropertyOffset_MaterialPropertyCasters;

		// Token: 0x04014B00 RID: 84736
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USimplygonMaterialCaster> _MaterialPropertyCasters;
	}
}
