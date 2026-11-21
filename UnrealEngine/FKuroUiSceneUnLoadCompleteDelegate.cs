using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004EB RID: 1259
	public sealed class FKuroUiSceneUnLoadCompleteDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060076D2 RID: 30418 RVA: 0x000AD8F2 File Offset: 0x000ABAF2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroUiSceneUnLoadCompleteDelegate.StaticFunctionPtr();
		}

		// Token: 0x060076D3 RID: 30419 RVA: 0x000AD8FE File Offset: 0x000ABAFE
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroUiSceneUnLoadCompleteDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroUiSceneUnLoadCompleteDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneUnLoadCompleteDelegate__DelegateSignature");
			}
			return FKuroUiSceneUnLoadCompleteDelegate._FunctionPtr;
		}

		// Token: 0x060076D4 RID: 30420 RVA: 0x000AD921 File Offset: 0x000ABB21
		public FKuroUiSceneUnLoadCompleteDelegate()
		{
		}

		// Token: 0x060076D5 RID: 30421 RVA: 0x000AD929 File Offset: 0x000ABB29
		[NullableContext(2)]
		public FKuroUiSceneUnLoadCompleteDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060076D6 RID: 30422 RVA: 0x000AD933 File Offset: 0x000ABB33
		public FKuroUiSceneUnLoadCompleteDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x000AD93E File Offset: 0x000ABB3E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x000AD970 File Offset: 0x000ABB70
		[NullableContext(1)]
		public void Bind(Action<string> Callback)
		{
			if (FKuroUiSceneUnLoadCompleteDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroUiSceneUnLoadCompleteDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroUiSceneUnLoadCompleteDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroUiSceneUnLoadCompleteDelegate.OnScriptCallback));
				}
				FKuroUiSceneUnLoadCompleteDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroUiSceneUnLoadCompleteDelegate.RegisterId);
		}

		// Token: 0x060076D9 RID: 30425 RVA: 0x000AD9AC File Offset: 0x000ABBAC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string ScenePath)
		{
			FKuroUiSceneUnLoadCompleteDelegate.__FKuroUiSceneUnLoadCompleteDelegate_DelegateParams* ptr = stackalloc FKuroUiSceneUnLoadCompleteDelegate.__FKuroUiSceneUnLoadCompleteDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FKuroUiSceneUnLoadCompleteDelegate.__FKuroUiSceneUnLoadCompleteDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroUiSceneUnLoadCompleteDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ScenePath), ScenePath);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroUiSceneUnLoadCompleteDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060076DA RID: 30426 RVA: 0x000ADA00 File Offset: 0x000ABC00
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FKuroUiSceneUnLoadCompleteDelegate.__FKuroUiSceneUnLoadCompleteDelegate_DelegateParams*)__Parameters)->ScenePath));
			action(obj);
		}

		// Token: 0x04003218 RID: 12824
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003219 RID: 12825
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneUnLoadCompleteDelegate__DelegateSignature";

		// Token: 0x0400321A RID: 12826
		private static int RegisterId;

		// Token: 0x02000C29 RID: 3113
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FKuroUiSceneUnLoadCompleteDelegate_DelegateParams
		{
			// Token: 0x04005E76 RID: 24182
			[FieldOffset(0)]
			public FString ScenePath;
		}

		// Token: 0x02000C2A RID: 3114
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005E77 RID: 24183
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
