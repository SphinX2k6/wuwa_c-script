using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000166 RID: 358
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorComponentDeactivateSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001639 RID: 5689 RVA: 0x0002226F File Offset: 0x0002046F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorComponentDeactivateSignature.StaticFunctionPtr();
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x0002227B File Offset: 0x0002047B
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorComponentDeactivateSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorComponentDeactivateSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorComponentDeactivateSignature__DelegateSignature");
			}
			return FActorComponentDeactivateSignature._FunctionPtr;
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x0002229E File Offset: 0x0002049E
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentDeactivated;
			}
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x000222A5 File Offset: 0x000204A5
		[NullableContext(2)]
		public FActorComponentDeactivateSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x000222AF File Offset: 0x000204AF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UActorComponent>) ?? ((Action<UActorComponent>)Delegate.CreateDelegate(typeof(Action<UActorComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x000222E4 File Offset: 0x000204E4
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UActorComponent> Callback)
		{
			if (FActorComponentDeactivateSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorComponentDeactivateSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorComponentDeactivateSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorComponentDeactivateSignature.OnScriptCallback));
				}
				FActorComponentDeactivateSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorComponentDeactivateSignature.RegisterId);
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00022334 File Offset: 0x00020534
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UActorComponent> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00022354 File Offset: 0x00020554
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UActorComponent Component)
		{
			FActorComponentDeactivateSignature.__FActorComponentDeactivateSignature_DelegateParams* ptr = stackalloc FActorComponentDeactivateSignature.__FActorComponentDeactivateSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FActorComponentDeactivateSignature.__FActorComponentDeactivateSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorComponentDeactivateSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Component = ((Component != null) ? Component.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x000223B0 File Offset: 0x000205B0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UActorComponent> action = target as Action<UActorComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UActorComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(((FActorComponentDeactivateSignature.__FActorComponentDeactivateSignature_DelegateParams*)__Parameters)->Component);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04000711 RID: 1809
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000712 RID: 1810
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorComponentDeactivateSignature__DelegateSignature";

		// Token: 0x04000713 RID: 1811
		private static int RegisterId;

		// Token: 0x0200094E RID: 2382
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FActorComponentDeactivateSignature_DelegateParams
		{
			// Token: 0x04005870 RID: 22640
			[FieldOffset(0)]
			public IntPtr Component;
		}

		// Token: 0x0200094F RID: 2383
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005871 RID: 22641
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
