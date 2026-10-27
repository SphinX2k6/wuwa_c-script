using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022FC RID: 8956
	public sealed class FOnRequestContentSucceeded : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021F15 RID: 139029 RVA: 0x0032322E File Offset: 0x0032142E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnRequestContentSucceeded.StaticFunctionPtr();
		}

		// Token: 0x06021F16 RID: 139030 RVA: 0x0032323A File Offset: 0x0032143A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnRequestContentSucceeded._FunctionPtr == IntPtr.Zero)
			{
				FOnRequestContentSucceeded._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MobilePatchingUtils.OnRequestContentSucceeded__DelegateSignature");
			}
			return FOnRequestContentSucceeded._FunctionPtr;
		}

		// Token: 0x06021F17 RID: 139031 RVA: 0x0032325D File Offset: 0x0032145D
		public FOnRequestContentSucceeded()
		{
		}

		// Token: 0x06021F18 RID: 139032 RVA: 0x00323265 File Offset: 0x00321465
		[NullableContext(2)]
		public FOnRequestContentSucceeded(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021F19 RID: 139033 RVA: 0x0032326F File Offset: 0x0032146F
		public FOnRequestContentSucceeded(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021F1A RID: 139034 RVA: 0x0032327A File Offset: 0x0032147A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UMobilePendingContent>) ?? ((Action<UMobilePendingContent>)Delegate.CreateDelegate(typeof(Action<UMobilePendingContent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021F1B RID: 139035 RVA: 0x003232AC File Offset: 0x003214AC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06021F1C RID: 139036 RVA: 0x003232E8 File Offset: 0x003214E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UMobilePendingContent MobilePendingContent)
		{
			FOnRequestContentSucceeded.__FOnRequestContentSucceeded_DelegateParams* ptr = stackalloc FOnRequestContentSucceeded.__FOnRequestContentSucceeded_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnRequestContentSucceeded.__FOnRequestContentSucceeded_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnRequestContentSucceeded.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->MobilePendingContent = ((MobilePendingContent != null) ? MobilePendingContent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06021F1D RID: 139037 RVA: 0x00323334 File Offset: 0x00321534
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040121AD RID: 74157
		internal static IntPtr _FunctionPtr;

		// Token: 0x040121AE RID: 74158
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MobilePatchingUtils.OnRequestContentSucceeded__DelegateSignature";

		// Token: 0x040121AF RID: 74159
		private static int RegisterId;

		// Token: 0x02003643 RID: 13891
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnRequestContentSucceeded_DelegateParams
		{
			// Token: 0x0401770B RID: 96011
			[FieldOffset(0)]
			public IntPtr MobilePendingContent;
		}

		// Token: 0x02003644 RID: 13892
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401770C RID: 96012
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
