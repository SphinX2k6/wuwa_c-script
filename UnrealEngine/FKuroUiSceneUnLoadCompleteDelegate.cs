using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BDA RID: 7130
	public sealed class FKuroUiSceneUnLoadCompleteDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601B5F5 RID: 112117 RVA: 0x00285502 File Offset: 0x00283702
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroUiSceneUnLoadCompleteDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601B5F6 RID: 112118 RVA: 0x0028550E File Offset: 0x0028370E
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroUiSceneUnLoadCompleteDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroUiSceneUnLoadCompleteDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneUnLoadCompleteDelegate__DelegateSignature");
			}
			return FKuroUiSceneUnLoadCompleteDelegate._FunctionPtr;
		}

		// Token: 0x0601B5F7 RID: 112119 RVA: 0x00285531 File Offset: 0x00283731
		public FKuroUiSceneUnLoadCompleteDelegate()
		{
		}

		// Token: 0x0601B5F8 RID: 112120 RVA: 0x00285539 File Offset: 0x00283739
		[NullableContext(2)]
		public FKuroUiSceneUnLoadCompleteDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B5F9 RID: 112121 RVA: 0x00285543 File Offset: 0x00283743
		public FKuroUiSceneUnLoadCompleteDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B5FA RID: 112122 RVA: 0x0028554E File Offset: 0x0028374E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601B5FB RID: 112123 RVA: 0x00285580 File Offset: 0x00283780
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601B5FC RID: 112124 RVA: 0x002855BC File Offset: 0x002837BC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string ScenePath)
		{
			FKuroUiSceneUnLoadCompleteDelegate.__FKuroUiSceneUnLoadCompleteDelegate_DelegateParams* ptr = stackalloc FKuroUiSceneUnLoadCompleteDelegate.__FKuroUiSceneUnLoadCompleteDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FKuroUiSceneUnLoadCompleteDelegate.__FKuroUiSceneUnLoadCompleteDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroUiSceneUnLoadCompleteDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ScenePath), ScenePath);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroUiSceneUnLoadCompleteDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601B5FD RID: 112125 RVA: 0x00285610 File Offset: 0x00283810
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
			string obj = FString.ToString((void*)(&((FKuroUiSceneUnLoadCompleteDelegate.__FKuroUiSceneUnLoadCompleteDelegate_DelegateParams*)__Parameters)->ScenePath));
			action(obj);
		}

		// Token: 0x0400EBC6 RID: 60358
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400EBC7 RID: 60359
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneUnLoadCompleteDelegate__DelegateSignature";

		// Token: 0x0400EBC8 RID: 60360
		private static int RegisterId;

		// Token: 0x02003184 RID: 12676
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FKuroUiSceneUnLoadCompleteDelegate_DelegateParams
		{
			// Token: 0x04016FC2 RID: 94146
			[FieldOffset(0)]
			public FString ScenePath;
		}

		// Token: 0x02003185 RID: 12677
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016FC3 RID: 94147
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
