using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B5D RID: 7005
	public sealed class FKuroMaterialControllerPostBodyInfoRuntimeReInit : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601A86B RID: 108651 RVA: 0x00271BA7 File Offset: 0x0026FDA7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroMaterialControllerPostBodyInfoRuntimeReInit.StaticFunctionPtr();
		}

		// Token: 0x0601A86C RID: 108652 RVA: 0x00271BB3 File Offset: 0x0026FDB3
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroMaterialControllerPostBodyInfoRuntimeReInit._FunctionPtr == IntPtr.Zero)
			{
				FKuroMaterialControllerPostBodyInfoRuntimeReInit._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerPostBodyInfoRuntimeReInit__DelegateSignature");
			}
			return FKuroMaterialControllerPostBodyInfoRuntimeReInit._FunctionPtr;
		}

		// Token: 0x0601A86D RID: 108653 RVA: 0x00271BD6 File Offset: 0x0026FDD6
		public FKuroMaterialControllerPostBodyInfoRuntimeReInit()
		{
		}

		// Token: 0x0601A86E RID: 108654 RVA: 0x00271BDE File Offset: 0x0026FDDE
		[NullableContext(2)]
		public FKuroMaterialControllerPostBodyInfoRuntimeReInit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A86F RID: 108655 RVA: 0x00271BE8 File Offset: 0x0026FDE8
		public FKuroMaterialControllerPostBodyInfoRuntimeReInit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A870 RID: 108656 RVA: 0x00271BF3 File Offset: 0x0026FDF3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FName>) ?? ((Action<FName>)Delegate.CreateDelegate(typeof(Action<FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601A871 RID: 108657 RVA: 0x00271C25 File Offset: 0x0026FE25
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601A872 RID: 108658 RVA: 0x00271C60 File Offset: 0x0026FE60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FName BodyName)
		{
			FKuroMaterialControllerPostBodyInfoRuntimeReInit.__FKuroMaterialControllerPostBodyInfoRuntimeReInit_DelegateParams* ptr = stackalloc FKuroMaterialControllerPostBodyInfoRuntimeReInit.__FKuroMaterialControllerPostBodyInfoRuntimeReInit_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FKuroMaterialControllerPostBodyInfoRuntimeReInit.__FKuroMaterialControllerPostBodyInfoRuntimeReInit_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroMaterialControllerPostBodyInfoRuntimeReInit.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->BodyName = BodyName;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601A873 RID: 108659 RVA: 0x00271CA0 File Offset: 0x0026FEA0
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
			action(((FKuroMaterialControllerPostBodyInfoRuntimeReInit.__FKuroMaterialControllerPostBodyInfoRuntimeReInit_DelegateParams*)__Parameters)->BodyName);
		}

		// Token: 0x0400E5DD RID: 58845
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400E5DE RID: 58846
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerPostBodyInfoRuntimeReInit__DelegateSignature";

		// Token: 0x0400E5DF RID: 58847
		private static int RegisterId;

		// Token: 0x02003155 RID: 12629
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FKuroMaterialControllerPostBodyInfoRuntimeReInit_DelegateParams
		{
			// Token: 0x04016F6C RID: 94060
			[FieldOffset(0)]
			public FName BodyName;
		}

		// Token: 0x02003156 RID: 12630
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016F6D RID: 94061
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
