using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004E8 RID: 1256
	public sealed class FKuroUiSceneInVisibleCompleteDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007695 RID: 30357 RVA: 0x000AD253 File Offset: 0x000AB453
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroUiSceneInVisibleCompleteDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007696 RID: 30358 RVA: 0x000AD25F File Offset: 0x000AB45F
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroUiSceneInVisibleCompleteDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroUiSceneInVisibleCompleteDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneInVisibleCompleteDelegate__DelegateSignature");
			}
			return FKuroUiSceneInVisibleCompleteDelegate._FunctionPtr;
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x000AD282 File Offset: 0x000AB482
		public FKuroUiSceneInVisibleCompleteDelegate()
		{
		}

		// Token: 0x06007698 RID: 30360 RVA: 0x000AD28A File Offset: 0x000AB48A
		[NullableContext(2)]
		public FKuroUiSceneInVisibleCompleteDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007699 RID: 30361 RVA: 0x000AD294 File Offset: 0x000AB494
		public FKuroUiSceneInVisibleCompleteDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x000AD29F File Offset: 0x000AB49F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600769B RID: 30363 RVA: 0x000AD2D1 File Offset: 0x000AB4D1
		[NullableContext(1)]
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

		// Token: 0x0600769C RID: 30364 RVA: 0x000AD30C File Offset: 0x000AB50C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string ScenePath)
		{
			FKuroUiSceneInVisibleCompleteDelegate.__FKuroUiSceneInVisibleCompleteDelegate_DelegateParams* ptr = stackalloc FKuroUiSceneInVisibleCompleteDelegate.__FKuroUiSceneInVisibleCompleteDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FKuroUiSceneInVisibleCompleteDelegate.__FKuroUiSceneInVisibleCompleteDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroUiSceneInVisibleCompleteDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ScenePath), ScenePath);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroUiSceneInVisibleCompleteDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600769D RID: 30365 RVA: 0x000AD360 File Offset: 0x000AB560
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003202 RID: 12802
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003203 RID: 12803
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneInVisibleCompleteDelegate__DelegateSignature";

		// Token: 0x04003204 RID: 12804
		private static int RegisterId;

		// Token: 0x02000C25 RID: 3109
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FKuroUiSceneInVisibleCompleteDelegate_DelegateParams
		{
			// Token: 0x04005E72 RID: 24178
			[FieldOffset(0)]
			public FString ScenePath;
		}

		// Token: 0x02000C26 RID: 3110
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005E73 RID: 24179
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
