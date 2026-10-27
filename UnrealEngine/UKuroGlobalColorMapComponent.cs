using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B0D RID: 6925
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalColorMapComponent")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UKuroGlobalColorMapComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019F5A RID: 106330 RVA: 0x00265875 File Offset: 0x00263A75
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGlobalColorMapComponent._ClassPtr;
		}

		// Token: 0x06019F5B RID: 106331 RVA: 0x00265884 File Offset: 0x00263A84
		public UKuroGlobalColorMapComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroGlobalColorMapComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019F5C RID: 106332 RVA: 0x002658AC File Offset: 0x00263AAC
		public UKuroGlobalColorMapComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGlobalColorMapComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006813 RID: 26643
		// (get) Token: 0x06019F5D RID: 106333 RVA: 0x002658DF File Offset: 0x00263ADF
		// (set) Token: 0x06019F5E RID: 106334 RVA: 0x002658F3 File Offset: 0x00263AF3
		[Nullable(2)]
		public unsafe UKuroGlobalColorSplitTextures GlobalColorSplitTextures
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGlobalColorSplitTextures>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGlobalColorMapComponent.__PropertyOffset_GlobalColorSplitTextures);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGlobalColorMapComponent.__PropertyOffset_GlobalColorSplitTextures, value);
			}
		}

		// Token: 0x17006814 RID: 26644
		// (get) Token: 0x06019F5F RID: 106335 RVA: 0x00265908 File Offset: 0x00263B08
		// (set) Token: 0x06019F60 RID: 106336 RVA: 0x0026591D File Offset: 0x00263B1D
		public TSoftObjectPtr<UTexture2D> ColorSplitTexturePlaceHolder
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)UKuroGlobalColorMapComponent.__PropertyOffset_ColorSplitTexturePlaceHolder, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UKuroGlobalColorMapComponent.__PropertyOffset_ColorSplitTexturePlaceHolder, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006815 RID: 26645
		// (get) Token: 0x06019F61 RID: 106337 RVA: 0x00265942 File Offset: 0x00263B42
		// (set) Token: 0x06019F62 RID: 106338 RVA: 0x00265952 File Offset: 0x00263B52
		public unsafe int SizePerCell
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalColorMapComponent.__PropertyOffset_SizePerCell);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalColorMapComponent.__PropertyOffset_SizePerCell) = value;
			}
		}

		// Token: 0x17006816 RID: 26646
		// (get) Token: 0x06019F63 RID: 106339 RVA: 0x00265963 File Offset: 0x00263B63
		// (set) Token: 0x06019F64 RID: 106340 RVA: 0x00265973 File Offset: 0x00263B73
		public unsafe bool bApplySplitColorMapPreviewOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalColorMapComponent.__PropertyOffset_bApplySplitColorMapPreviewOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalColorMapComponent.__PropertyOffset_bApplySplitColorMapPreviewOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006817 RID: 26647
		// (get) Token: 0x06019F65 RID: 106341 RVA: 0x00265984 File Offset: 0x00263B84
		// (set) Token: 0x06019F66 RID: 106342 RVA: 0x00265998 File Offset: 0x00263B98
		public unsafe FVector2D SplitColorMapPreviewOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalColorMapComponent.__PropertyOffset_SplitColorMapPreviewOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalColorMapComponent.__PropertyOffset_SplitColorMapPreviewOffset) = value;
			}
		}

		// Token: 0x17006818 RID: 26648
		// (get) Token: 0x06019F67 RID: 106343 RVA: 0x002659AD File Offset: 0x00263BAD
		// (set) Token: 0x06019F68 RID: 106344 RVA: 0x002659BD File Offset: 0x00263BBD
		public unsafe bool bUseSingleColorMap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalColorMapComponent.__PropertyOffset_bUseSingleColorMap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalColorMapComponent.__PropertyOffset_bUseSingleColorMap) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006819 RID: 26649
		// (get) Token: 0x06019F69 RID: 106345 RVA: 0x002659CE File Offset: 0x00263BCE
		// (set) Token: 0x06019F6A RID: 106346 RVA: 0x002659E2 File Offset: 0x00263BE2
		[Nullable(2)]
		public unsafe UTexture2D SingleColorMap
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGlobalColorMapComponent.__PropertyOffset_SingleColorMap);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGlobalColorMapComponent.__PropertyOffset_SingleColorMap, value);
			}
		}

		// Token: 0x1700681A RID: 26650
		// (get) Token: 0x06019F6B RID: 106347 RVA: 0x002659F7 File Offset: 0x00263BF7
		// (set) Token: 0x06019F6C RID: 106348 RVA: 0x00265A0B File Offset: 0x00263C0B
		public unsafe FVector4 SingleColorMapUVScaleAndBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalColorMapComponent.__PropertyOffset_SingleColorMapUVScaleAndBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalColorMapComponent.__PropertyOffset_SingleColorMapUVScaleAndBias) = value;
			}
		}

		// Token: 0x1700681B RID: 26651
		// (get) Token: 0x06019F6D RID: 106349 RVA: 0x00265A20 File Offset: 0x00263C20
		// (set) Token: 0x06019F6E RID: 106350 RVA: 0x00265A30 File Offset: 0x00263C30
		public unsafe bool bApplySingleColorMapLevelOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalColorMapComponent.__PropertyOffset_bApplySingleColorMapLevelOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalColorMapComponent.__PropertyOffset_bApplySingleColorMapLevelOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700681C RID: 26652
		// (get) Token: 0x06019F6F RID: 106351 RVA: 0x00265A44 File Offset: 0x00263C44
		// (set) Token: 0x06019F70 RID: 106352 RVA: 0x00265A7D File Offset: 0x00263C7D
		public TArray<UTexture2D> ActiveSplitTextures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._ActiveSplitTextures) == null)
				{
					result = (this._ActiveSplitTextures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)UKuroGlobalColorMapComponent.__PropertyOffset_ActiveSplitTextures, this));
				}
				return result;
			}
			set
			{
				this.ActiveSplitTextures.CopyAssign(value);
			}
		}

		// Token: 0x06019F71 RID: 106353 RVA: 0x00265A8B File Offset: 0x00263C8B
		[NullableContext(2)]
		public void UpdateColorMap(UObject WorldContextObject, FVector ViewLocation)
		{
			UKuroGlobalColorMapComponent.__UpdateColorMap_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ViewLocation);
		}

		// Token: 0x06019F72 RID: 106354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateColorMap_Internal(IntPtr @this, IntPtr WorldContextObject, FVector ViewLocation);

		// Token: 0x06019F73 RID: 106355 RVA: 0x00265AA9 File Offset: 0x00263CA9
		static UKuroGlobalColorMapComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalColorMapComponent");
		}

		// Token: 0x06019F74 RID: 106356 RVA: 0x00265AB7 File Offset: 0x00263CB7
		protected UKuroGlobalColorMapComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E1D2 RID: 57810
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalColorMapComponent";

		// Token: 0x0400E1D3 RID: 57811
		private static IntPtr _ClassPtr;

		// Token: 0x0400E1D4 RID: 57812
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E1D5 RID: 57813
		internal static int __PropertyOffset_GlobalColorSplitTextures;

		// Token: 0x0400E1D6 RID: 57814
		internal static int __PropertyOffset_ColorSplitTexturePlaceHolder;

		// Token: 0x0400E1D7 RID: 57815
		internal static int __PropertyOffset_SizePerCell;

		// Token: 0x0400E1D8 RID: 57816
		internal static int __PropertyOffset_bApplySplitColorMapPreviewOffset;

		// Token: 0x0400E1D9 RID: 57817
		internal static int __PropertyOffset_SplitColorMapPreviewOffset;

		// Token: 0x0400E1DA RID: 57818
		internal static int __PropertyOffset_bUseSingleColorMap;

		// Token: 0x0400E1DB RID: 57819
		internal static int __PropertyOffset_SingleColorMap;

		// Token: 0x0400E1DC RID: 57820
		internal static int __PropertyOffset_SingleColorMapUVScaleAndBias;

		// Token: 0x0400E1DD RID: 57821
		internal static int __PropertyOffset_bApplySingleColorMapLevelOffset;

		// Token: 0x0400E1DE RID: 57822
		internal static int __PropertyOffset_ActiveSplitTextures;

		// Token: 0x0400E1DF RID: 57823
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _ActiveSplitTextures;
	}
}
