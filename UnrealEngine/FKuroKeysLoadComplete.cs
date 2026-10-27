using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A11 RID: 6673
	public sealed class FKuroKeysLoadComplete : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018B6F RID: 101231 RVA: 0x002478AC File Offset: 0x00245AAC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroKeysLoadComplete.StaticFunctionPtr();
		}

		// Token: 0x06018B70 RID: 101232 RVA: 0x002478B8 File Offset: 0x00245AB8
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroKeysLoadComplete._FunctionPtr == IntPtr.Zero)
			{
				FKuroKeysLoadComplete._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroPakKey.KuroKeysLoadComplete__DelegateSignature");
			}
			return FKuroKeysLoadComplete._FunctionPtr;
		}

		// Token: 0x06018B71 RID: 101233 RVA: 0x002478DB File Offset: 0x00245ADB
		public FKuroKeysLoadComplete()
		{
		}

		// Token: 0x06018B72 RID: 101234 RVA: 0x002478E3 File Offset: 0x00245AE3
		[NullableContext(2)]
		public FKuroKeysLoadComplete(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018B73 RID: 101235 RVA: 0x002478ED File Offset: 0x00245AED
		public FKuroKeysLoadComplete(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018B74 RID: 101236 RVA: 0x002478F8 File Offset: 0x00245AF8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, string>) ?? ((Action<bool, string>)Delegate.CreateDelegate(typeof(Action<bool, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018B75 RID: 101237 RVA: 0x0024792A File Offset: 0x00245B2A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool, string> Callback)
		{
			if (FKuroKeysLoadComplete.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroKeysLoadComplete.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroKeysLoadComplete.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroKeysLoadComplete.OnScriptCallback));
				}
				FKuroKeysLoadComplete.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroKeysLoadComplete.RegisterId);
		}

		// Token: 0x06018B76 RID: 101238 RVA: 0x00247964 File Offset: 0x00245B64
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool Success, string Tag)
		{
			FKuroKeysLoadComplete.__FKuroKeysLoadComplete_DelegateParams* ptr = stackalloc FKuroKeysLoadComplete.__FKuroKeysLoadComplete_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FKuroKeysLoadComplete.__FKuroKeysLoadComplete_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroKeysLoadComplete.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Success = Success;
			FString.CopyFrom((void*)(&ptr->Tag), Tag);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroKeysLoadComplete._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018B77 RID: 101239 RVA: 0x002479C0 File Offset: 0x00245BC0
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
			string arg = FString.ToString((void*)(&((FKuroKeysLoadComplete.__FKuroKeysLoadComplete_DelegateParams*)__Parameters)->Tag));
			action(((FKuroKeysLoadComplete.__FKuroKeysLoadComplete_DelegateParams*)__Parameters)->Success, arg);
		}

		// Token: 0x0400D58A RID: 54666
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D58B RID: 54667
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPakKey.KuroKeysLoadComplete__DelegateSignature";

		// Token: 0x0400D58C RID: 54668
		private static int RegisterId;

		// Token: 0x020030C9 RID: 12489
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FKuroKeysLoadComplete_DelegateParams
		{
			// Token: 0x04016E27 RID: 93735
			[FieldOffset(0)]
			public bool Success;

			// Token: 0x04016E28 RID: 93736
			[FieldOffset(8)]
			public FString Tag;
		}

		// Token: 0x020030CA RID: 12490
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E29 RID: 93737
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
