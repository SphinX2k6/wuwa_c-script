using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002972 RID: 10610
	public sealed class FGetText : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060273D2 RID: 160722 RVA: 0x003BD6A0 File Offset: 0x003BB8A0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetText.StaticFunctionPtr();
		}

		// Token: 0x060273D3 RID: 160723 RVA: 0x003BD6AC File Offset: 0x003BB8AC
		private static IntPtr StaticFunctionPtr()
		{
			if (USlateAccessibleWidgetData.__GetText__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				USlateAccessibleWidgetData.__GetText__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.SlateAccessibleWidgetData:GetText__DelegateSignature");
			}
			return USlateAccessibleWidgetData.__GetText__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060273D4 RID: 160724 RVA: 0x003BD6CF File Offset: 0x003BB8CF
		public FGetText()
		{
		}

		// Token: 0x060273D5 RID: 160725 RVA: 0x003BD6D7 File Offset: 0x003BB8D7
		[NullableContext(2)]
		public FGetText(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060273D6 RID: 160726 RVA: 0x003BD6E1 File Offset: 0x003BB8E1
		public FGetText(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060273D7 RID: 160727 RVA: 0x003BD6EC File Offset: 0x003BB8EC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<FText>) ?? ((Func<FText>)Delegate.CreateDelegate(typeof(Func<FText>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060273D8 RID: 160728 RVA: 0x003BD71E File Offset: 0x003BB91E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<FText> Callback)
		{
			if (FGetText.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetText.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetText.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetText.OnScriptCallback));
				}
				FGetText.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGetText.RegisterId);
		}

		// Token: 0x060273D9 RID: 160729 RVA: 0x003BD758 File Offset: 0x003BB958
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FText Execute()
		{
			FGetText.__FGetText_DelegateParams* ptr = stackalloc FGetText.__FGetText_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FGetText.__FGetText_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetText.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			FText result = new FText(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(USlateAccessibleWidgetData.__GetText__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060273DA RID: 160730 RVA: 0x003BD7B0 File Offset: 0x003BB9B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<FText> func = target as Func<FText>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FText ftext = func();
			FText.NativeCopy((void*)(&((FGetText.__FGetText_DelegateParams*)__Parameters)->__Result), ftext.NativePtr, 1);
		}

		// Token: 0x040158FF RID: 88319
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.SlateAccessibleWidgetData:GetText__DelegateSignature";

		// Token: 0x04015900 RID: 88320
		private static int RegisterId;

		// Token: 0x02003B7F RID: 15231
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FGetText_DelegateParams
		{
			// Token: 0x04017D59 RID: 97625
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003B80 RID: 15232
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D5A RID: 97626
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
