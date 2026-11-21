using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004EC RID: 1260
	public sealed class FKuroUiSceneVisibleCompleteDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060076DB RID: 30427 RVA: 0x000ADA52 File Offset: 0x000ABC52
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroUiSceneVisibleCompleteDelegate.StaticFunctionPtr();
		}

		// Token: 0x060076DC RID: 30428 RVA: 0x000ADA5E File Offset: 0x000ABC5E
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroUiSceneVisibleCompleteDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroUiSceneVisibleCompleteDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneVisibleCompleteDelegate__DelegateSignature");
			}
			return FKuroUiSceneVisibleCompleteDelegate._FunctionPtr;
		}

		// Token: 0x060076DD RID: 30429 RVA: 0x000ADA81 File Offset: 0x000ABC81
		public FKuroUiSceneVisibleCompleteDelegate()
		{
		}

		// Token: 0x060076DE RID: 30430 RVA: 0x000ADA89 File Offset: 0x000ABC89
		[NullableContext(2)]
		public FKuroUiSceneVisibleCompleteDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060076DF RID: 30431 RVA: 0x000ADA93 File Offset: 0x000ABC93
		public FKuroUiSceneVisibleCompleteDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060076E0 RID: 30432 RVA: 0x000ADA9E File Offset: 0x000ABC9E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060076E1 RID: 30433 RVA: 0x000ADAD0 File Offset: 0x000ABCD0
		[NullableContext(1)]
		public void Bind(Action<string> Callback)
		{
			if (FKuroUiSceneVisibleCompleteDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroUiSceneVisibleCompleteDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroUiSceneVisibleCompleteDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroUiSceneVisibleCompleteDelegate.OnScriptCallback));
				}
				FKuroUiSceneVisibleCompleteDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroUiSceneVisibleCompleteDelegate.RegisterId);
		}

		// Token: 0x060076E2 RID: 30434 RVA: 0x000ADB0C File Offset: 0x000ABD0C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string ScenePath)
		{
			FKuroUiSceneVisibleCompleteDelegate.__FKuroUiSceneVisibleCompleteDelegate_DelegateParams* ptr = stackalloc FKuroUiSceneVisibleCompleteDelegate.__FKuroUiSceneVisibleCompleteDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FKuroUiSceneVisibleCompleteDelegate.__FKuroUiSceneVisibleCompleteDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroUiSceneVisibleCompleteDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ScenePath), ScenePath);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroUiSceneVisibleCompleteDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060076E3 RID: 30435 RVA: 0x000ADB60 File Offset: 0x000ABD60
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FKuroUiSceneVisibleCompleteDelegate.__FKuroUiSceneVisibleCompleteDelegate_DelegateParams*)__Parameters)->ScenePath));
			action(obj);
		}

		// Token: 0x0400321B RID: 12827
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400321C RID: 12828
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneVisibleCompleteDelegate__DelegateSignature";

		// Token: 0x0400321D RID: 12829
		private static int RegisterId;

		// Token: 0x02000C2B RID: 3115
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FKuroUiSceneVisibleCompleteDelegate_DelegateParams
		{
			// Token: 0x04005E78 RID: 24184
			[FieldOffset(0)]
			public FString ScenePath;
		}

		// Token: 0x02000C2C RID: 3116
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005E79 RID: 24185
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
