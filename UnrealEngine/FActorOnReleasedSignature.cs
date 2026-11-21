using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000171 RID: 369
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorOnReleasedSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600169A RID: 5786 RVA: 0x0002339B File Offset: 0x0002159B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorOnReleasedSignature.StaticFunctionPtr();
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x000233A7 File Offset: 0x000215A7
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorOnReleasedSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorOnReleasedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorOnReleasedSignature__DelegateSignature");
			}
			return FActorOnReleasedSignature._FunctionPtr;
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x000233CA File Offset: 0x000215CA
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnReleased;
			}
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x000233D1 File Offset: 0x000215D1
		[NullableContext(2)]
		public FActorOnReleasedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x000233DB File Offset: 0x000215DB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, FKey>) ?? ((Action<AActor, FKey>)Delegate.CreateDelegate(typeof(Action<AActor, FKey>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00023410 File Offset: 0x00021610
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<AActor, FKey> Callback)
		{
			if (FActorOnReleasedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorOnReleasedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorOnReleasedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorOnReleasedSignature.OnScriptCallback));
				}
				FActorOnReleasedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorOnReleasedSignature.RegisterId);
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00023460 File Offset: 0x00021660
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

		// Token: 0x060016A1 RID: 5793 RVA: 0x00023480 File Offset: 0x00021680
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AActor TouchedActor, FKey ButtonReleased)
		{
			FActorOnReleasedSignature.__FActorOnReleasedSignature_DelegateParams* ptr = stackalloc FActorOnReleasedSignature.__FActorOnReleasedSignature_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FActorOnReleasedSignature.__FActorOnReleasedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorOnReleasedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			if (ButtonReleased != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->ButtonReleased, ButtonReleased.NativePtr, 1, false);
			}
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FActorOnReleasedSignature._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00023510 File Offset: 0x00021710
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, FKey> action = target as Action<AActor, FKey>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorOnReleasedSignature.__FActorOnReleasedSignature_DelegateParams*)__Parameters)->TouchedActor);
			FKey arg = new FKey(&((FActorOnReleasedSignature.__FActorOnReleasedSignature_DelegateParams*)__Parameters)->ButtonReleased, true, true);
			action(orCreateUObjectByNativePointer, arg);
		}

		// Token: 0x04000731 RID: 1841
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000732 RID: 1842
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorOnReleasedSignature__DelegateSignature";

		// Token: 0x04000733 RID: 1843
		private static int RegisterId;

		// Token: 0x02000962 RID: 2402
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __FActorOnReleasedSignature_DelegateParams
		{
			// Token: 0x0400588D RID: 22669
			[FieldOffset(0)]
			public IntPtr TouchedActor;

			// Token: 0x0400588E RID: 22670
			[FieldOffset(8)]
			public byte ButtonReleased;
		}

		// Token: 0x02000963 RID: 2403
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400588F RID: 22671
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
