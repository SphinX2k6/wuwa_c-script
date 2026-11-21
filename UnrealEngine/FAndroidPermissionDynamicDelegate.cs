using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000DB RID: 219
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FAndroidPermissionDynamicDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06000F70 RID: 3952 RVA: 0x00017E85 File Offset: 0x00016085
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAndroidPermissionDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00017E91 File Offset: 0x00016091
		private static IntPtr StaticFunctionPtr()
		{
			if (FAndroidPermissionDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FAndroidPermissionDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AndroidPermission.AndroidPermissionDynamicDelegate__DelegateSignature");
			}
			return FAndroidPermissionDynamicDelegate._FunctionPtr;
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00017EB4 File Offset: 0x000160B4
		public FAndroidPermissionDynamicDelegate()
		{
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00017EBC File Offset: 0x000160BC
		[NullableContext(2)]
		public FAndroidPermissionDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00017EC6 File Offset: 0x000160C6
		public FAndroidPermissionDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00017ED1 File Offset: 0x000160D1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FAndroidPermissionDynamicDelegate.FAndroidPermissionDynamicDelegate_ScriptDelegate) ?? ((FAndroidPermissionDynamicDelegate.FAndroidPermissionDynamicDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FAndroidPermissionDynamicDelegate.FAndroidPermissionDynamicDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00017F03 File Offset: 0x00016103
		[NullableContext(1)]
		public void Add(FAndroidPermissionDynamicDelegate.FAndroidPermissionDynamicDelegate_ScriptDelegate Callback)
		{
			if (FAndroidPermissionDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAndroidPermissionDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAndroidPermissionDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAndroidPermissionDynamicDelegate.OnScriptCallback));
				}
				FAndroidPermissionDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FAndroidPermissionDynamicDelegate.RegisterId);
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00017F3D File Offset: 0x0001613D
		[NullableContext(1)]
		public void Remove(FAndroidPermissionDynamicDelegate.FAndroidPermissionDynamicDelegate_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00017F48 File Offset: 0x00016148
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Permissions, in TArray<bool> GrantResults)
		{
			FAndroidPermissionDynamicDelegate.__FAndroidPermissionDynamicDelegate_DelegateParams* ptr = stackalloc FAndroidPermissionDynamicDelegate.__FAndroidPermissionDynamicDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FAndroidPermissionDynamicDelegate.__FAndroidPermissionDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAndroidPermissionDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<string> tarray = Permissions;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Permissions);
			}
			TArray<bool> tarray2 = GrantResults;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->GrantResults);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<string> tarray3 = Permissions;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->Permissions);
			}
			TArray<bool> tarray4 = GrantResults;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->GrantResults);
			}
			UnrealReflectionUtils.DestroyStruct(FAndroidPermissionDynamicDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00017FE0 File Offset: 0x000161E0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FAndroidPermissionDynamicDelegate.FAndroidPermissionDynamicDelegate_ScriptDelegate fandroidPermissionDynamicDelegate_ScriptDelegate = target as FAndroidPermissionDynamicDelegate.FAndroidPermissionDynamicDelegate_ScriptDelegate;
			if (fandroidPermissionDynamicDelegate_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> tarray = new TArray<string>(&((FAndroidPermissionDynamicDelegate.__FAndroidPermissionDynamicDelegate_DelegateParams*)__Parameters)->Permissions, true, true);
			TArray<bool> tarray2 = new TArray<bool>(&((FAndroidPermissionDynamicDelegate.__FAndroidPermissionDynamicDelegate_DelegateParams*)__Parameters)->GrantResults, true, true);
			fandroidPermissionDynamicDelegate_ScriptDelegate(tarray, tarray2);
			if (tarray != null)
			{
				tarray.CopyTo(&((FAndroidPermissionDynamicDelegate.__FAndroidPermissionDynamicDelegate_DelegateParams*)__Parameters)->Permissions, default(UScriptStructStackOnlyPtr));
			}
			if (tarray2 != null)
			{
				tarray2.CopyTo(&((FAndroidPermissionDynamicDelegate.__FAndroidPermissionDynamicDelegate_DelegateParams*)__Parameters)->GrantResults, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04000372 RID: 882
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000373 RID: 883
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AndroidPermission.AndroidPermissionDynamicDelegate__DelegateSignature";

		// Token: 0x04000374 RID: 884
		private static int RegisterId;

		// Token: 0x02000909 RID: 2313
		// (Invoke) Token: 0x0600BEDF RID: 48863
		public delegate void FAndroidPermissionDynamicDelegate_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Permissions, in TArray<bool> GrantResults);

		// Token: 0x0200090A RID: 2314
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FAndroidPermissionDynamicDelegate_DelegateParams
		{
			// Token: 0x040057E3 RID: 22499
			[FieldOffset(0)]
			public byte Permissions;

			// Token: 0x040057E4 RID: 22500
			[FieldOffset(16)]
			public byte GrantResults;
		}

		// Token: 0x0200090B RID: 2315
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040057E5 RID: 22501
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
