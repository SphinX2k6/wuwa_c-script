using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000165 RID: 357
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorComponentActivatedSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001630 RID: 5680 RVA: 0x000220D1 File Offset: 0x000202D1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorComponentActivatedSignature.StaticFunctionPtr();
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x000220DD File Offset: 0x000202DD
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorComponentActivatedSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorComponentActivatedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorComponentActivatedSignature__DelegateSignature");
			}
			return FActorComponentActivatedSignature._FunctionPtr;
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x00022100 File Offset: 0x00020300
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentActivated;
			}
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00022107 File Offset: 0x00020307
		[NullableContext(2)]
		public FActorComponentActivatedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00022111 File Offset: 0x00020311
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UActorComponent, bool>) ?? ((Action<UActorComponent, bool>)Delegate.CreateDelegate(typeof(Action<UActorComponent, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00022144 File Offset: 0x00020344
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UActorComponent, bool> Callback)
		{
			if (FActorComponentActivatedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorComponentActivatedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorComponentActivatedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorComponentActivatedSignature.OnScriptCallback));
				}
				FActorComponentActivatedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorComponentActivatedSignature.RegisterId);
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00022194 File Offset: 0x00020394
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UActorComponent, bool> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x000221B4 File Offset: 0x000203B4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UActorComponent Component, bool bReset)
		{
			FActorComponentActivatedSignature.__FActorComponentActivatedSignature_DelegateParams* ptr = stackalloc FActorComponentActivatedSignature.__FActorComponentActivatedSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorComponentActivatedSignature.__FActorComponentActivatedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorComponentActivatedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Component = ((Component != null) ? Component.NativePtr : IntPtr.Zero);
			ptr->bReset = bReset;
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00022218 File Offset: 0x00020418
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UActorComponent, bool> action = target as Action<UActorComponent, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UActorComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(((FActorComponentActivatedSignature.__FActorComponentActivatedSignature_DelegateParams*)__Parameters)->Component);
			action(orCreateUObjectByNativePointer, ((FActorComponentActivatedSignature.__FActorComponentActivatedSignature_DelegateParams*)__Parameters)->bReset);
		}

		// Token: 0x0400070E RID: 1806
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400070F RID: 1807
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorComponentActivatedSignature__DelegateSignature";

		// Token: 0x04000710 RID: 1808
		private static int RegisterId;

		// Token: 0x0200094C RID: 2380
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FActorComponentActivatedSignature_DelegateParams
		{
			// Token: 0x0400586D RID: 22637
			[FieldOffset(0)]
			public IntPtr Component;

			// Token: 0x0400586E RID: 22638
			[FieldOffset(8)]
			public bool bReset;
		}

		// Token: 0x0200094D RID: 2381
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400586F RID: 22639
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
