using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200016A RID: 362
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorEndOverlapSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600165B RID: 5723 RVA: 0x00022781 File Offset: 0x00020981
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorEndOverlapSignature.StaticFunctionPtr();
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0002278D File Offset: 0x0002098D
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorEndOverlapSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorEndOverlapSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorEndOverlapSignature__DelegateSignature");
			}
			return FActorEndOverlapSignature._FunctionPtr;
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x000227B0 File Offset: 0x000209B0
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnActorEndOverlap;
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x000227B7 File Offset: 0x000209B7
		[NullableContext(2)]
		public FActorEndOverlapSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x000227C1 File Offset: 0x000209C1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, AActor>) ?? ((Action<AActor, AActor>)Delegate.CreateDelegate(typeof(Action<AActor, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x000227F4 File Offset: 0x000209F4
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<AActor, AActor> Callback)
		{
			if (FActorEndOverlapSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorEndOverlapSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorEndOverlapSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorEndOverlapSignature.OnScriptCallback));
				}
				FActorEndOverlapSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorEndOverlapSignature.RegisterId);
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00022844 File Offset: 0x00020A44
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<AActor, AActor> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00022864 File Offset: 0x00020A64
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AActor OverlappedActor, AActor OtherActor)
		{
			FActorEndOverlapSignature.__FActorEndOverlapSignature_DelegateParams* ptr = stackalloc FActorEndOverlapSignature.__FActorEndOverlapSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorEndOverlapSignature.__FActorEndOverlapSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorEndOverlapSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OverlappedActor = ((OverlappedActor != null) ? OverlappedActor.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x000228D8 File Offset: 0x00020AD8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, AActor> action = target as Action<AActor, AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorEndOverlapSignature.__FActorEndOverlapSignature_DelegateParams*)__Parameters)->OverlappedActor);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorEndOverlapSignature.__FActorEndOverlapSignature_DelegateParams*)__Parameters)->OtherActor);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
		}

		// Token: 0x0400071C RID: 1820
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400071D RID: 1821
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorEndOverlapSignature__DelegateSignature";

		// Token: 0x0400071E RID: 1822
		private static int RegisterId;

		// Token: 0x02000954 RID: 2388
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FActorEndOverlapSignature_DelegateParams
		{
			// Token: 0x04005876 RID: 22646
			[FieldOffset(0)]
			public IntPtr OverlappedActor;

			// Token: 0x04005877 RID: 22647
			[FieldOffset(8)]
			public IntPtr OtherActor;
		}

		// Token: 0x02000955 RID: 2389
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005878 RID: 22648
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
