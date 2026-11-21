using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006ED RID: 1773
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIBatchGeometryRenderable")]
	[UnrealStructLayout(2192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2192)]
	public abstract class UUIBatchGeometryRenderable : UUIBaseRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009671 RID: 38513 RVA: 0x000E2F41 File Offset: 0x000E1141
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIBatchGeometryRenderable._ClassPtr;
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06009672 RID: 38514 RVA: 0x000E2F50 File Offset: 0x000E1150
		// (set) Token: 0x06009673 RID: 38515 RVA: 0x000E2F89 File Offset: 0x000E1189
		[Nullable(1)]
		public TMap<FName, float> CustomScalarParameterTMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._CustomScalarParameterTMap) == null)
				{
					result = (this._CustomScalarParameterTMap = new TMap<FName, float>(base.NativePtr + (IntPtr)UUIBatchGeometryRenderable.__PropertyOffset_CustomScalarParameterTMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomScalarParameterTMap.CopyAssign(value);
			}
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06009674 RID: 38516 RVA: 0x000E2F98 File Offset: 0x000E1198
		// (set) Token: 0x06009675 RID: 38517 RVA: 0x000E2FD1 File Offset: 0x000E11D1
		[Nullable(1)]
		public TMap<FName, UTexture> CustomTextureParameterTMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._CustomTextureParameterTMap) == null)
				{
					result = (this._CustomTextureParameterTMap = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)UUIBatchGeometryRenderable.__PropertyOffset_CustomTextureParameterTMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomTextureParameterTMap.CopyAssign(value);
			}
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x06009676 RID: 38518 RVA: 0x000E2FE0 File Offset: 0x000E11E0
		// (set) Token: 0x06009677 RID: 38519 RVA: 0x000E3019 File Offset: 0x000E1219
		[Nullable(1)]
		public TMap<FName, FLinearColor> CustomVectorParameterTMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._CustomVectorParameterTMap) == null)
				{
					result = (this._CustomVectorParameterTMap = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)UUIBatchGeometryRenderable.__PropertyOffset_CustomVectorParameterTMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomVectorParameterTMap.CopyAssign(value);
			}
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06009678 RID: 38520 RVA: 0x000E3027 File Offset: 0x000E1227
		// (set) Token: 0x06009679 RID: 38521 RVA: 0x000E303B File Offset: 0x000E123B
		public unsafe UMaterialInterface CustomUIMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UUIBatchGeometryRenderable.__PropertyOffset_CustomUIMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIBatchGeometryRenderable.__PropertyOffset_CustomUIMaterial, value);
			}
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x0600967A RID: 38522 RVA: 0x000E3050 File Offset: 0x000E1250
		// (set) Token: 0x0600967B RID: 38523 RVA: 0x000E3060 File Offset: 0x000E1260
		public unsafe bool bIsSelfRender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIBatchGeometryRenderable.__PropertyOffset_bIsSelfRender) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIBatchGeometryRenderable.__PropertyOffset_bIsSelfRender) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x0600967C RID: 38524 RVA: 0x000E3071 File Offset: 0x000E1271
		// (set) Token: 0x0600967D RID: 38525 RVA: 0x000E3081 File Offset: 0x000E1281
		public unsafe bool bIsGray
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIBatchGeometryRenderable.__PropertyOffset_bIsGray) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIBatchGeometryRenderable.__PropertyOffset_bIsGray) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x0600967E RID: 38526 RVA: 0x000E3092 File Offset: 0x000E1292
		// (set) Token: 0x0600967F RID: 38527 RVA: 0x000E30A2 File Offset: 0x000E12A2
		public unsafe bool bIsColorRevert
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIBatchGeometryRenderable.__PropertyOffset_bIsColorRevert) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIBatchGeometryRenderable.__PropertyOffset_bIsColorRevert) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x06009680 RID: 38528 RVA: 0x000E30B3 File Offset: 0x000E12B3
		// (set) Token: 0x06009681 RID: 38529 RVA: 0x000E30C3 File Offset: 0x000E12C3
		public unsafe bool bRaycastComplex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIBatchGeometryRenderable.__PropertyOffset_bRaycastComplex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIBatchGeometryRenderable.__PropertyOffset_bRaycastComplex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x06009682 RID: 38530 RVA: 0x000E30D4 File Offset: 0x000E12D4
		// (set) Token: 0x06009683 RID: 38531 RVA: 0x000E30E8 File Offset: 0x000E12E8
		public unsafe UMaterialInstanceDynamic uiMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + UUIBatchGeometryRenderable.__PropertyOffset_uiMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIBatchGeometryRenderable.__PropertyOffset_uiMaterial, value);
			}
		}

		// Token: 0x06009684 RID: 38532 RVA: 0x000E30FD File Offset: 0x000E12FD
		public void SetRaycastComplex(bool newValue)
		{
			UUIBatchGeometryRenderable.__SetRaycastComplex_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06009685 RID: 38533 RVA: 0x000E310B File Offset: 0x000E130B
		public void SetKuroRenderingMaterial(UMaterialInstanceDynamic inMat)
		{
			UUIBatchGeometryRenderable.__SetKuroRenderingMaterial_Internal(base.NativePtr, (inMat != null) ? inMat.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009686 RID: 38534 RVA: 0x000E3128 File Offset: 0x000E1328
		public void SetIsSelfRender(bool value)
		{
			UUIBatchGeometryRenderable.__SetIsSelfRender_Internal(base.NativePtr, value);
		}

		// Token: 0x06009687 RID: 38535 RVA: 0x000E3136 File Offset: 0x000E1336
		public void SetIsGray(bool value)
		{
			UUIBatchGeometryRenderable.__SetIsGray_Internal(base.NativePtr, value);
		}

		// Token: 0x06009688 RID: 38536 RVA: 0x000E3144 File Offset: 0x000E1344
		public void SetIsColorRevert(bool value)
		{
			UUIBatchGeometryRenderable.__SetIsColorRevert_Internal(base.NativePtr, value);
		}

		// Token: 0x06009689 RID: 38537 RVA: 0x000E3152 File Offset: 0x000E1352
		public void SetCustomUIMaterial(UMaterialInterface inMat)
		{
			UUIBatchGeometryRenderable.__SetCustomUIMaterial_Internal(base.NativePtr, (inMat != null) ? inMat.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600968A RID: 38538 RVA: 0x000E316F File Offset: 0x000E136F
		public void SetCustomMaterialVectorParameter(FName paramterName, FLinearColor Value)
		{
			UUIBatchGeometryRenderable.__SetCustomMaterialVectorParameter_Internal(base.NativePtr, paramterName, Value);
		}

		// Token: 0x0600968B RID: 38539 RVA: 0x000E317E File Offset: 0x000E137E
		public void SetCustomMaterialTextureParameter(FName ParameterName, UTexture value)
		{
			UUIBatchGeometryRenderable.__SetCustomMaterialTextureParameter_Internal(base.NativePtr, ParameterName, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600968C RID: 38540 RVA: 0x000E319C File Offset: 0x000E139C
		public void SetCustomMaterialScalarParameter(FName paramterName, float value)
		{
			UUIBatchGeometryRenderable.__SetCustomMaterialScalarParameter_Internal(base.NativePtr, paramterName, value);
		}

		// Token: 0x0600968D RID: 38541 RVA: 0x000E31AB File Offset: 0x000E13AB
		public bool IsGray()
		{
			return UUIBatchGeometryRenderable.__IsGray_Internal(base.NativePtr);
		}

		// Token: 0x0600968E RID: 38542 RVA: 0x000E31B8 File Offset: 0x000E13B8
		public bool IsColorRevert()
		{
			return UUIBatchGeometryRenderable.__IsColorRevert_Internal(base.NativePtr);
		}

		// Token: 0x0600968F RID: 38543 RVA: 0x000E31C5 File Offset: 0x000E13C5
		public bool GetRaycastComplex()
		{
			return UUIBatchGeometryRenderable.__GetRaycastComplex_Internal(base.NativePtr);
		}

		// Token: 0x06009690 RID: 38544 RVA: 0x000E31D2 File Offset: 0x000E13D2
		public UMaterialInstanceDynamic GetMaterialInstanceDynamic()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UUIBatchGeometryRenderable.__GetMaterialInstanceDynamic_Internal(base.NativePtr));
		}

		// Token: 0x06009691 RID: 38545 RVA: 0x000E31E4 File Offset: 0x000E13E4
		public UMaterialInterface GetKuroRenderingMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UUIBatchGeometryRenderable.__GetKuroRenderingMaterial_Internal(base.NativePtr));
		}

		// Token: 0x06009692 RID: 38546 RVA: 0x000E31F6 File Offset: 0x000E13F6
		public bool GetIsSelfRender()
		{
			return UUIBatchGeometryRenderable.__GetIsSelfRender_Internal(base.NativePtr);
		}

		// Token: 0x06009693 RID: 38547 RVA: 0x000E3203 File Offset: 0x000E1403
		public UMaterialInterface GetCustomUIMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UUIBatchGeometryRenderable.__GetCustomUIMaterial_Internal(base.NativePtr));
		}

		// Token: 0x06009694 RID: 38548 RVA: 0x000E3215 File Offset: 0x000E1415
		public void ClearCustomMaterialParameterInMap()
		{
			UUIBatchGeometryRenderable.__ClearCustomMaterialParameterInMap_Internal(base.NativePtr);
		}

		// Token: 0x06009695 RID: 38549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRaycastComplex_Internal(IntPtr @this, bool newValue);

		// Token: 0x06009696 RID: 38550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroRenderingMaterial_Internal(IntPtr @this, IntPtr inMat);

		// Token: 0x06009697 RID: 38551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsSelfRender_Internal(IntPtr @this, bool value);

		// Token: 0x06009698 RID: 38552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsGray_Internal(IntPtr @this, bool value);

		// Token: 0x06009699 RID: 38553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsColorRevert_Internal(IntPtr @this, bool value);

		// Token: 0x0600969A RID: 38554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomUIMaterial_Internal(IntPtr @this, IntPtr inMat);

		// Token: 0x0600969B RID: 38555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomMaterialVectorParameter_Internal(IntPtr @this, FName paramterName, FLinearColor Value);

		// Token: 0x0600969C RID: 38556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomMaterialTextureParameter_Internal(IntPtr @this, FName ParameterName, IntPtr value);

		// Token: 0x0600969D RID: 38557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomMaterialScalarParameter_Internal(IntPtr @this, FName paramterName, float value);

		// Token: 0x0600969E RID: 38558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGray_Internal(IntPtr @this);

		// Token: 0x0600969F RID: 38559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsColorRevert_Internal(IntPtr @this);

		// Token: 0x060096A0 RID: 38560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRaycastComplex_Internal(IntPtr @this);

		// Token: 0x060096A1 RID: 38561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterialInstanceDynamic_Internal(IntPtr @this);

		// Token: 0x060096A2 RID: 38562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroRenderingMaterial_Internal(IntPtr @this);

		// Token: 0x060096A3 RID: 38563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsSelfRender_Internal(IntPtr @this);

		// Token: 0x060096A4 RID: 38564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCustomUIMaterial_Internal(IntPtr @this);

		// Token: 0x060096A5 RID: 38565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCustomMaterialParameterInMap_Internal(IntPtr @this);

		// Token: 0x060096A6 RID: 38566 RVA: 0x000E3222 File Offset: 0x000E1422
		static UUIBatchGeometryRenderable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIBatchGeometryRenderable");
		}

		// Token: 0x060096A7 RID: 38567 RVA: 0x000E3230 File Offset: 0x000E1430
		protected UUIBatchGeometryRenderable() : this(BuiltinUtils.AllocNativeUObject(UUIBatchGeometryRenderable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060096A8 RID: 38568 RVA: 0x000E3258 File Offset: 0x000E1458
		protected UUIBatchGeometryRenderable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400416C RID: 16748
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIBatchGeometryRenderable";

		// Token: 0x0400416D RID: 16749
		private static IntPtr _ClassPtr;

		// Token: 0x0400416E RID: 16750
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400416F RID: 16751
		internal static int __PropertyOffset_CustomScalarParameterTMap;

		// Token: 0x04004170 RID: 16752
		private TMap<FName, float> _CustomScalarParameterTMap;

		// Token: 0x04004171 RID: 16753
		internal static int __PropertyOffset_CustomTextureParameterTMap;

		// Token: 0x04004172 RID: 16754
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _CustomTextureParameterTMap;

		// Token: 0x04004173 RID: 16755
		internal static int __PropertyOffset_CustomVectorParameterTMap;

		// Token: 0x04004174 RID: 16756
		private TMap<FName, FLinearColor> _CustomVectorParameterTMap;

		// Token: 0x04004175 RID: 16757
		internal static int __PropertyOffset_CustomUIMaterial;

		// Token: 0x04004176 RID: 16758
		internal static int __PropertyOffset_bIsSelfRender;

		// Token: 0x04004177 RID: 16759
		internal static int __PropertyOffset_bIsGray;

		// Token: 0x04004178 RID: 16760
		internal static int __PropertyOffset_bIsColorRevert;

		// Token: 0x04004179 RID: 16761
		internal static int __PropertyOffset_bRaycastComplex;

		// Token: 0x0400417A RID: 16762
		internal static int __PropertyOffset_uiMaterial;
	}
}
