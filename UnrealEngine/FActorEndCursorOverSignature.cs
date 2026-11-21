using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000169 RID: 361
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorEndCursorOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001652 RID: 5714 RVA: 0x000225F1 File Offset: 0x000207F1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorEndCursorOverSignature.StaticFunctionPtr();
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x000225FD File Offset: 0x000207FD
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorEndCursorOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorEndCursorOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorEndCursorOverSignature__DelegateSignature");
			}
			return FActorEndCursorOverSignature._FunctionPtr;
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x00022620 File Offset: 0x00020820
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnEndCursorOver;
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00022627 File Offset: 0x00020827
		[NullableContext(2)]
		public FActorEndCursorOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00022631 File Offset: 0x00020831
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00022664 File Offset: 0x00020864
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			if (FActorEndCursorOverSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorEndCursorOverSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorEndCursorOverSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorEndCursorOverSignature.OnScriptCallback));
				}
				FActorEndCursorOverSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorEndCursorOverSignature.RegisterId);
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x000226B4 File Offset: 0x000208B4
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x000226D4 File Offset: 0x000208D4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AActor TouchedActor)
		{
			FActorEndCursorOverSignature.__FActorEndCursorOverSignature_DelegateParams* ptr = stackalloc FActorEndCursorOverSignature.__FActorEndCursorOverSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FActorEndCursorOverSignature.__FActorEndCursorOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorEndCursorOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00022730 File Offset: 0x00020930
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor> action = target as Action<AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorEndCursorOverSignature.__FActorEndCursorOverSignature_DelegateParams*)__Parameters)->TouchedActor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04000719 RID: 1817
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400071A RID: 1818
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorEndCursorOverSignature__DelegateSignature";

		// Token: 0x0400071B RID: 1819
		private static int RegisterId;

		// Token: 0x02000952 RID: 2386
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FActorEndCursorOverSignature_DelegateParams
		{
			// Token: 0x04005874 RID: 22644
			[FieldOffset(0)]
			public IntPtr TouchedActor;
		}

		// Token: 0x02000953 RID: 2387
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005875 RID: 22645
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
