using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200212F RID: 8495
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIBatchGeometryRenderable")]
	[UnrealStructLayout(2192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2192)]
	public abstract class UUIBatchGeometryRenderable : UUIBaseRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FF81 RID: 130945 RVA: 0x002F8AE1 File Offset: 0x002F6CE1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIBatchGeometryRenderable._ClassPtr;
		}

		// Token: 0x17007D9E RID: 32158
		// (get) Token: 0x0601FF82 RID: 130946 RVA: 0x002F8AF0 File Offset: 0x002F6CF0
		// (set) Token: 0x0601FF83 RID: 130947 RVA: 0x002F8B29 File Offset: 0x002F6D29
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

		// Token: 0x17007D9F RID: 32159
		// (get) Token: 0x0601FF84 RID: 130948 RVA: 0x002F8B38 File Offset: 0x002F6D38
		// (set) Token: 0x0601FF85 RID: 130949 RVA: 0x002F8B71 File Offset: 0x002F6D71
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

		// Token: 0x17007DA0 RID: 32160
		// (get) Token: 0x0601FF86 RID: 130950 RVA: 0x002F8B80 File Offset: 0x002F6D80
		// (set) Token: 0x0601FF87 RID: 130951 RVA: 0x002F8BB9 File Offset: 0x002F6DB9
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

		// Token: 0x17007DA1 RID: 32161
		// (get) Token: 0x0601FF88 RID: 130952 RVA: 0x002F8BC7 File Offset: 0x002F6DC7
		// (set) Token: 0x0601FF89 RID: 130953 RVA: 0x002F8BDB File Offset: 0x002F6DDB
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

		// Token: 0x17007DA2 RID: 32162
		// (get) Token: 0x0601FF8A RID: 130954 RVA: 0x002F8BF0 File Offset: 0x002F6DF0
		// (set) Token: 0x0601FF8B RID: 130955 RVA: 0x002F8C00 File Offset: 0x002F6E00
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

		// Token: 0x17007DA3 RID: 32163
		// (get) Token: 0x0601FF8C RID: 130956 RVA: 0x002F8C11 File Offset: 0x002F6E11
		// (set) Token: 0x0601FF8D RID: 130957 RVA: 0x002F8C21 File Offset: 0x002F6E21
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

		// Token: 0x17007DA4 RID: 32164
		// (get) Token: 0x0601FF8E RID: 130958 RVA: 0x002F8C32 File Offset: 0x002F6E32
		// (set) Token: 0x0601FF8F RID: 130959 RVA: 0x002F8C42 File Offset: 0x002F6E42
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

		// Token: 0x17007DA5 RID: 32165
		// (get) Token: 0x0601FF90 RID: 130960 RVA: 0x002F8C53 File Offset: 0x002F6E53
		// (set) Token: 0x0601FF91 RID: 130961 RVA: 0x002F8C63 File Offset: 0x002F6E63
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

		// Token: 0x17007DA6 RID: 32166
		// (get) Token: 0x0601FF92 RID: 130962 RVA: 0x002F8C74 File Offset: 0x002F6E74
		// (set) Token: 0x0601FF93 RID: 130963 RVA: 0x002F8C88 File Offset: 0x002F6E88
		public unsafe UUIDrawcallMesh uiMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIDrawcallMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UUIBatchGeometryRenderable.__PropertyOffset_uiMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIBatchGeometryRenderable.__PropertyOffset_uiMesh, value);
			}
		}

		// Token: 0x17007DA7 RID: 32167
		// (get) Token: 0x0601FF94 RID: 130964 RVA: 0x002F8C9D File Offset: 0x002F6E9D
		// (set) Token: 0x0601FF95 RID: 130965 RVA: 0x002F8CB1 File Offset: 0x002F6EB1
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

		// Token: 0x0601FF96 RID: 130966 RVA: 0x002F8CC6 File Offset: 0x002F6EC6
		public void SetRaycastComplex(bool newValue)
		{
			UUIBatchGeometryRenderable.__SetRaycastComplex_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0601FF97 RID: 130967 RVA: 0x002F8CD4 File Offset: 0x002F6ED4
		public void SetKuroRenderingMaterial(UMaterialInstanceDynamic inMat)
		{
			UUIBatchGeometryRenderable.__SetKuroRenderingMaterial_Internal(base.NativePtr, (inMat != null) ? inMat.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601FF98 RID: 130968 RVA: 0x002F8CF1 File Offset: 0x002F6EF1
		public void SetIsSelfRender(bool value)
		{
			UUIBatchGeometryRenderable.__SetIsSelfRender_Internal(base.NativePtr, value);
		}

		// Token: 0x0601FF99 RID: 130969 RVA: 0x002F8CFF File Offset: 0x002F6EFF
		public void SetIsGray(bool value)
		{
			UUIBatchGeometryRenderable.__SetIsGray_Internal(base.NativePtr, value);
		}

		// Token: 0x0601FF9A RID: 130970 RVA: 0x002F8D0D File Offset: 0x002F6F0D
		public void SetIsColorRevert(bool value)
		{
			UUIBatchGeometryRenderable.__SetIsColorRevert_Internal(base.NativePtr, value);
		}

		// Token: 0x0601FF9B RID: 130971 RVA: 0x002F8D1B File Offset: 0x002F6F1B
		public void SetCustomUIMaterial(UMaterialInterface inMat)
		{
			UUIBatchGeometryRenderable.__SetCustomUIMaterial_Internal(base.NativePtr, (inMat != null) ? inMat.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601FF9C RID: 130972 RVA: 0x002F8D38 File Offset: 0x002F6F38
		public void SetCustomMaterialVectorParameter(FName paramterName, FLinearColor Value)
		{
			UUIBatchGeometryRenderable.__SetCustomMaterialVectorParameter_Internal(base.NativePtr, paramterName, Value);
		}

		// Token: 0x0601FF9D RID: 130973 RVA: 0x002F8D47 File Offset: 0x002F6F47
		public void SetCustomMaterialTextureParameter(FName ParameterName, UTexture value)
		{
			UUIBatchGeometryRenderable.__SetCustomMaterialTextureParameter_Internal(base.NativePtr, ParameterName, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601FF9E RID: 130974 RVA: 0x002F8D65 File Offset: 0x002F6F65
		public void SetCustomMaterialScalarParameter(FName paramterName, float value)
		{
			UUIBatchGeometryRenderable.__SetCustomMaterialScalarParameter_Internal(base.NativePtr, paramterName, value);
		}

		// Token: 0x0601FF9F RID: 130975 RVA: 0x002F8D74 File Offset: 0x002F6F74
		public bool IsGray()
		{
			return UUIBatchGeometryRenderable.__IsGray_Internal(base.NativePtr);
		}

		// Token: 0x0601FFA0 RID: 130976 RVA: 0x002F8D81 File Offset: 0x002F6F81
		public bool IsColorRevert()
		{
			return UUIBatchGeometryRenderable.__IsColorRevert_Internal(base.NativePtr);
		}

		// Token: 0x0601FFA1 RID: 130977 RVA: 0x002F8D8E File Offset: 0x002F6F8E
		public bool GetRaycastComplex()
		{
			return UUIBatchGeometryRenderable.__GetRaycastComplex_Internal(base.NativePtr);
		}

		// Token: 0x0601FFA2 RID: 130978 RVA: 0x002F8D9B File Offset: 0x002F6F9B
		public UMaterialInstanceDynamic GetMaterialInstanceDynamic()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UUIBatchGeometryRenderable.__GetMaterialInstanceDynamic_Internal(base.NativePtr));
		}

		// Token: 0x0601FFA3 RID: 130979 RVA: 0x002F8DAD File Offset: 0x002F6FAD
		public UMaterialInterface GetKuroRenderingMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UUIBatchGeometryRenderable.__GetKuroRenderingMaterial_Internal(base.NativePtr));
		}

		// Token: 0x0601FFA4 RID: 130980 RVA: 0x002F8DBF File Offset: 0x002F6FBF
		public bool GetIsSelfRender()
		{
			return UUIBatchGeometryRenderable.__GetIsSelfRender_Internal(base.NativePtr);
		}

		// Token: 0x0601FFA5 RID: 130981 RVA: 0x002F8DCC File Offset: 0x002F6FCC
		public UMaterialInterface GetCustomUIMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UUIBatchGeometryRenderable.__GetCustomUIMaterial_Internal(base.NativePtr));
		}

		// Token: 0x0601FFA6 RID: 130982 RVA: 0x002F8DDE File Offset: 0x002F6FDE
		public void ClearCustomMaterialParameterInMap()
		{
			UUIBatchGeometryRenderable.__ClearCustomMaterialParameterInMap_Internal(base.NativePtr);
		}

		// Token: 0x0601FFA7 RID: 130983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRaycastComplex_Internal(IntPtr @this, bool newValue);

		// Token: 0x0601FFA8 RID: 130984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroRenderingMaterial_Internal(IntPtr @this, IntPtr inMat);

		// Token: 0x0601FFA9 RID: 130985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsSelfRender_Internal(IntPtr @this, bool value);

		// Token: 0x0601FFAA RID: 130986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsGray_Internal(IntPtr @this, bool value);

		// Token: 0x0601FFAB RID: 130987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsColorRevert_Internal(IntPtr @this, bool value);

		// Token: 0x0601FFAC RID: 130988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomUIMaterial_Internal(IntPtr @this, IntPtr inMat);

		// Token: 0x0601FFAD RID: 130989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomMaterialVectorParameter_Internal(IntPtr @this, FName paramterName, FLinearColor Value);

		// Token: 0x0601FFAE RID: 130990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomMaterialTextureParameter_Internal(IntPtr @this, FName ParameterName, IntPtr value);

		// Token: 0x0601FFAF RID: 130991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomMaterialScalarParameter_Internal(IntPtr @this, FName paramterName, float value);

		// Token: 0x0601FFB0 RID: 130992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGray_Internal(IntPtr @this);

		// Token: 0x0601FFB1 RID: 130993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsColorRevert_Internal(IntPtr @this);

		// Token: 0x0601FFB2 RID: 130994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRaycastComplex_Internal(IntPtr @this);

		// Token: 0x0601FFB3 RID: 130995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterialInstanceDynamic_Internal(IntPtr @this);

		// Token: 0x0601FFB4 RID: 130996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroRenderingMaterial_Internal(IntPtr @this);

		// Token: 0x0601FFB5 RID: 130997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsSelfRender_Internal(IntPtr @this);

		// Token: 0x0601FFB6 RID: 130998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCustomUIMaterial_Internal(IntPtr @this);

		// Token: 0x0601FFB7 RID: 130999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCustomMaterialParameterInMap_Internal(IntPtr @this);

		// Token: 0x0601FFB8 RID: 131000 RVA: 0x002F8DEB File Offset: 0x002F6FEB
		static UUIBatchGeometryRenderable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIBatchGeometryRenderable");
		}

		// Token: 0x0601FFB9 RID: 131001 RVA: 0x002F8DFC File Offset: 0x002F6FFC
		protected UUIBatchGeometryRenderable() : this(BuiltinUtils.AllocNativeUObject(UUIBatchGeometryRenderable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FFBA RID: 131002 RVA: 0x002F8E24 File Offset: 0x002F7024
		protected UUIBatchGeometryRenderable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401136E RID: 70510
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIBatchGeometryRenderable";

		// Token: 0x0401136F RID: 70511
		private static IntPtr _ClassPtr;

		// Token: 0x04011370 RID: 70512
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011371 RID: 70513
		internal static int __PropertyOffset_CustomScalarParameterTMap;

		// Token: 0x04011372 RID: 70514
		private TMap<FName, float> _CustomScalarParameterTMap;

		// Token: 0x04011373 RID: 70515
		internal static int __PropertyOffset_CustomTextureParameterTMap;

		// Token: 0x04011374 RID: 70516
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _CustomTextureParameterTMap;

		// Token: 0x04011375 RID: 70517
		internal static int __PropertyOffset_CustomVectorParameterTMap;

		// Token: 0x04011376 RID: 70518
		private TMap<FName, FLinearColor> _CustomVectorParameterTMap;

		// Token: 0x04011377 RID: 70519
		internal static int __PropertyOffset_CustomUIMaterial;

		// Token: 0x04011378 RID: 70520
		internal static int __PropertyOffset_bIsSelfRender;

		// Token: 0x04011379 RID: 70521
		internal static int __PropertyOffset_bIsGray;

		// Token: 0x0401137A RID: 70522
		internal static int __PropertyOffset_bIsColorRevert;

		// Token: 0x0401137B RID: 70523
		internal static int __PropertyOffset_bRaycastComplex;

		// Token: 0x0401137C RID: 70524
		internal static int __PropertyOffset_uiMesh;

		// Token: 0x0401137D RID: 70525
		internal static int __PropertyOffset_uiMaterial;
	}
}
