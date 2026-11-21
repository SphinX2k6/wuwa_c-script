using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001AF RID: 431
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentConveyBaseMovementSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002006 RID: 8198 RVA: 0x0002E977 File Offset: 0x0002CB77
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentConveyBaseMovementSignature.StaticFunctionPtr();
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x0002E983 File Offset: 0x0002CB83
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentConveyBaseMovementSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentConveyBaseMovementSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentConveyBaseMovementSignature__DelegateSignature");
			}
			return FComponentConveyBaseMovementSignature._FunctionPtr;
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x0002E9A6 File Offset: 0x0002CBA6
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnConveyBase;
			}
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x0002E9AD File Offset: 0x0002CBAD
		[NullableContext(2)]
		public FComponentConveyBaseMovementSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x0002E9B7 File Offset: 0x0002CBB7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float, FVector, UCharacterMovementComponent>) ?? ((Action<float, FVector, UCharacterMovementComponent>)Delegate.CreateDelegate(typeof(Action<float, FVector, UCharacterMovementComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x0002E9EC File Offset: 0x0002CBEC
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<float, FVector, UCharacterMovementComponent> Callback)
		{
			if (FComponentConveyBaseMovementSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentConveyBaseMovementSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentConveyBaseMovementSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentConveyBaseMovementSignature.OnScriptCallback));
				}
				FComponentConveyBaseMovementSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentConveyBaseMovementSignature.RegisterId);
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x0002EA3C File Offset: 0x0002CC3C
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<float, FVector, UCharacterMovementComponent> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x0002EA5C File Offset: 0x0002CC5C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(float DeltaSeconds, FVector FloorLocation, UCharacterMovementComponent CharacterMovement)
		{
			FComponentConveyBaseMovementSignature.__FComponentConveyBaseMovementSignature_DelegateParams* ptr = stackalloc FComponentConveyBaseMovementSignature.__FComponentConveyBaseMovementSignature_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FComponentConveyBaseMovementSignature.__FComponentConveyBaseMovementSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentConveyBaseMovementSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->FloorLocation = FloorLocation;
			ptr->CharacterMovement = ((CharacterMovement != null) ? CharacterMovement.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x0002EAC8 File Offset: 0x0002CCC8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float, FVector, UCharacterMovementComponent> action = target as Action<float, FVector, UCharacterMovementComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UCharacterMovementComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCharacterMovementComponent>(((FComponentConveyBaseMovementSignature.__FComponentConveyBaseMovementSignature_DelegateParams*)__Parameters)->CharacterMovement);
			action(((FComponentConveyBaseMovementSignature.__FComponentConveyBaseMovementSignature_DelegateParams*)__Parameters)->DeltaSeconds, ((FComponentConveyBaseMovementSignature.__FComponentConveyBaseMovementSignature_DelegateParams*)__Parameters)->FloorLocation, orCreateUObjectByNativePointer);
		}

		// Token: 0x04000AA6 RID: 2726
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000AA7 RID: 2727
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentConveyBaseMovementSignature__DelegateSignature";

		// Token: 0x04000AA8 RID: 2728
		private static int RegisterId;

		// Token: 0x02000985 RID: 2437
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FComponentConveyBaseMovementSignature_DelegateParams
		{
			// Token: 0x040058DC RID: 22748
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x040058DD RID: 22749
			[FieldOffset(4)]
			public FVector FloorLocation;

			// Token: 0x040058DE RID: 22750
			[FieldOffset(16)]
			public IntPtr CharacterMovement;
		}

		// Token: 0x02000986 RID: 2438
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058DF RID: 22751
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
