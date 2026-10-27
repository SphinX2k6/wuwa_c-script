using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BDB RID: 7131
	public sealed class FKuroUiSceneVisibleCompleteDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601B5FE RID: 112126 RVA: 0x00285662 File Offset: 0x00283862
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroUiSceneVisibleCompleteDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601B5FF RID: 112127 RVA: 0x0028566E File Offset: 0x0028386E
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroUiSceneVisibleCompleteDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroUiSceneVisibleCompleteDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneVisibleCompleteDelegate__DelegateSignature");
			}
			return FKuroUiSceneVisibleCompleteDelegate._FunctionPtr;
		}

		// Token: 0x0601B600 RID: 112128 RVA: 0x00285691 File Offset: 0x00283891
		public FKuroUiSceneVisibleCompleteDelegate()
		{
		}

		// Token: 0x0601B601 RID: 112129 RVA: 0x00285699 File Offset: 0x00283899
		[NullableContext(2)]
		public FKuroUiSceneVisibleCompleteDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B602 RID: 112130 RVA: 0x002856A3 File Offset: 0x002838A3
		public FKuroUiSceneVisibleCompleteDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B603 RID: 112131 RVA: 0x002856AE File Offset: 0x002838AE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601B604 RID: 112132 RVA: 0x002856E0 File Offset: 0x002838E0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601B605 RID: 112133 RVA: 0x0028571C File Offset: 0x0028391C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string ScenePath)
		{
			FKuroUiSceneVisibleCompleteDelegate.__FKuroUiSceneVisibleCompleteDelegate_DelegateParams* ptr = stackalloc FKuroUiSceneVisibleCompleteDelegate.__FKuroUiSceneVisibleCompleteDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FKuroUiSceneVisibleCompleteDelegate.__FKuroUiSceneVisibleCompleteDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroUiSceneVisibleCompleteDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ScenePath), ScenePath);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroUiSceneVisibleCompleteDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601B606 RID: 112134 RVA: 0x00285770 File Offset: 0x00283970
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
			string obj = FString.ToString((void*)(&((FKuroUiSceneVisibleCompleteDelegate.__FKuroUiSceneVisibleCompleteDelegate_DelegateParams*)__Parameters)->ScenePath));
			action(obj);
		}

		// Token: 0x0400EBC9 RID: 60361
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400EBCA RID: 60362
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneVisibleCompleteDelegate__DelegateSignature";

		// Token: 0x0400EBCB RID: 60363
		private static int RegisterId;

		// Token: 0x02003186 RID: 12678
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FKuroUiSceneVisibleCompleteDelegate_DelegateParams
		{
			// Token: 0x04016FC4 RID: 94148
			[FieldOffset(0)]
			public FString ScenePath;
		}

		// Token: 0x02003187 RID: 12679
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016FC5 RID: 94149
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
