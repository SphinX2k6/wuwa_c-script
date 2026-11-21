using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200085F RID: 2143
	public sealed class FGetWidget : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BA45 RID: 47685 RVA: 0x0012A638 File Offset: 0x00128838
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetWidget.StaticFunctionPtr();
		}

		// Token: 0x0600BA46 RID: 47686 RVA: 0x0012A644 File Offset: 0x00128844
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GetWidget__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GetWidget__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GetWidget__DelegateSignature");
			}
			return UWidget.__GetWidget__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600BA47 RID: 47687 RVA: 0x0012A667 File Offset: 0x00128867
		public FGetWidget()
		{
		}

		// Token: 0x0600BA48 RID: 47688 RVA: 0x0012A66F File Offset: 0x0012886F
		[NullableContext(2)]
		public FGetWidget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BA49 RID: 47689 RVA: 0x0012A679 File Offset: 0x00128879
		public FGetWidget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BA4A RID: 47690 RVA: 0x0012A684 File Offset: 0x00128884
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<UWidget>) ?? ((Func<UWidget>)Delegate.CreateDelegate(typeof(Func<UWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BA4B RID: 47691 RVA: 0x0012A6B6 File Offset: 0x001288B6
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

		// Token: 0x0600BA4C RID: 47692 RVA: 0x0012A6F0 File Offset: 0x001288F0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UWidget Execute()
		{
			FGetWidget.__FGetWidget_DelegateParams* ptr = stackalloc FGetWidget.__FGetWidget_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FGetWidget.__FGetWidget_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetWidget.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidget>(ptr->__Result);
		}

		// Token: 0x0600BA4D RID: 47693 RVA: 0x0012A734 File Offset: 0x00128934
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400548A RID: 21642
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GetWidget__DelegateSignature";

		// Token: 0x0400548B RID: 21643
		private static int RegisterId;

		// Token: 0x020013FB RID: 5115
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FGetWidget_DelegateParams
		{
			// Token: 0x040068A5 RID: 26789
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x020013FC RID: 5116
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068A6 RID: 26790
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
