using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027CF RID: 10191
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.RemeshingPipelineSettings")]
	[UnrealStructLayout(560, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 560)]
	public class FRemeshingPipelineSettings : FSimplygonPipelineSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602602C RID: 155692 RVA: 0x0039A4ED File Offset: 0x003986ED
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRemeshingPipelineSettings._ScriptStructPtr != 0) ? FRemeshingPipelineSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.RemeshingPipelineSettings", ref FRemeshingPipelineSettings._ScriptStructPtr);
		}

		// Token: 0x170092AB RID: 37547
		// (get) Token: 0x0602602D RID: 155693 RVA: 0x0039A514 File Offset: 0x00398714
		// (set) Token: 0x0602602E RID: 155694 RVA: 0x0039A557 File Offset: 0x00398757
		public FRemeshingSettings RemeshingSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRemeshingSettings result;
				if ((result = this._RemeshingSettings) == null)
				{
					result = (this._RemeshingSettings = new FRemeshingSettings(base.NativePtr + (IntPtr)FRemeshingPipelineSettings.__PropertyOffset_RemeshingSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRemeshingSettings.StaticStruct(), base.NativePtr + (IntPtr)FRemeshingPipelineSettings.__PropertyOffset_RemeshingSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170092AC RID: 37548
		// (get) Token: 0x0602602F RID: 155695 RVA: 0x0039A578 File Offset: 0x00398778
		// (set) Token: 0x06026030 RID: 155696 RVA: 0x0039A5BB File Offset: 0x003987BB
		public FBoneSettings BoneSettings
		{
			get
			{
				base.FastCheckIsValid();
				FBoneSettings result;
				if ((result = this._BoneSettings) == null)
				{
					result = (this._BoneSettings = new FBoneSettings(base.NativePtr + (IntPtr)FRemeshingPipelineSettings.__PropertyOffset_BoneSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneSettings.StaticStruct(), base.NativePtr + (IntPtr)FRemeshingPipelineSettings.__PropertyOffset_BoneSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170092AD RID: 37549
		// (get) Token: 0x06026031 RID: 155697 RVA: 0x0039A5DC File Offset: 0x003987DC
		// (set) Token: 0x06026032 RID: 155698 RVA: 0x0039A61F File Offset: 0x0039881F
		public FGeometryCullingSettings GeometryCullingSettings
		{
			get
			{
				base.FastCheckIsValid();
				FGeometryCullingSettings result;
				if ((result = this._GeometryCullingSettings) == null)
				{
					result = (this._GeometryCullingSettings = new FGeometryCullingSettings(base.NativePtr + (IntPtr)FRemeshingPipelineSettings.__PropertyOffset_GeometryCullingSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometryCullingSettings.StaticStruct(), base.NativePtr + (IntPtr)FRemeshingPipelineSettings.__PropertyOffset_GeometryCullingSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170092AE RID: 37550
		// (get) Token: 0x06026033 RID: 155699 RVA: 0x0039A640 File Offset: 0x00398840
		// (set) Token: 0x06026034 RID: 155700 RVA: 0x0039A683 File Offset: 0x00398883
		public FVisibilitySettings VisibilitySettings
		{
			get
			{
				base.FastCheckIsValid();
				FVisibilitySettings result;
				if ((result = this._VisibilitySettings) == null)
				{
					result = (this._VisibilitySettings = new FVisibilitySettings(base.NativePtr + (IntPtr)FRemeshingPipelineSettings.__PropertyOffset_VisibilitySettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVisibilitySettings.StaticStruct(), base.NativePtr + (IntPtr)FRemeshingPipelineSettings.__PropertyOffset_VisibilitySettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170092AF RID: 37551
		// (get) Token: 0x06026035 RID: 155701 RVA: 0x0039A6A4 File Offset: 0x003988A4
		// (set) Token: 0x06026036 RID: 155702 RVA: 0x0039A6E7 File Offset: 0x003988E7
		public FAttributeTessellationSettings AttributeTessellationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAttributeTessellationSettings result;
				if ((result = this._AttributeTessellationSettings) == null)
				{
					result = (this._AttributeTessellationSettings = new FAttributeTessellationSettings(base.NativePtr + (IntPtr)FRemeshingPipelineSettings.__PropertyOffset_AttributeTessellationSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAttributeTessellationSettings.StaticStruct(), base.NativePtr + (IntPtr)FRemeshingPipelineSettings.__PropertyOffset_AttributeTessellationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170092B0 RID: 37552
		// (get) Token: 0x06026037 RID: 155703 RVA: 0x0039A708 File Offset: 0x00398908
		// (set) Token: 0x06026038 RID: 155704 RVA: 0x0039A74B File Offset: 0x0039894B
		public FMappingImageSettings MappingImageSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMappingImageSettings result;
				if ((result = this._MappingImageSettings) == null)
				{
					result = (this._MappingImageSettings = new FMappingImageSettings(base.NativePtr + (IntPtr)FRemeshingPipelineSettings.__PropertyOffset_MappingImageSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMappingImageSettings.StaticStruct(), base.NativePtr + (IntPtr)FRemeshingPipelineSettings.__PropertyOffset_MappingImageSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170092B1 RID: 37553
		// (get) Token: 0x06026039 RID: 155705 RVA: 0x0039A76C File Offset: 0x0039896C
		// (set) Token: 0x0602603A RID: 155706 RVA: 0x0039A7AF File Offset: 0x003989AF
		public TArray<USimplygonMaterialCaster> MaterialPropertyCasters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USimplygonMaterialCaster> result;
				if ((result = this._MaterialPropertyCasters) == null)
				{
					result = (this._MaterialPropertyCasters = new TArray<USimplygonMaterialCaster>(base.NativePtr + (IntPtr)FRemeshingPipelineSettings.__PropertyOffset_MaterialPropertyCasters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialPropertyCasters.CopyAssign(value);
			}
		}

		// Token: 0x0602603B RID: 155707 RVA: 0x0039A7BD File Offset: 0x003989BD
		public FRemeshingPipelineSettings()
		{
		}

		// Token: 0x0602603C RID: 155708 RVA: 0x0039A7C5 File Offset: 0x003989C5
		public FRemeshingPipelineSettings(FRemeshingSettings RemeshingSettings, FBoneSettings BoneSettings, FGeometryCullingSettings GeometryCullingSettings, FVisibilitySettings VisibilitySettings, FAttributeTessellationSettings AttributeTessellationSettings, FMappingImageSettings MappingImageSettings, TArray<USimplygonMaterialCaster> MaterialPropertyCasters)
		{
			this.RemeshingSettings = RemeshingSettings;
			this.BoneSettings = BoneSettings;
			this.GeometryCullingSettings = GeometryCullingSettings;
			this.VisibilitySettings = VisibilitySettings;
			this.AttributeTessellationSettings = AttributeTessellationSettings;
			this.MappingImageSettings = MappingImageSettings;
			this.MaterialPropertyCasters = MaterialPropertyCasters;
		}

		// Token: 0x0602603D RID: 155709 RVA: 0x0039A802 File Offset: 0x00398A02
		protected override IntPtr GetUStructPtr()
		{
			return FRemeshingPipelineSettings.StaticStruct();
		}

		// Token: 0x0602603E RID: 155710 RVA: 0x0039A80E File Offset: 0x00398A0E
		[NullableContext(2)]
		public FRemeshingPipelineSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602603F RID: 155711 RVA: 0x0039A818 File Offset: 0x00398A18
		public FRemeshingPipelineSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026040 RID: 155712 RVA: 0x0039A823 File Offset: 0x00398A23
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRemeshingPipelineSettings(Pointer, false, true);
		}

		// Token: 0x06026041 RID: 155713 RVA: 0x0039A82D File Offset: 0x00398A2D
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRemeshingPipelineSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014C09 RID: 85001
		public new const string __ObjectPath = "/Script/SimplygonUObjects.RemeshingPipelineSettings";

		// Token: 0x04014C0A RID: 85002
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014C0B RID: 85003
		internal static int __PropertyOffset_RemeshingSettings;

		// Token: 0x04014C0C RID: 85004
		[Nullable(2)]
		private FRemeshingSettings _RemeshingSettings;

		// Token: 0x04014C0D RID: 85005
		internal static int __PropertyOffset_BoneSettings;

		// Token: 0x04014C0E RID: 85006
		[Nullable(2)]
		private FBoneSettings _BoneSettings;

		// Token: 0x04014C0F RID: 85007
		internal static int __PropertyOffset_GeometryCullingSettings;

		// Token: 0x04014C10 RID: 85008
		[Nullable(2)]
		private FGeometryCullingSettings _GeometryCullingSettings;

		// Token: 0x04014C11 RID: 85009
		internal static int __PropertyOffset_VisibilitySettings;

		// Token: 0x04014C12 RID: 85010
		[Nullable(2)]
		private FVisibilitySettings _VisibilitySettings;

		// Token: 0x04014C13 RID: 85011
		internal static int __PropertyOffset_AttributeTessellationSettings;

		// Token: 0x04014C14 RID: 85012
		[Nullable(2)]
		private FAttributeTessellationSettings _AttributeTessellationSettings;

		// Token: 0x04014C15 RID: 85013
		internal static int __PropertyOffset_MappingImageSettings;

		// Token: 0x04014C16 RID: 85014
		[Nullable(2)]
		private FMappingImageSettings _MappingImageSettings;

		// Token: 0x04014C17 RID: 85015
		internal static int __PropertyOffset_MaterialPropertyCasters;

		// Token: 0x04014C18 RID: 85016
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USimplygonMaterialCaster> _MaterialPropertyCasters;
	}
}
