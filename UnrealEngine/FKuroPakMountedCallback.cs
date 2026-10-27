using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A14 RID: 6676
	public sealed class FKuroPakMountedCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018B97 RID: 101271 RVA: 0x00247C5A File Offset: 0x00245E5A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroPakMountedCallback.StaticFunctionPtr();
		}

		// Token: 0x06018B98 RID: 101272 RVA: 0x00247C66 File Offset: 0x00245E66
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroPakMountedCallback._FunctionPtr == IntPtr.Zero)
			{
				FKuroPakMountedCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroPakKey.KuroPakMountedCallback__DelegateSignature");
			}
			return FKuroPakMountedCallback._FunctionPtr;
		}

		// Token: 0x06018B99 RID: 101273 RVA: 0x00247C89 File Offset: 0x00245E89
		public FKuroPakMountedCallback()
		{
		}

		// Token: 0x06018B9A RID: 101274 RVA: 0x00247C91 File Offset: 0x00245E91
		[NullableContext(2)]
		public FKuroPakMountedCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018B9B RID: 101275 RVA: 0x00247C9B File Offset: 0x00245E9B
		public FKuroPakMountedCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018B9C RID: 101276 RVA: 0x00247CA6 File Offset: 0x00245EA6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018B9D RID: 101277 RVA: 0x00247CD8 File Offset: 0x00245ED8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string> Callback)
		{
			if (FKuroPakMountedCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroPakMountedCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroPakMountedCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroPakMountedCallback.OnScriptCallback));
				}
				FKuroPakMountedCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroPakMountedCallback.RegisterId);
		}

		// Token: 0x06018B9E RID: 101278 RVA: 0x00247D14 File Offset: 0x00245F14
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string Tag)
		{
			FKuroPakMountedCallback.__FKuroPakMountedCallback_DelegateParams* ptr = stackalloc FKuroPakMountedCallback.__FKuroPakMountedCallback_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FKuroPakMountedCallback.__FKuroPakMountedCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroPakMountedCallback.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Tag), Tag);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroPakMountedCallback._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018B9F RID: 101279 RVA: 0x00247D68 File Offset: 0x00245F68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FKuroPakMountedCallback.__FKuroPakMountedCallback_DelegateParams*)__Parameters)->Tag));
			action(obj);
		}

		// Token: 0x0400D597 RID: 54679
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D598 RID: 54680
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPakKey.KuroPakMountedCallback__DelegateSignature";

		// Token: 0x0400D599 RID: 54681
		private static int RegisterId;

		// Token: 0x020030CB RID: 12491
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FKuroPakMountedCallback_DelegateParams
		{
			// Token: 0x04016E2A RID: 93738
			[FieldOffset(0)]
			public FString Tag;
		}

		// Token: 0x020030CC RID: 12492
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E2B RID: 93739
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
