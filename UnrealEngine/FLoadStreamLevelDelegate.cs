using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005EF RID: 1519
	public sealed class FLoadStreamLevelDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008742 RID: 34626 RVA: 0x000CAD60 File Offset: 0x000C8F60
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLoadStreamLevelDelegate.StaticFunctionPtr();
		}

		// Token: 0x06008743 RID: 34627 RVA: 0x000CAD6C File Offset: 0x000C8F6C
		private static IntPtr StaticFunctionPtr()
		{
			if (FLoadStreamLevelDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLoadStreamLevelDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.LoadStreamLevelDelegate__DelegateSignature");
			}
			return FLoadStreamLevelDelegate._FunctionPtr;
		}

		// Token: 0x06008744 RID: 34628 RVA: 0x000CAD8F File Offset: 0x000C8F8F
		public FLoadStreamLevelDelegate()
		{
		}

		// Token: 0x06008745 RID: 34629 RVA: 0x000CAD97 File Offset: 0x000C8F97
		[NullableContext(2)]
		public FLoadStreamLevelDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008746 RID: 34630 RVA: 0x000CADA1 File Offset: 0x000C8FA1
		public FLoadStreamLevelDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008747 RID: 34631 RVA: 0x000CADAC File Offset: 0x000C8FAC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, FName, ULevelStreaming>) ?? ((Action<int, FName, ULevelStreaming>)Delegate.CreateDelegate(typeof(Action<int, FName, ULevelStreaming>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008748 RID: 34632 RVA: 0x000CADDE File Offset: 0x000C8FDE
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<int, FName, ULevelStreaming> Callback)
		{
			if (FLoadStreamLevelDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLoadStreamLevelDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLoadStreamLevelDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLoadStreamLevelDelegate.OnScriptCallback));
				}
				FLoadStreamLevelDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLoadStreamLevelDelegate.RegisterId);
		}

		// Token: 0x06008749 RID: 34633 RVA: 0x000CAE18 File Offset: 0x000C9018
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(int LinkId, in FName LevelName, ULevelStreaming StreamingLevel)
		{
			FLoadStreamLevelDelegate.__FLoadStreamLevelDelegate_DelegateParams* ptr = stackalloc FLoadStreamLevelDelegate.__FLoadStreamLevelDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FLoadStreamLevelDelegate.__FLoadStreamLevelDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLoadStreamLevelDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->LinkId = LinkId;
			ptr->LevelName = LevelName;
			ptr->StreamingLevel = ((StreamingLevel != null) ? StreamingLevel.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600874A RID: 34634 RVA: 0x000CAE78 File Offset: 0x000C9078
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, FName, ULevelStreaming> action = target as Action<int, FName, ULevelStreaming>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ULevelStreaming orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelStreaming>(((FLoadStreamLevelDelegate.__FLoadStreamLevelDelegate_DelegateParams*)__Parameters)->StreamingLevel);
			action(((FLoadStreamLevelDelegate.__FLoadStreamLevelDelegate_DelegateParams*)__Parameters)->LinkId, ((FLoadStreamLevelDelegate.__FLoadStreamLevelDelegate_DelegateParams*)__Parameters)->LevelName, orCreateUObjectByNativePointer);
		}

		// Token: 0x04003AD8 RID: 15064
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003AD9 RID: 15065
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.LoadStreamLevelDelegate__DelegateSignature";

		// Token: 0x04003ADA RID: 15066
		private static int RegisterId;

		// Token: 0x02000DF9 RID: 3577
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FLoadStreamLevelDelegate_DelegateParams
		{
			// Token: 0x0400618A RID: 24970
			[FieldOffset(0)]
			public int LinkId;

			// Token: 0x0400618B RID: 24971
			[FieldOffset(4)]
			public FName LevelName;

			// Token: 0x0400618C RID: 24972
			[FieldOffset(16)]
			public IntPtr StreamingLevel;
		}

		// Token: 0x02000DFA RID: 3578
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400618D RID: 24973
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
