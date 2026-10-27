using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200296A RID: 10602
	public sealed class FGenerateWidgetForString : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602738A RID: 160650 RVA: 0x003BCBE9 File Offset: 0x003BADE9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGenerateWidgetForString.StaticFunctionPtr();
		}

		// Token: 0x0602738B RID: 160651 RVA: 0x003BCBF5 File Offset: 0x003BADF5
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GenerateWidgetForString__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GenerateWidgetForString__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GenerateWidgetForString__DelegateSignature");
			}
			return UWidget.__GenerateWidgetForString__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602738C RID: 160652 RVA: 0x003BCC18 File Offset: 0x003BAE18
		public FGenerateWidgetForString()
		{
		}

		// Token: 0x0602738D RID: 160653 RVA: 0x003BCC20 File Offset: 0x003BAE20
		[NullableContext(2)]
		public FGenerateWidgetForString(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602738E RID: 160654 RVA: 0x003BCC2A File Offset: 0x003BAE2A
		public FGenerateWidgetForString(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602738F RID: 160655 RVA: 0x003BCC35 File Offset: 0x003BAE35
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, UWidget>) ?? ((Func<string, UWidget>)Delegate.CreateDelegate(typeof(Func<string, UWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027390 RID: 160656 RVA: 0x003BCC67 File Offset: 0x003BAE67
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Func<string, UWidget> Callback)
		{
			if (FGenerateWidgetForString.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGenerateWidgetForString.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGenerateWidgetForString.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGenerateWidgetForString.OnScriptCallback));
				}
				FGenerateWidgetForString.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGenerateWidgetForString.RegisterId);
		}

		// Token: 0x06027391 RID: 160657 RVA: 0x003BCCA4 File Offset: 0x003BAEA4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(2)]
		public unsafe UWidget Execute(string Item)
		{
			FGenerateWidgetForString.__FGenerateWidgetForString_DelegateParams* ptr = stackalloc FGenerateWidgetForString.__FGenerateWidgetForString_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FGenerateWidgetForString.__FGenerateWidgetForString_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGenerateWidgetForString.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Item), Item);
			base.ExecuteInternal((void*)ptr);
			UWidget orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidget>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UWidget.__GenerateWidgetForString__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06027392 RID: 160658 RVA: 0x003BCD04 File Offset: 0x003BAF04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, UWidget> func = target as Func<string, UWidget>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FGenerateWidgetForString.__FGenerateWidgetForString_DelegateParams*)__Parameters)->Item));
			UWidget uwidget = func(arg);
			((FGenerateWidgetForString.__FGenerateWidgetForString_DelegateParams*)__Parameters)->__Result = ((uwidget != null) ? uwidget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x040158EF RID: 88303
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GenerateWidgetForString__DelegateSignature";

		// Token: 0x040158F0 RID: 88304
		private static int RegisterId;

		// Token: 0x02003B6F RID: 15215
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FGenerateWidgetForString_DelegateParams
		{
			// Token: 0x04017D48 RID: 97608
			[FieldOffset(0)]
			public FString Item;

			// Token: 0x04017D49 RID: 97609
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02003B70 RID: 15216
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D4A RID: 97610
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
