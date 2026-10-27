using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002166 RID: 8550
	[UnrealObjectPath("/Script/LGUI.UIExtendButtonComponent")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1688)]
	public class UUIExtendButtonComponent : UUIButtonComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020437 RID: 132151 RVA: 0x002FE797 File Offset: 0x002FC997
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIExtendButtonComponent._ClassPtr;
		}

		// Token: 0x06020438 RID: 132152 RVA: 0x002FE7A4 File Offset: 0x002FC9A4
		public UUIExtendButtonComponent() : this(BuiltinUtils.AllocNativeUObject(UUIExtendButtonComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020439 RID: 132153 RVA: 0x002FE7CC File Offset: 0x002FC9CC
		[NullableContext(1)]
		public UUIExtendButtonComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIExtendButtonComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E72 RID: 32370
		// (get) Token: 0x0602043A RID: 132154 RVA: 0x002FE7FF File Offset: 0x002FC9FF
		// (set) Token: 0x0602043B RID: 132155 RVA: 0x002FE80F File Offset: 0x002FCA0F
		public unsafe int HelpGroupId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIExtendButtonComponent.__PropertyOffset_HelpGroupId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIExtendButtonComponent.__PropertyOffset_HelpGroupId) = value;
			}
		}

		// Token: 0x0602043C RID: 132156 RVA: 0x002FE820 File Offset: 0x002FCA20
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetDelegateForHelpClick(in FLGUIDelegateForHelpClick delegateObj)
		{
			UUIExtendButtonComponent.__SetDelegateForHelpClick_FunctionParams* ptr = stackalloc UUIExtendButtonComponent.__SetDelegateForHelpClick_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UUIExtendButtonComponent.__SetDelegateForHelpClick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UUIExtendButtonComponent.__SetDelegateForHelpClick_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->delegateObj;
			FLGUIDelegateForHelpClick flguidelegateForHelpClick = delegateObj;
			FScriptDelegate.NativeCopy(dest, (flguidelegateForHelpClick != null) ? flguidelegateForHelpClick.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UUIExtendButtonComponent._ClassDefaultObjectPtr, UUIExtendButtonComponent.__SetDelegateForHelpClick_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UUIExtendButtonComponent.__SetDelegateForHelpClick_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602043D RID: 132157 RVA: 0x002FE88B File Offset: 0x002FCA8B
		static UUIExtendButtonComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIExtendButtonComponent");
		}

		// Token: 0x0602043E RID: 132158 RVA: 0x002FE899 File Offset: 0x002FCA99
		protected UUIExtendButtonComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401154F RID: 70991
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIExtendButtonComponent";

		// Token: 0x04011550 RID: 70992
		private static IntPtr _ClassPtr;

		// Token: 0x04011551 RID: 70993
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011552 RID: 70994
		internal static int __PropertyOffset_HelpGroupId;

		// Token: 0x04011553 RID: 70995
		private static IntPtr __SetDelegateForHelpClick_NativeFunctionPtr;

		// Token: 0x020034F7 RID: 13559
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetDelegateForHelpClick_FunctionParams
		{
			// Token: 0x0401751B RID: 95515
			[FieldOffset(0)]
			public byte delegateObj;
		}
	}
}
