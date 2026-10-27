using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007B2 RID: 1970
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorComponentDeactivateSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600697C RID: 27004 RVA: 0x000976A3 File Offset: 0x000958A3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorComponentDeactivateSignature.StaticFunctionPtr();
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x000976AF File Offset: 0x000958AF
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorComponentDeactivateSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorComponentDeactivateSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorComponentDeactivateSignature__DelegateSignature");
			}
			return FActorComponentDeactivateSignature._FunctionPtr;
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x0600697E RID: 27006 RVA: 0x000976D2 File Offset: 0x000958D2
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentDeactivated;
			}
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x000976D9 File Offset: 0x000958D9
		[NullableContext(2)]
		public FActorComponentDeactivateSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x000976E3 File Offset: 0x000958E3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UActorComponent>) ?? ((Action<UActorComponent>)Delegate.CreateDelegate(typeof(Action<UActorComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x00097718 File Offset: 0x00095918
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06006982 RID: 27010 RVA: 0x00097768 File Offset: 0x00095968
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UActorComponent> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x00097788 File Offset: 0x00095988
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UActorComponent Component)
		{
			FActorComponentDeactivateSignature.__FActorComponentDeactivateSignature_DelegateParams* ptr = stackalloc FActorComponentDeactivateSignature.__FActorComponentDeactivateSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FActorComponentDeactivateSignature.__FActorComponentDeactivateSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorComponentDeactivateSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Component = ((Component != null) ? Component.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x000977E4 File Offset: 0x000959E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040032DB RID: 13019
		internal static IntPtr _FunctionPtr;

		// Token: 0x040032DC RID: 13020
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorComponentDeactivateSignature__DelegateSignature";

		// Token: 0x040032DD RID: 13021
		private static int RegisterId;

		// Token: 0x02002C6B RID: 11371
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FActorComponentDeactivateSignature_DelegateParams
		{
			// Token: 0x0401659A RID: 91546
			[FieldOffset(0)]
			public IntPtr Component;
		}

		// Token: 0x02002C6C RID: 11372
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401659B RID: 91547
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
