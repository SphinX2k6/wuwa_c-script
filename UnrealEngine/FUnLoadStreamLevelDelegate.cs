using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200061C RID: 1564
	public sealed class FUnLoadStreamLevelDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600890C RID: 35084 RVA: 0x000CEBE9 File Offset: 0x000CCDE9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUnLoadStreamLevelDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600890D RID: 35085 RVA: 0x000CEBF5 File Offset: 0x000CCDF5
		private static IntPtr StaticFunctionPtr()
		{
			if (FUnLoadStreamLevelDelegate._FunctionPtr == IntPtr.Zero)
			{
				FUnLoadStreamLevelDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.UnLoadStreamLevelDelegate__DelegateSignature");
			}
			return FUnLoadStreamLevelDelegate._FunctionPtr;
		}

		// Token: 0x0600890E RID: 35086 RVA: 0x000CEC18 File Offset: 0x000CCE18
		public FUnLoadStreamLevelDelegate()
		{
		}

		// Token: 0x0600890F RID: 35087 RVA: 0x000CEC20 File Offset: 0x000CCE20
		[NullableContext(2)]
		public FUnLoadStreamLevelDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008910 RID: 35088 RVA: 0x000CEC2A File Offset: 0x000CCE2A
		public FUnLoadStreamLevelDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008911 RID: 35089 RVA: 0x000CEC35 File Offset: 0x000CCE35
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, FName>) ?? ((Action<int, FName>)Delegate.CreateDelegate(typeof(Action<int, FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008912 RID: 35090 RVA: 0x000CEC67 File Offset: 0x000CCE67
		[NullableContext(1)]
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

		// Token: 0x06008913 RID: 35091 RVA: 0x000CECA4 File Offset: 0x000CCEA4
		[SkipLocalsInit]
		public unsafe void Execute(int LinkId, in FName LevelName)
		{
			FUnLoadStreamLevelDelegate.__FUnLoadStreamLevelDelegate_DelegateParams* ptr = stackalloc FUnLoadStreamLevelDelegate.__FUnLoadStreamLevelDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FUnLoadStreamLevelDelegate.__FUnLoadStreamLevelDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUnLoadStreamLevelDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->LinkId = LinkId;
			ptr->LevelName = LevelName;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008914 RID: 35092 RVA: 0x000CECF0 File Offset: 0x000CCEF0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, FName> action = target as Action<int, FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FUnLoadStreamLevelDelegate.__FUnLoadStreamLevelDelegate_DelegateParams*)__Parameters)->LinkId, ((FUnLoadStreamLevelDelegate.__FUnLoadStreamLevelDelegate_DelegateParams*)__Parameters)->LevelName);
		}

		// Token: 0x04003B7E RID: 15230
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B7F RID: 15231
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.UnLoadStreamLevelDelegate__DelegateSignature";

		// Token: 0x04003B80 RID: 15232
		private static int RegisterId;

		// Token: 0x02000E4C RID: 3660
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FUnLoadStreamLevelDelegate_DelegateParams
		{
			// Token: 0x040061E6 RID: 25062
			[FieldOffset(0)]
			public int LinkId;

			// Token: 0x040061E7 RID: 25063
			[FieldOffset(4)]
			public FName LevelName;
		}

		// Token: 0x02000E4D RID: 3661
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061E8 RID: 25064
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
