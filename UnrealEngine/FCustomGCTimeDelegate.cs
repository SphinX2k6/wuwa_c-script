using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E93 RID: 7827
	public sealed class FCustomGCTimeDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DC51 RID: 121937 RVA: 0x002BFD5B File Offset: 0x002BDF5B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCustomGCTimeDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601DC52 RID: 121938 RVA: 0x002BFD67 File Offset: 0x002BDF67
		private static IntPtr StaticFunctionPtr()
		{
			if (FCustomGCTimeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FCustomGCTimeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.CustomGCTimeDelegate__DelegateSignature");
			}
			return FCustomGCTimeDelegate._FunctionPtr;
		}

		// Token: 0x0601DC53 RID: 121939 RVA: 0x002BFD8A File Offset: 0x002BDF8A
		public FCustomGCTimeDelegate()
		{
		}

		// Token: 0x0601DC54 RID: 121940 RVA: 0x002BFD92 File Offset: 0x002BDF92
		[NullableContext(2)]
		public FCustomGCTimeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC55 RID: 121941 RVA: 0x002BFD9C File Offset: 0x002BDF9C
		public FCustomGCTimeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC56 RID: 121942 RVA: 0x002BFDA7 File Offset: 0x002BDFA7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<float, float, int, float>) ?? ((Func<float, float, int, float>)Delegate.CreateDelegate(typeof(Func<float, float, int, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DC57 RID: 121943 RVA: 0x002BFDD9 File Offset: 0x002BDFD9
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601DC58 RID: 121944 RVA: 0x002BFE14 File Offset: 0x002BE014
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601DC59 RID: 121945 RVA: 0x002BFE68 File Offset: 0x002BE068
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040101DB RID: 66011
		internal static IntPtr _FunctionPtr;

		// Token: 0x040101DC RID: 66012
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.CustomGCTimeDelegate__DelegateSignature";

		// Token: 0x040101DD RID: 66013
		private static int RegisterId;

		// Token: 0x020032E1 RID: 13025
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FCustomGCTimeDelegate_DelegateParams
		{
			// Token: 0x0401718E RID: 94606
			[FieldOffset(0)]
			public float MBFree;

			// Token: 0x0401718F RID: 94607
			[FieldOffset(4)]
			public float ExtraDevelopmentMemorySize;

			// Token: 0x04017190 RID: 94608
			[FieldOffset(8)]
			public int NumObjects;

			// Token: 0x04017191 RID: 94609
			[FieldOffset(12)]
			public float __Result;
		}

		// Token: 0x020032E2 RID: 13026
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017192 RID: 94610
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
