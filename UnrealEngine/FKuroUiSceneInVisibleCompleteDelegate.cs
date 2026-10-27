using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BD6 RID: 7126
	public sealed class FKuroUiSceneInVisibleCompleteDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601B5B1 RID: 112049 RVA: 0x00284DB1 File Offset: 0x00282FB1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroUiSceneInVisibleCompleteDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601B5B2 RID: 112050 RVA: 0x00284DBD File Offset: 0x00282FBD
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroUiSceneInVisibleCompleteDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroUiSceneInVisibleCompleteDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneInVisibleCompleteDelegate__DelegateSignature");
			}
			return FKuroUiSceneInVisibleCompleteDelegate._FunctionPtr;
		}

		// Token: 0x0601B5B3 RID: 112051 RVA: 0x00284DE0 File Offset: 0x00282FE0
		public FKuroUiSceneInVisibleCompleteDelegate()
		{
		}

		// Token: 0x0601B5B4 RID: 112052 RVA: 0x00284DE8 File Offset: 0x00282FE8
		[NullableContext(2)]
		public FKuroUiSceneInVisibleCompleteDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B5B5 RID: 112053 RVA: 0x00284DF2 File Offset: 0x00282FF2
		public FKuroUiSceneInVisibleCompleteDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B5B6 RID: 112054 RVA: 0x00284DFD File Offset: 0x00282FFD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601B5B7 RID: 112055 RVA: 0x00284E2F File Offset: 0x0028302F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string> Callback)
		{
			if (FKuroUiSceneInVisibleCompleteDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroUiSceneInVisibleCompleteDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroUiSceneInVisibleCompleteDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroUiSceneInVisibleCompleteDelegate.OnScriptCallback));
				}
				FKuroUiSceneInVisibleCompleteDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroUiSceneInVisibleCompleteDelegate.RegisterId);
		}

		// Token: 0x0601B5B8 RID: 112056 RVA: 0x00284E6C File Offset: 0x0028306C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string ScenePath)
		{
			FKuroUiSceneInVisibleCompleteDelegate.__FKuroUiSceneInVisibleCompleteDelegate_DelegateParams* ptr = stackalloc FKuroUiSceneInVisibleCompleteDelegate.__FKuroUiSceneInVisibleCompleteDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FKuroUiSceneInVisibleCompleteDelegate.__FKuroUiSceneInVisibleCompleteDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroUiSceneInVisibleCompleteDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ScenePath), ScenePath);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroUiSceneInVisibleCompleteDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601B5B9 RID: 112057 RVA: 0x00284EC0 File Offset: 0x002830C0
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
			string obj = FString.ToString((void*)(&((FKuroUiSceneInVisibleCompleteDelegate.__FKuroUiSceneInVisibleCompleteDelegate_DelegateParams*)__Parameters)->ScenePath));
			action(obj);
		}

		// Token: 0x0400EBAD RID: 60333
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400EBAE RID: 60334
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneInVisibleCompleteDelegate__DelegateSignature";

		// Token: 0x0400EBAF RID: 60335
		private static int RegisterId;

		// Token: 0x02003180 RID: 12672
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FKuroUiSceneInVisibleCompleteDelegate_DelegateParams
		{
			// Token: 0x04016FBE RID: 94142
			[FieldOffset(0)]
			public FString ScenePath;
		}

		// Token: 0x02003181 RID: 12673
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016FBF RID: 94143
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
