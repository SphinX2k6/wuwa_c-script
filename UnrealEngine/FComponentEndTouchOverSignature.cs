using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B2 RID: 434
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentEndTouchOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002021 RID: 8225 RVA: 0x0002EE9C File Offset: 0x0002D09C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentEndTouchOverSignature.StaticFunctionPtr();
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x0002EEA8 File Offset: 0x0002D0A8
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentEndTouchOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentEndTouchOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentEndTouchOverSignature__DelegateSignature");
			}
			return FComponentEndTouchOverSignature._FunctionPtr;
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06002023 RID: 8227 RVA: 0x0002EECB File Offset: 0x0002D0CB
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchLeave;
			}
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x0002EED2 File Offset: 0x0002D0D2
		[NullableContext(2)]
		public FComponentEndTouchOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x0002EEDC File Offset: 0x0002D0DC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>) ?? ((Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x0002EF10 File Offset: 0x0002D110
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> Callback)
		{
			if (FComponentEndTouchOverSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentEndTouchOverSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentEndTouchOverSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentEndTouchOverSignature.OnScriptCallback));
				}
				FComponentEndTouchOverSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentEndTouchOverSignature.RegisterId);
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x0002EF60 File Offset: 0x0002D160
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

		// Token: 0x06002028 RID: 8232 RVA: 0x0002EF80 File Offset: 0x0002D180
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent)
		{
			FComponentEndTouchOverSignature.__FComponentEndTouchOverSignature_DelegateParams* ptr = stackalloc FComponentEndTouchOverSignature.__FComponentEndTouchOverSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FComponentEndTouchOverSignature.__FComponentEndTouchOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentEndTouchOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x0002EFE8 File Offset: 0x0002D1E8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> action = target as Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentEndTouchOverSignature.__FComponentEndTouchOverSignature_DelegateParams*)__Parameters)->TouchedComponent);
			action(((FComponentEndTouchOverSignature.__FComponentEndTouchOverSignature_DelegateParams*)__Parameters)->FingerIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04000AAF RID: 2735
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000AB0 RID: 2736
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentEndTouchOverSignature__DelegateSignature";

		// Token: 0x04000AB1 RID: 2737
		private static int RegisterId;

		// Token: 0x0200098B RID: 2443
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FComponentEndTouchOverSignature_DelegateParams
		{
			// Token: 0x040058E7 RID: 22759
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x040058E8 RID: 22760
			[FieldOffset(8)]
			public IntPtr TouchedComponent;
		}

		// Token: 0x0200098C RID: 2444
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058E9 RID: 22761
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
