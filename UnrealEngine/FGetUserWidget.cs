using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002973 RID: 10611
	public sealed class FGetUserWidget : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060273DB RID: 160731 RVA: 0x003BD808 File Offset: 0x003BBA08
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetUserWidget.StaticFunctionPtr();
		}

		// Token: 0x060273DC RID: 160732 RVA: 0x003BD814 File Offset: 0x003BBA14
		private static IntPtr StaticFunctionPtr()
		{
			if (UMenuAnchor.__GetUserWidget__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UMenuAnchor.__GetUserWidget__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.MenuAnchor:GetUserWidget__DelegateSignature");
			}
			return UMenuAnchor.__GetUserWidget__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060273DD RID: 160733 RVA: 0x003BD837 File Offset: 0x003BBA37
		public FGetUserWidget()
		{
		}

		// Token: 0x060273DE RID: 160734 RVA: 0x003BD83F File Offset: 0x003BBA3F
		[NullableContext(2)]
		public FGetUserWidget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060273DF RID: 160735 RVA: 0x003BD849 File Offset: 0x003BBA49
		public FGetUserWidget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060273E0 RID: 160736 RVA: 0x003BD854 File Offset: 0x003BBA54
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<UUserWidget>) ?? ((Func<UUserWidget>)Delegate.CreateDelegate(typeof(Func<UUserWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060273E1 RID: 160737 RVA: 0x003BD886 File Offset: 0x003BBA86
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Func<UUserWidget> Callback)
		{
			if (FGetUserWidget.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetUserWidget.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetUserWidget.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetUserWidget.OnScriptCallback));
				}
				FGetUserWidget.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGetUserWidget.RegisterId);
		}

		// Token: 0x060273E2 RID: 160738 RVA: 0x003BD8C0 File Offset: 0x003BBAC0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UUserWidget Execute()
		{
			FGetUserWidget.__FGetUserWidget_DelegateParams* ptr = stackalloc FGetUserWidget.__FGetUserWidget_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FGetUserWidget.__FGetUserWidget_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetUserWidget.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(ptr->__Result);
		}

		// Token: 0x060273E3 RID: 160739 RVA: 0x003BD904 File Offset: 0x003BBB04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<UUserWidget> func = target as Func<UUserWidget>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUserWidget uuserWidget = func();
			((FGetUserWidget.__FGetUserWidget_DelegateParams*)__Parameters)->__Result = ((uuserWidget != null) ? uuserWidget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x04015901 RID: 88321
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.MenuAnchor:GetUserWidget__DelegateSignature";

		// Token: 0x04015902 RID: 88322
		private static int RegisterId;

		// Token: 0x02003B81 RID: 15233
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FGetUserWidget_DelegateParams
		{
			// Token: 0x04017D5B RID: 97627
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003B82 RID: 15234
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D5C RID: 97628
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
