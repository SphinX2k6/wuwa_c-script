using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F41 RID: 3905
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FParticleCollisionSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D29F RID: 53919 RVA: 0x00134A8E File Offset: 0x00132C8E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FParticleCollisionSignature.StaticFunctionPtr();
		}

		// Token: 0x0600D2A0 RID: 53920 RVA: 0x00134A9A File Offset: 0x00132C9A
		private static IntPtr StaticFunctionPtr()
		{
			if (FParticleCollisionSignature._FunctionPtr == IntPtr.Zero)
			{
				FParticleCollisionSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ParticleCollisionSignature__DelegateSignature");
			}
			return FParticleCollisionSignature._FunctionPtr;
		}

		// Token: 0x0600D2A1 RID: 53921 RVA: 0x00134ABD File Offset: 0x00132CBD
		public FParticleCollisionSignature()
		{
		}

		// Token: 0x0600D2A2 RID: 53922 RVA: 0x00134AC5 File Offset: 0x00132CC5
		[NullableContext(2)]
		public FParticleCollisionSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D2A3 RID: 53923 RVA: 0x00134ACF File Offset: 0x00132CCF
		public FParticleCollisionSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D2A4 RID: 53924 RVA: 0x00134ADA File Offset: 0x00132CDA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName, float, int, FVector, FVector, FVector, FVector, FName, UPhysicalMaterial>) ?? ((Action<FName, float, int, FVector, FVector, FVector, FVector, FName, UPhysicalMaterial>)Delegate.CreateDelegate(typeof(Action<FName, float, int, FVector, FVector, FVector, FVector, FName, UPhysicalMaterial>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D2A5 RID: 53925 RVA: 0x00134B0C File Offset: 0x00132D0C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<FName, float, int, FVector, FVector, FVector, FVector, FName, UPhysicalMaterial> Callback)
		{
			if (FParticleCollisionSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FParticleCollisionSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FParticleCollisionSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FParticleCollisionSignature.OnScriptCallback));
				}
				FParticleCollisionSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FParticleCollisionSignature.RegisterId);
		}

		// Token: 0x0600D2A6 RID: 53926 RVA: 0x00134B46 File Offset: 0x00132D46
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<FName, float, int, FVector, FVector, FVector, FVector, FName, UPhysicalMaterial> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D2A7 RID: 53927 RVA: 0x00134B50 File Offset: 0x00132D50
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FName EventName, float EmitterTime, int ParticleTime, FVector Location, FVector Velocity, FVector Direction, FVector Normal, FName BoneName, UPhysicalMaterial PhysMat)
		{
			FParticleCollisionSignature.__FParticleCollisionSignature_DelegateParams* ptr = stackalloc FParticleCollisionSignature.__FParticleCollisionSignature_DelegateParams[(UIntPtr)103] + 15L / (long)sizeof(FParticleCollisionSignature.__FParticleCollisionSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FParticleCollisionSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EventName = EventName;
			ptr->EmitterTime = EmitterTime;
			ptr->ParticleTime = ParticleTime;
			ptr->Location = Location;
			ptr->Velocity = Velocity;
			ptr->Direction = Direction;
			ptr->Normal = Normal;
			ptr->BoneName = BoneName;
			ptr->PhysMat = ((PhysMat != null) ? PhysMat.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D2A8 RID: 53928 RVA: 0x00134BDC File Offset: 0x00132DDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName, float, int, FVector, FVector, FVector, FVector, FName, UPhysicalMaterial> action = target as Action<FName, float, int, FVector, FVector, FVector, FVector, FName, UPhysicalMaterial>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPhysicalMaterial orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterial>(((FParticleCollisionSignature.__FParticleCollisionSignature_DelegateParams*)__Parameters)->PhysMat);
			action(((FParticleCollisionSignature.__FParticleCollisionSignature_DelegateParams*)__Parameters)->EventName, ((FParticleCollisionSignature.__FParticleCollisionSignature_DelegateParams*)__Parameters)->EmitterTime, ((FParticleCollisionSignature.__FParticleCollisionSignature_DelegateParams*)__Parameters)->ParticleTime, ((FParticleCollisionSignature.__FParticleCollisionSignature_DelegateParams*)__Parameters)->Location, ((FParticleCollisionSignature.__FParticleCollisionSignature_DelegateParams*)__Parameters)->Velocity, ((FParticleCollisionSignature.__FParticleCollisionSignature_DelegateParams*)__Parameters)->Direction, ((FParticleCollisionSignature.__FParticleCollisionSignature_DelegateParams*)__Parameters)->Normal, ((FParticleCollisionSignature.__FParticleCollisionSignature_DelegateParams*)__Parameters)->BoneName, orCreateUObjectByNativePointer);
		}

		// Token: 0x04007100 RID: 28928
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007101 RID: 28929
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ParticleCollisionSignature__DelegateSignature";

		// Token: 0x04007102 RID: 28930
		private static int RegisterId;

		// Token: 0x02002DB6 RID: 11702
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __FParticleCollisionSignature_DelegateParams
		{
			// Token: 0x040167DD RID: 92125
			[FieldOffset(0)]
			public FName EventName;

			// Token: 0x040167DE RID: 92126
			[FieldOffset(12)]
			public float EmitterTime;

			// Token: 0x040167DF RID: 92127
			[FieldOffset(16)]
			public int ParticleTime;

			// Token: 0x040167E0 RID: 92128
			[FieldOffset(20)]
			public FVector Location;

			// Token: 0x040167E1 RID: 92129
			[FieldOffset(32)]
			public FVector Velocity;

			// Token: 0x040167E2 RID: 92130
			[FieldOffset(44)]
			public FVector Direction;

			// Token: 0x040167E3 RID: 92131
			[FieldOffset(56)]
			public FVector Normal;

			// Token: 0x040167E4 RID: 92132
			[FieldOffset(68)]
			public FName BoneName;

			// Token: 0x040167E5 RID: 92133
			[FieldOffset(80)]
			public IntPtr PhysMat;
		}

		// Token: 0x02002DB7 RID: 11703
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167E6 RID: 92134
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
