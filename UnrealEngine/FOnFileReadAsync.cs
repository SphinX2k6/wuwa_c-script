using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000377 RID: 887
	public sealed class FOnFileReadAsync : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060059DD RID: 23005 RVA: 0x0007EF57 File Offset: 0x0007D157
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnFileReadAsync.StaticFunctionPtr();
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x0007EF63 File Offset: 0x0007D163
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnFileReadAsync._FunctionPtr == IntPtr.Zero)
			{
				FOnFileReadAsync._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroEditorRuntime.OnFileReadAsync__DelegateSignature");
			}
			return FOnFileReadAsync._FunctionPtr;
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x0007EF86 File Offset: 0x0007D186
		public FOnFileReadAsync()
		{
		}

		// Token: 0x060059E0 RID: 23008 RVA: 0x0007EF8E File Offset: 0x0007D18E
		[NullableContext(2)]
		public FOnFileReadAsync(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060059E1 RID: 23009 RVA: 0x0007EF98 File Offset: 0x0007D198
		public FOnFileReadAsync(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060059E2 RID: 23010 RVA: 0x0007EFA3 File Offset: 0x0007D1A3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, string>) ?? ((Action<bool, string>)Delegate.CreateDelegate(typeof(Action<bool, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060059E3 RID: 23011 RVA: 0x0007EFD5 File Offset: 0x0007D1D5
		[NullableContext(1)]
		public void Bind(Action<bool, string> Callback)
		{
			if (FOnFileReadAsync.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnFileReadAsync.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnFileReadAsync.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnFileReadAsync.OnScriptCallback));
				}
				FOnFileReadAsync.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnFileReadAsync.RegisterId);
		}

		// Token: 0x060059E4 RID: 23012 RVA: 0x0007F010 File Offset: 0x0007D210
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(bool IsSuccess, string FileContent)
		{
			FOnFileReadAsync.__FOnFileReadAsync_DelegateParams* ptr = stackalloc FOnFileReadAsync.__FOnFileReadAsync_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnFileReadAsync.__FOnFileReadAsync_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnFileReadAsync.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->IsSuccess = IsSuccess;
			FString.CopyFrom((void*)(&ptr->FileContent), FileContent);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnFileReadAsync._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060059E5 RID: 23013 RVA: 0x0007F06C File Offset: 0x0007D26C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, string> action = target as Action<bool, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FOnFileReadAsync.__FOnFileReadAsync_DelegateParams*)__Parameters)->FileContent));
			action(((FOnFileReadAsync.__FOnFileReadAsync_DelegateParams*)__Parameters)->IsSuccess, arg);
		}

		// Token: 0x04002547 RID: 9543
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002548 RID: 9544
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroEditorRuntime.OnFileReadAsync__DelegateSignature";

		// Token: 0x04002549 RID: 9545
		private static int RegisterId;

		// Token: 0x02000A8B RID: 2699
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FOnFileReadAsync_DelegateParams
		{
			// Token: 0x04005ADA RID: 23258
			[FieldOffset(0)]
			public bool IsSuccess;

			// Token: 0x04005ADB RID: 23259
			[FieldOffset(8)]
			public FString FileContent;
		}

		// Token: 0x02000A8C RID: 2700
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005ADC RID: 23260
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
