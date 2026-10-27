using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C52 RID: 3154
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputAxisDelegateBinding")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UInputAxisDelegateBinding : UInputDelegateBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009FEE RID: 40942 RVA: 0x000E3486 File Offset: 0x000E1686
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInputAxisDelegateBinding._ClassPtr;
		}

		// Token: 0x06009FEF RID: 40943 RVA: 0x000E3494 File Offset: 0x000E1694
		public UInputAxisDelegateBinding() : this(BuiltinUtils.AllocNativeUObject(UInputAxisDelegateBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009FF0 RID: 40944 RVA: 0x000E34BC File Offset: 0x000E16BC
		public UInputAxisDelegateBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInputAxisDelegateBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x06009FF1 RID: 40945 RVA: 0x000E34F0 File Offset: 0x000E16F0
		// (set) Token: 0x06009FF2 RID: 40946 RVA: 0x000E3529 File Offset: 0x000E1729
		public TArray<FBlueprintInputAxisDelegateBinding> InputAxisDelegateBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBlueprintInputAxisDelegateBinding> result;
				if ((result = this._InputAxisDelegateBindings) == null)
				{
					result = (this._InputAxisDelegateBindings = new TArray<FBlueprintInputAxisDelegateBinding>(base.NativePtr + (IntPtr)UInputAxisDelegateBinding.__PropertyOffset_InputAxisDelegateBindings, this));
				}
				return result;
			}
			set
			{
				this.InputAxisDelegateBindings.CopyAssign(value);
			}
		}

		// Token: 0x06009FF3 RID: 40947 RVA: 0x000E3537 File Offset: 0x000E1737
		static UInputAxisDelegateBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InputAxisDelegateBinding");
		}

		// Token: 0x06009FF4 RID: 40948 RVA: 0x000E3545 File Offset: 0x000E1745
		protected UInputAxisDelegateBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005800 RID: 22528
		public new const string __ObjectPath = "/Script/Engine.InputAxisDelegateBinding";

		// Token: 0x04005801 RID: 22529
		private static IntPtr _ClassPtr;

		// Token: 0x04005802 RID: 22530
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005803 RID: 22531
		internal static int __PropertyOffset_InputAxisDelegateBindings;

		// Token: 0x04005804 RID: 22532
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBlueprintInputAxisDelegateBinding> _InputAxisDelegateBindings;
	}
}
