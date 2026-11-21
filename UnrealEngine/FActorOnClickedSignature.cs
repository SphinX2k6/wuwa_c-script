using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200016E RID: 366
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorOnClickedSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600167F RID: 5759 RVA: 0x00022E7F File Offset: 0x0002107F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorOnClickedSignature.StaticFunctionPtr();
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00022E8B File Offset: 0x0002108B
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorOnClickedSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorOnClickedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorOnClickedSignature__DelegateSignature");
			}
			return FActorOnClickedSignature._FunctionPtr;
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x00022EAE File Offset: 0x000210AE
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnClicked;
			}
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00022EB5 File Offset: 0x000210B5
		[NullableContext(2)]
		public FActorOnClickedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00022EBF File Offset: 0x000210BF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, FKey>) ?? ((Action<AActor, FKey>)Delegate.CreateDelegate(typeof(Action<AActor, FKey>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00022EF4 File Offset: 0x000210F4
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<AActor, FKey> Callback)
		{
			if (FActorOnClickedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorOnClickedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorOnClickedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorOnClickedSignature.OnScriptCallback));
				}
				FActorOnClickedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorOnClickedSignature.RegisterId);
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00022F44 File Offset: 0x00021144
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<AActor, FKey> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00022F64 File Offset: 0x00021164
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AActor TouchedActor, FKey ButtonPressed)
		{
			FActorOnClickedSignature.__FActorOnClickedSignature_DelegateParams* ptr = stackalloc FActorOnClickedSignature.__FActorOnClickedSignature_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FActorOnClickedSignature.__FActorOnClickedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorOnClickedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			if (ButtonPressed != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->ButtonPressed, ButtonPressed.NativePtr, 1, false);
			}
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FActorOnClickedSignature._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00022FF4 File Offset: 0x000211F4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, FKey> action = target as Action<AActor, FKey>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorOnClickedSignature.__FActorOnClickedSignature_DelegateParams*)__Parameters)->TouchedActor);
			FKey arg = new FKey(&((FActorOnClickedSignature.__FActorOnClickedSignature_DelegateParams*)__Parameters)->ButtonPressed, true, true);
			action(orCreateUObjectByNativePointer, arg);
		}

		// Token: 0x04000728 RID: 1832
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000729 RID: 1833
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorOnClickedSignature__DelegateSignature";

		// Token: 0x0400072A RID: 1834
		private static int RegisterId;

		// Token: 0x0200095C RID: 2396
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __FActorOnClickedSignature_DelegateParams
		{
			// Token: 0x04005884 RID: 22660
			[FieldOffset(0)]
			public IntPtr TouchedActor;

			// Token: 0x04005885 RID: 22661
			[FieldOffset(8)]
			public byte ButtonPressed;
		}

		// Token: 0x0200095D RID: 2397
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005886 RID: 22662
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
