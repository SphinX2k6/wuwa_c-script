using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F40 RID: 3904
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FParticleBurstSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D295 RID: 53909 RVA: 0x0013492B File Offset: 0x00132B2B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FParticleBurstSignature.StaticFunctionPtr();
		}

		// Token: 0x0600D296 RID: 53910 RVA: 0x00134937 File Offset: 0x00132B37
		private static IntPtr StaticFunctionPtr()
		{
			if (FParticleBurstSignature._FunctionPtr == IntPtr.Zero)
			{
				FParticleBurstSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ParticleBurstSignature__DelegateSignature");
			}
			return FParticleBurstSignature._FunctionPtr;
		}

		// Token: 0x0600D297 RID: 53911 RVA: 0x0013495A File Offset: 0x00132B5A
		public FParticleBurstSignature()
		{
		}

		// Token: 0x0600D298 RID: 53912 RVA: 0x00134962 File Offset: 0x00132B62
		[NullableContext(2)]
		public FParticleBurstSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D299 RID: 53913 RVA: 0x0013496C File Offset: 0x00132B6C
		public FParticleBurstSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D29A RID: 53914 RVA: 0x00134977 File Offset: 0x00132B77
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName, float, int>) ?? ((Action<FName, float, int>)Delegate.CreateDelegate(typeof(Action<FName, float, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D29B RID: 53915 RVA: 0x001349A9 File Offset: 0x00132BA9
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FName, float, int> Callback)
		{
			if (FParticleBurstSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FParticleBurstSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FParticleBurstSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FParticleBurstSignature.OnScriptCallback));
				}
				FParticleBurstSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FParticleBurstSignature.RegisterId);
		}

		// Token: 0x0600D29C RID: 53916 RVA: 0x001349E3 File Offset: 0x00132BE3
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FName, float, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D29D RID: 53917 RVA: 0x001349EC File Offset: 0x00132BEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FName EventName, float EmitterTime, int ParticleCount)
		{
			FParticleBurstSignature.__FParticleBurstSignature_DelegateParams* ptr = stackalloc FParticleBurstSignature.__FParticleBurstSignature_DelegateParams[(UIntPtr)35] + 15L / (long)sizeof(FParticleBurstSignature.__FParticleBurstSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FParticleBurstSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EventName = EventName;
			ptr->EmitterTime = EmitterTime;
			ptr->ParticleCount = ParticleCount;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D29E RID: 53918 RVA: 0x00134A38 File Offset: 0x00132C38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName, float, int> action = target as Action<FName, float, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FParticleBurstSignature.__FParticleBurstSignature_DelegateParams*)__Parameters)->EventName, ((FParticleBurstSignature.__FParticleBurstSignature_DelegateParams*)__Parameters)->EmitterTime, ((FParticleBurstSignature.__FParticleBurstSignature_DelegateParams*)__Parameters)->ParticleCount);
		}

		// Token: 0x040070FD RID: 28925
		internal static IntPtr _FunctionPtr;

		// Token: 0x040070FE RID: 28926
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ParticleBurstSignature__DelegateSignature";

		// Token: 0x040070FF RID: 28927
		private static int RegisterId;

		// Token: 0x02002DB4 RID: 11700
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __FParticleBurstSignature_DelegateParams
		{
			// Token: 0x040167D9 RID: 92121
			[FieldOffset(0)]
			public FName EventName;

			// Token: 0x040167DA RID: 92122
			[FieldOffset(12)]
			public float EmitterTime;

			// Token: 0x040167DB RID: 92123
			[FieldOffset(16)]
			public int ParticleCount;
		}

		// Token: 0x02002DB5 RID: 11701
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167DC RID: 92124
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
