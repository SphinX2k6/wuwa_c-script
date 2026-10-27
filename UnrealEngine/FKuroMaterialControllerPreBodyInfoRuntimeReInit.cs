using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B5E RID: 7006
	public sealed class FKuroMaterialControllerPreBodyInfoRuntimeReInit : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601A874 RID: 108660 RVA: 0x00271CEA File Offset: 0x0026FEEA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroMaterialControllerPreBodyInfoRuntimeReInit.StaticFunctionPtr();
		}

		// Token: 0x0601A875 RID: 108661 RVA: 0x00271CF6 File Offset: 0x0026FEF6
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroMaterialControllerPreBodyInfoRuntimeReInit._FunctionPtr == IntPtr.Zero)
			{
				FKuroMaterialControllerPreBodyInfoRuntimeReInit._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerPreBodyInfoRuntimeReInit__DelegateSignature");
			}
			return FKuroMaterialControllerPreBodyInfoRuntimeReInit._FunctionPtr;
		}

		// Token: 0x0601A876 RID: 108662 RVA: 0x00271D19 File Offset: 0x0026FF19
		public FKuroMaterialControllerPreBodyInfoRuntimeReInit()
		{
		}

		// Token: 0x0601A877 RID: 108663 RVA: 0x00271D21 File Offset: 0x0026FF21
		[NullableContext(2)]
		public FKuroMaterialControllerPreBodyInfoRuntimeReInit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A878 RID: 108664 RVA: 0x00271D2B File Offset: 0x0026FF2B
		public FKuroMaterialControllerPreBodyInfoRuntimeReInit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A879 RID: 108665 RVA: 0x00271D36 File Offset: 0x0026FF36
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FName>) ?? ((Action<FName>)Delegate.CreateDelegate(typeof(Action<FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601A87A RID: 108666 RVA: 0x00271D68 File Offset: 0x0026FF68
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601A87B RID: 108667 RVA: 0x00271DA4 File Offset: 0x0026FFA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FName BodyName)
		{
			FKuroMaterialControllerPreBodyInfoRuntimeReInit.__FKuroMaterialControllerPreBodyInfoRuntimeReInit_DelegateParams* ptr = stackalloc FKuroMaterialControllerPreBodyInfoRuntimeReInit.__FKuroMaterialControllerPreBodyInfoRuntimeReInit_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FKuroMaterialControllerPreBodyInfoRuntimeReInit.__FKuroMaterialControllerPreBodyInfoRuntimeReInit_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroMaterialControllerPreBodyInfoRuntimeReInit.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->BodyName = BodyName;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601A87C RID: 108668 RVA: 0x00271DE4 File Offset: 0x0026FFE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName> action = target as Action<FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroMaterialControllerPreBodyInfoRuntimeReInit.__FKuroMaterialControllerPreBodyInfoRuntimeReInit_DelegateParams*)__Parameters)->BodyName);
		}

		// Token: 0x0400E5E0 RID: 58848
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400E5E1 RID: 58849
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerPreBodyInfoRuntimeReInit__DelegateSignature";

		// Token: 0x0400E5E2 RID: 58850
		private static int RegisterId;

		// Token: 0x02003157 RID: 12631
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FKuroMaterialControllerPreBodyInfoRuntimeReInit_DelegateParams
		{
			// Token: 0x04016F6E RID: 94062
			[FieldOffset(0)]
			public FName BodyName;
		}

		// Token: 0x02003158 RID: 12632
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016F6F RID: 94063
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
