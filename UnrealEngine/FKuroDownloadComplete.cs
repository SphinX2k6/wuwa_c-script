using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001989 RID: 6537
	public sealed class FKuroDownloadComplete : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601846E RID: 99438 RVA: 0x0023CFDF File Offset: 0x0023B1DF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroDownloadComplete.StaticFunctionPtr();
		}

		// Token: 0x0601846F RID: 99439 RVA: 0x0023CFEB File Offset: 0x0023B1EB
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroDownloadComplete._FunctionPtr == IntPtr.Zero)
			{
				FKuroDownloadComplete._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroHotPatch.KuroDownloadComplete__DelegateSignature");
			}
			return FKuroDownloadComplete._FunctionPtr;
		}

		// Token: 0x06018470 RID: 99440 RVA: 0x0023D00E File Offset: 0x0023B20E
		public FKuroDownloadComplete()
		{
		}

		// Token: 0x06018471 RID: 99441 RVA: 0x0023D016 File Offset: 0x0023B216
		[NullableContext(2)]
		public FKuroDownloadComplete(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018472 RID: 99442 RVA: 0x0023D020 File Offset: 0x0023B220
		public FKuroDownloadComplete(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018473 RID: 99443 RVA: 0x0023D02B File Offset: 0x0023B22B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<byte, int>) ?? ((Action<byte, int>)Delegate.CreateDelegate(typeof(Action<byte, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018474 RID: 99444 RVA: 0x0023D05D File Offset: 0x0023B25D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06018475 RID: 99445 RVA: 0x0023D098 File Offset: 0x0023B298
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(byte DownloadState, int HttpState)
		{
			FKuroDownloadComplete.__FKuroDownloadComplete_DelegateParams* ptr = stackalloc FKuroDownloadComplete.__FKuroDownloadComplete_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FKuroDownloadComplete.__FKuroDownloadComplete_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroDownloadComplete.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DownloadState = DownloadState;
			ptr->HttpState = HttpState;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06018476 RID: 99446 RVA: 0x0023D0DC File Offset: 0x0023B2DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<byte, int> action = target as Action<byte, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroDownloadComplete.__FKuroDownloadComplete_DelegateParams*)__Parameters)->DownloadState, ((FKuroDownloadComplete.__FKuroDownloadComplete_DelegateParams*)__Parameters)->HttpState);
		}

		// Token: 0x0400D254 RID: 53844
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D255 RID: 53845
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroHotPatch.KuroDownloadComplete__DelegateSignature";

		// Token: 0x0400D256 RID: 53846
		private static int RegisterId;

		// Token: 0x02003080 RID: 12416
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FKuroDownloadComplete_DelegateParams
		{
			// Token: 0x04016D5C RID: 93532
			[FieldOffset(0)]
			public byte DownloadState;

			// Token: 0x04016D5D RID: 93533
			[FieldOffset(4)]
			public int HttpState;
		}

		// Token: 0x02003081 RID: 12417
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D5E RID: 93534
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
