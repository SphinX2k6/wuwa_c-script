using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DB6 RID: 3510
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDesaturation")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMaterialExpressionDesaturation : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BEBC RID: 48828 RVA: 0x0011141D File Offset: 0x0010F61D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDesaturation._ClassPtr;
		}

		// Token: 0x0600BEBD RID: 48829 RVA: 0x0011142C File Offset: 0x0010F62C
		public UMaterialExpressionDesaturation() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDesaturation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BEBE RID: 48830 RVA: 0x00111454 File Offset: 0x0010F654
		public UMaterialExpressionDesaturation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDesaturation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C39 RID: 11321
		// (get) Token: 0x0600BEBF RID: 48831 RVA: 0x00111488 File Offset: 0x0010F688
		// (set) Token: 0x0600BEC0 RID: 48832 RVA: 0x001114C1 File Offset: 0x0010F6C1
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDesaturation.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDesaturation.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C3A RID: 11322
		// (get) Token: 0x0600BEC1 RID: 48833 RVA: 0x001114E4 File Offset: 0x0010F6E4
		// (set) Token: 0x0600BEC2 RID: 48834 RVA: 0x0011151D File Offset: 0x0010F71D
		public FExpressionInput Fraction
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Fraction) == null)
				{
					result = (this._Fraction = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDesaturation.__PropertyOffset_Fraction, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDesaturation.__PropertyOffset_Fraction, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C3B RID: 11323
		// (get) Token: 0x0600BEC3 RID: 48835 RVA: 0x0011153E File Offset: 0x0010F73E
		// (set) Token: 0x0600BEC4 RID: 48836 RVA: 0x00111552 File Offset: 0x0010F752
		public unsafe FLinearColor LuminanceFactors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionDesaturation.__PropertyOffset_LuminanceFactors);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionDesaturation.__PropertyOffset_LuminanceFactors) = value;
			}
		}

		// Token: 0x0600BEC5 RID: 48837 RVA: 0x00111567 File Offset: 0x0010F767
		static UMaterialExpressionDesaturation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDesaturation");
		}

		// Token: 0x0600BEC6 RID: 48838 RVA: 0x00111575 File Offset: 0x0010F775
		protected UMaterialExpressionDesaturation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064DD RID: 25821
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDesaturation";

		// Token: 0x040064DE RID: 25822
		private static IntPtr _ClassPtr;

		// Token: 0x040064DF RID: 25823
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040064E0 RID: 25824
		internal static int __PropertyOffset_Input;

		// Token: 0x040064E1 RID: 25825
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x040064E2 RID: 25826
		internal static int __PropertyOffset_Fraction;

		// Token: 0x040064E3 RID: 25827
		[Nullable(2)]
		private FExpressionInput _Fraction;

		// Token: 0x040064E4 RID: 25828
		internal static int __PropertyOffset_LuminanceFactors;
	}
}
