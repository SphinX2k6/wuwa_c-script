using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200075D RID: 1885
	public sealed class FOnRequestContentSucceeded : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A449 RID: 42057 RVA: 0x000F294E File Offset: 0x000F0B4E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnRequestContentSucceeded.StaticFunctionPtr();
		}

		// Token: 0x0600A44A RID: 42058 RVA: 0x000F295A File Offset: 0x000F0B5A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnRequestContentSucceeded._FunctionPtr == IntPtr.Zero)
			{
				FOnRequestContentSucceeded._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MobilePatchingUtils.OnRequestContentSucceeded__DelegateSignature");
			}
			return FOnRequestContentSucceeded._FunctionPtr;
		}

		// Token: 0x0600A44B RID: 42059 RVA: 0x000F297D File Offset: 0x000F0B7D
		public FOnRequestContentSucceeded()
		{
		}

		// Token: 0x0600A44C RID: 42060 RVA: 0x000F2985 File Offset: 0x000F0B85
		[NullableContext(2)]
		public FOnRequestContentSucceeded(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A44D RID: 42061 RVA: 0x000F298F File Offset: 0x000F0B8F
		public FOnRequestContentSucceeded(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A44E RID: 42062 RVA: 0x000F299A File Offset: 0x000F0B9A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UMobilePendingContent>) ?? ((Action<UMobilePendingContent>)Delegate.CreateDelegate(typeof(Action<UMobilePendingContent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A44F RID: 42063 RVA: 0x000F29CC File Offset: 0x000F0BCC
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UMobilePendingContent> Callback)
		{
			if (FOnRequestContentSucceeded.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnRequestContentSucceeded.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnRequestContentSucceeded.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnRequestContentSucceeded.OnScriptCallback));
				}
				FOnRequestContentSucceeded.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnRequestContentSucceeded.RegisterId);
		}

		// Token: 0x0600A450 RID: 42064 RVA: 0x000F2A08 File Offset: 0x000F0C08
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UMobilePendingContent MobilePendingContent)
		{
			FOnRequestContentSucceeded.__FOnRequestContentSucceeded_DelegateParams* ptr = stackalloc FOnRequestContentSucceeded.__FOnRequestContentSucceeded_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnRequestContentSucceeded.__FOnRequestContentSucceeded_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnRequestContentSucceeded.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->MobilePendingContent = ((MobilePendingContent != null) ? MobilePendingContent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600A451 RID: 42065 RVA: 0x000F2A54 File Offset: 0x000F0C54
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UMobilePendingContent> action = target as Action<UMobilePendingContent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UMobilePendingContent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMobilePendingContent>(((FOnRequestContentSucceeded.__FOnRequestContentSucceeded_DelegateParams*)__Parameters)->MobilePendingContent);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04004608 RID: 17928
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004609 RID: 17929
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MobilePatchingUtils.OnRequestContentSucceeded__DelegateSignature";

		// Token: 0x0400460A RID: 17930
		private static int RegisterId;

		// Token: 0x02000F49 RID: 3913
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnRequestContentSucceeded_DelegateParams
		{
			// Token: 0x0400631F RID: 25375
			[FieldOffset(0)]
			public IntPtr MobilePendingContent;
		}

		// Token: 0x02000F4A RID: 3914
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006320 RID: 25376
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
