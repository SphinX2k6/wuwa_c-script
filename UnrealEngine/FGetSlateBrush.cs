using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200296F RID: 10607
	public sealed class FGetSlateBrush : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060273B7 RID: 160695 RVA: 0x003BD270 File Offset: 0x003BB470
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetSlateBrush.StaticFunctionPtr();
		}

		// Token: 0x060273B8 RID: 160696 RVA: 0x003BD27C File Offset: 0x003BB47C
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GetSlateBrush__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GetSlateBrush__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GetSlateBrush__DelegateSignature");
			}
			return UWidget.__GetSlateBrush__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060273B9 RID: 160697 RVA: 0x003BD29F File Offset: 0x003BB49F
		public FGetSlateBrush()
		{
		}

		// Token: 0x060273BA RID: 160698 RVA: 0x003BD2A7 File Offset: 0x003BB4A7
		[NullableContext(2)]
		public FGetSlateBrush(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060273BB RID: 160699 RVA: 0x003BD2B1 File Offset: 0x003BB4B1
		public FGetSlateBrush(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060273BC RID: 160700 RVA: 0x003BD2BC File Offset: 0x003BB4BC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<FSlateBrush>) ?? ((Func<FSlateBrush>)Delegate.CreateDelegate(typeof(Func<FSlateBrush>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060273BD RID: 160701 RVA: 0x003BD2EE File Offset: 0x003BB4EE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<FSlateBrush> Callback)
		{
			if (FGetSlateBrush.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetSlateBrush.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetSlateBrush.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetSlateBrush.OnScriptCallback));
				}
				FGetSlateBrush.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGetSlateBrush.RegisterId);
		}

		// Token: 0x060273BE RID: 160702 RVA: 0x003BD328 File Offset: 0x003BB528
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FSlateBrush Execute()
		{
			FGetSlateBrush.__FGetSlateBrush_DelegateParams* ptr = stackalloc FGetSlateBrush.__FGetSlateBrush_DelegateParams[(UIntPtr)175] + 15L / (long)sizeof(FGetSlateBrush.__FGetSlateBrush_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetSlateBrush.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			FSlateBrush result = new FSlateBrush(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UWidget.__GetSlateBrush__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060273BF RID: 160703 RVA: 0x003BD380 File Offset: 0x003BB580
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<FSlateBrush> func = target as Func<FSlateBrush>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FSlateBrush fslateBrush = func();
			if (fslateBrush != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), &((FGetSlateBrush.__FGetSlateBrush_DelegateParams*)__Parameters)->__Result, fslateBrush.NativePtr, 1, false);
			}
		}

		// Token: 0x040158F9 RID: 88313
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GetSlateBrush__DelegateSignature";

		// Token: 0x040158FA RID: 88314
		private static int RegisterId;

		// Token: 0x02003B79 RID: 15225
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __FGetSlateBrush_DelegateParams
		{
			// Token: 0x04017D53 RID: 97619
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003B7A RID: 15226
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D54 RID: 97620
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
