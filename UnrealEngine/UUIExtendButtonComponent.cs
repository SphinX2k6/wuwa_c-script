using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006FE RID: 1790
	[UnrealObjectPath("/Script/LGUI.UIExtendButtonComponent")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1688)]
	public class UUIExtendButtonComponent : UUIButtonComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009872 RID: 39026 RVA: 0x000E5785 File Offset: 0x000E3985
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIExtendButtonComponent._ClassPtr;
		}

		// Token: 0x06009873 RID: 39027 RVA: 0x000E5794 File Offset: 0x000E3994
		public UUIExtendButtonComponent() : this(BuiltinUtils.AllocNativeUObject(UUIExtendButtonComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009874 RID: 39028 RVA: 0x000E57BC File Offset: 0x000E39BC
		[NullableContext(1)]
		public UUIExtendButtonComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIExtendButtonComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06009875 RID: 39029 RVA: 0x000E57EF File Offset: 0x000E39EF
		// (set) Token: 0x06009876 RID: 39030 RVA: 0x000E57FF File Offset: 0x000E39FF
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

		// Token: 0x06009877 RID: 39031 RVA: 0x000E5810 File Offset: 0x000E3A10
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void SetDelegateForHelpClick(in FLGUIDelegateForHelpClick delegateObj)
		{
			UUIExtendButtonComponent.__SetDelegateForHelpClick_FunctionParams* ptr = stackalloc UUIExtendButtonComponent.__SetDelegateForHelpClick_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UUIExtendButtonComponent.__SetDelegateForHelpClick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UUIExtendButtonComponent.__SetDelegateForHelpClick_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->delegateObj;
			FLGUIDelegateForHelpClick flguidelegateForHelpClick = delegateObj;
			FScriptDelegate.NativeCopy(dest, (flguidelegateForHelpClick != null) ? flguidelegateForHelpClick.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UUIExtendButtonComponent._ClassDefaultObjectPtr, UUIExtendButtonComponent.__SetDelegateForHelpClick_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UUIExtendButtonComponent.__SetDelegateForHelpClick_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06009878 RID: 39032 RVA: 0x000E587A File Offset: 0x000E3A7A
		static UUIExtendButtonComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIExtendButtonComponent");
		}

		// Token: 0x06009879 RID: 39033 RVA: 0x000E5888 File Offset: 0x000E3A88
		protected UUIExtendButtonComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004233 RID: 16947
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIExtendButtonComponent";

		// Token: 0x04004234 RID: 16948
		private static IntPtr _ClassPtr;

		// Token: 0x04004235 RID: 16949
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004236 RID: 16950
		internal static int __PropertyOffset_HelpGroupId;

		// Token: 0x04004237 RID: 16951
		private static IntPtr __SetDelegateForHelpClick_NativeFunctionPtr;

		// Token: 0x02000F1A RID: 3866
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetDelegateForHelpClick_FunctionParams
		{
			// Token: 0x040062E9 RID: 25321
			[FieldOffset(0)]
			public byte delegateObj;
		}
	}
}
