using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001822 RID: 6178
	public sealed class FOnFileReadAsync : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06016D17 RID: 93463 RVA: 0x00214FEF File Offset: 0x002131EF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnFileReadAsync.StaticFunctionPtr();
		}

		// Token: 0x06016D18 RID: 93464 RVA: 0x00214FFB File Offset: 0x002131FB
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnFileReadAsync._FunctionPtr == IntPtr.Zero)
			{
				FOnFileReadAsync._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroEditorRuntime.OnFileReadAsync__DelegateSignature");
			}
			return FOnFileReadAsync._FunctionPtr;
		}

		// Token: 0x06016D19 RID: 93465 RVA: 0x0021501E File Offset: 0x0021321E
		public FOnFileReadAsync()
		{
		}

		// Token: 0x06016D1A RID: 93466 RVA: 0x00215026 File Offset: 0x00213226
		[NullableContext(2)]
		public FOnFileReadAsync(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016D1B RID: 93467 RVA: 0x00215030 File Offset: 0x00213230
		public FOnFileReadAsync(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016D1C RID: 93468 RVA: 0x0021503B File Offset: 0x0021323B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, string>) ?? ((Action<bool, string>)Delegate.CreateDelegate(typeof(Action<bool, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06016D1D RID: 93469 RVA: 0x0021506D File Offset: 0x0021326D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06016D1E RID: 93470 RVA: 0x002150A8 File Offset: 0x002132A8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool IsSuccess, string FileContent)
		{
			FOnFileReadAsync.__FOnFileReadAsync_DelegateParams* ptr = stackalloc FOnFileReadAsync.__FOnFileReadAsync_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnFileReadAsync.__FOnFileReadAsync_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnFileReadAsync.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->IsSuccess = IsSuccess;
			FString.CopyFrom((void*)(&ptr->FileContent), FileContent);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnFileReadAsync._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06016D1F RID: 93471 RVA: 0x00215104 File Offset: 0x00213304
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400C651 RID: 50769
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C652 RID: 50770
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroEditorRuntime.OnFileReadAsync__DelegateSignature";

		// Token: 0x0400C653 RID: 50771
		private static int RegisterId;

		// Token: 0x02002F62 RID: 12130
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnFileReadAsync_DelegateParams
		{
			// Token: 0x04016B18 RID: 92952
			[FieldOffset(0)]
			public bool IsSuccess;

			// Token: 0x04016B19 RID: 92953
			[FieldOffset(8)]
			public FString FileContent;
		}

		// Token: 0x02002F63 RID: 12131
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B1A RID: 92954
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
