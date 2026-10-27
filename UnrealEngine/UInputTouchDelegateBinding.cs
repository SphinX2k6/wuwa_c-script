using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C60 RID: 3168
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputTouchDelegateBinding")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UInputTouchDelegateBinding : UInputDelegateBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A0F7 RID: 41207 RVA: 0x000E4B4C File Offset: 0x000E2D4C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInputTouchDelegateBinding._ClassPtr;
		}

		// Token: 0x0600A0F8 RID: 41208 RVA: 0x000E4B58 File Offset: 0x000E2D58
		public UInputTouchDelegateBinding() : this(BuiltinUtils.AllocNativeUObject(UInputTouchDelegateBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A0F9 RID: 41209 RVA: 0x000E4B80 File Offset: 0x000E2D80
		public UInputTouchDelegateBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInputTouchDelegateBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002659 RID: 9817
		// (get) Token: 0x0600A0FA RID: 41210 RVA: 0x000E4BB4 File Offset: 0x000E2DB4
		// (set) Token: 0x0600A0FB RID: 41211 RVA: 0x000E4BED File Offset: 0x000E2DED
		public TArray<FBlueprintInputTouchDelegateBinding> InputTouchDelegateBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBlueprintInputTouchDelegateBinding> result;
				if ((result = this._InputTouchDelegateBindings) == null)
				{
					result = (this._InputTouchDelegateBindings = new TArray<FBlueprintInputTouchDelegateBinding>(base.NativePtr + (IntPtr)UInputTouchDelegateBinding.__PropertyOffset_InputTouchDelegateBindings, this));
				}
				return result;
			}
			set
			{
				this.InputTouchDelegateBindings.CopyAssign(value);
			}
		}

		// Token: 0x0600A0FC RID: 41212 RVA: 0x000E4BFB File Offset: 0x000E2DFB
		static UInputTouchDelegateBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InputTouchDelegateBinding");
		}

		// Token: 0x0600A0FD RID: 41213 RVA: 0x000E4C09 File Offset: 0x000E2E09
		protected UInputTouchDelegateBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400587B RID: 22651
		public new const string __ObjectPath = "/Script/Engine.InputTouchDelegateBinding";

		// Token: 0x0400587C RID: 22652
		private static IntPtr _ClassPtr;

		// Token: 0x0400587D RID: 22653
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400587E RID: 22654
		internal static int __PropertyOffset_InputTouchDelegateBindings;

		// Token: 0x0400587F RID: 22655
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBlueprintInputTouchDelegateBinding> _InputTouchDelegateBindings;
	}
}
