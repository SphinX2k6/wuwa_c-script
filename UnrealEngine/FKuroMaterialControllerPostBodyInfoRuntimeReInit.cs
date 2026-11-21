using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004D1 RID: 1233
	public sealed class FKuroMaterialControllerPostBodyInfoRuntimeReInit : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600736C RID: 29548 RVA: 0x000A91FE File Offset: 0x000A73FE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroMaterialControllerPostBodyInfoRuntimeReInit.StaticFunctionPtr();
		}

		// Token: 0x0600736D RID: 29549 RVA: 0x000A920A File Offset: 0x000A740A
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroMaterialControllerPostBodyInfoRuntimeReInit._FunctionPtr == IntPtr.Zero)
			{
				FKuroMaterialControllerPostBodyInfoRuntimeReInit._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerPostBodyInfoRuntimeReInit__DelegateSignature");
			}
			return FKuroMaterialControllerPostBodyInfoRuntimeReInit._FunctionPtr;
		}

		// Token: 0x0600736E RID: 29550 RVA: 0x000A922D File Offset: 0x000A742D
		public FKuroMaterialControllerPostBodyInfoRuntimeReInit()
		{
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x000A9235 File Offset: 0x000A7435
		[NullableContext(2)]
		public FKuroMaterialControllerPostBodyInfoRuntimeReInit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007370 RID: 29552 RVA: 0x000A923F File Offset: 0x000A743F
		public FKuroMaterialControllerPostBodyInfoRuntimeReInit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007371 RID: 29553 RVA: 0x000A924A File Offset: 0x000A744A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FName>) ?? ((Action<FName>)Delegate.CreateDelegate(typeof(Action<FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x000A927C File Offset: 0x000A747C
		[NullableContext(1)]
		public void Bind(Action<FName> Callback)
		{
			if (FKuroMaterialControllerPostBodyInfoRuntimeReInit.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroMaterialControllerPostBodyInfoRuntimeReInit.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroMaterialControllerPostBodyInfoRuntimeReInit.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroMaterialControllerPostBodyInfoRuntimeReInit.OnScriptCallback));
				}
				FKuroMaterialControllerPostBodyInfoRuntimeReInit.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroMaterialControllerPostBodyInfoRuntimeReInit.RegisterId);
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x000A92B8 File Offset: 0x000A74B8
		[SkipLocalsInit]
		public unsafe void Execute(FName BodyName)
		{
			FKuroMaterialControllerPostBodyInfoRuntimeReInit.__FKuroMaterialControllerPostBodyInfoRuntimeReInit_DelegateParams* ptr = stackalloc FKuroMaterialControllerPostBodyInfoRuntimeReInit.__FKuroMaterialControllerPostBodyInfoRuntimeReInit_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FKuroMaterialControllerPostBodyInfoRuntimeReInit.__FKuroMaterialControllerPostBodyInfoRuntimeReInit_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroMaterialControllerPostBodyInfoRuntimeReInit.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->BodyName = BodyName;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06007374 RID: 29556 RVA: 0x000A92F8 File Offset: 0x000A74F8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName> action = target as Action<FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroMaterialControllerPostBodyInfoRuntimeReInit.__FKuroMaterialControllerPostBodyInfoRuntimeReInit_DelegateParams*)__Parameters)->BodyName);
		}

		// Token: 0x04003175 RID: 12661
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003176 RID: 12662
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerPostBodyInfoRuntimeReInit__DelegateSignature";

		// Token: 0x04003177 RID: 12663
		private static int RegisterId;

		// Token: 0x02000C13 RID: 3091
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FKuroMaterialControllerPostBodyInfoRuntimeReInit_DelegateParams
		{
			// Token: 0x04005E4A RID: 24138
			[FieldOffset(0)]
			public FName BodyName;
		}

		// Token: 0x02000C14 RID: 3092
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005E4B RID: 24139
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
