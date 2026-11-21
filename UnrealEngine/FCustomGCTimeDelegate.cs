using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B8 RID: 1464
	public sealed class FCustomGCTimeDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008352 RID: 33618 RVA: 0x000C2525 File Offset: 0x000C0725
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCustomGCTimeDelegate.StaticFunctionPtr();
		}

		// Token: 0x06008353 RID: 33619 RVA: 0x000C2531 File Offset: 0x000C0731
		private static IntPtr StaticFunctionPtr()
		{
			if (FCustomGCTimeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FCustomGCTimeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.CustomGCTimeDelegate__DelegateSignature");
			}
			return FCustomGCTimeDelegate._FunctionPtr;
		}

		// Token: 0x06008354 RID: 33620 RVA: 0x000C2554 File Offset: 0x000C0754
		public FCustomGCTimeDelegate()
		{
		}

		// Token: 0x06008355 RID: 33621 RVA: 0x000C255C File Offset: 0x000C075C
		[NullableContext(2)]
		public FCustomGCTimeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008356 RID: 33622 RVA: 0x000C2566 File Offset: 0x000C0766
		public FCustomGCTimeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008357 RID: 33623 RVA: 0x000C2571 File Offset: 0x000C0771
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<float, float, int, float>) ?? ((Func<float, float, int, float>)Delegate.CreateDelegate(typeof(Func<float, float, int, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008358 RID: 33624 RVA: 0x000C25A3 File Offset: 0x000C07A3
		[NullableContext(1)]
		public void Bind(Func<float, float, int, float> Callback)
		{
			if (FCustomGCTimeDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCustomGCTimeDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCustomGCTimeDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCustomGCTimeDelegate.OnScriptCallback));
				}
				FCustomGCTimeDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FCustomGCTimeDelegate.RegisterId);
		}

		// Token: 0x06008359 RID: 33625 RVA: 0x000C25E0 File Offset: 0x000C07E0
		[SkipLocalsInit]
		public unsafe float Execute(float MBFree, float ExtraDevelopmentMemorySize, int NumObjects)
		{
			FCustomGCTimeDelegate.__FCustomGCTimeDelegate_DelegateParams* ptr = stackalloc FCustomGCTimeDelegate.__FCustomGCTimeDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FCustomGCTimeDelegate.__FCustomGCTimeDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FCustomGCTimeDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->MBFree = MBFree;
			ptr->ExtraDevelopmentMemorySize = ExtraDevelopmentMemorySize;
			ptr->NumObjects = NumObjects;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600835A RID: 33626 RVA: 0x000C2634 File Offset: 0x000C0834
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<float, float, int, float> func = target as Func<float, float, int, float>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			float _Result = func(((FCustomGCTimeDelegate.__FCustomGCTimeDelegate_DelegateParams*)__Parameters)->MBFree, ((FCustomGCTimeDelegate.__FCustomGCTimeDelegate_DelegateParams*)__Parameters)->ExtraDevelopmentMemorySize, ((FCustomGCTimeDelegate.__FCustomGCTimeDelegate_DelegateParams*)__Parameters)->NumObjects);
			((FCustomGCTimeDelegate.__FCustomGCTimeDelegate_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x0400391C RID: 14620
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400391D RID: 14621
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.CustomGCTimeDelegate__DelegateSignature";

		// Token: 0x0400391E RID: 14622
		private static int RegisterId;

		// Token: 0x02000D3B RID: 3387
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FCustomGCTimeDelegate_DelegateParams
		{
			// Token: 0x04005FD5 RID: 24533
			[FieldOffset(0)]
			public float MBFree;

			// Token: 0x04005FD6 RID: 24534
			[FieldOffset(4)]
			public float ExtraDevelopmentMemorySize;

			// Token: 0x04005FD7 RID: 24535
			[FieldOffset(8)]
			public int NumObjects;

			// Token: 0x04005FD8 RID: 24536
			[FieldOffset(12)]
			public float __Result;
		}

		// Token: 0x02000D3C RID: 3388
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FD9 RID: 24537
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
