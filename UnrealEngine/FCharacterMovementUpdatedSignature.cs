using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A2 RID: 418
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FCharacterMovementUpdatedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001EDF RID: 7903 RVA: 0x0002D072 File Offset: 0x0002B272
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCharacterMovementUpdatedSignature.StaticFunctionPtr();
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x0002D07E File Offset: 0x0002B27E
		private static IntPtr StaticFunctionPtr()
		{
			if (FCharacterMovementUpdatedSignature._FunctionPtr == IntPtr.Zero)
			{
				FCharacterMovementUpdatedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.CharacterMovementUpdatedSignature__DelegateSignature");
			}
			return FCharacterMovementUpdatedSignature._FunctionPtr;
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0002D0A1 File Offset: 0x0002B2A1
		public FCharacterMovementUpdatedSignature()
		{
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x0002D0A9 File Offset: 0x0002B2A9
		[NullableContext(2)]
		public FCharacterMovementUpdatedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x0002D0B3 File Offset: 0x0002B2B3
		public FCharacterMovementUpdatedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x0002D0BE File Offset: 0x0002B2BE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float, FVector, FVector>) ?? ((Action<float, FVector, FVector>)Delegate.CreateDelegate(typeof(Action<float, FVector, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x0002D0F0 File Offset: 0x0002B2F0
		[NullableContext(1)]
		public void Add(Action<float, FVector, FVector> Callback)
		{
			if (FCharacterMovementUpdatedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCharacterMovementUpdatedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCharacterMovementUpdatedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCharacterMovementUpdatedSignature.OnScriptCallback));
				}
				FCharacterMovementUpdatedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FCharacterMovementUpdatedSignature.RegisterId);
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x0002D12A File Offset: 0x0002B32A
		[NullableContext(1)]
		public void Remove(Action<float, FVector, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x0002D134 File Offset: 0x0002B334
		[SkipLocalsInit]
		public unsafe void Broadcast(float DeltaSeconds, FVector OldLocation, FVector OldVelocity)
		{
			FCharacterMovementUpdatedSignature.__FCharacterMovementUpdatedSignature_DelegateParams* ptr = stackalloc FCharacterMovementUpdatedSignature.__FCharacterMovementUpdatedSignature_DelegateParams[(UIntPtr)43] + 15L / (long)sizeof(FCharacterMovementUpdatedSignature.__FCharacterMovementUpdatedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FCharacterMovementUpdatedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->OldLocation = OldLocation;
			ptr->OldVelocity = OldVelocity;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x0002D180 File Offset: 0x0002B380
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float, FVector, FVector> action = target as Action<float, FVector, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FCharacterMovementUpdatedSignature.__FCharacterMovementUpdatedSignature_DelegateParams*)__Parameters)->DeltaSeconds, ((FCharacterMovementUpdatedSignature.__FCharacterMovementUpdatedSignature_DelegateParams*)__Parameters)->OldLocation, ((FCharacterMovementUpdatedSignature.__FCharacterMovementUpdatedSignature_DelegateParams*)__Parameters)->OldVelocity);
		}

		// Token: 0x04000A5A RID: 2650
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000A5B RID: 2651
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CharacterMovementUpdatedSignature__DelegateSignature";

		// Token: 0x04000A5C RID: 2652
		private static int RegisterId;

		// Token: 0x02000978 RID: 2424
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		private ref struct __FCharacterMovementUpdatedSignature_DelegateParams
		{
			// Token: 0x040058C0 RID: 22720
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x040058C1 RID: 22721
			[FieldOffset(4)]
			public FVector OldLocation;

			// Token: 0x040058C2 RID: 22722
			[FieldOffset(16)]
			public FVector OldVelocity;
		}

		// Token: 0x02000979 RID: 2425
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058C3 RID: 22723
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
