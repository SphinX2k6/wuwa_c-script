using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FC1 RID: 4033
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FParticleSpawnSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D90E RID: 55566 RVA: 0x0014063E File Offset: 0x0013E83E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FParticleSpawnSignature.StaticFunctionPtr();
		}

		// Token: 0x0600D90F RID: 55567 RVA: 0x0014064A File Offset: 0x0013E84A
		private static IntPtr StaticFunctionPtr()
		{
			if (FParticleSpawnSignature._FunctionPtr == IntPtr.Zero)
			{
				FParticleSpawnSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ParticleSpawnSignature__DelegateSignature");
			}
			return FParticleSpawnSignature._FunctionPtr;
		}

		// Token: 0x0600D910 RID: 55568 RVA: 0x0014066D File Offset: 0x0013E86D
		public FParticleSpawnSignature()
		{
		}

		// Token: 0x0600D911 RID: 55569 RVA: 0x00140675 File Offset: 0x0013E875
		[NullableContext(2)]
		public FParticleSpawnSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D912 RID: 55570 RVA: 0x0014067F File Offset: 0x0013E87F
		public FParticleSpawnSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D913 RID: 55571 RVA: 0x0014068A File Offset: 0x0013E88A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName, float, FVector, FVector>) ?? ((Action<FName, float, FVector, FVector>)Delegate.CreateDelegate(typeof(Action<FName, float, FVector, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D914 RID: 55572 RVA: 0x001406BC File Offset: 0x0013E8BC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FName, float, FVector, FVector> Callback)
		{
			if (FParticleSpawnSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FParticleSpawnSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FParticleSpawnSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FParticleSpawnSignature.OnScriptCallback));
				}
				FParticleSpawnSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FParticleSpawnSignature.RegisterId);
		}

		// Token: 0x0600D915 RID: 55573 RVA: 0x001406F6 File Offset: 0x0013E8F6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FName, float, FVector, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D916 RID: 55574 RVA: 0x00140700 File Offset: 0x0013E900
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FName EventName, float EmitterTime, FVector Location, FVector Velocity)
		{
			FParticleSpawnSignature.__FParticleSpawnSignature_DelegateParams* ptr = stackalloc FParticleSpawnSignature.__FParticleSpawnSignature_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FParticleSpawnSignature.__FParticleSpawnSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FParticleSpawnSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EventName = EventName;
			ptr->EmitterTime = EmitterTime;
			ptr->Location = Location;
			ptr->Velocity = Velocity;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D917 RID: 55575 RVA: 0x00140754 File Offset: 0x0013E954
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName, float, FVector, FVector> action = target as Action<FName, float, FVector, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FParticleSpawnSignature.__FParticleSpawnSignature_DelegateParams*)__Parameters)->EventName, ((FParticleSpawnSignature.__FParticleSpawnSignature_DelegateParams*)__Parameters)->EmitterTime, ((FParticleSpawnSignature.__FParticleSpawnSignature_DelegateParams*)__Parameters)->Location, ((FParticleSpawnSignature.__FParticleSpawnSignature_DelegateParams*)__Parameters)->Velocity);
		}

		// Token: 0x040075B3 RID: 30131
		internal static IntPtr _FunctionPtr;

		// Token: 0x040075B4 RID: 30132
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ParticleSpawnSignature__DelegateSignature";

		// Token: 0x040075B5 RID: 30133
		private static int RegisterId;

		// Token: 0x02002DBA RID: 11706
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FParticleSpawnSignature_DelegateParams
		{
			// Token: 0x040167EE RID: 92142
			[FieldOffset(0)]
			public FName EventName;

			// Token: 0x040167EF RID: 92143
			[FieldOffset(12)]
			public float EmitterTime;

			// Token: 0x040167F0 RID: 92144
			[FieldOffset(16)]
			public FVector Location;

			// Token: 0x040167F1 RID: 92145
			[FieldOffset(28)]
			public FVector Velocity;
		}

		// Token: 0x02002DBB RID: 11707
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167F2 RID: 92146
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
