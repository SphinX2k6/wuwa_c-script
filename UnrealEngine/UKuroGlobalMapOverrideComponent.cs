using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B11 RID: 6929
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalMapOverrideComponent")]
	[UnrealStructLayout(384, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class UKuroGlobalMapOverrideComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A0DA RID: 106714 RVA: 0x00267617 File Offset: 0x00265817
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGlobalMapOverrideComponent._ClassPtr;
		}

		// Token: 0x0601A0DB RID: 106715 RVA: 0x00267624 File Offset: 0x00265824
		public UKuroGlobalMapOverrideComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroGlobalMapOverrideComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A0DC RID: 106716 RVA: 0x0026764C File Offset: 0x0026584C
		[NullableContext(1)]
		public UKuroGlobalMapOverrideComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGlobalMapOverrideComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006889 RID: 26761
		// (get) Token: 0x0601A0DD RID: 106717 RVA: 0x0026767F File Offset: 0x0026587F
		// (set) Token: 0x0601A0DE RID: 106718 RVA: 0x0026768F File Offset: 0x0026588F
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700688A RID: 26762
		// (get) Token: 0x0601A0DF RID: 106719 RVA: 0x002676A0 File Offset: 0x002658A0
		// (set) Token: 0x0601A0E0 RID: 106720 RVA: 0x002676B0 File Offset: 0x002658B0
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x1700688B RID: 26763
		// (get) Token: 0x0601A0E1 RID: 106721 RVA: 0x002676C1 File Offset: 0x002658C1
		// (set) Token: 0x0601A0E2 RID: 106722 RVA: 0x002676D1 File Offset: 0x002658D1
		public unsafe bool bOverride_UseSingleColorMap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_UseSingleColorMap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_UseSingleColorMap) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700688C RID: 26764
		// (get) Token: 0x0601A0E3 RID: 106723 RVA: 0x002676E2 File Offset: 0x002658E2
		// (set) Token: 0x0601A0E4 RID: 106724 RVA: 0x002676F2 File Offset: 0x002658F2
		public unsafe bool bUseSingleColorMap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bUseSingleColorMap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bUseSingleColorMap) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700688D RID: 26765
		// (get) Token: 0x0601A0E5 RID: 106725 RVA: 0x00267703 File Offset: 0x00265903
		// (set) Token: 0x0601A0E6 RID: 106726 RVA: 0x00267713 File Offset: 0x00265913
		public unsafe bool bOverride_SingleColorMap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_SingleColorMap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_SingleColorMap) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700688E RID: 26766
		// (get) Token: 0x0601A0E7 RID: 106727 RVA: 0x00267724 File Offset: 0x00265924
		// (set) Token: 0x0601A0E8 RID: 106728 RVA: 0x00267738 File Offset: 0x00265938
		public unsafe UTexture2D SingleColorMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGlobalMapOverrideComponent.__PropertyOffset_SingleColorMap);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGlobalMapOverrideComponent.__PropertyOffset_SingleColorMap, value);
			}
		}

		// Token: 0x1700688F RID: 26767
		// (get) Token: 0x0601A0E9 RID: 106729 RVA: 0x0026774D File Offset: 0x0026594D
		// (set) Token: 0x0601A0EA RID: 106730 RVA: 0x0026775D File Offset: 0x0026595D
		public unsafe bool bOverride_SingleColorMapUVScaleAndBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_SingleColorMapUVScaleAndBias) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_SingleColorMapUVScaleAndBias) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006890 RID: 26768
		// (get) Token: 0x0601A0EB RID: 106731 RVA: 0x0026776E File Offset: 0x0026596E
		// (set) Token: 0x0601A0EC RID: 106732 RVA: 0x00267782 File Offset: 0x00265982
		public unsafe FVector4 SingleColorMapUVScaleAndBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_SingleColorMapUVScaleAndBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_SingleColorMapUVScaleAndBias) = value;
			}
		}

		// Token: 0x17006891 RID: 26769
		// (get) Token: 0x0601A0ED RID: 106733 RVA: 0x00267797 File Offset: 0x00265997
		// (set) Token: 0x0601A0EE RID: 106734 RVA: 0x002677A7 File Offset: 0x002659A7
		public unsafe bool bOverride_ApplySingleColorMapLevelOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_ApplySingleColorMapLevelOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_ApplySingleColorMapLevelOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006892 RID: 26770
		// (get) Token: 0x0601A0EF RID: 106735 RVA: 0x002677B8 File Offset: 0x002659B8
		// (set) Token: 0x0601A0F0 RID: 106736 RVA: 0x002677C8 File Offset: 0x002659C8
		public unsafe bool bApplySingleColorMapLevelOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bApplySingleColorMapLevelOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bApplySingleColorMapLevelOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006893 RID: 26771
		// (get) Token: 0x0601A0F1 RID: 106737 RVA: 0x002677D9 File Offset: 0x002659D9
		// (set) Token: 0x0601A0F2 RID: 106738 RVA: 0x002677E9 File Offset: 0x002659E9
		public unsafe bool bOverride_GlobalColorSplitTextures
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_GlobalColorSplitTextures) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_GlobalColorSplitTextures) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006894 RID: 26772
		// (get) Token: 0x0601A0F3 RID: 106739 RVA: 0x002677FA File Offset: 0x002659FA
		// (set) Token: 0x0601A0F4 RID: 106740 RVA: 0x0026780E File Offset: 0x00265A0E
		public unsafe UKuroGlobalColorSplitTextures GlobalColorSplitTextures
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGlobalColorSplitTextures>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGlobalMapOverrideComponent.__PropertyOffset_GlobalColorSplitTextures);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGlobalMapOverrideComponent.__PropertyOffset_GlobalColorSplitTextures, value);
			}
		}

		// Token: 0x17006895 RID: 26773
		// (get) Token: 0x0601A0F5 RID: 106741 RVA: 0x00267823 File Offset: 0x00265A23
		// (set) Token: 0x0601A0F6 RID: 106742 RVA: 0x00267833 File Offset: 0x00265A33
		public unsafe bool bOverride_ColorSplitTexturePlaceHolder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_ColorSplitTexturePlaceHolder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_ColorSplitTexturePlaceHolder) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006896 RID: 26774
		// (get) Token: 0x0601A0F7 RID: 106743 RVA: 0x00267844 File Offset: 0x00265A44
		// (set) Token: 0x0601A0F8 RID: 106744 RVA: 0x00267859 File Offset: 0x00265A59
		[Nullable(1)]
		public TSoftObjectPtr<UTexture2D> ColorSplitTexturePlaceHolder
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_ColorSplitTexturePlaceHolder, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_ColorSplitTexturePlaceHolder, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006897 RID: 26775
		// (get) Token: 0x0601A0F9 RID: 106745 RVA: 0x0026787E File Offset: 0x00265A7E
		// (set) Token: 0x0601A0FA RID: 106746 RVA: 0x0026788E File Offset: 0x00265A8E
		public unsafe bool bOverride_SizePerCell
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_SizePerCell) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_SizePerCell) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006898 RID: 26776
		// (get) Token: 0x0601A0FB RID: 106747 RVA: 0x0026789F File Offset: 0x00265A9F
		// (set) Token: 0x0601A0FC RID: 106748 RVA: 0x002678AF File Offset: 0x00265AAF
		public unsafe int SizePerCell
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_SizePerCell);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_SizePerCell) = value;
			}
		}

		// Token: 0x17006899 RID: 26777
		// (get) Token: 0x0601A0FD RID: 106749 RVA: 0x002678C0 File Offset: 0x00265AC0
		// (set) Token: 0x0601A0FE RID: 106750 RVA: 0x002678D0 File Offset: 0x00265AD0
		public unsafe bool bOverride_HeightMapSettings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_HeightMapSettings) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_HeightMapSettings) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700689A RID: 26778
		// (get) Token: 0x0601A0FF RID: 106751 RVA: 0x002678E1 File Offset: 0x00265AE1
		// (set) Token: 0x0601A100 RID: 106752 RVA: 0x002678F5 File Offset: 0x00265AF5
		public unsafe UKuroHeightMapSettings HeightMapSettings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroHeightMapSettings>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGlobalMapOverrideComponent.__PropertyOffset_HeightMapSettings);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGlobalMapOverrideComponent.__PropertyOffset_HeightMapSettings, value);
			}
		}

		// Token: 0x1700689B RID: 26779
		// (get) Token: 0x0601A101 RID: 106753 RVA: 0x0026790A File Offset: 0x00265B0A
		// (set) Token: 0x0601A102 RID: 106754 RVA: 0x0026791A File Offset: 0x00265B1A
		public unsafe bool bOverride_LoadNumPerSidePc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_LoadNumPerSidePc) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_LoadNumPerSidePc) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700689C RID: 26780
		// (get) Token: 0x0601A103 RID: 106755 RVA: 0x0026792B File Offset: 0x00265B2B
		// (set) Token: 0x0601A104 RID: 106756 RVA: 0x0026793B File Offset: 0x00265B3B
		public unsafe int LoadNumPerSidePc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_LoadNumPerSidePc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_LoadNumPerSidePc) = value;
			}
		}

		// Token: 0x1700689D RID: 26781
		// (get) Token: 0x0601A105 RID: 106757 RVA: 0x0026794C File Offset: 0x00265B4C
		// (set) Token: 0x0601A106 RID: 106758 RVA: 0x0026795C File Offset: 0x00265B5C
		public unsafe bool bOverride_LoadNumPerSideMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_LoadNumPerSideMobile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_LoadNumPerSideMobile) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700689E RID: 26782
		// (get) Token: 0x0601A107 RID: 106759 RVA: 0x0026796D File Offset: 0x00265B6D
		// (set) Token: 0x0601A108 RID: 106760 RVA: 0x0026797D File Offset: 0x00265B7D
		public unsafe int LoadNumPerSideMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_LoadNumPerSideMobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_LoadNumPerSideMobile) = value;
			}
		}

		// Token: 0x1700689F RID: 26783
		// (get) Token: 0x0601A109 RID: 106761 RVA: 0x0026798E File Offset: 0x00265B8E
		// (set) Token: 0x0601A10A RID: 106762 RVA: 0x0026799E File Offset: 0x00265B9E
		public unsafe bool bOverride_EnableHeightOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_EnableHeightOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_EnableHeightOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068A0 RID: 26784
		// (get) Token: 0x0601A10B RID: 106763 RVA: 0x002679AF File Offset: 0x00265BAF
		// (set) Token: 0x0601A10C RID: 106764 RVA: 0x002679BF File Offset: 0x00265BBF
		public unsafe bool EnableHeightOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_EnableHeightOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_EnableHeightOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068A1 RID: 26785
		// (get) Token: 0x0601A10D RID: 106765 RVA: 0x002679D0 File Offset: 0x00265BD0
		// (set) Token: 0x0601A10E RID: 106766 RVA: 0x002679E0 File Offset: 0x00265BE0
		public unsafe bool bOverride_HeightOverrideValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_HeightOverrideValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_bOverride_HeightOverrideValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068A2 RID: 26786
		// (get) Token: 0x0601A10F RID: 106767 RVA: 0x002679F1 File Offset: 0x00265BF1
		// (set) Token: 0x0601A110 RID: 106768 RVA: 0x00267A01 File Offset: 0x00265C01
		public unsafe float HeightOverrideValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_HeightOverrideValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalMapOverrideComponent.__PropertyOffset_HeightOverrideValue) = value;
			}
		}

		// Token: 0x0601A111 RID: 106769 RVA: 0x00267A12 File Offset: 0x00265C12
		public void SetPriority(int NewPriority)
		{
			UKuroGlobalMapOverrideComponent.__SetPriority_Internal(base.NativePtr, NewPriority);
		}

		// Token: 0x0601A112 RID: 106770 RVA: 0x00267A20 File Offset: 0x00265C20
		public void SetEnabled(bool bNewEnabled)
		{
			UKuroGlobalMapOverrideComponent.__SetEnabled_Internal(base.NativePtr, bNewEnabled);
		}

		// Token: 0x0601A113 RID: 106771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPriority_Internal(IntPtr @this, int NewPriority);

		// Token: 0x0601A114 RID: 106772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnabled_Internal(IntPtr @this, bool bNewEnabled);

		// Token: 0x0601A115 RID: 106773 RVA: 0x00267A2E File Offset: 0x00265C2E
		static UKuroGlobalMapOverrideComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalMapOverrideComponent");
		}

		// Token: 0x0601A116 RID: 106774 RVA: 0x00267A3C File Offset: 0x00265C3C
		protected UKuroGlobalMapOverrideComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E262 RID: 57954
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalMapOverrideComponent";

		// Token: 0x0400E263 RID: 57955
		private static IntPtr _ClassPtr;

		// Token: 0x0400E264 RID: 57956
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E265 RID: 57957
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x0400E266 RID: 57958
		internal static int __PropertyOffset_Priority;

		// Token: 0x0400E267 RID: 57959
		internal static int __PropertyOffset_bOverride_UseSingleColorMap;

		// Token: 0x0400E268 RID: 57960
		internal static int __PropertyOffset_bUseSingleColorMap;

		// Token: 0x0400E269 RID: 57961
		internal static int __PropertyOffset_bOverride_SingleColorMap;

		// Token: 0x0400E26A RID: 57962
		internal static int __PropertyOffset_SingleColorMap;

		// Token: 0x0400E26B RID: 57963
		internal static int __PropertyOffset_bOverride_SingleColorMapUVScaleAndBias;

		// Token: 0x0400E26C RID: 57964
		internal static int __PropertyOffset_SingleColorMapUVScaleAndBias;

		// Token: 0x0400E26D RID: 57965
		internal static int __PropertyOffset_bOverride_ApplySingleColorMapLevelOffset;

		// Token: 0x0400E26E RID: 57966
		internal static int __PropertyOffset_bApplySingleColorMapLevelOffset;

		// Token: 0x0400E26F RID: 57967
		internal static int __PropertyOffset_bOverride_GlobalColorSplitTextures;

		// Token: 0x0400E270 RID: 57968
		internal static int __PropertyOffset_GlobalColorSplitTextures;

		// Token: 0x0400E271 RID: 57969
		internal static int __PropertyOffset_bOverride_ColorSplitTexturePlaceHolder;

		// Token: 0x0400E272 RID: 57970
		internal static int __PropertyOffset_ColorSplitTexturePlaceHolder;

		// Token: 0x0400E273 RID: 57971
		internal static int __PropertyOffset_bOverride_SizePerCell;

		// Token: 0x0400E274 RID: 57972
		internal static int __PropertyOffset_SizePerCell;

		// Token: 0x0400E275 RID: 57973
		internal static int __PropertyOffset_bOverride_HeightMapSettings;

		// Token: 0x0400E276 RID: 57974
		internal static int __PropertyOffset_HeightMapSettings;

		// Token: 0x0400E277 RID: 57975
		internal static int __PropertyOffset_bOverride_LoadNumPerSidePc;

		// Token: 0x0400E278 RID: 57976
		internal static int __PropertyOffset_LoadNumPerSidePc;

		// Token: 0x0400E279 RID: 57977
		internal static int __PropertyOffset_bOverride_LoadNumPerSideMobile;

		// Token: 0x0400E27A RID: 57978
		internal static int __PropertyOffset_LoadNumPerSideMobile;

		// Token: 0x0400E27B RID: 57979
		internal static int __PropertyOffset_bOverride_EnableHeightOverride;

		// Token: 0x0400E27C RID: 57980
		internal static int __PropertyOffset_EnableHeightOverride;

		// Token: 0x0400E27D RID: 57981
		internal static int __PropertyOffset_bOverride_HeightOverrideValue;

		// Token: 0x0400E27E RID: 57982
		internal static int __PropertyOffset_HeightOverrideValue;
	}
}
