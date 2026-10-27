using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001448 RID: 5192
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GLTFExporter.GLTFHotspotActor")]
	[UnrealStructLayout(1200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1200)]
	public class AGLTFHotspotActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012FDF RID: 77791 RVA: 0x001BEB40 File Offset: 0x001BCD40
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGLTFHotspotActor._ClassPtr;
		}

		// Token: 0x06012FE0 RID: 77792 RVA: 0x001BEB4C File Offset: 0x001BCD4C
		public AGLTFHotspotActor() : this(BuiltinUtils.AllocNativeUObject(AGLTFHotspotActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012FE1 RID: 77793 RVA: 0x001BEB74 File Offset: 0x001BCD74
		[NullableContext(1)]
		public AGLTFHotspotActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGLTFHotspotActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170049E0 RID: 18912
		// (get) Token: 0x06012FE2 RID: 77794 RVA: 0x001BEBA7 File Offset: 0x001BCDA7
		// (set) Token: 0x06012FE3 RID: 77795 RVA: 0x001BEBBB File Offset: 0x001BCDBB
		public unsafe ASkeletalMeshActor SkeletalMeshActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_SkeletalMeshActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_SkeletalMeshActor, value);
			}
		}

		// Token: 0x170049E1 RID: 18913
		// (get) Token: 0x06012FE4 RID: 77796 RVA: 0x001BEBD0 File Offset: 0x001BCDD0
		// (set) Token: 0x06012FE5 RID: 77797 RVA: 0x001BEBE4 File Offset: 0x001BCDE4
		public unsafe UAnimSequence AnimationSequence
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_AnimationSequence);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_AnimationSequence, value);
			}
		}

		// Token: 0x170049E2 RID: 18914
		// (get) Token: 0x06012FE6 RID: 77798 RVA: 0x001BEBF9 File Offset: 0x001BCDF9
		// (set) Token: 0x06012FE7 RID: 77799 RVA: 0x001BEC0D File Offset: 0x001BCE0D
		public unsafe ULevelSequence LevelSequence
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_LevelSequence);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_LevelSequence, value);
			}
		}

		// Token: 0x170049E3 RID: 18915
		// (get) Token: 0x06012FE8 RID: 77800 RVA: 0x001BEC22 File Offset: 0x001BCE22
		// (set) Token: 0x06012FE9 RID: 77801 RVA: 0x001BEC36 File Offset: 0x001BCE36
		public unsafe UTexture2D Image
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_Image);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_Image, value);
			}
		}

		// Token: 0x170049E4 RID: 18916
		// (get) Token: 0x06012FEA RID: 77802 RVA: 0x001BEC4B File Offset: 0x001BCE4B
		// (set) Token: 0x06012FEB RID: 77803 RVA: 0x001BEC5F File Offset: 0x001BCE5F
		public unsafe UTexture2D HoveredImage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_HoveredImage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_HoveredImage, value);
			}
		}

		// Token: 0x170049E5 RID: 18917
		// (get) Token: 0x06012FEC RID: 77804 RVA: 0x001BEC74 File Offset: 0x001BCE74
		// (set) Token: 0x06012FED RID: 77805 RVA: 0x001BEC88 File Offset: 0x001BCE88
		public unsafe UTexture2D ToggledImage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_ToggledImage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_ToggledImage, value);
			}
		}

		// Token: 0x170049E6 RID: 18918
		// (get) Token: 0x06012FEE RID: 77806 RVA: 0x001BEC9D File Offset: 0x001BCE9D
		// (set) Token: 0x06012FEF RID: 77807 RVA: 0x001BECB1 File Offset: 0x001BCEB1
		public unsafe UTexture2D ToggledHoveredImage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_ToggledHoveredImage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_ToggledHoveredImage, value);
			}
		}

		// Token: 0x170049E7 RID: 18919
		// (get) Token: 0x06012FF0 RID: 77808 RVA: 0x001BECC6 File Offset: 0x001BCEC6
		// (set) Token: 0x06012FF1 RID: 77809 RVA: 0x001BECDA File Offset: 0x001BCEDA
		public unsafe UMaterialBillboardComponent BillboardComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_BillboardComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_BillboardComponent, value);
			}
		}

		// Token: 0x170049E8 RID: 18920
		// (get) Token: 0x06012FF2 RID: 77810 RVA: 0x001BECEF File Offset: 0x001BCEEF
		// (set) Token: 0x06012FF3 RID: 77811 RVA: 0x001BED03 File Offset: 0x001BCF03
		public unsafe USphereComponent SphereComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_SphereComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_SphereComponent, value);
			}
		}

		// Token: 0x170049E9 RID: 18921
		// (get) Token: 0x06012FF4 RID: 77812 RVA: 0x001BED18 File Offset: 0x001BCF18
		// (set) Token: 0x06012FF5 RID: 77813 RVA: 0x001BED2C File Offset: 0x001BCF2C
		public unsafe UMaterialInterface DefaultMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_DefaultMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_DefaultMaterial, value);
			}
		}

		// Token: 0x170049EA RID: 18922
		// (get) Token: 0x06012FF6 RID: 77814 RVA: 0x001BED41 File Offset: 0x001BCF41
		// (set) Token: 0x06012FF7 RID: 77815 RVA: 0x001BED55 File Offset: 0x001BCF55
		public unsafe UTexture2D DefaultImage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_DefaultImage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_DefaultImage, value);
			}
		}

		// Token: 0x170049EB RID: 18923
		// (get) Token: 0x06012FF8 RID: 77816 RVA: 0x001BED6A File Offset: 0x001BCF6A
		// (set) Token: 0x06012FF9 RID: 77817 RVA: 0x001BED7E File Offset: 0x001BCF7E
		public unsafe UTexture2D DefaultHoveredImage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_DefaultHoveredImage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_DefaultHoveredImage, value);
			}
		}

		// Token: 0x170049EC RID: 18924
		// (get) Token: 0x06012FFA RID: 77818 RVA: 0x001BED93 File Offset: 0x001BCF93
		// (set) Token: 0x06012FFB RID: 77819 RVA: 0x001BEDA7 File Offset: 0x001BCFA7
		public unsafe UTexture2D DefaultToggledImage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_DefaultToggledImage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_DefaultToggledImage, value);
			}
		}

		// Token: 0x170049ED RID: 18925
		// (get) Token: 0x06012FFC RID: 77820 RVA: 0x001BEDBC File Offset: 0x001BCFBC
		// (set) Token: 0x06012FFD RID: 77821 RVA: 0x001BEDD0 File Offset: 0x001BCFD0
		public unsafe UTexture2D DefaultToggledHoveredImage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_DefaultToggledHoveredImage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_DefaultToggledHoveredImage, value);
			}
		}

		// Token: 0x170049EE RID: 18926
		// (get) Token: 0x06012FFE RID: 77822 RVA: 0x001BEDE5 File Offset: 0x001BCFE5
		// (set) Token: 0x06012FFF RID: 77823 RVA: 0x001BEDF9 File Offset: 0x001BCFF9
		public unsafe UMaterialInterface DefaultIconMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_DefaultIconMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_DefaultIconMaterial, value);
			}
		}

		// Token: 0x170049EF RID: 18927
		// (get) Token: 0x06013000 RID: 77824 RVA: 0x001BEE0E File Offset: 0x001BD00E
		// (set) Token: 0x06013001 RID: 77825 RVA: 0x001BEE22 File Offset: 0x001BD022
		public unsafe UTexture ActiveImage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_ActiveImage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_ActiveImage, value);
			}
		}

		// Token: 0x170049F0 RID: 18928
		// (get) Token: 0x06013002 RID: 77826 RVA: 0x001BEE37 File Offset: 0x001BD037
		// (set) Token: 0x06013003 RID: 77827 RVA: 0x001BEE4B File Offset: 0x001BD04B
		public unsafe ULevelSequencePlayer LevelSequencePlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequencePlayer>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_LevelSequencePlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFHotspotActor.__PropertyOffset_LevelSequencePlayer, value);
			}
		}

		// Token: 0x06013004 RID: 77828 RVA: 0x001BEE60 File Offset: 0x001BD060
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void EndCursorOver(UPrimitiveComponent TouchedComponent)
		{
			AGLTFHotspotActor.__EndCursorOver_FunctionParams* ptr = stackalloc AGLTFHotspotActor.__EndCursorOver_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(AGLTFHotspotActor.__EndCursorOver_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AGLTFHotspotActor.__EndCursorOver_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AGLTFHotspotActor.__EndCursorOver_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06013005 RID: 77829 RVA: 0x001BEEB8 File Offset: 0x001BD0B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Clicked(UPrimitiveComponent TouchedComponent, FKey ButtonPressed)
		{
			AGLTFHotspotActor.__Clicked_FunctionParams* ptr = stackalloc AGLTFHotspotActor.__Clicked_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(AGLTFHotspotActor.__Clicked_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AGLTFHotspotActor.__Clicked_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			if (ButtonPressed != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->ButtonPressed, ButtonPressed.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AGLTFHotspotActor.__Clicked_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(AGLTFHotspotActor.__Clicked_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06013006 RID: 77830 RVA: 0x001BEF44 File Offset: 0x001BD144
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void BeginCursorOver(UPrimitiveComponent TouchedComponent)
		{
			AGLTFHotspotActor.__BeginCursorOver_FunctionParams* ptr = stackalloc AGLTFHotspotActor.__BeginCursorOver_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(AGLTFHotspotActor.__BeginCursorOver_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AGLTFHotspotActor.__BeginCursorOver_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AGLTFHotspotActor.__BeginCursorOver_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06013007 RID: 77831 RVA: 0x001BEF9A File Offset: 0x001BD19A
		static AGLTFHotspotActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GLTFExporter.GLTFHotspotActor");
		}

		// Token: 0x06013008 RID: 77832 RVA: 0x001BEFA8 File Offset: 0x001BD1A8
		protected AGLTFHotspotActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A281 RID: 41601
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GLTFExporter.GLTFHotspotActor";

		// Token: 0x0400A282 RID: 41602
		private static IntPtr _ClassPtr;

		// Token: 0x0400A283 RID: 41603
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A284 RID: 41604
		internal static int __PropertyOffset_SkeletalMeshActor;

		// Token: 0x0400A285 RID: 41605
		internal static int __PropertyOffset_AnimationSequence;

		// Token: 0x0400A286 RID: 41606
		internal static int __PropertyOffset_LevelSequence;

		// Token: 0x0400A287 RID: 41607
		internal static int __PropertyOffset_Image;

		// Token: 0x0400A288 RID: 41608
		internal static int __PropertyOffset_HoveredImage;

		// Token: 0x0400A289 RID: 41609
		internal static int __PropertyOffset_ToggledImage;

		// Token: 0x0400A28A RID: 41610
		internal static int __PropertyOffset_ToggledHoveredImage;

		// Token: 0x0400A28B RID: 41611
		internal static int __PropertyOffset_BillboardComponent;

		// Token: 0x0400A28C RID: 41612
		internal static int __PropertyOffset_SphereComponent;

		// Token: 0x0400A28D RID: 41613
		internal static int __PropertyOffset_DefaultMaterial;

		// Token: 0x0400A28E RID: 41614
		internal static int __PropertyOffset_DefaultImage;

		// Token: 0x0400A28F RID: 41615
		internal static int __PropertyOffset_DefaultHoveredImage;

		// Token: 0x0400A290 RID: 41616
		internal static int __PropertyOffset_DefaultToggledImage;

		// Token: 0x0400A291 RID: 41617
		internal static int __PropertyOffset_DefaultToggledHoveredImage;

		// Token: 0x0400A292 RID: 41618
		internal static int __PropertyOffset_DefaultIconMaterial;

		// Token: 0x0400A293 RID: 41619
		internal static int __PropertyOffset_ActiveImage;

		// Token: 0x0400A294 RID: 41620
		internal static int __PropertyOffset_LevelSequencePlayer;

		// Token: 0x0400A295 RID: 41621
		private static IntPtr __EndCursorOver_NativeFunctionPtr;

		// Token: 0x0400A296 RID: 41622
		private static IntPtr __Clicked_NativeFunctionPtr;

		// Token: 0x0400A297 RID: 41623
		private static IntPtr __BeginCursorOver_NativeFunctionPtr;

		// Token: 0x02002E95 RID: 11925
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __EndCursorOver_FunctionParams
		{
			// Token: 0x0401696B RID: 92523
			[FieldOffset(0)]
			public IntPtr TouchedComponent;
		}

		// Token: 0x02002E96 RID: 11926
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __Clicked_FunctionParams
		{
			// Token: 0x0401696C RID: 92524
			[FieldOffset(0)]
			public IntPtr TouchedComponent;

			// Token: 0x0401696D RID: 92525
			[FieldOffset(8)]
			public byte ButtonPressed;
		}

		// Token: 0x02002E97 RID: 11927
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BeginCursorOver_FunctionParams
		{
			// Token: 0x0401696E RID: 92526
			[FieldOffset(0)]
			public IntPtr TouchedComponent;
		}
	}
}
