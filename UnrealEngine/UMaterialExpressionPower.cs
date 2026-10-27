using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E1B RID: 3611
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionPower")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMaterialExpressionPower : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C27E RID: 49790 RVA: 0x00118622 File Offset: 0x00116822
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionPower._ClassPtr;
		}

		// Token: 0x0600C27F RID: 49791 RVA: 0x00118630 File Offset: 0x00116830
		public UMaterialExpressionPower() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPower.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C280 RID: 49792 RVA: 0x00118658 File Offset: 0x00116858
		public UMaterialExpressionPower(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPower.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D1E RID: 11550
		// (get) Token: 0x0600C281 RID: 49793 RVA: 0x0011868C File Offset: 0x0011688C
		// (set) Token: 0x0600C282 RID: 49794 RVA: 0x001186C5 File Offset: 0x001168C5
		public FExpressionInput Base
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Base) == null)
				{
					result = (this._Base = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionPower.__PropertyOffset_Base, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionPower.__PropertyOffset_Base, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D1F RID: 11551
		// (get) Token: 0x0600C283 RID: 49795 RVA: 0x001186E8 File Offset: 0x001168E8
		// (set) Token: 0x0600C284 RID: 49796 RVA: 0x00118721 File Offset: 0x00116921
		public FExpressionInput Exponent
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Exponent) == null)
				{
					result = (this._Exponent = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionPower.__PropertyOffset_Exponent, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionPower.__PropertyOffset_Exponent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D20 RID: 11552
		// (get) Token: 0x0600C285 RID: 49797 RVA: 0x00118742 File Offset: 0x00116942
		// (set) Token: 0x0600C286 RID: 49798 RVA: 0x00118752 File Offset: 0x00116952
		public unsafe float ConstExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionPower.__PropertyOffset_ConstExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionPower.__PropertyOffset_ConstExponent) = value;
			}
		}

		// Token: 0x0600C287 RID: 49799 RVA: 0x00118763 File Offset: 0x00116963
		static UMaterialExpressionPower()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionPower");
		}

		// Token: 0x0600C288 RID: 49800 RVA: 0x00118771 File Offset: 0x00116971
		protected UMaterialExpressionPower(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006786 RID: 26502
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionPower";

		// Token: 0x04006787 RID: 26503
		private static IntPtr _ClassPtr;

		// Token: 0x04006788 RID: 26504
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006789 RID: 26505
		internal static int __PropertyOffset_Base;

		// Token: 0x0400678A RID: 26506
		[Nullable(2)]
		private FExpressionInput _Base;

		// Token: 0x0400678B RID: 26507
		internal static int __PropertyOffset_Exponent;

		// Token: 0x0400678C RID: 26508
		[Nullable(2)]
		private FExpressionInput _Exponent;

		// Token: 0x0400678D RID: 26509
		internal static int __PropertyOffset_ConstExponent;
	}
}
