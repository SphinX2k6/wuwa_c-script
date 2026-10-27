using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CEF RID: 7407
	[UnrealObjectPath("/Script/KuroSimpleCombat.InstanceCapsuleComponent")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class UInstanceCapsuleComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C7E1 RID: 116705 RVA: 0x002A2216 File Offset: 0x002A0416
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInstanceCapsuleComponent._ClassPtr;
		}

		// Token: 0x0601C7E2 RID: 116706 RVA: 0x002A2224 File Offset: 0x002A0424
		public UInstanceCapsuleComponent() : this(BuiltinUtils.AllocNativeUObject(UInstanceCapsuleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C7E3 RID: 116707 RVA: 0x002A224C File Offset: 0x002A044C
		[NullableContext(1)]
		public UInstanceCapsuleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInstanceCapsuleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170072C9 RID: 29385
		// (get) Token: 0x0601C7E4 RID: 116708 RVA: 0x002A227F File Offset: 0x002A047F
		// (set) Token: 0x0601C7E5 RID: 116709 RVA: 0x002A228F File Offset: 0x002A048F
		public unsafe float CapsuleHalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInstanceCapsuleComponent.__PropertyOffset_CapsuleHalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInstanceCapsuleComponent.__PropertyOffset_CapsuleHalfHeight) = value;
			}
		}

		// Token: 0x170072CA RID: 29386
		// (get) Token: 0x0601C7E6 RID: 116710 RVA: 0x002A22A0 File Offset: 0x002A04A0
		// (set) Token: 0x0601C7E7 RID: 116711 RVA: 0x002A22B0 File Offset: 0x002A04B0
		public unsafe float CapsuleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInstanceCapsuleComponent.__PropertyOffset_CapsuleRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInstanceCapsuleComponent.__PropertyOffset_CapsuleRadius) = value;
			}
		}

		// Token: 0x170072CB RID: 29387
		// (get) Token: 0x0601C7E8 RID: 116712 RVA: 0x002A22C1 File Offset: 0x002A04C1
		// (set) Token: 0x0601C7E9 RID: 116713 RVA: 0x002A22D5 File Offset: 0x002A04D5
		[Nullable(2)]
		public unsafe UBodySetup ShapeBodySetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UInstanceCapsuleComponent.__PropertyOffset_ShapeBodySetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInstanceCapsuleComponent.__PropertyOffset_ShapeBodySetup, value);
			}
		}

		// Token: 0x0601C7EA RID: 116714 RVA: 0x002A22EC File Offset: 0x002A04EC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void UpdateInstanceTransforms(in TArray<int> InstanceIndices, in TArray<FTransform> InTransforms)
		{
			UInstanceCapsuleComponent.__UpdateInstanceTransforms_FunctionParams* ptr = stackalloc UInstanceCapsuleComponent.__UpdateInstanceTransforms_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UInstanceCapsuleComponent.__UpdateInstanceTransforms_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UInstanceCapsuleComponent.__UpdateInstanceTransforms_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = InstanceIndices;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InstanceIndices);
			}
			TArray<FTransform> tarray2 = InTransforms;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->InTransforms);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UInstanceCapsuleComponent.__UpdateInstanceTransforms_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray3 = InstanceIndices;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->InstanceIndices);
			}
			TArray<FTransform> tarray4 = InTransforms;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->InTransforms);
			}
			UnrealReflectionUtils.DestroyStruct(UInstanceCapsuleComponent.__UpdateInstanceTransforms_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C7EB RID: 116715 RVA: 0x002A2390 File Offset: 0x002A0590
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void UpdateInstanceBodyTransform(int InstanceIndex, in FTransform WorldSpaceInstanceTransform)
		{
			UInstanceCapsuleComponent.__UpdateInstanceBodyTransform_FunctionParams* ptr = stackalloc UInstanceCapsuleComponent.__UpdateInstanceBodyTransform_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UInstanceCapsuleComponent.__UpdateInstanceBodyTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UInstanceCapsuleComponent.__UpdateInstanceBodyTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InstanceIndex = InstanceIndex;
			ptr->WorldSpaceInstanceTransform = WorldSpaceInstanceTransform;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UInstanceCapsuleComponent.__UpdateInstanceBodyTransform_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C7EC RID: 116716 RVA: 0x002A23E3 File Offset: 0x002A05E3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ClearAllInstanceBodies()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UInstanceCapsuleComponent.__ClearAllInstanceBodies_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C7ED RID: 116717 RVA: 0x002A23F8 File Offset: 0x002A05F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int AddNewInstanceData(in FTransform WorldSpaceInstanceTransform)
		{
			UInstanceCapsuleComponent.__AddNewInstanceData_FunctionParams* ptr = stackalloc UInstanceCapsuleComponent.__AddNewInstanceData_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UInstanceCapsuleComponent.__AddNewInstanceData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UInstanceCapsuleComponent.__AddNewInstanceData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldSpaceInstanceTransform = WorldSpaceInstanceTransform;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UInstanceCapsuleComponent.__AddNewInstanceData_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C7EE RID: 116718 RVA: 0x002A244A File Offset: 0x002A064A
		static UInstanceCapsuleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.InstanceCapsuleComponent");
		}

		// Token: 0x0601C7EF RID: 116719 RVA: 0x002A2458 File Offset: 0x002A0658
		protected UInstanceCapsuleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F738 RID: 63288
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.InstanceCapsuleComponent";

		// Token: 0x0400F739 RID: 63289
		private static IntPtr _ClassPtr;

		// Token: 0x0400F73A RID: 63290
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F73B RID: 63291
		internal static int __PropertyOffset_CapsuleHalfHeight;

		// Token: 0x0400F73C RID: 63292
		internal static int __PropertyOffset_CapsuleRadius;

		// Token: 0x0400F73D RID: 63293
		internal static int __PropertyOffset_ShapeBodySetup;

		// Token: 0x0400F73E RID: 63294
		private static IntPtr __UpdateInstanceTransforms_NativeFunctionPtr;

		// Token: 0x0400F73F RID: 63295
		private static IntPtr __UpdateInstanceBodyTransform_NativeFunctionPtr;

		// Token: 0x0400F740 RID: 63296
		private static IntPtr __ClearAllInstanceBodies_NativeFunctionPtr;

		// Token: 0x0400F741 RID: 63297
		private static IntPtr __AddNewInstanceData_NativeFunctionPtr;

		// Token: 0x02003296 RID: 12950
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UpdateInstanceTransforms_FunctionParams
		{
			// Token: 0x04017125 RID: 94501
			[FieldOffset(0)]
			public byte InstanceIndices;

			// Token: 0x04017126 RID: 94502
			[FieldOffset(16)]
			public byte InTransforms;
		}

		// Token: 0x02003297 RID: 12951
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __UpdateInstanceBodyTransform_FunctionParams
		{
			// Token: 0x04017127 RID: 94503
			[FieldOffset(0)]
			public int InstanceIndex;

			// Token: 0x04017128 RID: 94504
			[FieldOffset(16)]
			public FTransform WorldSpaceInstanceTransform;
		}

		// Token: 0x02003298 RID: 12952
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __AddNewInstanceData_FunctionParams
		{
			// Token: 0x04017129 RID: 94505
			[FieldOffset(0)]
			public FTransform WorldSpaceInstanceTransform;

			// Token: 0x0401712A RID: 94506
			[FieldOffset(48)]
			public int __Result;
		}
	}
}
