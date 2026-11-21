using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200066B RID: 1643
	public sealed class FLGUIBehaviourLateUpdateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008E42 RID: 36418 RVA: 0x000D60E5 File Offset: 0x000D42E5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIBehaviourLateUpdateDelegate.StaticFunctionPtr();
		}

		// Token: 0x06008E43 RID: 36419 RVA: 0x000D60F1 File Offset: 0x000D42F1
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIBehaviourLateUpdateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIBehaviourLateUpdateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIBehaviourLateUpdateDelegate__DelegateSignature");
			}
			return FLGUIBehaviourLateUpdateDelegate._FunctionPtr;
		}

		// Token: 0x06008E44 RID: 36420 RVA: 0x000D6114 File Offset: 0x000D4314
		public FLGUIBehaviourLateUpdateDelegate()
		{
		}

		// Token: 0x06008E45 RID: 36421 RVA: 0x000D611C File Offset: 0x000D431C
		[NullableContext(2)]
		public FLGUIBehaviourLateUpdateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008E46 RID: 36422 RVA: 0x000D6126 File Offset: 0x000D4326
		public FLGUIBehaviourLateUpdateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008E47 RID: 36423 RVA: 0x000D6131 File Offset: 0x000D4331
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008E48 RID: 36424 RVA: 0x000D6163 File Offset: 0x000D4363
		[NullableContext(1)]
		public void Bind(Action<float> Callback)
		{
			if (FLGUIBehaviourLateUpdateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIBehaviourLateUpdateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIBehaviourLateUpdateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIBehaviourLateUpdateDelegate.OnScriptCallback));
				}
				FLGUIBehaviourLateUpdateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIBehaviourLateUpdateDelegate.RegisterId);
		}

		// Token: 0x06008E49 RID: 36425 RVA: 0x000D61A0 File Offset: 0x000D43A0
		[SkipLocalsInit]
		public unsafe void Execute(float DeltaTime)
		{
			FLGUIBehaviourLateUpdateDelegate.__FLGUIBehaviourLateUpdateDelegate_DelegateParams* ptr = stackalloc FLGUIBehaviourLateUpdateDelegate.__FLGUIBehaviourLateUpdateDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLGUIBehaviourLateUpdateDelegate.__FLGUIBehaviourLateUpdateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIBehaviourLateUpdateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008E4A RID: 36426 RVA: 0x000D61E0 File Offset: 0x000D43E0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIBehaviourLateUpdateDelegate.__FLGUIBehaviourLateUpdateDelegate_DelegateParams*)__Parameters)->DeltaTime);
		}

		// Token: 0x04003E9F RID: 16031
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003EA0 RID: 16032
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIBehaviourLateUpdateDelegate__DelegateSignature";

		// Token: 0x04003EA1 RID: 16033
		private static int RegisterId;

		// Token: 0x02000E76 RID: 3702
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FLGUIBehaviourLateUpdateDelegate_DelegateParams
		{
			// Token: 0x04006221 RID: 25121
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02000E77 RID: 3703
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006222 RID: 25122
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
