using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B7 RID: 439
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentOnReleasedSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600204E RID: 8270 RVA: 0x0002F77B File Offset: 0x0002D97B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentOnReleasedSignature.StaticFunctionPtr();
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x0002F787 File Offset: 0x0002D987
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentOnReleasedSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentOnReleasedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentOnReleasedSignature__DelegateSignature");
			}
			return FComponentOnReleasedSignature._FunctionPtr;
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x0002F7AA File Offset: 0x0002D9AA
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnReleased;
			}
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x0002F7B1 File Offset: 0x0002D9B1
		[NullableContext(2)]
		public FComponentOnReleasedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x0002F7BB File Offset: 0x0002D9BB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, FKey>) ?? ((Action<UPrimitiveComponent, FKey>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, FKey>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x0002F7F0 File Offset: 0x0002D9F0
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<UPrimitiveComponent, FKey> Callback)
		{
			if (FComponentOnReleasedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentOnReleasedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentOnReleasedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentOnReleasedSignature.OnScriptCallback));
				}
				FComponentOnReleasedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentOnReleasedSignature.RegisterId);
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x0002F840 File Offset: 0x0002DA40
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<UPrimitiveComponent, FKey> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x0002F860 File Offset: 0x0002DA60
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UPrimitiveComponent TouchedComponent, FKey ButtonReleased)
		{
			FComponentOnReleasedSignature.__FComponentOnReleasedSignature_DelegateParams* ptr = stackalloc FComponentOnReleasedSignature.__FComponentOnReleasedSignature_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FComponentOnReleasedSignature.__FComponentOnReleasedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentOnReleasedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			if (ButtonReleased != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->ButtonReleased, ButtonReleased.NativePtr, 1, false);
			}
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FComponentOnReleasedSignature._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x0002F8F0 File Offset: 0x0002DAF0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent, FKey> action = target as Action<UPrimitiveComponent, FKey>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentOnReleasedSignature.__FComponentOnReleasedSignature_DelegateParams*)__Parameters)->TouchedComponent);
			FKey arg = new FKey(&((FComponentOnReleasedSignature.__FComponentOnReleasedSignature_DelegateParams*)__Parameters)->ButtonReleased, true, true);
			action(orCreateUObjectByNativePointer, arg);
		}

		// Token: 0x04000ABE RID: 2750
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000ABF RID: 2751
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentOnReleasedSignature__DelegateSignature";

		// Token: 0x04000AC0 RID: 2752
		private static int RegisterId;

		// Token: 0x02000995 RID: 2453
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __FComponentOnReleasedSignature_DelegateParams
		{
			// Token: 0x040058F9 RID: 22777
			[FieldOffset(0)]
			public IntPtr TouchedComponent;

			// Token: 0x040058FA RID: 22778
			[FieldOffset(8)]
			public byte ButtonReleased;
		}

		// Token: 0x02000996 RID: 2454
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058FB RID: 22779
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
