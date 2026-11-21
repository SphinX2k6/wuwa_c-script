using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000168 RID: 360
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorDestroyedSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001649 RID: 5705 RVA: 0x00022461 File Offset: 0x00020661
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorDestroyedSignature.StaticFunctionPtr();
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0002246D File Offset: 0x0002066D
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorDestroyedSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorDestroyedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorDestroyedSignature__DelegateSignature");
			}
			return FActorDestroyedSignature._FunctionPtr;
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x00022490 File Offset: 0x00020690
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnDestroyed;
			}
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00022497 File Offset: 0x00020697
		[NullableContext(2)]
		public FActorDestroyedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x000224A1 File Offset: 0x000206A1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x000224D4 File Offset: 0x000206D4
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			if (FActorDestroyedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorDestroyedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorDestroyedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorDestroyedSignature.OnScriptCallback));
				}
				FActorDestroyedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorDestroyedSignature.RegisterId);
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00022524 File Offset: 0x00020724
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00022544 File Offset: 0x00020744
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AActor DestroyedActor)
		{
			FActorDestroyedSignature.__FActorDestroyedSignature_DelegateParams* ptr = stackalloc FActorDestroyedSignature.__FActorDestroyedSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FActorDestroyedSignature.__FActorDestroyedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorDestroyedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DestroyedActor = ((DestroyedActor != null) ? DestroyedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x000225A0 File Offset: 0x000207A0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor> action = target as Action<AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorDestroyedSignature.__FActorDestroyedSignature_DelegateParams*)__Parameters)->DestroyedActor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04000716 RID: 1814
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000717 RID: 1815
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorDestroyedSignature__DelegateSignature";

		// Token: 0x04000718 RID: 1816
		private static int RegisterId;

		// Token: 0x02000950 RID: 2384
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FActorDestroyedSignature_DelegateParams
		{
			// Token: 0x04005872 RID: 22642
			[FieldOffset(0)]
			public IntPtr DestroyedActor;
		}

		// Token: 0x02000951 RID: 2385
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005873 RID: 22643
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
