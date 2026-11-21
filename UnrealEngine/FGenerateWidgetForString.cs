using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000859 RID: 2137
	public sealed class FGenerateWidgetForString : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BA0F RID: 47631 RVA: 0x00129E11 File Offset: 0x00128011
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGenerateWidgetForString.StaticFunctionPtr();
		}

		// Token: 0x0600BA10 RID: 47632 RVA: 0x00129E1D File Offset: 0x0012801D
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GenerateWidgetForString__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GenerateWidgetForString__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GenerateWidgetForString__DelegateSignature");
			}
			return UWidget.__GenerateWidgetForString__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600BA11 RID: 47633 RVA: 0x00129E40 File Offset: 0x00128040
		public FGenerateWidgetForString()
		{
		}

		// Token: 0x0600BA12 RID: 47634 RVA: 0x00129E48 File Offset: 0x00128048
		[NullableContext(2)]
		public FGenerateWidgetForString(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BA13 RID: 47635 RVA: 0x00129E52 File Offset: 0x00128052
		public FGenerateWidgetForString(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BA14 RID: 47636 RVA: 0x00129E5D File Offset: 0x0012805D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, UWidget>) ?? ((Func<string, UWidget>)Delegate.CreateDelegate(typeof(Func<string, UWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BA15 RID: 47637 RVA: 0x00129E8F File Offset: 0x0012808F
		public void Bind([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Func<string, UWidget> Callback)
		{
			if (FGenerateWidgetForString.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGenerateWidgetForString.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGenerateWidgetForString.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGenerateWidgetForString.OnScriptCallback));
				}
				FGenerateWidgetForString.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGenerateWidgetForString.RegisterId);
		}

		// Token: 0x0600BA16 RID: 47638 RVA: 0x00129ECC File Offset: 0x001280CC
		[NullableContext(1)]
		[SkipLocalsInit]
		[return: Nullable(2)]
		public unsafe UWidget Execute(string Item)
		{
			FGenerateWidgetForString.__FGenerateWidgetForString_DelegateParams* ptr = stackalloc FGenerateWidgetForString.__FGenerateWidgetForString_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FGenerateWidgetForString.__FGenerateWidgetForString_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGenerateWidgetForString.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Item), Item);
			base.ExecuteInternal((void*)ptr);
			UWidget orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidget>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UWidget.__GenerateWidgetForString__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600BA17 RID: 47639 RVA: 0x00129F2C File Offset: 0x0012812C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, UWidget> func = target as Func<string, UWidget>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FGenerateWidgetForString.__FGenerateWidgetForString_DelegateParams*)__Parameters)->Item));
			UWidget uwidget = func(arg);
			((FGenerateWidgetForString.__FGenerateWidgetForString_DelegateParams*)__Parameters)->__Result = ((uwidget != null) ? uwidget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0400547E RID: 21630
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GenerateWidgetForString__DelegateSignature";

		// Token: 0x0400547F RID: 21631
		private static int RegisterId;

		// Token: 0x020013EF RID: 5103
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FGenerateWidgetForString_DelegateParams
		{
			// Token: 0x04006898 RID: 26776
			[FieldOffset(0)]
			public FString Item;

			// Token: 0x04006899 RID: 26777
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x020013F0 RID: 5104
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400689A RID: 26778
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
