using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BD7 RID: 7127
	public sealed class FKuroUiSceneLoadCompleteDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601B5BA RID: 112058 RVA: 0x00284F12 File Offset: 0x00283112
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroUiSceneLoadCompleteDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601B5BB RID: 112059 RVA: 0x00284F1E File Offset: 0x0028311E
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroUiSceneLoadCompleteDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroUiSceneLoadCompleteDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneLoadCompleteDelegate__DelegateSignature");
			}
			return FKuroUiSceneLoadCompleteDelegate._FunctionPtr;
		}

		// Token: 0x0601B5BC RID: 112060 RVA: 0x00284F41 File Offset: 0x00283141
		public FKuroUiSceneLoadCompleteDelegate()
		{
		}

		// Token: 0x0601B5BD RID: 112061 RVA: 0x00284F49 File Offset: 0x00283149
		[NullableContext(2)]
		public FKuroUiSceneLoadCompleteDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B5BE RID: 112062 RVA: 0x00284F53 File Offset: 0x00283153
		public FKuroUiSceneLoadCompleteDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B5BF RID: 112063 RVA: 0x00284F5E File Offset: 0x0028315E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601B5C0 RID: 112064 RVA: 0x00284F90 File Offset: 0x00283190
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601B5C1 RID: 112065 RVA: 0x00284FCC File Offset: 0x002831CC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string ScenePath)
		{
			FKuroUiSceneLoadCompleteDelegate.__FKuroUiSceneLoadCompleteDelegate_DelegateParams* ptr = stackalloc FKuroUiSceneLoadCompleteDelegate.__FKuroUiSceneLoadCompleteDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FKuroUiSceneLoadCompleteDelegate.__FKuroUiSceneLoadCompleteDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroUiSceneLoadCompleteDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ScenePath), ScenePath);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroUiSceneLoadCompleteDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601B5C2 RID: 112066 RVA: 0x00285020 File Offset: 0x00283220
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
			string obj = FString.ToString((void*)(&((FKuroUiSceneLoadCompleteDelegate.__FKuroUiSceneLoadCompleteDelegate_DelegateParams*)__Parameters)->ScenePath));
			action(obj);
		}

		// Token: 0x0400EBB0 RID: 60336
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400EBB1 RID: 60337
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneLoadCompleteDelegate__DelegateSignature";

		// Token: 0x0400EBB2 RID: 60338
		private static int RegisterId;

		// Token: 0x02003182 RID: 12674
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FKuroUiSceneLoadCompleteDelegate_DelegateParams
		{
			// Token: 0x04016FC0 RID: 94144
			[FieldOffset(0)]
			public FString ScenePath;
		}

		// Token: 0x02003183 RID: 12675
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016FC1 RID: 94145
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
