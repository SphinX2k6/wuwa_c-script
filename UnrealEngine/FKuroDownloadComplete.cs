using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000444 RID: 1092
	public sealed class FKuroDownloadComplete : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006954 RID: 26964 RVA: 0x00099E6C File Offset: 0x0009806C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroDownloadComplete.StaticFunctionPtr();
		}

		// Token: 0x06006955 RID: 26965 RVA: 0x00099E78 File Offset: 0x00098078
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroDownloadComplete._FunctionPtr == IntPtr.Zero)
			{
				FKuroDownloadComplete._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroHotPatch.KuroDownloadComplete__DelegateSignature");
			}
			return FKuroDownloadComplete._FunctionPtr;
		}

		// Token: 0x06006956 RID: 26966 RVA: 0x00099E9B File Offset: 0x0009809B
		public FKuroDownloadComplete()
		{
		}

		// Token: 0x06006957 RID: 26967 RVA: 0x00099EA3 File Offset: 0x000980A3
		[NullableContext(2)]
		public FKuroDownloadComplete(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006958 RID: 26968 RVA: 0x00099EAD File Offset: 0x000980AD
		public FKuroDownloadComplete(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006959 RID: 26969 RVA: 0x00099EB8 File Offset: 0x000980B8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<byte, int>) ?? ((Action<byte, int>)Delegate.CreateDelegate(typeof(Action<byte, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x00099EEA File Offset: 0x000980EA
		[NullableContext(1)]
		public void Bind(Action<byte, int> Callback)
		{
			if (FKuroDownloadComplete.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroDownloadComplete.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroDownloadComplete.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroDownloadComplete.OnScriptCallback));
				}
				FKuroDownloadComplete.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroDownloadComplete.RegisterId);
		}

		// Token: 0x0600695B RID: 26971 RVA: 0x00099F24 File Offset: 0x00098124
		[SkipLocalsInit]
		public unsafe void Execute(byte DownloadState, int HttpState)
		{
			FKuroDownloadComplete.__FKuroDownloadComplete_DelegateParams* ptr = stackalloc FKuroDownloadComplete.__FKuroDownloadComplete_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FKuroDownloadComplete.__FKuroDownloadComplete_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroDownloadComplete.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DownloadState = DownloadState;
			ptr->HttpState = HttpState;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600695C RID: 26972 RVA: 0x00099F68 File Offset: 0x00098168
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<byte, int> action = target as Action<byte, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroDownloadComplete.__FKuroDownloadComplete_DelegateParams*)__Parameters)->DownloadState, ((FKuroDownloadComplete.__FKuroDownloadComplete_DelegateParams*)__Parameters)->HttpState);
		}

		// Token: 0x04002CE5 RID: 11493
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002CE6 RID: 11494
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroHotPatch.KuroDownloadComplete__DelegateSignature";

		// Token: 0x04002CE7 RID: 11495
		private static int RegisterId;

		// Token: 0x02000B66 RID: 2918
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FKuroDownloadComplete_DelegateParams
		{
			// Token: 0x04005C7F RID: 23679
			[FieldOffset(0)]
			public byte DownloadState;

			// Token: 0x04005C80 RID: 23680
			[FieldOffset(4)]
			public int HttpState;
		}

		// Token: 0x02000B67 RID: 2919
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005C81 RID: 23681
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
