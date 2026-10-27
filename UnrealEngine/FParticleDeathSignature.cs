using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F43 RID: 3907
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FParticleDeathSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D2B5 RID: 53941 RVA: 0x00134D25 File Offset: 0x00132F25
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FParticleDeathSignature.StaticFunctionPtr();
		}

		// Token: 0x0600D2B6 RID: 53942 RVA: 0x00134D31 File Offset: 0x00132F31
		private static IntPtr StaticFunctionPtr()
		{
			if (FParticleDeathSignature._FunctionPtr == IntPtr.Zero)
			{
				FParticleDeathSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ParticleDeathSignature__DelegateSignature");
			}
			return FParticleDeathSignature._FunctionPtr;
		}

		// Token: 0x0600D2B7 RID: 53943 RVA: 0x00134D54 File Offset: 0x00132F54
		public FParticleDeathSignature()
		{
		}

		// Token: 0x0600D2B8 RID: 53944 RVA: 0x00134D5C File Offset: 0x00132F5C
		[NullableContext(2)]
		public FParticleDeathSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D2B9 RID: 53945 RVA: 0x00134D66 File Offset: 0x00132F66
		public FParticleDeathSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D2BA RID: 53946 RVA: 0x00134D71 File Offset: 0x00132F71
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName, float, int, FVector, FVector, FVector>) ?? ((Action<FName, float, int, FVector, FVector, FVector>)Delegate.CreateDelegate(typeof(Action<FName, float, int, FVector, FVector, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D2BB RID: 53947 RVA: 0x00134DA3 File Offset: 0x00132FA3
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FName, float, int, FVector, FVector, FVector> Callback)
		{
			if (FParticleDeathSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FParticleDeathSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FParticleDeathSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FParticleDeathSignature.OnScriptCallback));
				}
				FParticleDeathSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FParticleDeathSignature.RegisterId);
		}

		// Token: 0x0600D2BC RID: 53948 RVA: 0x00134DDD File Offset: 0x00132FDD
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FName, float, int, FVector, FVector, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D2BD RID: 53949 RVA: 0x00134DE8 File Offset: 0x00132FE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FName EventName, float EmitterTime, int ParticleTime, FVector Location, FVector Velocity, FVector Direction)
		{
			FParticleDeathSignature.__FParticleDeathSignature_DelegateParams* ptr = stackalloc FParticleDeathSignature.__FParticleDeathSignature_DelegateParams[(UIntPtr)71] + 15L / (long)sizeof(FParticleDeathSignature.__FParticleDeathSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FParticleDeathSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EventName = EventName;
			ptr->EmitterTime = EmitterTime;
			ptr->ParticleTime = ParticleTime;
			ptr->Location = Location;
			ptr->Velocity = Velocity;
			ptr->Direction = Direction;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D2BE RID: 53950 RVA: 0x00134E4C File Offset: 0x0013304C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName, float, int, FVector, FVector, FVector> action = target as Action<FName, float, int, FVector, FVector, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FParticleDeathSignature.__FParticleDeathSignature_DelegateParams*)__Parameters)->EventName, ((FParticleDeathSignature.__FParticleDeathSignature_DelegateParams*)__Parameters)->EmitterTime, ((FParticleDeathSignature.__FParticleDeathSignature_DelegateParams*)__Parameters)->ParticleTime, ((FParticleDeathSignature.__FParticleDeathSignature_DelegateParams*)__Parameters)->Location, ((FParticleDeathSignature.__FParticleDeathSignature_DelegateParams*)__Parameters)->Velocity, ((FParticleDeathSignature.__FParticleDeathSignature_DelegateParams*)__Parameters)->Direction);
		}

		// Token: 0x04007107 RID: 28935
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007108 RID: 28936
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ParticleDeathSignature__DelegateSignature";

		// Token: 0x04007109 RID: 28937
		private static int RegisterId;

		// Token: 0x02002DB8 RID: 11704
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __FParticleDeathSignature_DelegateParams
		{
			// Token: 0x040167E7 RID: 92135
			[FieldOffset(0)]
			public FName EventName;

			// Token: 0x040167E8 RID: 92136
			[FieldOffset(12)]
			public float EmitterTime;

			// Token: 0x040167E9 RID: 92137
			[FieldOffset(16)]
			public int ParticleTime;

			// Token: 0x040167EA RID: 92138
			[FieldOffset(20)]
			public FVector Location;

			// Token: 0x040167EB RID: 92139
			[FieldOffset(32)]
			public FVector Velocity;

			// Token: 0x040167EC RID: 92140
			[FieldOffset(44)]
			public FVector Direction;
		}

		// Token: 0x02002DB9 RID: 11705
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167ED RID: 92141
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
