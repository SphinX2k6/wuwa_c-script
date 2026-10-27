using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007B1 RID: 1969
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorComponentActivatedSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006973 RID: 26995 RVA: 0x00097505 File Offset: 0x00095705
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorComponentActivatedSignature.StaticFunctionPtr();
		}

		// Token: 0x06006974 RID: 26996 RVA: 0x00097511 File Offset: 0x00095711
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorComponentActivatedSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorComponentActivatedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorComponentActivatedSignature__DelegateSignature");
			}
			return FActorComponentActivatedSignature._FunctionPtr;
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x06006975 RID: 26997 RVA: 0x00097534 File Offset: 0x00095734
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentActivated;
			}
		}

		// Token: 0x06006976 RID: 26998 RVA: 0x0009753B File Offset: 0x0009573B
		[NullableContext(2)]
		public FActorComponentActivatedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006977 RID: 26999 RVA: 0x00097545 File Offset: 0x00095745
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UActorComponent, bool>) ?? ((Action<UActorComponent, bool>)Delegate.CreateDelegate(typeof(Action<UActorComponent, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006978 RID: 27000 RVA: 0x00097578 File Offset: 0x00095778
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06006979 RID: 27001 RVA: 0x000975C8 File Offset: 0x000957C8
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UActorComponent, bool> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x0600697A RID: 27002 RVA: 0x000975E8 File Offset: 0x000957E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UActorComponent Component, bool bReset)
		{
			FActorComponentActivatedSignature.__FActorComponentActivatedSignature_DelegateParams* ptr = stackalloc FActorComponentActivatedSignature.__FActorComponentActivatedSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorComponentActivatedSignature.__FActorComponentActivatedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorComponentActivatedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Component = ((Component != null) ? Component.NativePtr : IntPtr.Zero);
			ptr->bReset = bReset;
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x0600697B RID: 27003 RVA: 0x0009764C File Offset: 0x0009584C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040032D8 RID: 13016
		internal static IntPtr _FunctionPtr;

		// Token: 0x040032D9 RID: 13017
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorComponentActivatedSignature__DelegateSignature";

		// Token: 0x040032DA RID: 13018
		private static int RegisterId;

		// Token: 0x02002C69 RID: 11369
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FActorComponentActivatedSignature_DelegateParams
		{
			// Token: 0x04016597 RID: 91543
			[FieldOffset(0)]
			public IntPtr Component;

			// Token: 0x04016598 RID: 91544
			[FieldOffset(8)]
			public bool bReset;
		}

		// Token: 0x02002C6A RID: 11370
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016599 RID: 91545
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
