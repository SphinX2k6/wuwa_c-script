using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000350 RID: 848
	[UnrealObjectPath("/Script/ApexDestruction.DestructibleComponent")]
	[UnrealStructLayout(2848, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2848)]
	public class UDestructibleComponent : USkinnedMeshComponent, IUnrealUObject, IUnrealObject, IDestructibleInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06002F09 RID: 12041 RVA: 0x00047F67 File Offset: 0x00046167
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDestructibleComponent._ClassPtr;
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x00047F73 File Offset: 0x00046173
		int IDestructibleInterface.InterfaceOffset()
		{
			return UDestructibleComponent.__InterfaceOffset_IDestructibleInterface;
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x00047F7C File Offset: 0x0004617C
		public UDestructibleComponent() : this(BuiltinUtils.AllocNativeUObject(UDestructibleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x00047FA4 File Offset: 0x000461A4
		[NullableContext(1)]
		public UDestructibleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDestructibleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06002F0D RID: 12045 RVA: 0x00047FD7 File Offset: 0x000461D7
		// (set) Token: 0x06002F0E RID: 12046 RVA: 0x00047FF0 File Offset: 0x000461F0
		public unsafe bool bFractureEffectOverride
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDestructibleComponent.__PropertyOffset_bFractureEffectOverride) & UDestructibleComponent.__PropertyMask_bFractureEffectOverride) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDestructibleComponent.__PropertyOffset_bFractureEffectOverride) = ((*(base.NativePtr + (IntPtr)UDestructibleComponent.__PropertyOffset_bFractureEffectOverride) & ~UDestructibleComponent.__PropertyMask_bFractureEffectOverride) | (value ? UDestructibleComponent.__PropertyMask_bFractureEffectOverride : 0));
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x00048020 File Offset: 0x00046220
		// (set) Token: 0x06002F10 RID: 12048 RVA: 0x00048059 File Offset: 0x00046259
		[Nullable(1)]
		public TArray<FFractureEffect> FractureEffects
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FFractureEffect> result;
				if ((result = this._FractureEffects) == null)
				{
					result = (this._FractureEffects = new TArray<FFractureEffect>(base.NativePtr + (IntPtr)UDestructibleComponent.__PropertyOffset_FractureEffects, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FractureEffects.CopyAssign(value);
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x00048067 File Offset: 0x00046267
		// (set) Token: 0x06002F12 RID: 12050 RVA: 0x00048077 File Offset: 0x00046277
		public unsafe bool bEnableHardSleeping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDestructibleComponent.__PropertyOffset_bEnableHardSleeping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDestructibleComponent.__PropertyOffset_bEnableHardSleeping) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x00048088 File Offset: 0x00046288
		// (set) Token: 0x06002F14 RID: 12052 RVA: 0x00048098 File Offset: 0x00046298
		public unsafe float LargeChunkThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDestructibleComponent.__PropertyOffset_LargeChunkThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDestructibleComponent.__PropertyOffset_LargeChunkThreshold) = value;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x000480AC File Offset: 0x000462AC
		// (set) Token: 0x06002F16 RID: 12054 RVA: 0x000480E5 File Offset: 0x000462E5
		[Nullable(1)]
		public FComponentFractureSignature OnComponentFracture
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FComponentFractureSignature result;
				if ((result = this._OnComponentFracture) == null)
				{
					result = (this._OnComponentFracture = new FComponentFractureSignature(base.NativePtr + (IntPtr)UDestructibleComponent.__PropertyOffset_OnComponentFracture, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UDestructibleComponent.__PropertyOffset_OnComponentFracture, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x00048108 File Offset: 0x00046308
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetDestructibleMesh(UDestructibleMesh NewMesh)
		{
			UDestructibleComponent.__SetDestructibleMesh_FunctionParams* ptr = stackalloc UDestructibleComponent.__SetDestructibleMesh_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UDestructibleComponent.__SetDestructibleMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDestructibleComponent.__SetDestructibleMesh_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewMesh = ((NewMesh != null) ? NewMesh.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDestructibleComponent.__SetDestructibleMesh_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x00048160 File Offset: 0x00046360
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UDestructibleMesh GetDestructibleMesh()
		{
			UDestructibleComponent.__GetDestructibleMesh_FunctionParams* ptr = stackalloc UDestructibleComponent.__GetDestructibleMesh_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UDestructibleComponent.__GetDestructibleMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDestructibleComponent.__GetDestructibleMesh_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDestructibleComponent.__GetDestructibleMesh_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UDestructibleMesh>(ptr->__Result);
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x000481AC File Offset: 0x000463AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void D_ApplyRadiusDamage(float BaseDamage, in FVectorDouble HurtOrigin, float DamageRadius, float ImpulseStrength, bool bFullDamage)
		{
			UDestructibleComponent.__D_ApplyRadiusDamage_FunctionParams* ptr = stackalloc UDestructibleComponent.__D_ApplyRadiusDamage_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UDestructibleComponent.__D_ApplyRadiusDamage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDestructibleComponent.__D_ApplyRadiusDamage_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BaseDamage = BaseDamage;
			ptr->HurtOrigin = HurtOrigin;
			ptr->DamageRadius = DamageRadius;
			ptr->ImpulseStrength = ImpulseStrength;
			ptr->bFullDamage = bFullDamage;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDestructibleComponent.__D_ApplyRadiusDamage_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x00048218 File Offset: 0x00046418
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void D_ApplyDamage(float DamageAmount, in FVectorDouble HitLocation, in FVectorDouble ImpulseDir, float ImpulseStrength)
		{
			UDestructibleComponent.__D_ApplyDamage_FunctionParams* ptr = stackalloc UDestructibleComponent.__D_ApplyDamage_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UDestructibleComponent.__D_ApplyDamage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDestructibleComponent.__D_ApplyDamage_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DamageAmount = DamageAmount;
			ptr->HitLocation = HitLocation;
			ptr->ImpulseDir = ImpulseDir;
			ptr->ImpulseStrength = ImpulseStrength;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDestructibleComponent.__D_ApplyDamage_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x00048280 File Offset: 0x00046480
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void ApplyRadiusDamage(float BaseDamage, in FVector HurtOrigin, float DamageRadius, float ImpulseStrength, bool bFullDamage)
		{
			UDestructibleComponent.__ApplyRadiusDamage_FunctionParams* ptr = stackalloc UDestructibleComponent.__ApplyRadiusDamage_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(UDestructibleComponent.__ApplyRadiusDamage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDestructibleComponent.__ApplyRadiusDamage_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BaseDamage = BaseDamage;
			ptr->HurtOrigin = HurtOrigin;
			ptr->DamageRadius = DamageRadius;
			ptr->ImpulseStrength = ImpulseStrength;
			ptr->bFullDamage = bFullDamage;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDestructibleComponent.__ApplyRadiusDamage_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x000482EC File Offset: 0x000464EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void ApplyDamage(float DamageAmount, in FVector HitLocation, in FVector ImpulseDir, float ImpulseStrength)
		{
			UDestructibleComponent.__ApplyDamage_FunctionParams* ptr = stackalloc UDestructibleComponent.__ApplyDamage_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UDestructibleComponent.__ApplyDamage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDestructibleComponent.__ApplyDamage_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DamageAmount = DamageAmount;
			ptr->HitLocation = HitLocation;
			ptr->ImpulseDir = ImpulseDir;
			ptr->ImpulseStrength = ImpulseStrength;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDestructibleComponent.__ApplyDamage_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x00048354 File Offset: 0x00046554
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void AddForceToChunk(FVector Force, bool bAccelChange = false)
		{
			UDestructibleComponent.__AddForceToChunk_FunctionParams* ptr = stackalloc UDestructibleComponent.__AddForceToChunk_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UDestructibleComponent.__AddForceToChunk_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDestructibleComponent.__AddForceToChunk_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Force = Force;
			ptr->bAccelChange = bAccelChange;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDestructibleComponent.__AddForceToChunk_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x000483A2 File Offset: 0x000465A2
		static UDestructibleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ApexDestruction.DestructibleComponent");
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x000483B0 File Offset: 0x000465B0
		protected UDestructibleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001442 RID: 5186
		internal static int __InterfaceOffset_IDestructibleInterface;

		// Token: 0x04001443 RID: 5187
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ApexDestruction.DestructibleComponent";

		// Token: 0x04001444 RID: 5188
		private static IntPtr _ClassPtr;

		// Token: 0x04001445 RID: 5189
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001446 RID: 5190
		internal static int __PropertyOffset_bFractureEffectOverride;

		// Token: 0x04001447 RID: 5191
		internal static byte __PropertyMask_bFractureEffectOverride;

		// Token: 0x04001448 RID: 5192
		internal static int __PropertyOffset_FractureEffects;

		// Token: 0x04001449 RID: 5193
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFractureEffect> _FractureEffects;

		// Token: 0x0400144A RID: 5194
		internal static int __PropertyOffset_bEnableHardSleeping;

		// Token: 0x0400144B RID: 5195
		internal static int __PropertyOffset_LargeChunkThreshold;

		// Token: 0x0400144C RID: 5196
		internal static int __PropertyOffset_OnComponentFracture;

		// Token: 0x0400144D RID: 5197
		[Nullable(2)]
		private FComponentFractureSignature _OnComponentFracture;

		// Token: 0x0400144E RID: 5198
		private static IntPtr __SetDestructibleMesh_NativeFunctionPtr;

		// Token: 0x0400144F RID: 5199
		private static IntPtr __GetDestructibleMesh_NativeFunctionPtr;

		// Token: 0x04001450 RID: 5200
		private static IntPtr __D_ApplyRadiusDamage_NativeFunctionPtr;

		// Token: 0x04001451 RID: 5201
		private static IntPtr __D_ApplyDamage_NativeFunctionPtr;

		// Token: 0x04001452 RID: 5202
		private static IntPtr __ApplyRadiusDamage_NativeFunctionPtr;

		// Token: 0x04001453 RID: 5203
		private static IntPtr __ApplyDamage_NativeFunctionPtr;

		// Token: 0x04001454 RID: 5204
		private static IntPtr __AddForceToChunk_NativeFunctionPtr;

		// Token: 0x02002BD4 RID: 11220
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetDestructibleMesh_FunctionParams
		{
			// Token: 0x04016491 RID: 91281
			[FieldOffset(0)]
			public IntPtr NewMesh;
		}

		// Token: 0x02002BD5 RID: 11221
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetDestructibleMesh_FunctionParams
		{
			// Token: 0x04016492 RID: 91282
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02002BD6 RID: 11222
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __D_ApplyRadiusDamage_FunctionParams
		{
			// Token: 0x04016493 RID: 91283
			[FieldOffset(0)]
			public float BaseDamage;

			// Token: 0x04016494 RID: 91284
			[FieldOffset(8)]
			public FVectorDouble HurtOrigin;

			// Token: 0x04016495 RID: 91285
			[FieldOffset(32)]
			public float DamageRadius;

			// Token: 0x04016496 RID: 91286
			[FieldOffset(36)]
			public float ImpulseStrength;

			// Token: 0x04016497 RID: 91287
			[FieldOffset(40)]
			public bool bFullDamage;
		}

		// Token: 0x02002BD7 RID: 11223
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __D_ApplyDamage_FunctionParams
		{
			// Token: 0x04016498 RID: 91288
			[FieldOffset(0)]
			public float DamageAmount;

			// Token: 0x04016499 RID: 91289
			[FieldOffset(8)]
			public FVectorDouble HitLocation;

			// Token: 0x0401649A RID: 91290
			[FieldOffset(32)]
			public FVectorDouble ImpulseDir;

			// Token: 0x0401649B RID: 91291
			[FieldOffset(56)]
			public float ImpulseStrength;
		}

		// Token: 0x02002BD8 RID: 11224
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __ApplyRadiusDamage_FunctionParams
		{
			// Token: 0x0401649C RID: 91292
			[FieldOffset(0)]
			public float BaseDamage;

			// Token: 0x0401649D RID: 91293
			[FieldOffset(4)]
			public FVector HurtOrigin;

			// Token: 0x0401649E RID: 91294
			[FieldOffset(16)]
			public float DamageRadius;

			// Token: 0x0401649F RID: 91295
			[FieldOffset(20)]
			public float ImpulseStrength;

			// Token: 0x040164A0 RID: 91296
			[FieldOffset(24)]
			public bool bFullDamage;
		}

		// Token: 0x02002BD9 RID: 11225
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ApplyDamage_FunctionParams
		{
			// Token: 0x040164A1 RID: 91297
			[FieldOffset(0)]
			public float DamageAmount;

			// Token: 0x040164A2 RID: 91298
			[FieldOffset(4)]
			public FVector HitLocation;

			// Token: 0x040164A3 RID: 91299
			[FieldOffset(16)]
			public FVector ImpulseDir;

			// Token: 0x040164A4 RID: 91300
			[FieldOffset(28)]
			public float ImpulseStrength;
		}

		// Token: 0x02002BDA RID: 11226
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __AddForceToChunk_FunctionParams
		{
			// Token: 0x040164A5 RID: 91301
			[FieldOffset(0)]
			public FVector Force;

			// Token: 0x040164A6 RID: 91302
			[FieldOffset(12)]
			public bool bAccelChange;
		}
	}
}
