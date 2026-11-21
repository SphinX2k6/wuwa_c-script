using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B5 RID: 437
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentOnInputTouchBeginSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600203C RID: 8252 RVA: 0x0002F436 File Offset: 0x0002D636
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentOnInputTouchBeginSignature.StaticFunctionPtr();
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x0002F442 File Offset: 0x0002D642
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentOnInputTouchBeginSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentOnInputTouchBeginSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentOnInputTouchBeginSignature__DelegateSignature");
			}
			return FComponentOnInputTouchBeginSignature._FunctionPtr;
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600203E RID: 8254 RVA: 0x0002F465 File Offset: 0x0002D665
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchBegin;
			}
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0002F46C File Offset: 0x0002D66C
		[NullableContext(2)]
		public FComponentOnInputTouchBeginSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x0002F476 File Offset: 0x0002D676
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>) ?? ((Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x0002F4A8 File Offset: 0x0002D6A8
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> Callback)
		{
			if (FComponentOnInputTouchBeginSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentOnInputTouchBeginSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentOnInputTouchBeginSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentOnInputTouchBeginSignature.OnScriptCallback));
				}
				FComponentOnInputTouchBeginSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentOnInputTouchBeginSignature.RegisterId);
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0002F4F8 File Offset: 0x0002D6F8
		public void Remove([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x0002F518 File Offset: 0x0002D718
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent)
		{
			FComponentOnInputTouchBeginSignature.__FComponentOnInputTouchBeginSignature_DelegateParams* ptr = stackalloc FComponentOnInputTouchBeginSignature.__FComponentOnInputTouchBeginSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FComponentOnInputTouchBeginSignature.__FComponentOnInputTouchBeginSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentOnInputTouchBeginSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x0002F580 File Offset: 0x0002D780
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> action = target as Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentOnInputTouchBeginSignature.__FComponentOnInputTouchBeginSignature_DelegateParams*)__Parameters)->TouchedComponent);
			action(((FComponentOnInputTouchBeginSignature.__FComponentOnInputTouchBeginSignature_DelegateParams*)__Parameters)->FingerIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04000AB8 RID: 2744
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000AB9 RID: 2745
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentOnInputTouchBeginSignature__DelegateSignature";

		// Token: 0x04000ABA RID: 2746
		private static int RegisterId;

		// Token: 0x02000991 RID: 2449
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FComponentOnInputTouchBeginSignature_DelegateParams
		{
			// Token: 0x040058F3 RID: 22771
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x040058F4 RID: 22772
			[FieldOffset(8)]
			public IntPtr TouchedComponent;
		}

		// Token: 0x02000992 RID: 2450
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058F5 RID: 22773
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
