using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004E9 RID: 1257
	public sealed class FKuroUiSceneLoadCompleteDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600769E RID: 30366 RVA: 0x000AD3B2 File Offset: 0x000AB5B2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroUiSceneLoadCompleteDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600769F RID: 30367 RVA: 0x000AD3BE File Offset: 0x000AB5BE
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroUiSceneLoadCompleteDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroUiSceneLoadCompleteDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneLoadCompleteDelegate__DelegateSignature");
			}
			return FKuroUiSceneLoadCompleteDelegate._FunctionPtr;
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x000AD3E1 File Offset: 0x000AB5E1
		public FKuroUiSceneLoadCompleteDelegate()
		{
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x000AD3E9 File Offset: 0x000AB5E9
		[NullableContext(2)]
		public FKuroUiSceneLoadCompleteDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x000AD3F3 File Offset: 0x000AB5F3
		public FKuroUiSceneLoadCompleteDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x000AD3FE File Offset: 0x000AB5FE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060076A4 RID: 30372 RVA: 0x000AD430 File Offset: 0x000AB630
		[NullableContext(1)]
		public void Bind(Action<string> Callback)
		{
			if (FKuroUiSceneLoadCompleteDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroUiSceneLoadCompleteDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroUiSceneLoadCompleteDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroUiSceneLoadCompleteDelegate.OnScriptCallback));
				}
				FKuroUiSceneLoadCompleteDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroUiSceneLoadCompleteDelegate.RegisterId);
		}

		// Token: 0x060076A5 RID: 30373 RVA: 0x000AD46C File Offset: 0x000AB66C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string ScenePath)
		{
			FKuroUiSceneLoadCompleteDelegate.__FKuroUiSceneLoadCompleteDelegate_DelegateParams* ptr = stackalloc FKuroUiSceneLoadCompleteDelegate.__FKuroUiSceneLoadCompleteDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FKuroUiSceneLoadCompleteDelegate.__FKuroUiSceneLoadCompleteDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroUiSceneLoadCompleteDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ScenePath), ScenePath);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroUiSceneLoadCompleteDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060076A6 RID: 30374 RVA: 0x000AD4C0 File Offset: 0x000AB6C0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FKuroUiSceneLoadCompleteDelegate.__FKuroUiSceneLoadCompleteDelegate_DelegateParams*)__Parameters)->ScenePath));
			action(obj);
		}

		// Token: 0x04003205 RID: 12805
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003206 RID: 12806
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneLoadCompleteDelegate__DelegateSignature";

		// Token: 0x04003207 RID: 12807
		private static int RegisterId;

		// Token: 0x02000C27 RID: 3111
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FKuroUiSceneLoadCompleteDelegate_DelegateParams
		{
			// Token: 0x04005E74 RID: 24180
			[FieldOffset(0)]
			public FString ScenePath;
		}

		// Token: 0x02000C28 RID: 3112
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005E75 RID: 24181
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
