using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000616 RID: 1558
	public sealed class FTickHandler : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060088B3 RID: 34995 RVA: 0x000CE48E File Offset: 0x000CC68E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTickHandler.StaticFunctionPtr();
		}

		// Token: 0x060088B4 RID: 34996 RVA: 0x000CE49A File Offset: 0x000CC69A
		private static IntPtr StaticFunctionPtr()
		{
			if (FTickHandler._FunctionPtr == IntPtr.Zero)
			{
				FTickHandler._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.TickHandler__DelegateSignature");
			}
			return FTickHandler._FunctionPtr;
		}

		// Token: 0x060088B5 RID: 34997 RVA: 0x000CE4BD File Offset: 0x000CC6BD
		public FTickHandler()
		{
		}

		// Token: 0x060088B6 RID: 34998 RVA: 0x000CE4C5 File Offset: 0x000CC6C5
		[NullableContext(2)]
		public FTickHandler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060088B7 RID: 34999 RVA: 0x000CE4CF File Offset: 0x000CC6CF
		public FTickHandler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060088B8 RID: 35000 RVA: 0x000CE4DA File Offset: 0x000CC6DA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060088B9 RID: 35001 RVA: 0x000CE50C File Offset: 0x000CC70C
		[NullableContext(1)]
		public void Bind(Action<float> Callback)
		{
			if (FTickHandler.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTickHandler.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTickHandler.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTickHandler.OnScriptCallback));
				}
				FTickHandler.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTickHandler.RegisterId);
		}

		// Token: 0x060088BA RID: 35002 RVA: 0x000CE548 File Offset: 0x000CC748
		[SkipLocalsInit]
		public unsafe void Execute(float DeltaSeconds)
		{
			FTickHandler.__FTickHandler_DelegateParams* ptr = stackalloc FTickHandler.__FTickHandler_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FTickHandler.__FTickHandler_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTickHandler.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060088BB RID: 35003 RVA: 0x000CE588 File Offset: 0x000CC788
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FTickHandler.__FTickHandler_DelegateParams*)__Parameters)->DeltaSeconds);
		}

		// Token: 0x04003B5A RID: 15194
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B5B RID: 15195
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.TickHandler__DelegateSignature";

		// Token: 0x04003B5C RID: 15196
		private static int RegisterId;

		// Token: 0x02000E48 RID: 3656
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FTickHandler_DelegateParams
		{
			// Token: 0x040061E2 RID: 25058
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02000E49 RID: 3657
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061E3 RID: 25059
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
