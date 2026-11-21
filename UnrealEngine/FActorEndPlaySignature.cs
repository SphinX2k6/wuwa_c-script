using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200016B RID: 363
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorEndPlaySignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001664 RID: 5732 RVA: 0x00022937 File Offset: 0x00020B37
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorEndPlaySignature.StaticFunctionPtr();
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00022943 File Offset: 0x00020B43
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorEndPlaySignature._FunctionPtr == IntPtr.Zero)
			{
				FActorEndPlaySignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorEndPlaySignature__DelegateSignature");
			}
			return FActorEndPlaySignature._FunctionPtr;
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x00022966 File Offset: 0x00020B66
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnEndPlay;
			}
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x0002296D File Offset: 0x00020B6D
		[NullableContext(2)]
		public FActorEndPlaySignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00022977 File Offset: 0x00020B77
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, TEnumAsByte<EEndPlayReason>>) ?? ((Action<AActor, TEnumAsByte<EEndPlayReason>>)Delegate.CreateDelegate(typeof(Action<AActor, TEnumAsByte<EEndPlayReason>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x000229AC File Offset: 0x00020BAC
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			0
		})] Action<AActor, TEnumAsByte<EEndPlayReason>> Callback)
		{
			if (FActorEndPlaySignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorEndPlaySignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorEndPlaySignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorEndPlaySignature.OnScriptCallback));
				}
				FActorEndPlaySignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorEndPlaySignature.RegisterId);
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000229FC File Offset: 0x00020BFC
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			0
		})] Action<AActor, TEnumAsByte<EEndPlayReason>> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00022A1C File Offset: 0x00020C1C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AActor Actor, EEndPlayReason EndPlayReason)
		{
			FActorEndPlaySignature.__FActorEndPlaySignature_DelegateParams* ptr = stackalloc FActorEndPlaySignature.__FActorEndPlaySignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorEndPlaySignature.__FActorEndPlaySignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorEndPlaySignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->EndPlayReason = EndPlayReason;
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00022A84 File Offset: 0x00020C84
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, TEnumAsByte<EEndPlayReason>> action = target as Action<AActor, TEnumAsByte<EEndPlayReason>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorEndPlaySignature.__FActorEndPlaySignature_DelegateParams*)__Parameters)->Actor);
			action(orCreateUObjectByNativePointer, ((FActorEndPlaySignature.__FActorEndPlaySignature_DelegateParams*)__Parameters)->EndPlayReason);
		}

		// Token: 0x0400071F RID: 1823
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000720 RID: 1824
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorEndPlaySignature__DelegateSignature";

		// Token: 0x04000721 RID: 1825
		private static int RegisterId;

		// Token: 0x02000956 RID: 2390
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FActorEndPlaySignature_DelegateParams
		{
			// Token: 0x04005879 RID: 22649
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x0400587A RID: 22650
			[FieldOffset(8)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02000957 RID: 2391
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400587B RID: 22651
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
