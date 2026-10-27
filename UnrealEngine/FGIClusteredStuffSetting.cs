using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A9A RID: 6810
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.GIClusteredStuffSetting")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FGIClusteredStuffSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060191E0 RID: 102880 RVA: 0x00251E65 File Offset: 0x00250065
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGIClusteredStuffSetting._ScriptStructPtr != 0) ? FGIClusteredStuffSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.GIClusteredStuffSetting", ref FGIClusteredStuffSetting._ScriptStructPtr);
		}

		// Token: 0x170063C0 RID: 25536
		// (get) Token: 0x060191E1 RID: 102881 RVA: 0x00251E89 File Offset: 0x00250089
		// (set) Token: 0x060191E2 RID: 102882 RVA: 0x00251EA2 File Offset: 0x002500A2
		public unsafe bool bOverride_ClusteredStuffAssets
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIClusteredStuffSetting.__PropertyOffset_bOverride_ClusteredStuffAssets) & FGIClusteredStuffSetting.__PropertyMask_bOverride_ClusteredStuffAssets) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIClusteredStuffSetting.__PropertyOffset_bOverride_ClusteredStuffAssets) = ((*(base.NativePtr + (IntPtr)FGIClusteredStuffSetting.__PropertyOffset_bOverride_ClusteredStuffAssets) & ~FGIClusteredStuffSetting.__PropertyMask_bOverride_ClusteredStuffAssets) | (value ? FGIClusteredStuffSetting.__PropertyMask_bOverride_ClusteredStuffAssets : 0));
			}
		}

		// Token: 0x170063C1 RID: 25537
		// (get) Token: 0x060191E3 RID: 102883 RVA: 0x00251ED2 File Offset: 0x002500D2
		// (set) Token: 0x060191E4 RID: 102884 RVA: 0x00251EE2 File Offset: 0x002500E2
		public unsafe EKuroClusteredStuffBlendMode BlendMode
		{
			get
			{
				return (EKuroClusteredStuffBlendMode)(*(base.NativePtr + (IntPtr)FGIClusteredStuffSetting.__PropertyOffset_BlendMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIClusteredStuffSetting.__PropertyOffset_BlendMode) = (byte)value;
			}
		}

		// Token: 0x170063C2 RID: 25538
		// (get) Token: 0x060191E5 RID: 102885 RVA: 0x00251EF4 File Offset: 0x002500F4
		// (set) Token: 0x060191E6 RID: 102886 RVA: 0x00251F37 File Offset: 0x00250137
		public TArray<UClusteredStuffDataAsset> ClusteredStuffAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UClusteredStuffDataAsset> result;
				if ((result = this._ClusteredStuffAssets) == null)
				{
					result = (this._ClusteredStuffAssets = new TArray<UClusteredStuffDataAsset>(base.NativePtr + (IntPtr)FGIClusteredStuffSetting.__PropertyOffset_ClusteredStuffAssets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ClusteredStuffAssets.CopyAssign(value);
			}
		}

		// Token: 0x170063C3 RID: 25539
		// (get) Token: 0x060191E7 RID: 102887 RVA: 0x00251F45 File Offset: 0x00250145
		// (set) Token: 0x060191E8 RID: 102888 RVA: 0x00251F5E File Offset: 0x0025015E
		public unsafe bool bOverride_AutoGrassEffectData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIClusteredStuffSetting.__PropertyOffset_bOverride_AutoGrassEffectData) & FGIClusteredStuffSetting.__PropertyMask_bOverride_AutoGrassEffectData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIClusteredStuffSetting.__PropertyOffset_bOverride_AutoGrassEffectData) = ((*(base.NativePtr + (IntPtr)FGIClusteredStuffSetting.__PropertyOffset_bOverride_AutoGrassEffectData) & ~FGIClusteredStuffSetting.__PropertyMask_bOverride_AutoGrassEffectData) | (value ? FGIClusteredStuffSetting.__PropertyMask_bOverride_AutoGrassEffectData : 0));
			}
		}

		// Token: 0x170063C4 RID: 25540
		// (get) Token: 0x060191E9 RID: 102889 RVA: 0x00251F8E File Offset: 0x0025018E
		// (set) Token: 0x060191EA RID: 102890 RVA: 0x00251FA7 File Offset: 0x002501A7
		public unsafe bool bOverride_AutoGrassDensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIClusteredStuffSetting.__PropertyOffset_bOverride_AutoGrassDensity) & FGIClusteredStuffSetting.__PropertyMask_bOverride_AutoGrassDensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIClusteredStuffSetting.__PropertyOffset_bOverride_AutoGrassDensity) = ((*(base.NativePtr + (IntPtr)FGIClusteredStuffSetting.__PropertyOffset_bOverride_AutoGrassDensity) & ~FGIClusteredStuffSetting.__PropertyMask_bOverride_AutoGrassDensity) | (value ? FGIClusteredStuffSetting.__PropertyMask_bOverride_AutoGrassDensity : 0));
			}
		}

		// Token: 0x170063C5 RID: 25541
		// (get) Token: 0x060191EB RID: 102891 RVA: 0x00251FD7 File Offset: 0x002501D7
		// (set) Token: 0x060191EC RID: 102892 RVA: 0x00251FEB File Offset: 0x002501EB
		[Nullable(2)]
		public unsafe UClusteredStuffDataAsset AutoGrassEffectData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UClusteredStuffDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FGIClusteredStuffSetting.__PropertyOffset_AutoGrassEffectData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGIClusteredStuffSetting.__PropertyOffset_AutoGrassEffectData, value);
			}
		}

		// Token: 0x170063C6 RID: 25542
		// (get) Token: 0x060191ED RID: 102893 RVA: 0x00252000 File Offset: 0x00250200
		// (set) Token: 0x060191EE RID: 102894 RVA: 0x00252010 File Offset: 0x00250210
		public unsafe float AutoGrassDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIClusteredStuffSetting.__PropertyOffset_AutoGrassDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIClusteredStuffSetting.__PropertyOffset_AutoGrassDensity) = value;
			}
		}

		// Token: 0x060191EF RID: 102895 RVA: 0x00252021 File Offset: 0x00250221
		public FGIClusteredStuffSetting()
		{
		}

		// Token: 0x060191F0 RID: 102896 RVA: 0x00252029 File Offset: 0x00250229
		public FGIClusteredStuffSetting(bool bOverride_ClusteredStuffAssets, EKuroClusteredStuffBlendMode BlendMode, TArray<UClusteredStuffDataAsset> ClusteredStuffAssets, bool bOverride_AutoGrassEffectData, bool bOverride_AutoGrassDensity, UClusteredStuffDataAsset AutoGrassEffectData, float AutoGrassDensity)
		{
			this.bOverride_ClusteredStuffAssets = bOverride_ClusteredStuffAssets;
			this.BlendMode = BlendMode;
			this.ClusteredStuffAssets = ClusteredStuffAssets;
			this.bOverride_AutoGrassEffectData = bOverride_AutoGrassEffectData;
			this.bOverride_AutoGrassDensity = bOverride_AutoGrassDensity;
			this.AutoGrassEffectData = AutoGrassEffectData;
			this.AutoGrassDensity = AutoGrassDensity;
		}

		// Token: 0x060191F1 RID: 102897 RVA: 0x00252066 File Offset: 0x00250266
		protected override IntPtr GetUStructPtr()
		{
			return FGIClusteredStuffSetting.StaticStruct();
		}

		// Token: 0x060191F2 RID: 102898 RVA: 0x00252072 File Offset: 0x00250272
		[NullableContext(2)]
		public FGIClusteredStuffSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060191F3 RID: 102899 RVA: 0x0025207C File Offset: 0x0025027C
		public FGIClusteredStuffSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060191F4 RID: 102900 RVA: 0x00252087 File Offset: 0x00250287
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGIClusteredStuffSetting(Pointer, false, true);
		}

		// Token: 0x060191F5 RID: 102901 RVA: 0x00252091 File Offset: 0x00250291
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGIClusteredStuffSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400DAF9 RID: 56057
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.GIClusteredStuffSetting";

		// Token: 0x0400DAFA RID: 56058
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DAFB RID: 56059
		internal static int __PropertyOffset_bOverride_ClusteredStuffAssets;

		// Token: 0x0400DAFC RID: 56060
		internal static byte __PropertyMask_bOverride_ClusteredStuffAssets;

		// Token: 0x0400DAFD RID: 56061
		internal static int __PropertyOffset_BlendMode;

		// Token: 0x0400DAFE RID: 56062
		internal static int __PropertyOffset_ClusteredStuffAssets;

		// Token: 0x0400DAFF RID: 56063
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClusteredStuffDataAsset> _ClusteredStuffAssets;

		// Token: 0x0400DB00 RID: 56064
		internal static int __PropertyOffset_bOverride_AutoGrassEffectData;

		// Token: 0x0400DB01 RID: 56065
		internal static byte __PropertyMask_bOverride_AutoGrassEffectData;

		// Token: 0x0400DB02 RID: 56066
		internal static int __PropertyOffset_bOverride_AutoGrassDensity;

		// Token: 0x0400DB03 RID: 56067
		internal static byte __PropertyMask_bOverride_AutoGrassDensity;

		// Token: 0x0400DB04 RID: 56068
		internal static int __PropertyOffset_AutoGrassEffectData;

		// Token: 0x0400DB05 RID: 56069
		internal static int __PropertyOffset_AutoGrassDensity;
	}
}
