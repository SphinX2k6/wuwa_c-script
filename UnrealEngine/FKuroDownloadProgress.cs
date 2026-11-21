using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000445 RID: 1093
	public sealed class FKuroDownloadProgress : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600695D RID: 26973 RVA: 0x00099FB8 File Offset: 0x000981B8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroDownloadProgress.StaticFunctionPtr();
		}

		// Token: 0x0600695E RID: 26974 RVA: 0x00099FC4 File Offset: 0x000981C4
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroDownloadProgress._FunctionPtr == IntPtr.Zero)
			{
				FKuroDownloadProgress._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroHotPatch.KuroDownloadProgress__DelegateSignature");
			}
			return FKuroDownloadProgress._FunctionPtr;
		}

		// Token: 0x0600695F RID: 26975 RVA: 0x00099FE7 File Offset: 0x000981E7
		public FKuroDownloadProgress()
		{
		}

		// Token: 0x06006960 RID: 26976 RVA: 0x00099FEF File Offset: 0x000981EF
		[NullableContext(2)]
		public FKuroDownloadProgress(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006961 RID: 26977 RVA: 0x00099FF9 File Offset: 0x000981F9
		public FKuroDownloadProgress(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006962 RID: 26978 RVA: 0x0009A004 File Offset: 0x00098204
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<long, long, long>) ?? ((Action<long, long, long>)Delegate.CreateDelegate(typeof(Action<long, long, long>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006963 RID: 26979 RVA: 0x0009A036 File Offset: 0x00098236
		[NullableContext(1)]
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

		// Token: 0x06006964 RID: 26980 RVA: 0x0009A070 File Offset: 0x00098270
		[SkipLocalsInit]
		public unsafe void Execute(long ThisTimeReceiveSize, long ReceivedSize, long SavedSize)
		{
			FKuroDownloadProgress.__FKuroDownloadProgress_DelegateParams* ptr = stackalloc FKuroDownloadProgress.__FKuroDownloadProgress_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FKuroDownloadProgress.__FKuroDownloadProgress_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroDownloadProgress.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ThisTimeReceiveSize = ThisTimeReceiveSize;
			ptr->ReceivedSize = ReceivedSize;
			ptr->SavedSize = SavedSize;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x0009A0BC File Offset: 0x000982BC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<long, long, long> action = target as Action<long, long, long>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroDownloadProgress.__FKuroDownloadProgress_DelegateParams*)__Parameters)->ThisTimeReceiveSize, ((FKuroDownloadProgress.__FKuroDownloadProgress_DelegateParams*)__Parameters)->ReceivedSize, ((FKuroDownloadProgress.__FKuroDownloadProgress_DelegateParams*)__Parameters)->SavedSize);
		}

		// Token: 0x04002CE8 RID: 11496
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002CE9 RID: 11497
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroHotPatch.KuroDownloadProgress__DelegateSignature";

		// Token: 0x04002CEA RID: 11498
		private static int RegisterId;

		// Token: 0x02000B68 RID: 2920
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FKuroDownloadProgress_DelegateParams
		{
			// Token: 0x04005C82 RID: 23682
			[FieldOffset(0)]
			public long ThisTimeReceiveSize;

			// Token: 0x04005C83 RID: 23683
			[FieldOffset(8)]
			public long ReceivedSize;

			// Token: 0x04005C84 RID: 23684
			[FieldOffset(16)]
			public long SavedSize;
		}

		// Token: 0x02000B69 RID: 2921
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005C85 RID: 23685
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
