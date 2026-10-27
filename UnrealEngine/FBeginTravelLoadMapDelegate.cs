using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E90 RID: 7824
	public sealed class FBeginTravelLoadMapDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DC30 RID: 121904 RVA: 0x002BF97E File Offset: 0x002BDB7E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FBeginTravelLoadMapDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601DC31 RID: 121905 RVA: 0x002BF98A File Offset: 0x002BDB8A
		private static IntPtr StaticFunctionPtr()
		{
			if (FBeginTravelLoadMapDelegate._FunctionPtr == IntPtr.Zero)
			{
				FBeginTravelLoadMapDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.BeginTravelLoadMapDelegate__DelegateSignature");
			}
			return FBeginTravelLoadMapDelegate._FunctionPtr;
		}

		// Token: 0x0601DC32 RID: 121906 RVA: 0x002BF9AD File Offset: 0x002BDBAD
		public FBeginTravelLoadMapDelegate()
		{
		}

		// Token: 0x0601DC33 RID: 121907 RVA: 0x002BF9B5 File Offset: 0x002BDBB5
		[NullableContext(2)]
		public FBeginTravelLoadMapDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC34 RID: 121908 RVA: 0x002BF9BF File Offset: 0x002BDBBF
		public FBeginTravelLoadMapDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC35 RID: 121909 RVA: 0x002BF9CA File Offset: 0x002BDBCA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DC36 RID: 121910 RVA: 0x002BF9FC File Offset: 0x002BDBFC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string> Callback)
		{
			if (FBeginTravelLoadMapDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FBeginTravelLoadMapDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FBeginTravelLoadMapDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FBeginTravelLoadMapDelegate.OnScriptCallback));
				}
				FBeginTravelLoadMapDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FBeginTravelLoadMapDelegate.RegisterId);
		}

		// Token: 0x0601DC37 RID: 121911 RVA: 0x002BFA38 File Offset: 0x002BDC38
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string MapName)
		{
			FBeginTravelLoadMapDelegate.__FBeginTravelLoadMapDelegate_DelegateParams* ptr = stackalloc FBeginTravelLoadMapDelegate.__FBeginTravelLoadMapDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FBeginTravelLoadMapDelegate.__FBeginTravelLoadMapDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FBeginTravelLoadMapDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->MapName), MapName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FBeginTravelLoadMapDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DC38 RID: 121912 RVA: 0x002BFA8C File Offset: 0x002BDC8C
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
			string obj = FString.ToString((void*)(&((FBeginTravelLoadMapDelegate.__FBeginTravelLoadMapDelegate_DelegateParams*)__Parameters)->MapName));
			action(obj);
		}

		// Token: 0x040101CF RID: 65999
		internal static IntPtr _FunctionPtr;

		// Token: 0x040101D0 RID: 66000
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.BeginTravelLoadMapDelegate__DelegateSignature";

		// Token: 0x040101D1 RID: 66001
		private static int RegisterId;

		// Token: 0x020032DC RID: 13020
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FBeginTravelLoadMapDelegate_DelegateParams
		{
			// Token: 0x04017189 RID: 94601
			[FieldOffset(0)]
			public FString MapName;
		}

		// Token: 0x020032DD RID: 13021
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401718A RID: 94602
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
