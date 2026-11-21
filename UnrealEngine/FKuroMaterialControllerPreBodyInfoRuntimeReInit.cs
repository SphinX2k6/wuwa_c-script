using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004D2 RID: 1234
	public sealed class FKuroMaterialControllerPreBodyInfoRuntimeReInit : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007375 RID: 29557 RVA: 0x000A9342 File Offset: 0x000A7542
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroMaterialControllerPreBodyInfoRuntimeReInit.StaticFunctionPtr();
		}

		// Token: 0x06007376 RID: 29558 RVA: 0x000A934E File Offset: 0x000A754E
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroMaterialControllerPreBodyInfoRuntimeReInit._FunctionPtr == IntPtr.Zero)
			{
				FKuroMaterialControllerPreBodyInfoRuntimeReInit._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerPreBodyInfoRuntimeReInit__DelegateSignature");
			}
			return FKuroMaterialControllerPreBodyInfoRuntimeReInit._FunctionPtr;
		}

		// Token: 0x06007377 RID: 29559 RVA: 0x000A9371 File Offset: 0x000A7571
		public FKuroMaterialControllerPreBodyInfoRuntimeReInit()
		{
		}

		// Token: 0x06007378 RID: 29560 RVA: 0x000A9379 File Offset: 0x000A7579
		[NullableContext(2)]
		public FKuroMaterialControllerPreBodyInfoRuntimeReInit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x000A9383 File Offset: 0x000A7583
		public FKuroMaterialControllerPreBodyInfoRuntimeReInit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600737A RID: 29562 RVA: 0x000A938E File Offset: 0x000A758E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FName>) ?? ((Action<FName>)Delegate.CreateDelegate(typeof(Action<FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600737B RID: 29563 RVA: 0x000A93C0 File Offset: 0x000A75C0
		[NullableContext(1)]
		public void Bind(Action<FName> Callback)
		{
			if (FKuroMaterialControllerPreBodyInfoRuntimeReInit.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroMaterialControllerPreBodyInfoRuntimeReInit.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroMaterialControllerPreBodyInfoRuntimeReInit.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroMaterialControllerPreBodyInfoRuntimeReInit.OnScriptCallback));
				}
				FKuroMaterialControllerPreBodyInfoRuntimeReInit.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroMaterialControllerPreBodyInfoRuntimeReInit.RegisterId);
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x000A93FC File Offset: 0x000A75FC
		[SkipLocalsInit]
		public unsafe void Execute(FName BodyName)
		{
			FKuroMaterialControllerPreBodyInfoRuntimeReInit.__FKuroMaterialControllerPreBodyInfoRuntimeReInit_DelegateParams* ptr = stackalloc FKuroMaterialControllerPreBodyInfoRuntimeReInit.__FKuroMaterialControllerPreBodyInfoRuntimeReInit_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FKuroMaterialControllerPreBodyInfoRuntimeReInit.__FKuroMaterialControllerPreBodyInfoRuntimeReInit_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroMaterialControllerPreBodyInfoRuntimeReInit.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->BodyName = BodyName;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600737D RID: 29565 RVA: 0x000A943C File Offset: 0x000A763C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName> action = target as Action<FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroMaterialControllerPreBodyInfoRuntimeReInit.__FKuroMaterialControllerPreBodyInfoRuntimeReInit_DelegateParams*)__Parameters)->BodyName);
		}

		// Token: 0x04003178 RID: 12664
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003179 RID: 12665
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerPreBodyInfoRuntimeReInit__DelegateSignature";

		// Token: 0x0400317A RID: 12666
		private static int RegisterId;

		// Token: 0x02000C15 RID: 3093
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FKuroMaterialControllerPreBodyInfoRuntimeReInit_DelegateParams
		{
			// Token: 0x04005E4C RID: 24140
			[FieldOffset(0)]
			public FName BodyName;
		}

		// Token: 0x02000C16 RID: 3094
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005E4D RID: 24141
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
