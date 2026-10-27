using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B71 RID: 7025
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialVariationComponent")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UKuroMaterialVariationComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A954 RID: 108884 RVA: 0x002731F8 File Offset: 0x002713F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMaterialVariationComponent._ClassPtr;
		}

		// Token: 0x0601A955 RID: 108885 RVA: 0x00273204 File Offset: 0x00271404
		public UKuroMaterialVariationComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialVariationComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A956 RID: 108886 RVA: 0x0027322C File Offset: 0x0027142C
		[NullableContext(1)]
		public UKuroMaterialVariationComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialVariationComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006ACC RID: 27340
		// (get) Token: 0x0601A957 RID: 108887 RVA: 0x0027325F File Offset: 0x0027145F
		// (set) Token: 0x0601A958 RID: 108888 RVA: 0x0027326F File Offset: 0x0027146F
		public unsafe bool bIsInitSuccess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialVariationComponent.__PropertyOffset_bIsInitSuccess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialVariationComponent.__PropertyOffset_bIsInitSuccess) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006ACD RID: 27341
		// (get) Token: 0x0601A959 RID: 108889 RVA: 0x00273280 File Offset: 0x00271480
		// (set) Token: 0x0601A95A RID: 108890 RVA: 0x00273290 File Offset: 0x00271490
		public unsafe bool bIsSkeletalMeshType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialVariationComponent.__PropertyOffset_bIsSkeletalMeshType) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialVariationComponent.__PropertyOffset_bIsSkeletalMeshType) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006ACE RID: 27342
		// (get) Token: 0x0601A95B RID: 108891 RVA: 0x002732A1 File Offset: 0x002714A1
		// (set) Token: 0x0601A95C RID: 108892 RVA: 0x002732B5 File Offset: 0x002714B5
		public unsafe UStaticMeshComponent ParentStaticMeshComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMaterialVariationComponent.__PropertyOffset_ParentStaticMeshComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMaterialVariationComponent.__PropertyOffset_ParentStaticMeshComp, value);
			}
		}

		// Token: 0x17006ACF RID: 27343
		// (get) Token: 0x0601A95D RID: 108893 RVA: 0x002732CA File Offset: 0x002714CA
		// (set) Token: 0x0601A95E RID: 108894 RVA: 0x002732DE File Offset: 0x002714DE
		public unsafe USkeletalMeshComponent ParentSkeletalMeshComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMaterialVariationComponent.__PropertyOffset_ParentSkeletalMeshComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMaterialVariationComponent.__PropertyOffset_ParentSkeletalMeshComp, value);
			}
		}

		// Token: 0x17006AD0 RID: 27344
		// (get) Token: 0x0601A95F RID: 108895 RVA: 0x002732F4 File Offset: 0x002714F4
		// (set) Token: 0x0601A960 RID: 108896 RVA: 0x0027332D File Offset: 0x0027152D
		[Nullable(1)]
		public TArray<FKuroMaterialVariationRuntimeInfo> AllRuntimeMaterialInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialVariationRuntimeInfo> result;
				if ((result = this._AllRuntimeMaterialInfo) == null)
				{
					result = (this._AllRuntimeMaterialInfo = new TArray<FKuroMaterialVariationRuntimeInfo>(base.NativePtr + (IntPtr)UKuroMaterialVariationComponent.__PropertyOffset_AllRuntimeMaterialInfo, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AllRuntimeMaterialInfo.CopyAssign(value);
			}
		}

		// Token: 0x0601A961 RID: 108897 RVA: 0x0027333B File Offset: 0x0027153B
		public void SetMaterialTextureAll(FName PropertyName, UTexture InValue)
		{
			UKuroMaterialVariationComponent.__SetMaterialTextureAll_Internal(base.NativePtr, PropertyName, (InValue != null) ? InValue.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A962 RID: 108898 RVA: 0x00273359 File Offset: 0x00271559
		public void SetMaterialTexture(FName PropertyName, UTexture InValue, int MaterialIndex)
		{
			UKuroMaterialVariationComponent.__SetMaterialTexture_Internal(base.NativePtr, PropertyName, (InValue != null) ? InValue.NativePtr : IntPtr.Zero, MaterialIndex);
		}

		// Token: 0x0601A963 RID: 108899 RVA: 0x00273378 File Offset: 0x00271578
		public void SetMaterialLinearColorAll(FName PropertyName, FLinearColor InValue)
		{
			UKuroMaterialVariationComponent.__SetMaterialLinearColorAll_Internal(base.NativePtr, PropertyName, InValue);
		}

		// Token: 0x0601A964 RID: 108900 RVA: 0x00273387 File Offset: 0x00271587
		public void SetMaterialLinearColor(FName PropertyName, FLinearColor InValue, int MaterialIndex)
		{
			UKuroMaterialVariationComponent.__SetMaterialLinearColor_Internal(base.NativePtr, PropertyName, InValue, MaterialIndex);
		}

		// Token: 0x0601A965 RID: 108901 RVA: 0x00273397 File Offset: 0x00271597
		public void SetMaterialFloatAll(FName PropertyName, float InValue)
		{
			UKuroMaterialVariationComponent.__SetMaterialFloatAll_Internal(base.NativePtr, PropertyName, InValue);
		}

		// Token: 0x0601A966 RID: 108902 RVA: 0x002733A6 File Offset: 0x002715A6
		public void SetMaterialFloat(FName PropertyName, float InValue, int MaterialIndex)
		{
			UKuroMaterialVariationComponent.__SetMaterialFloat_Internal(base.NativePtr, PropertyName, InValue, MaterialIndex);
		}

		// Token: 0x0601A967 RID: 108903 RVA: 0x002733B6 File Offset: 0x002715B6
		public void SetKeywordStateAll(FName Keyword, bool InIsEnable)
		{
			UKuroMaterialVariationComponent.__SetKeywordStateAll_Internal(base.NativePtr, Keyword, InIsEnable);
		}

		// Token: 0x0601A968 RID: 108904 RVA: 0x002733C5 File Offset: 0x002715C5
		public void SetKeywordState(FName Keyword, bool InIsEnable, int MaterialIndex)
		{
			UKuroMaterialVariationComponent.__SetKeywordState_Internal(base.NativePtr, Keyword, InIsEnable, MaterialIndex);
		}

		// Token: 0x0601A969 RID: 108905 RVA: 0x002733D5 File Offset: 0x002715D5
		public void RevertMaterialTextureAll(FName PropertyName)
		{
			UKuroMaterialVariationComponent.__RevertMaterialTextureAll_Internal(base.NativePtr, PropertyName);
		}

		// Token: 0x0601A96A RID: 108906 RVA: 0x002733E3 File Offset: 0x002715E3
		public void RevertMaterialTexture(FName PropertyName, int MaterialIndex)
		{
			UKuroMaterialVariationComponent.__RevertMaterialTexture_Internal(base.NativePtr, PropertyName, MaterialIndex);
		}

		// Token: 0x0601A96B RID: 108907 RVA: 0x002733F2 File Offset: 0x002715F2
		public void RevertMaterialLinearColorAll(FName PropertyName)
		{
			UKuroMaterialVariationComponent.__RevertMaterialLinearColorAll_Internal(base.NativePtr, PropertyName);
		}

		// Token: 0x0601A96C RID: 108908 RVA: 0x00273400 File Offset: 0x00271600
		public void RevertMaterialLinearColor(FName PropertyName, int MaterialIndex)
		{
			UKuroMaterialVariationComponent.__RevertMaterialLinearColor_Internal(base.NativePtr, PropertyName, MaterialIndex);
		}

		// Token: 0x0601A96D RID: 108909 RVA: 0x0027340F File Offset: 0x0027160F
		public void RevertMaterialFloatAll(FName PropertyName)
		{
			UKuroMaterialVariationComponent.__RevertMaterialFloatAll_Internal(base.NativePtr, PropertyName);
		}

		// Token: 0x0601A96E RID: 108910 RVA: 0x0027341D File Offset: 0x0027161D
		public void RevertMaterialFloat(FName PropertyName, int MaterialIndex)
		{
			UKuroMaterialVariationComponent.__RevertMaterialFloat_Internal(base.NativePtr, PropertyName, MaterialIndex);
		}

		// Token: 0x0601A96F RID: 108911 RVA: 0x0027342C File Offset: 0x0027162C
		public void RevertMaterial(int MaterialIndex)
		{
			UKuroMaterialVariationComponent.__RevertMaterial_Internal(base.NativePtr, MaterialIndex);
		}

		// Token: 0x0601A970 RID: 108912 RVA: 0x0027343A File Offset: 0x0027163A
		public void ReplaceMaterial(UMaterialInterface MatToReplace, int MaterialIndex)
		{
			UKuroMaterialVariationComponent.__ReplaceMaterial_Internal(base.NativePtr, (MatToReplace != null) ? MatToReplace.NativePtr : IntPtr.Zero, MaterialIndex);
		}

		// Token: 0x0601A971 RID: 108913 RVA: 0x00273458 File Offset: 0x00271658
		public bool IsMaterialVariationDataValid(UMeshComponent CheckMeshComponent, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<UKuroMaterialVariationCollection> CheckCollection)
		{
			return UKuroMaterialVariationComponent.__IsMaterialVariationDataValid_Internal(base.NativePtr, (CheckMeshComponent != null) ? CheckMeshComponent.NativePtr : IntPtr.Zero, (CheckCollection ?? new TArray<UKuroMaterialVariationCollection>()).NativePtr);
		}

		// Token: 0x0601A972 RID: 108914 RVA: 0x00273484 File Offset: 0x00271684
		public bool IsComponentValid()
		{
			return UKuroMaterialVariationComponent.__IsComponentValid_Internal(base.NativePtr);
		}

		// Token: 0x0601A973 RID: 108915 RVA: 0x00273491 File Offset: 0x00271691
		public bool InitWithStaticMeshComponent(UStaticMeshComponent InStaticMeshComponent)
		{
			return UKuroMaterialVariationComponent.__InitWithStaticMeshComponent_Internal(base.NativePtr, (InStaticMeshComponent != null) ? InStaticMeshComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A974 RID: 108916 RVA: 0x002734AE File Offset: 0x002716AE
		public bool InitWithSkeletalMeshComponent(USkeletalMeshComponent InSkeletalMeshComponent)
		{
			return UKuroMaterialVariationComponent.__InitWithSkeletalMeshComponent_Internal(base.NativePtr, (InSkeletalMeshComponent != null) ? InSkeletalMeshComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A975 RID: 108917 RVA: 0x002734CB File Offset: 0x002716CB
		public UTexture GetMaterialTexture(FName PropertyName, int MaterialIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture>(UKuroMaterialVariationComponent.__GetMaterialTexture_Internal(base.NativePtr, PropertyName, MaterialIndex));
		}

		// Token: 0x0601A976 RID: 108918 RVA: 0x002734DF File Offset: 0x002716DF
		public FLinearColor GetMaterialLinearColor(FName PropertyName, int MaterialIndex)
		{
			return UKuroMaterialVariationComponent.__GetMaterialLinearColor_Internal(base.NativePtr, PropertyName, MaterialIndex);
		}

		// Token: 0x0601A977 RID: 108919 RVA: 0x002734EE File Offset: 0x002716EE
		public float GetMaterialFloat(FName PropertyName, int MaterialIndex)
		{
			return UKuroMaterialVariationComponent.__GetMaterialFloat_Internal(base.NativePtr, PropertyName, MaterialIndex);
		}

		// Token: 0x0601A978 RID: 108920 RVA: 0x002734FD File Offset: 0x002716FD
		public bool GetKeywordState(FName PropertyName, int MaterialIndex)
		{
			return UKuroMaterialVariationComponent.__GetKeywordState_Internal(base.NativePtr, PropertyName, MaterialIndex);
		}

		// Token: 0x0601A979 RID: 108921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterialTextureAll_Internal(IntPtr @this, FName PropertyName, IntPtr InValue);

		// Token: 0x0601A97A RID: 108922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterialTexture_Internal(IntPtr @this, FName PropertyName, IntPtr InValue, int MaterialIndex);

		// Token: 0x0601A97B RID: 108923
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterialLinearColorAll_Internal(IntPtr @this, FName PropertyName, FLinearColor InValue);

		// Token: 0x0601A97C RID: 108924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterialLinearColor_Internal(IntPtr @this, FName PropertyName, FLinearColor InValue, int MaterialIndex);

		// Token: 0x0601A97D RID: 108925
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterialFloatAll_Internal(IntPtr @this, FName PropertyName, float InValue);

		// Token: 0x0601A97E RID: 108926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterialFloat_Internal(IntPtr @this, FName PropertyName, float InValue, int MaterialIndex);

		// Token: 0x0601A97F RID: 108927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKeywordStateAll_Internal(IntPtr @this, FName Keyword, bool InIsEnable);

		// Token: 0x0601A980 RID: 108928
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKeywordState_Internal(IntPtr @this, FName Keyword, bool InIsEnable, int MaterialIndex);

		// Token: 0x0601A981 RID: 108929
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RevertMaterialTextureAll_Internal(IntPtr @this, FName PropertyName);

		// Token: 0x0601A982 RID: 108930
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RevertMaterialTexture_Internal(IntPtr @this, FName PropertyName, int MaterialIndex);

		// Token: 0x0601A983 RID: 108931
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RevertMaterialLinearColorAll_Internal(IntPtr @this, FName PropertyName);

		// Token: 0x0601A984 RID: 108932
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RevertMaterialLinearColor_Internal(IntPtr @this, FName PropertyName, int MaterialIndex);

		// Token: 0x0601A985 RID: 108933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RevertMaterialFloatAll_Internal(IntPtr @this, FName PropertyName);

		// Token: 0x0601A986 RID: 108934
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RevertMaterialFloat_Internal(IntPtr @this, FName PropertyName, int MaterialIndex);

		// Token: 0x0601A987 RID: 108935
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RevertMaterial_Internal(IntPtr @this, int MaterialIndex);

		// Token: 0x0601A988 RID: 108936
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReplaceMaterial_Internal(IntPtr @this, IntPtr MatToReplace, int MaterialIndex);

		// Token: 0x0601A989 RID: 108937
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMaterialVariationDataValid_Internal(IntPtr @this, IntPtr CheckMeshComponent, IntPtr CheckCollection);

		// Token: 0x0601A98A RID: 108938
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsComponentValid_Internal(IntPtr @this);

		// Token: 0x0601A98B RID: 108939
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InitWithStaticMeshComponent_Internal(IntPtr @this, IntPtr InStaticMeshComponent);

		// Token: 0x0601A98C RID: 108940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InitWithSkeletalMeshComponent_Internal(IntPtr @this, IntPtr InSkeletalMeshComponent);

		// Token: 0x0601A98D RID: 108941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterialTexture_Internal(IntPtr @this, FName PropertyName, int MaterialIndex);

		// Token: 0x0601A98E RID: 108942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetMaterialLinearColor_Internal(IntPtr @this, FName PropertyName, int MaterialIndex);

		// Token: 0x0601A98F RID: 108943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaterialFloat_Internal(IntPtr @this, FName PropertyName, int MaterialIndex);

		// Token: 0x0601A990 RID: 108944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetKeywordState_Internal(IntPtr @this, FName PropertyName, int MaterialIndex);

		// Token: 0x0601A991 RID: 108945 RVA: 0x0027350C File Offset: 0x0027170C
		static UKuroMaterialVariationComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialVariationComponent");
		}

		// Token: 0x0601A992 RID: 108946 RVA: 0x0027351A File Offset: 0x0027171A
		protected UKuroMaterialVariationComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E646 RID: 58950
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialVariationComponent";

		// Token: 0x0400E647 RID: 58951
		private static IntPtr _ClassPtr;

		// Token: 0x0400E648 RID: 58952
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E649 RID: 58953
		internal static int __PropertyOffset_bIsInitSuccess;

		// Token: 0x0400E64A RID: 58954
		internal static int __PropertyOffset_bIsSkeletalMeshType;

		// Token: 0x0400E64B RID: 58955
		internal static int __PropertyOffset_ParentStaticMeshComp;

		// Token: 0x0400E64C RID: 58956
		internal static int __PropertyOffset_ParentSkeletalMeshComp;

		// Token: 0x0400E64D RID: 58957
		internal static int __PropertyOffset_AllRuntimeMaterialInfo;

		// Token: 0x0400E64E RID: 58958
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialVariationRuntimeInfo> _AllRuntimeMaterialInfo;
	}
}
