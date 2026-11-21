using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000518 RID: 1304
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRopeEffect.RopeEffectComponent")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class URopeEffectComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060079E0 RID: 31200 RVA: 0x000B2CB2 File Offset: 0x000B0EB2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URopeEffectComponent._ClassPtr;
		}

		// Token: 0x060079E1 RID: 31201 RVA: 0x000B2CC0 File Offset: 0x000B0EC0
		public URopeEffectComponent() : this(BuiltinUtils.AllocNativeUObject(URopeEffectComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060079E2 RID: 31202 RVA: 0x000B2CE8 File Offset: 0x000B0EE8
		[NullableContext(1)]
		public URopeEffectComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URopeEffectComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x060079E3 RID: 31203 RVA: 0x000B2D1B File Offset: 0x000B0F1B
		// (set) Token: 0x060079E4 RID: 31204 RVA: 0x000B2D2F File Offset: 0x000B0F2F
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

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x060079E5 RID: 31205 RVA: 0x000B2D44 File Offset: 0x000B0F44
		// (set) Token: 0x060079E6 RID: 31206 RVA: 0x000B2D54 File Offset: 0x000B0F54
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

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x060079E7 RID: 31207 RVA: 0x000B2D65 File Offset: 0x000B0F65
		// (set) Token: 0x060079E8 RID: 31208 RVA: 0x000B2D79 File Offset: 0x000B0F79
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

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x060079E9 RID: 31209 RVA: 0x000B2D8E File Offset: 0x000B0F8E
		// (set) Token: 0x060079EA RID: 31210 RVA: 0x000B2DA2 File Offset: 0x000B0FA2
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

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x060079EB RID: 31211 RVA: 0x000B2DB7 File Offset: 0x000B0FB7
		// (set) Token: 0x060079EC RID: 31212 RVA: 0x000B2DCB File Offset: 0x000B0FCB
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

		// Token: 0x060079ED RID: 31213 RVA: 0x000B2DE0 File Offset: 0x000B0FE0
		[SkipLocalsInit]
		public unsafe void SetSkeletalMeshComponent(USkeletalMeshComponent SkeletalMeshComp)
		{
			URopeEffectComponent.__SetSkeletalMeshComponent_FunctionParams* ptr = stackalloc URopeEffectComponent.__SetSkeletalMeshComponent_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(URopeEffectComponent.__SetSkeletalMeshComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(URopeEffectComponent.__SetSkeletalMeshComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SkeletalMeshComp = ((SkeletalMeshComp != null) ? SkeletalMeshComp.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, URopeEffectComponent.__SetSkeletalMeshComponent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060079EE RID: 31214 RVA: 0x000B2E38 File Offset: 0x000B1038
		[SkipLocalsInit]
		public unsafe bool IsRopeValid()
		{
			URopeEffectComponent.__IsRopeValid_FunctionParams* ptr = stackalloc URopeEffectComponent.__IsRopeValid_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(URopeEffectComponent.__IsRopeValid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(URopeEffectComponent.__IsRopeValid_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, URopeEffectComponent.__IsRopeValid_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060079EF RID: 31215 RVA: 0x000B2E80 File Offset: 0x000B1080
		[SkipLocalsInit]
		public unsafe USkeletalMeshComponent GetSkeletalMeshComponent()
		{
			URopeEffectComponent.__GetSkeletalMeshComponent_FunctionParams* ptr = stackalloc URopeEffectComponent.__GetSkeletalMeshComponent_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(URopeEffectComponent.__GetSkeletalMeshComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(URopeEffectComponent.__GetSkeletalMeshComponent_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, URopeEffectComponent.__GetSkeletalMeshComponent_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(ptr->__Result);
		}

		// Token: 0x060079F0 RID: 31216 RVA: 0x000B2ECC File Offset: 0x000B10CC
		[SkipLocalsInit]
		public unsafe ARopeEffectSplineActor GetRopeActor()
		{
			URopeEffectComponent.__GetRopeActor_FunctionParams* ptr = stackalloc URopeEffectComponent.__GetRopeActor_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(URopeEffectComponent.__GetRopeActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(URopeEffectComponent.__GetRopeActor_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, URopeEffectComponent.__GetRopeActor_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ARopeEffectSplineActor>(ptr->__Result);
		}

		// Token: 0x060079F1 RID: 31217 RVA: 0x000B2F18 File Offset: 0x000B1118
		[SkipLocalsInit]
		public unsafe bool GenerateSlicedRopes()
		{
			URopeEffectComponent.__GenerateSlicedRopes_FunctionParams* ptr = stackalloc URopeEffectComponent.__GenerateSlicedRopes_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(URopeEffectComponent.__GenerateSlicedRopes_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(URopeEffectComponent.__GenerateSlicedRopes_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, URopeEffectComponent.__GenerateSlicedRopes_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060079F2 RID: 31218 RVA: 0x000B2F5D File Offset: 0x000B115D
		[SkipLocalsInit]
		public void DestroyRope()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, URopeEffectComponent.__DestroyRope_NativeFunctionPtr, null);
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x000B2F71 File Offset: 0x000B1171
		static URopeEffectComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRopeEffect.RopeEffectComponent");
		}

		// Token: 0x060079F4 RID: 31220 RVA: 0x000B2F7F File Offset: 0x000B117F
		protected URopeEffectComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040033C6 RID: 13254
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRopeEffect.RopeEffectComponent";

		// Token: 0x040033C7 RID: 13255
		private static IntPtr _ClassPtr;

		// Token: 0x040033C8 RID: 13256
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040033C9 RID: 13257
		internal static int __PropertyOffset_RopeDataAsset;

		// Token: 0x040033CA RID: 13258
		internal static int __PropertyOffset_bAutoFindSkeletalMesh;

		// Token: 0x040033CB RID: 13259
		internal static int __PropertyOffset_TargetSkeletalMeshComponent;

		// Token: 0x040033CC RID: 13260
		internal static int __PropertyOffset_CachedSkeletalMeshComponent;

		// Token: 0x040033CD RID: 13261
		internal static int __PropertyOffset_RopeSplineActor;

		// Token: 0x040033CE RID: 13262
		private static IntPtr __SetSkeletalMeshComponent_NativeFunctionPtr;

		// Token: 0x040033CF RID: 13263
		private static IntPtr __IsRopeValid_NativeFunctionPtr;

		// Token: 0x040033D0 RID: 13264
		private static IntPtr __GetSkeletalMeshComponent_NativeFunctionPtr;

		// Token: 0x040033D1 RID: 13265
		private static IntPtr __GetRopeActor_NativeFunctionPtr;

		// Token: 0x040033D2 RID: 13266
		private static IntPtr __GenerateSlicedRopes_NativeFunctionPtr;

		// Token: 0x040033D3 RID: 13267
		private static IntPtr __DestroyRope_NativeFunctionPtr;

		// Token: 0x02000C81 RID: 3201
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetSkeletalMeshComponent_FunctionParams
		{
			// Token: 0x04005EE3 RID: 24291
			[FieldOffset(0)]
			public IntPtr SkeletalMeshComp;
		}

		// Token: 0x02000C82 RID: 3202
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRopeValid_FunctionParams
		{
			// Token: 0x04005EE4 RID: 24292
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000C83 RID: 3203
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSkeletalMeshComponent_FunctionParams
		{
			// Token: 0x04005EE5 RID: 24293
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02000C84 RID: 3204
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetRopeActor_FunctionParams
		{
			// Token: 0x04005EE6 RID: 24294
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02000C85 RID: 3205
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GenerateSlicedRopes_FunctionParams
		{
			// Token: 0x04005EE7 RID: 24295
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
