using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C76 RID: 7286
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRopeEffect.RopeEffectComponent")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class URopeEffectComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C43D RID: 115773 RVA: 0x0029A9A6 File Offset: 0x00298BA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URopeEffectComponent._ClassPtr;
		}

		// Token: 0x0601C43E RID: 115774 RVA: 0x0029A9B4 File Offset: 0x00298BB4
		public URopeEffectComponent() : this(BuiltinUtils.AllocNativeUObject(URopeEffectComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C43F RID: 115775 RVA: 0x0029A9DC File Offset: 0x00298BDC
		[NullableContext(1)]
		public URopeEffectComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URopeEffectComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700723D RID: 29245
		// (get) Token: 0x0601C440 RID: 115776 RVA: 0x0029AA0F File Offset: 0x00298C0F
		// (set) Token: 0x0601C441 RID: 115777 RVA: 0x0029AA23 File Offset: 0x00298C23
		public unsafe URopeEffectDataAsset RopeDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URopeEffectDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + URopeEffectComponent.__PropertyOffset_RopeDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + URopeEffectComponent.__PropertyOffset_RopeDataAsset, value);
			}
		}

		// Token: 0x1700723E RID: 29246
		// (get) Token: 0x0601C442 RID: 115778 RVA: 0x0029AA38 File Offset: 0x00298C38
		// (set) Token: 0x0601C443 RID: 115779 RVA: 0x0029AA48 File Offset: 0x00298C48
		public unsafe bool bAutoFindSkeletalMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectComponent.__PropertyOffset_bAutoFindSkeletalMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectComponent.__PropertyOffset_bAutoFindSkeletalMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700723F RID: 29247
		// (get) Token: 0x0601C444 RID: 115780 RVA: 0x0029AA59 File Offset: 0x00298C59
		// (set) Token: 0x0601C445 RID: 115781 RVA: 0x0029AA6D File Offset: 0x00298C6D
		public unsafe USkeletalMeshComponent TargetSkeletalMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + URopeEffectComponent.__PropertyOffset_TargetSkeletalMeshComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + URopeEffectComponent.__PropertyOffset_TargetSkeletalMeshComponent, value);
			}
		}

		// Token: 0x17007240 RID: 29248
		// (get) Token: 0x0601C446 RID: 115782 RVA: 0x0029AA82 File Offset: 0x00298C82
		// (set) Token: 0x0601C447 RID: 115783 RVA: 0x0029AA96 File Offset: 0x00298C96
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USkeletalMeshComponent> CachedSkeletalMeshComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectComponent.__PropertyOffset_CachedSkeletalMeshComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectComponent.__PropertyOffset_CachedSkeletalMeshComponent) = value;
			}
		}

		// Token: 0x17007241 RID: 29249
		// (get) Token: 0x0601C448 RID: 115784 RVA: 0x0029AAAB File Offset: 0x00298CAB
		// (set) Token: 0x0601C449 RID: 115785 RVA: 0x0029AABF File Offset: 0x00298CBF
		public unsafe ARopeEffectSplineActor RopeSplineActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ARopeEffectSplineActor>(base.NativePtr / (IntPtr)sizeof(void*) + URopeEffectComponent.__PropertyOffset_RopeSplineActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + URopeEffectComponent.__PropertyOffset_RopeSplineActor, value);
			}
		}

		// Token: 0x0601C44A RID: 115786 RVA: 0x0029AAD4 File Offset: 0x00298CD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSkeletalMeshComponent(USkeletalMeshComponent SkeletalMeshComp)
		{
			URopeEffectComponent.__SetSkeletalMeshComponent_FunctionParams* ptr = stackalloc URopeEffectComponent.__SetSkeletalMeshComponent_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(URopeEffectComponent.__SetSkeletalMeshComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(URopeEffectComponent.__SetSkeletalMeshComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SkeletalMeshComp = ((SkeletalMeshComp != null) ? SkeletalMeshComp.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, URopeEffectComponent.__SetSkeletalMeshComponent_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C44B RID: 115787 RVA: 0x0029AB2C File Offset: 0x00298D2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRopeValid()
		{
			URopeEffectComponent.__IsRopeValid_FunctionParams* ptr = stackalloc URopeEffectComponent.__IsRopeValid_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(URopeEffectComponent.__IsRopeValid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(URopeEffectComponent.__IsRopeValid_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, URopeEffectComponent.__IsRopeValid_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C44C RID: 115788 RVA: 0x0029AB74 File Offset: 0x00298D74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USkeletalMeshComponent GetSkeletalMeshComponent()
		{
			URopeEffectComponent.__GetSkeletalMeshComponent_FunctionParams* ptr = stackalloc URopeEffectComponent.__GetSkeletalMeshComponent_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(URopeEffectComponent.__GetSkeletalMeshComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(URopeEffectComponent.__GetSkeletalMeshComponent_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, URopeEffectComponent.__GetSkeletalMeshComponent_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(ptr->__Result);
		}

		// Token: 0x0601C44D RID: 115789 RVA: 0x0029ABC0 File Offset: 0x00298DC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ARopeEffectSplineActor GetRopeActor()
		{
			URopeEffectComponent.__GetRopeActor_FunctionParams* ptr = stackalloc URopeEffectComponent.__GetRopeActor_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(URopeEffectComponent.__GetRopeActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(URopeEffectComponent.__GetRopeActor_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, URopeEffectComponent.__GetRopeActor_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ARopeEffectSplineActor>(ptr->__Result);
		}

		// Token: 0x0601C44E RID: 115790 RVA: 0x0029AC0C File Offset: 0x00298E0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GenerateSlicedRopes()
		{
			URopeEffectComponent.__GenerateSlicedRopes_FunctionParams* ptr = stackalloc URopeEffectComponent.__GenerateSlicedRopes_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(URopeEffectComponent.__GenerateSlicedRopes_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(URopeEffectComponent.__GenerateSlicedRopes_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, URopeEffectComponent.__GenerateSlicedRopes_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C44F RID: 115791 RVA: 0x0029AC52 File Offset: 0x00298E52
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void DestroyRope()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, URopeEffectComponent.__DestroyRope_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C450 RID: 115792 RVA: 0x0029AC67 File Offset: 0x00298E67
		static URopeEffectComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRopeEffect.RopeEffectComponent");
		}

		// Token: 0x0601C451 RID: 115793 RVA: 0x0029AC75 File Offset: 0x00298E75
		protected URopeEffectComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F328 RID: 62248
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRopeEffect.RopeEffectComponent";

		// Token: 0x0400F329 RID: 62249
		private static IntPtr _ClassPtr;

		// Token: 0x0400F32A RID: 62250
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F32B RID: 62251
		internal static int __PropertyOffset_RopeDataAsset;

		// Token: 0x0400F32C RID: 62252
		internal static int __PropertyOffset_bAutoFindSkeletalMesh;

		// Token: 0x0400F32D RID: 62253
		internal static int __PropertyOffset_TargetSkeletalMeshComponent;

		// Token: 0x0400F32E RID: 62254
		internal static int __PropertyOffset_CachedSkeletalMeshComponent;

		// Token: 0x0400F32F RID: 62255
		internal static int __PropertyOffset_RopeSplineActor;

		// Token: 0x0400F330 RID: 62256
		private static IntPtr __SetSkeletalMeshComponent_NativeFunctionPtr;

		// Token: 0x0400F331 RID: 62257
		private static IntPtr __IsRopeValid_NativeFunctionPtr;

		// Token: 0x0400F332 RID: 62258
		private static IntPtr __GetSkeletalMeshComponent_NativeFunctionPtr;

		// Token: 0x0400F333 RID: 62259
		private static IntPtr __GetRopeActor_NativeFunctionPtr;

		// Token: 0x0400F334 RID: 62260
		private static IntPtr __GenerateSlicedRopes_NativeFunctionPtr;

		// Token: 0x0400F335 RID: 62261
		private static IntPtr __DestroyRope_NativeFunctionPtr;

		// Token: 0x0200320C RID: 12812
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetSkeletalMeshComponent_FunctionParams
		{
			// Token: 0x0401706F RID: 94319
			[FieldOffset(0)]
			public IntPtr SkeletalMeshComp;
		}

		// Token: 0x0200320D RID: 12813
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRopeValid_FunctionParams
		{
			// Token: 0x04017070 RID: 94320
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200320E RID: 12814
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSkeletalMeshComponent_FunctionParams
		{
			// Token: 0x04017071 RID: 94321
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x0200320F RID: 12815
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetRopeActor_FunctionParams
		{
			// Token: 0x04017072 RID: 94322
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003210 RID: 12816
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GenerateSlicedRopes_FunctionParams
		{
			// Token: 0x04017073 RID: 94323
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
