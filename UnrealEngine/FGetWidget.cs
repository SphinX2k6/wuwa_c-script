using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002974 RID: 10612
	public sealed class FGetWidget : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060273E4 RID: 160740 RVA: 0x003BD95F File Offset: 0x003BBB5F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetWidget.StaticFunctionPtr();
		}

		// Token: 0x060273E5 RID: 160741 RVA: 0x003BD96B File Offset: 0x003BBB6B
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GetWidget__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GetWidget__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GetWidget__DelegateSignature");
			}
			return UWidget.__GetWidget__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060273E6 RID: 160742 RVA: 0x003BD98E File Offset: 0x003BBB8E
		public FGetWidget()
		{
		}

		// Token: 0x060273E7 RID: 160743 RVA: 0x003BD996 File Offset: 0x003BBB96
		[NullableContext(2)]
		public FGetWidget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060273E8 RID: 160744 RVA: 0x003BD9A0 File Offset: 0x003BBBA0
		public FGetWidget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060273E9 RID: 160745 RVA: 0x003BD9AB File Offset: 0x003BBBAB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<UWidget>) ?? ((Func<UWidget>)Delegate.CreateDelegate(typeof(Func<UWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060273EA RID: 160746 RVA: 0x003BD9DD File Offset: 0x003BBBDD
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Func<UWidget> Callback)
		{
			if (FGetWidget.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetWidget.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetWidget.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetWidget.OnScriptCallback));
				}
				FGetWidget.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGetWidget.RegisterId);
		}

		// Token: 0x060273EB RID: 160747 RVA: 0x003BDA18 File Offset: 0x003BBC18
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UWidget Execute()
		{
			FGetWidget.__FGetWidget_DelegateParams* ptr = stackalloc FGetWidget.__FGetWidget_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FGetWidget.__FGetWidget_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetWidget.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidget>(ptr->__Result);
		}

		// Token: 0x060273EC RID: 160748 RVA: 0x003BDA5C File Offset: 0x003BBC5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<UWidget> func = target as Func<UWidget>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UWidget uwidget = func();
			((FGetWidget.__FGetWidget_DelegateParams*)__Parameters)->__Result = ((uwidget != null) ? uwidget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x04015903 RID: 88323
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GetWidget__DelegateSignature";

		// Token: 0x04015904 RID: 88324
		private static int RegisterId;

		// Token: 0x02003B83 RID: 15235
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FGetWidget_DelegateParams
		{
			// Token: 0x04017D5D RID: 97629
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003B84 RID: 15236
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D5E RID: 97630
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
