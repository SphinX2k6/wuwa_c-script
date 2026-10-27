using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200198A RID: 6538
	public sealed class FKuroDownloadProgress : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018477 RID: 99447 RVA: 0x0023D12C File Offset: 0x0023B32C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroDownloadProgress.StaticFunctionPtr();
		}

		// Token: 0x06018478 RID: 99448 RVA: 0x0023D138 File Offset: 0x0023B338
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroDownloadProgress._FunctionPtr == IntPtr.Zero)
			{
				FKuroDownloadProgress._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroHotPatch.KuroDownloadProgress__DelegateSignature");
			}
			return FKuroDownloadProgress._FunctionPtr;
		}

		// Token: 0x06018479 RID: 99449 RVA: 0x0023D15B File Offset: 0x0023B35B
		public FKuroDownloadProgress()
		{
		}

		// Token: 0x0601847A RID: 99450 RVA: 0x0023D163 File Offset: 0x0023B363
		[NullableContext(2)]
		public FKuroDownloadProgress(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601847B RID: 99451 RVA: 0x0023D16D File Offset: 0x0023B36D
		public FKuroDownloadProgress(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601847C RID: 99452 RVA: 0x0023D178 File Offset: 0x0023B378
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<long, long, long>) ?? ((Action<long, long, long>)Delegate.CreateDelegate(typeof(Action<long, long, long>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601847D RID: 99453 RVA: 0x0023D1AA File Offset: 0x0023B3AA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<long, long, long> Callback)
		{
			if (FKuroDownloadProgress.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroDownloadProgress.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroDownloadProgress.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroDownloadProgress.OnScriptCallback));
				}
				FKuroDownloadProgress.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroDownloadProgress.RegisterId);
		}

		// Token: 0x0601847E RID: 99454 RVA: 0x0023D1E4 File Offset: 0x0023B3E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(long ThisTimeReceiveSize, long ReceivedSize, long SavedSize)
		{
			FKuroDownloadProgress.__FKuroDownloadProgress_DelegateParams* ptr = stackalloc FKuroDownloadProgress.__FKuroDownloadProgress_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FKuroDownloadProgress.__FKuroDownloadProgress_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroDownloadProgress.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ThisTimeReceiveSize = ThisTimeReceiveSize;
			ptr->ReceivedSize = ReceivedSize;
			ptr->SavedSize = SavedSize;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601847F RID: 99455 RVA: 0x0023D230 File Offset: 0x0023B430
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<long, long, long> action = target as Action<long, long, long>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroDownloadProgress.__FKuroDownloadProgress_DelegateParams*)__Parameters)->ThisTimeReceiveSize, ((FKuroDownloadProgress.__FKuroDownloadProgress_DelegateParams*)__Parameters)->ReceivedSize, ((FKuroDownloadProgress.__FKuroDownloadProgress_DelegateParams*)__Parameters)->SavedSize);
		}

		// Token: 0x0400D257 RID: 53847
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D258 RID: 53848
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroHotPatch.KuroDownloadProgress__DelegateSignature";

		// Token: 0x0400D259 RID: 53849
		private static int RegisterId;

		// Token: 0x02003082 RID: 12418
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FKuroDownloadProgress_DelegateParams
		{
			// Token: 0x04016D5F RID: 93535
			[FieldOffset(0)]
			public long ThisTimeReceiveSize;

			// Token: 0x04016D60 RID: 93536
			[FieldOffset(8)]
			public long ReceivedSize;

			// Token: 0x04016D61 RID: 93537
			[FieldOffset(16)]
			public long SavedSize;
		}

		// Token: 0x02003083 RID: 12419
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D62 RID: 93538
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
