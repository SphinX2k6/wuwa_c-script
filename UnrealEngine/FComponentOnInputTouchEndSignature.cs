using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B6 RID: 438
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentOnInputTouchEndSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002045 RID: 8261 RVA: 0x0002F5D7 File Offset: 0x0002D7D7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentOnInputTouchEndSignature.StaticFunctionPtr();
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x0002F5E3 File Offset: 0x0002D7E3
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentOnInputTouchEndSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentOnInputTouchEndSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentOnInputTouchEndSignature__DelegateSignature");
			}
			return FComponentOnInputTouchEndSignature._FunctionPtr;
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x0002F606 File Offset: 0x0002D806
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchEnd;
			}
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x0002F60D File Offset: 0x0002D80D
		[NullableContext(2)]
		public FComponentOnInputTouchEndSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x0002F617 File Offset: 0x0002D817
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>) ?? ((Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x0002F64C File Offset: 0x0002D84C
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> Callback)
		{
			if (FComponentOnInputTouchEndSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentOnInputTouchEndSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentOnInputTouchEndSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentOnInputTouchEndSignature.OnScriptCallback));
				}
				FComponentOnInputTouchEndSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentOnInputTouchEndSignature.RegisterId);
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x0002F69C File Offset: 0x0002D89C
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

		// Token: 0x0600204C RID: 8268 RVA: 0x0002F6BC File Offset: 0x0002D8BC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent)
		{
			FComponentOnInputTouchEndSignature.__FComponentOnInputTouchEndSignature_DelegateParams* ptr = stackalloc FComponentOnInputTouchEndSignature.__FComponentOnInputTouchEndSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FComponentOnInputTouchEndSignature.__FComponentOnInputTouchEndSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentOnInputTouchEndSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x0002F724 File Offset: 0x0002D924
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> action = target as Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentOnInputTouchEndSignature.__FComponentOnInputTouchEndSignature_DelegateParams*)__Parameters)->TouchedComponent);
			action(((FComponentOnInputTouchEndSignature.__FComponentOnInputTouchEndSignature_DelegateParams*)__Parameters)->FingerIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04000ABB RID: 2747
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000ABC RID: 2748
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentOnInputTouchEndSignature__DelegateSignature";

		// Token: 0x04000ABD RID: 2749
		private static int RegisterId;

		// Token: 0x02000993 RID: 2451
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FComponentOnInputTouchEndSignature_DelegateParams
		{
			// Token: 0x040058F6 RID: 22774
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x040058F7 RID: 22775
			[FieldOffset(8)]
			public IntPtr TouchedComponent;
		}

		// Token: 0x02000994 RID: 2452
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058F8 RID: 22776
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
