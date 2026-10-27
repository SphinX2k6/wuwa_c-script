using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E58 RID: 3672
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionStaticSwitch")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class UMaterialExpressionStaticSwitch : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C4DD RID: 50397 RVA: 0x0011CDA6 File Offset: 0x0011AFA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionStaticSwitch._ClassPtr;
		}

		// Token: 0x0600C4DE RID: 50398 RVA: 0x0011CDB4 File Offset: 0x0011AFB4
		public UMaterialExpressionStaticSwitch() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionStaticSwitch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C4DF RID: 50399 RVA: 0x0011CDDC File Offset: 0x0011AFDC
		public UMaterialExpressionStaticSwitch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionStaticSwitch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DB6 RID: 11702
		// (get) Token: 0x0600C4E0 RID: 50400 RVA: 0x0011CE0F File Offset: 0x0011B00F
		// (set) Token: 0x0600C4E1 RID: 50401 RVA: 0x0011CE28 File Offset: 0x0011B028
		public unsafe bool DefaultValue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionStaticSwitch.__PropertyOffset_DefaultValue) & UMaterialExpressionStaticSwitch.__PropertyMask_DefaultValue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionStaticSwitch.__PropertyOffset_DefaultValue) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionStaticSwitch.__PropertyOffset_DefaultValue) & ~UMaterialExpressionStaticSwitch.__PropertyMask_DefaultValue) | (value ? UMaterialExpressionStaticSwitch.__PropertyMask_DefaultValue : 0));
			}
		}

		// Token: 0x17002DB7 RID: 11703
		// (get) Token: 0x0600C4E2 RID: 50402 RVA: 0x0011CE58 File Offset: 0x0011B058
		// (set) Token: 0x0600C4E3 RID: 50403 RVA: 0x0011CE91 File Offset: 0x0011B091
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionStaticSwitch.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionStaticSwitch.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DB8 RID: 11704
		// (get) Token: 0x0600C4E4 RID: 50404 RVA: 0x0011CEB4 File Offset: 0x0011B0B4
		// (set) Token: 0x0600C4E5 RID: 50405 RVA: 0x0011CEED File Offset: 0x0011B0ED
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionStaticSwitch.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionStaticSwitch.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DB9 RID: 11705
		// (get) Token: 0x0600C4E6 RID: 50406 RVA: 0x0011CF10 File Offset: 0x0011B110
		// (set) Token: 0x0600C4E7 RID: 50407 RVA: 0x0011CF49 File Offset: 0x0011B149
		public FExpressionInput Value
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionStaticSwitch.__PropertyOffset_Value, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionStaticSwitch.__PropertyOffset_Value, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C4E8 RID: 50408 RVA: 0x0011CF6A File Offset: 0x0011B16A
		static UMaterialExpressionStaticSwitch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionStaticSwitch");
		}

		// Token: 0x0600C4E9 RID: 50409 RVA: 0x0011CF78 File Offset: 0x0011B178
		protected UMaterialExpressionStaticSwitch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006935 RID: 26933
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionStaticSwitch";

		// Token: 0x04006936 RID: 26934
		private static IntPtr _ClassPtr;

		// Token: 0x04006937 RID: 26935
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006938 RID: 26936
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x04006939 RID: 26937
		internal static byte __PropertyMask_DefaultValue;

		// Token: 0x0400693A RID: 26938
		internal static int __PropertyOffset_A;

		// Token: 0x0400693B RID: 26939
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x0400693C RID: 26940
		internal static int __PropertyOffset_B;

		// Token: 0x0400693D RID: 26941
		[Nullable(2)]
		private FExpressionInput _B;

		// Token: 0x0400693E RID: 26942
		internal static int __PropertyOffset_Value;

		// Token: 0x0400693F RID: 26943
		[Nullable(2)]
		private FExpressionInput _Value;
	}
}
