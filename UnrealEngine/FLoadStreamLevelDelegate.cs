using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EDE RID: 7902
	public sealed class FLoadStreamLevelDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E0D2 RID: 123090 RVA: 0x002C97F4 File Offset: 0x002C79F4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLoadStreamLevelDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601E0D3 RID: 123091 RVA: 0x002C9800 File Offset: 0x002C7A00
		private static IntPtr StaticFunctionPtr()
		{
			if (FLoadStreamLevelDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLoadStreamLevelDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.LoadStreamLevelDelegate__DelegateSignature");
			}
			return FLoadStreamLevelDelegate._FunctionPtr;
		}

		// Token: 0x0601E0D4 RID: 123092 RVA: 0x002C9823 File Offset: 0x002C7A23
		public FLoadStreamLevelDelegate()
		{
		}

		// Token: 0x0601E0D5 RID: 123093 RVA: 0x002C982B File Offset: 0x002C7A2B
		[NullableContext(2)]
		public FLoadStreamLevelDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E0D6 RID: 123094 RVA: 0x002C9835 File Offset: 0x002C7A35
		public FLoadStreamLevelDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E0D7 RID: 123095 RVA: 0x002C9840 File Offset: 0x002C7A40
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, FName, ULevelStreaming>) ?? ((Action<int, FName, ULevelStreaming>)Delegate.CreateDelegate(typeof(Action<int, FName, ULevelStreaming>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E0D8 RID: 123096 RVA: 0x002C9872 File Offset: 0x002C7A72
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E0D9 RID: 123097 RVA: 0x002C98AC File Offset: 0x002C7AAC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int LinkId, in FName LevelName, ULevelStreaming StreamingLevel)
		{
			FLoadStreamLevelDelegate.__FLoadStreamLevelDelegate_DelegateParams* ptr = stackalloc FLoadStreamLevelDelegate.__FLoadStreamLevelDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FLoadStreamLevelDelegate.__FLoadStreamLevelDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLoadStreamLevelDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->LinkId = LinkId;
			ptr->LevelName = LevelName;
			ptr->StreamingLevel = ((StreamingLevel != null) ? StreamingLevel.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E0DA RID: 123098 RVA: 0x002C990C File Offset: 0x002C7B0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040103F4 RID: 66548
		internal static IntPtr _FunctionPtr;

		// Token: 0x040103F5 RID: 66549
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.LoadStreamLevelDelegate__DelegateSignature";

		// Token: 0x040103F6 RID: 66550
		private static int RegisterId;

		// Token: 0x020033A4 RID: 13220
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FLoadStreamLevelDelegate_DelegateParams
		{
			// Token: 0x04017355 RID: 95061
			[FieldOffset(0)]
			public int LinkId;

			// Token: 0x04017356 RID: 95062
			[FieldOffset(4)]
			public FName LevelName;

			// Token: 0x04017357 RID: 95063
			[FieldOffset(16)]
			public IntPtr StreamingLevel;
		}

		// Token: 0x020033A5 RID: 13221
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017358 RID: 95064
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
