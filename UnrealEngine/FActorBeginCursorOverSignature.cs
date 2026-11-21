using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000161 RID: 353
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorBeginCursorOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060015B7 RID: 5559 RVA: 0x00021575 File Offset: 0x0001F775
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorBeginCursorOverSignature.StaticFunctionPtr();
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00021581 File Offset: 0x0001F781
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorBeginCursorOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorBeginCursorOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorBeginCursorOverSignature__DelegateSignature");
			}
			return FActorBeginCursorOverSignature._FunctionPtr;
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x000215A4 File Offset: 0x0001F7A4
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnBeginCursorOver;
			}
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x000215AB File Offset: 0x0001F7AB
		[NullableContext(2)]
		public FActorBeginCursorOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x000215B5 File Offset: 0x0001F7B5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x000215E8 File Offset: 0x0001F7E8
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			if (FActorBeginCursorOverSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorBeginCursorOverSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorBeginCursorOverSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorBeginCursorOverSignature.OnScriptCallback));
				}
				FActorBeginCursorOverSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorBeginCursorOverSignature.RegisterId);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00021638 File Offset: 0x0001F838
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00021658 File Offset: 0x0001F858
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AActor TouchedActor)
		{
			FActorBeginCursorOverSignature.__FActorBeginCursorOverSignature_DelegateParams* ptr = stackalloc FActorBeginCursorOverSignature.__FActorBeginCursorOverSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FActorBeginCursorOverSignature.__FActorBeginCursorOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorBeginCursorOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x000216B4 File Offset: 0x0001F8B4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor> action = target as Action<AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorBeginCursorOverSignature.__FActorBeginCursorOverSignature_DelegateParams*)__Parameters)->TouchedActor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040006E6 RID: 1766
		internal static IntPtr _FunctionPtr;

		// Token: 0x040006E7 RID: 1767
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorBeginCursorOverSignature__DelegateSignature";

		// Token: 0x040006E8 RID: 1768
		private static int RegisterId;

		// Token: 0x02000944 RID: 2372
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FActorBeginCursorOverSignature_DelegateParams
		{
			// Token: 0x04005863 RID: 22627
			[FieldOffset(0)]
			public IntPtr TouchedActor;
		}

		// Token: 0x02000945 RID: 2373
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005864 RID: 22628
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
