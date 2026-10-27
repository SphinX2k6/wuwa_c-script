using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000955 RID: 2389
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentEndCursorOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600872F RID: 34607 RVA: 0x000C122E File Offset: 0x000BF42E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentEndCursorOverSignature.StaticFunctionPtr();
		}

		// Token: 0x06008730 RID: 34608 RVA: 0x000C123A File Offset: 0x000BF43A
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentEndCursorOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentEndCursorOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentEndCursorOverSignature__DelegateSignature");
			}
			return FComponentEndCursorOverSignature._FunctionPtr;
		}

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x06008731 RID: 34609 RVA: 0x000C125D File Offset: 0x000BF45D
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnEndCursorOver;
			}
		}

		// Token: 0x06008732 RID: 34610 RVA: 0x000C1264 File Offset: 0x000BF464
		[NullableContext(2)]
		public FComponentEndCursorOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008733 RID: 34611 RVA: 0x000C126E File Offset: 0x000BF46E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent>) ?? ((Action<UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008734 RID: 34612 RVA: 0x000C12A0 File Offset: 0x000BF4A0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent> Callback)
		{
			if (FComponentEndCursorOverSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentEndCursorOverSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentEndCursorOverSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentEndCursorOverSignature.OnScriptCallback));
				}
				FComponentEndCursorOverSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentEndCursorOverSignature.RegisterId);
		}

		// Token: 0x06008735 RID: 34613 RVA: 0x000C12F0 File Offset: 0x000BF4F0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06008736 RID: 34614 RVA: 0x000C1310 File Offset: 0x000BF510
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UPrimitiveComponent TouchedComponent)
		{
			FComponentEndCursorOverSignature.__FComponentEndCursorOverSignature_DelegateParams* ptr = stackalloc FComponentEndCursorOverSignature.__FComponentEndCursorOverSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FComponentEndCursorOverSignature.__FComponentEndCursorOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentEndCursorOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06008737 RID: 34615 RVA: 0x000C136C File Offset: 0x000BF56C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent> action = target as Action<UPrimitiveComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentEndCursorOverSignature.__FComponentEndCursorOverSignature_DelegateParams*)__Parameters)->TouchedComponent);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04004054 RID: 16468
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004055 RID: 16469
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentEndCursorOverSignature__DelegateSignature";

		// Token: 0x04004056 RID: 16470
		private static int RegisterId;

		// Token: 0x02002CCB RID: 11467
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FComponentEndCursorOverSignature_DelegateParams
		{
			// Token: 0x0401666B RID: 91755
			[FieldOffset(0)]
			public IntPtr TouchedComponent;
		}

		// Token: 0x02002CCC RID: 11468
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401666C RID: 91756
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
