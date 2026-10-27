using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000407 RID: 1031
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FInstanceARActorToBeDestroyedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600376E RID: 14190 RVA: 0x000543C1 File Offset: 0x000525C1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FInstanceARActorToBeDestroyedDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x000543CD File Offset: 0x000525CD
		private static IntPtr StaticFunctionPtr()
		{
			if (UARLifeCycleComponent.__InstanceARActorToBeDestroyedDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UARLifeCycleComponent.__InstanceARActorToBeDestroyedDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AugmentedReality.ARLifeCycleComponent:InstanceARActorToBeDestroyedDelegate__DelegateSignature");
			}
			return UARLifeCycleComponent.__InstanceARActorToBeDestroyedDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x000543F0 File Offset: 0x000525F0
		public FInstanceARActorToBeDestroyedDelegate()
		{
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x000543F8 File Offset: 0x000525F8
		[NullableContext(2)]
		public FInstanceARActorToBeDestroyedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x00054402 File Offset: 0x00052602
		public FInstanceARActorToBeDestroyedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x0005440D File Offset: 0x0005260D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AARActor>) ?? ((Action<AARActor>)Delegate.CreateDelegate(typeof(Action<AARActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x0005443F File Offset: 0x0005263F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AARActor> Callback)
		{
			if (FInstanceARActorToBeDestroyedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FInstanceARActorToBeDestroyedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FInstanceARActorToBeDestroyedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FInstanceARActorToBeDestroyedDelegate.OnScriptCallback));
				}
				FInstanceARActorToBeDestroyedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FInstanceARActorToBeDestroyedDelegate.RegisterId);
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x00054479 File Offset: 0x00052679
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AARActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x00054484 File Offset: 0x00052684
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AARActor Actor)
		{
			FInstanceARActorToBeDestroyedDelegate.__FInstanceARActorToBeDestroyedDelegate_DelegateParams* ptr = stackalloc FInstanceARActorToBeDestroyedDelegate.__FInstanceARActorToBeDestroyedDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FInstanceARActorToBeDestroyedDelegate.__FInstanceARActorToBeDestroyedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FInstanceARActorToBeDestroyedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x000544D0 File Offset: 0x000526D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AARActor> action = target as Action<AARActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AARActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AARActor>(((FInstanceARActorToBeDestroyedDelegate.__FInstanceARActorToBeDestroyedDelegate_DelegateParams*)__Parameters)->Actor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04001934 RID: 6452
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.ARLifeCycleComponent:InstanceARActorToBeDestroyedDelegate__DelegateSignature";

		// Token: 0x04001935 RID: 6453
		private static int RegisterId;

		// Token: 0x02002C25 RID: 11301
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FInstanceARActorToBeDestroyedDelegate_DelegateParams
		{
			// Token: 0x0401652E RID: 91438
			[FieldOffset(0)]
			public IntPtr Actor;
		}

		// Token: 0x02002C26 RID: 11302
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401652F RID: 91439
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
