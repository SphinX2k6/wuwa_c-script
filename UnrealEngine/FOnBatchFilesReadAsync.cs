using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001821 RID: 6177
	public sealed class FOnBatchFilesReadAsync : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06016D0E RID: 93454 RVA: 0x00214E02 File Offset: 0x00213002
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnBatchFilesReadAsync.StaticFunctionPtr();
		}

		// Token: 0x06016D0F RID: 93455 RVA: 0x00214E0E File Offset: 0x0021300E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnBatchFilesReadAsync._FunctionPtr == IntPtr.Zero)
			{
				FOnBatchFilesReadAsync._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroEditorRuntime.OnBatchFilesReadAsync__DelegateSignature");
			}
			return FOnBatchFilesReadAsync._FunctionPtr;
		}

		// Token: 0x06016D10 RID: 93456 RVA: 0x00214E31 File Offset: 0x00213031
		public FOnBatchFilesReadAsync()
		{
		}

		// Token: 0x06016D11 RID: 93457 RVA: 0x00214E39 File Offset: 0x00213039
		[NullableContext(2)]
		public FOnBatchFilesReadAsync(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016D12 RID: 93458 RVA: 0x00214E43 File Offset: 0x00213043
		public FOnBatchFilesReadAsync(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016D13 RID: 93459 RVA: 0x00214E4E File Offset: 0x0021304E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnBatchFilesReadAsync.FOnBatchFilesReadAsync_ScriptDelegate) ?? ((FOnBatchFilesReadAsync.FOnBatchFilesReadAsync_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnBatchFilesReadAsync.FOnBatchFilesReadAsync_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06016D14 RID: 93460 RVA: 0x00214E80 File Offset: 0x00213080
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06016D15 RID: 93461 RVA: 0x00214EBC File Offset: 0x002130BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06016D16 RID: 93462 RVA: 0x00214F54 File Offset: 0x00213154
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400C64E RID: 50766
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C64F RID: 50767
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroEditorRuntime.OnBatchFilesReadAsync__DelegateSignature";

		// Token: 0x0400C650 RID: 50768
		private static int RegisterId;

		// Token: 0x02002F5F RID: 12127
		// (Invoke) Token: 0x0602857A RID: 165242
		public delegate void FOnBatchFilesReadAsync_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FReadFileData> LoadedFiles, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> ReadFailedFiles);

		// Token: 0x02002F60 RID: 12128
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnBatchFilesReadAsync_DelegateParams
		{
			// Token: 0x04016B15 RID: 92949
			[FieldOffset(0)]
			public byte LoadedFiles;

			// Token: 0x04016B16 RID: 92950
			[FieldOffset(16)]
			public byte ReadFailedFiles;
		}

		// Token: 0x02002F61 RID: 12129
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B17 RID: 92951
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
