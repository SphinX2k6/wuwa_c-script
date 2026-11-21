using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000376 RID: 886
	public sealed class FOnBatchFilesReadAsync : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060059D4 RID: 22996 RVA: 0x0007ED6A File Offset: 0x0007CF6A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnBatchFilesReadAsync.StaticFunctionPtr();
		}

		// Token: 0x060059D5 RID: 22997 RVA: 0x0007ED76 File Offset: 0x0007CF76
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnBatchFilesReadAsync._FunctionPtr == IntPtr.Zero)
			{
				FOnBatchFilesReadAsync._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroEditorRuntime.OnBatchFilesReadAsync__DelegateSignature");
			}
			return FOnBatchFilesReadAsync._FunctionPtr;
		}

		// Token: 0x060059D6 RID: 22998 RVA: 0x0007ED99 File Offset: 0x0007CF99
		public FOnBatchFilesReadAsync()
		{
		}

		// Token: 0x060059D7 RID: 22999 RVA: 0x0007EDA1 File Offset: 0x0007CFA1
		[NullableContext(2)]
		public FOnBatchFilesReadAsync(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060059D8 RID: 23000 RVA: 0x0007EDAB File Offset: 0x0007CFAB
		public FOnBatchFilesReadAsync(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060059D9 RID: 23001 RVA: 0x0007EDB6 File Offset: 0x0007CFB6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnBatchFilesReadAsync.FOnBatchFilesReadAsync_ScriptDelegate) ?? ((FOnBatchFilesReadAsync.FOnBatchFilesReadAsync_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnBatchFilesReadAsync.FOnBatchFilesReadAsync_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x060059DA RID: 23002 RVA: 0x0007EDE8 File Offset: 0x0007CFE8
		[NullableContext(1)]
		public void Bind(FOnBatchFilesReadAsync.FOnBatchFilesReadAsync_ScriptDelegate Callback)
		{
			if (FOnBatchFilesReadAsync.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnBatchFilesReadAsync.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnBatchFilesReadAsync.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnBatchFilesReadAsync.OnScriptCallback));
				}
				FOnBatchFilesReadAsync.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnBatchFilesReadAsync.RegisterId);
		}

		// Token: 0x060059DB RID: 23003 RVA: 0x0007EE24 File Offset: 0x0007D024
		[SkipLocalsInit]
		public unsafe void Execute([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FReadFileData> LoadedFiles, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> ReadFailedFiles)
		{
			FOnBatchFilesReadAsync.__FOnBatchFilesReadAsync_DelegateParams* ptr = stackalloc FOnBatchFilesReadAsync.__FOnBatchFilesReadAsync_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnBatchFilesReadAsync.__FOnBatchFilesReadAsync_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnBatchFilesReadAsync.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<FReadFileData> tarray = LoadedFiles;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->LoadedFiles);
			}
			TArray<string> tarray2 = ReadFailedFiles;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->ReadFailedFiles);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<FReadFileData> tarray3 = LoadedFiles;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->LoadedFiles);
			}
			TArray<string> tarray4 = ReadFailedFiles;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->ReadFailedFiles);
			}
			UnrealReflectionUtils.DestroyStruct(FOnBatchFilesReadAsync._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060059DC RID: 23004 RVA: 0x0007EEBC File Offset: 0x0007D0BC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnBatchFilesReadAsync.FOnBatchFilesReadAsync_ScriptDelegate fonBatchFilesReadAsync_ScriptDelegate = target as FOnBatchFilesReadAsync.FOnBatchFilesReadAsync_ScriptDelegate;
			if (fonBatchFilesReadAsync_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FReadFileData> tarray = new TArray<FReadFileData>(&((FOnBatchFilesReadAsync.__FOnBatchFilesReadAsync_DelegateParams*)__Parameters)->LoadedFiles, true, true);
			TArray<string> tarray2 = new TArray<string>(&((FOnBatchFilesReadAsync.__FOnBatchFilesReadAsync_DelegateParams*)__Parameters)->ReadFailedFiles, true, true);
			fonBatchFilesReadAsync_ScriptDelegate(tarray, tarray2);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnBatchFilesReadAsync.__FOnBatchFilesReadAsync_DelegateParams*)__Parameters)->LoadedFiles, default(UScriptStructStackOnlyPtr));
			}
			if (tarray2 != null)
			{
				tarray2.CopyTo(&((FOnBatchFilesReadAsync.__FOnBatchFilesReadAsync_DelegateParams*)__Parameters)->ReadFailedFiles, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04002544 RID: 9540
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002545 RID: 9541
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroEditorRuntime.OnBatchFilesReadAsync__DelegateSignature";

		// Token: 0x04002546 RID: 9542
		private static int RegisterId;

		// Token: 0x02000A88 RID: 2696
		// (Invoke) Token: 0x0600BEEB RID: 48875
		public delegate void FOnBatchFilesReadAsync_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FReadFileData> LoadedFiles, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> ReadFailedFiles);

		// Token: 0x02000A89 RID: 2697
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FOnBatchFilesReadAsync_DelegateParams
		{
			// Token: 0x04005AD7 RID: 23255
			[FieldOffset(0)]
			public byte LoadedFiles;

			// Token: 0x04005AD8 RID: 23256
			[FieldOffset(16)]
			public byte ReadFailedFiles;
		}

		// Token: 0x02000A8A RID: 2698
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005AD9 RID: 23257
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
