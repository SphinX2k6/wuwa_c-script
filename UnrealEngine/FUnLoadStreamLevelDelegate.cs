using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F11 RID: 7953
	public sealed class FUnLoadStreamLevelDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E2E6 RID: 123622 RVA: 0x002CDF76 File Offset: 0x002CC176
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUnLoadStreamLevelDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601E2E7 RID: 123623 RVA: 0x002CDF82 File Offset: 0x002CC182
		private static IntPtr StaticFunctionPtr()
		{
			if (FUnLoadStreamLevelDelegate._FunctionPtr == IntPtr.Zero)
			{
				FUnLoadStreamLevelDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.UnLoadStreamLevelDelegate__DelegateSignature");
			}
			return FUnLoadStreamLevelDelegate._FunctionPtr;
		}

		// Token: 0x0601E2E8 RID: 123624 RVA: 0x002CDFA5 File Offset: 0x002CC1A5
		public FUnLoadStreamLevelDelegate()
		{
		}

		// Token: 0x0601E2E9 RID: 123625 RVA: 0x002CDFAD File Offset: 0x002CC1AD
		[NullableContext(2)]
		public FUnLoadStreamLevelDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E2EA RID: 123626 RVA: 0x002CDFB7 File Offset: 0x002CC1B7
		public FUnLoadStreamLevelDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E2EB RID: 123627 RVA: 0x002CDFC2 File Offset: 0x002CC1C2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, FName>) ?? ((Action<int, FName>)Delegate.CreateDelegate(typeof(Action<int, FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E2EC RID: 123628 RVA: 0x002CDFF4 File Offset: 0x002CC1F4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, FName> Callback)
		{
			if (FUnLoadStreamLevelDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUnLoadStreamLevelDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUnLoadStreamLevelDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUnLoadStreamLevelDelegate.OnScriptCallback));
				}
				FUnLoadStreamLevelDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FUnLoadStreamLevelDelegate.RegisterId);
		}

		// Token: 0x0601E2ED RID: 123629 RVA: 0x002CE030 File Offset: 0x002CC230
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int LinkId, in FName LevelName)
		{
			FUnLoadStreamLevelDelegate.__FUnLoadStreamLevelDelegate_DelegateParams* ptr = stackalloc FUnLoadStreamLevelDelegate.__FUnLoadStreamLevelDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FUnLoadStreamLevelDelegate.__FUnLoadStreamLevelDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUnLoadStreamLevelDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->LinkId = LinkId;
			ptr->LevelName = LevelName;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E2EE RID: 123630 RVA: 0x002CE07C File Offset: 0x002CC27C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, FName> action = target as Action<int, FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FUnLoadStreamLevelDelegate.__FUnLoadStreamLevelDelegate_DelegateParams*)__Parameters)->LinkId, ((FUnLoadStreamLevelDelegate.__FUnLoadStreamLevelDelegate_DelegateParams*)__Parameters)->LevelName);
		}

		// Token: 0x040104B3 RID: 66739
		internal static IntPtr _FunctionPtr;

		// Token: 0x040104B4 RID: 66740
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.UnLoadStreamLevelDelegate__DelegateSignature";

		// Token: 0x040104B5 RID: 66741
		private static int RegisterId;

		// Token: 0x020033FF RID: 13311
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FUnLoadStreamLevelDelegate_DelegateParams
		{
			// Token: 0x040173B9 RID: 95161
			[FieldOffset(0)]
			public int LinkId;

			// Token: 0x040173BA RID: 95162
			[FieldOffset(4)]
			public FName LevelName;
		}

		// Token: 0x02003400 RID: 13312
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173BB RID: 95163
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
