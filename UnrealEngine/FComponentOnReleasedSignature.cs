using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200095E RID: 2398
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentOnReleasedSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008788 RID: 34696 RVA: 0x000C203B File Offset: 0x000C023B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentOnReleasedSignature.StaticFunctionPtr();
		}

		// Token: 0x06008789 RID: 34697 RVA: 0x000C2047 File Offset: 0x000C0247
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentOnReleasedSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentOnReleasedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentOnReleasedSignature__DelegateSignature");
			}
			return FComponentOnReleasedSignature._FunctionPtr;
		}

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x0600878A RID: 34698 RVA: 0x000C206A File Offset: 0x000C026A
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnReleased;
			}
		}

		// Token: 0x0600878B RID: 34699 RVA: 0x000C2071 File Offset: 0x000C0271
		[NullableContext(2)]
		public FComponentOnReleasedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600878C RID: 34700 RVA: 0x000C207B File Offset: 0x000C027B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, FKey>) ?? ((Action<UPrimitiveComponent, FKey>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, FKey>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600878D RID: 34701 RVA: 0x000C20B0 File Offset: 0x000C02B0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0600878E RID: 34702 RVA: 0x000C2100 File Offset: 0x000C0300
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0600878F RID: 34703 RVA: 0x000C2120 File Offset: 0x000C0320
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06008790 RID: 34704 RVA: 0x000C21B0 File Offset: 0x000C03B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04004072 RID: 16498
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004073 RID: 16499
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentOnReleasedSignature__DelegateSignature";

		// Token: 0x04004074 RID: 16500
		private static int RegisterId;

		// Token: 0x02002CD9 RID: 11481
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FComponentOnReleasedSignature_DelegateParams
		{
			// Token: 0x04016684 RID: 91780
			[FieldOffset(0)]
			public IntPtr TouchedComponent;

			// Token: 0x04016685 RID: 91781
			[FieldOffset(8)]
			public byte ButtonReleased;
		}

		// Token: 0x02002CDA RID: 11482
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016686 RID: 91782
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
