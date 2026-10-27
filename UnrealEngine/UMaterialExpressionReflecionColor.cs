using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E25 RID: 3621
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionReflecionColor")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMaterialExpressionReflecionColor : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C2CA RID: 49866 RVA: 0x00118F69 File Offset: 0x00117169
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionReflecionColor._ClassPtr;
		}

		// Token: 0x0600C2CB RID: 49867 RVA: 0x00118F78 File Offset: 0x00117178
		public UMaterialExpressionReflecionColor() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionReflecionColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C2CC RID: 49868 RVA: 0x00118FA0 File Offset: 0x001171A0
		public UMaterialExpressionReflecionColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionReflecionColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D2B RID: 11563
		// (get) Token: 0x0600C2CD RID: 49869 RVA: 0x00118FD4 File Offset: 0x001171D4
		// (set) Token: 0x0600C2CE RID: 49870 RVA: 0x0011900D File Offset: 0x0011720D
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionReflecionColor.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionReflecionColor.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D2C RID: 11564
		// (get) Token: 0x0600C2CF RID: 49871 RVA: 0x00119030 File Offset: 0x00117230
		// (set) Token: 0x0600C2D0 RID: 49872 RVA: 0x00119069 File Offset: 0x00117269
		public FExpressionInput OffsetFraction_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._OffsetFraction_DEPRECATED) == null)
				{
					result = (this._OffsetFraction_DEPRECATED = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionReflecionColor.__PropertyOffset_OffsetFraction_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionReflecionColor.__PropertyOffset_OffsetFraction_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D2D RID: 11565
		// (get) Token: 0x0600C2D1 RID: 49873 RVA: 0x0011908A File Offset: 0x0011728A
		// (set) Token: 0x0600C2D2 RID: 49874 RVA: 0x0011909E File Offset: 0x0011729E
		public unsafe FVector2D ConstInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionReflecionColor.__PropertyOffset_ConstInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionReflecionColor.__PropertyOffset_ConstInput) = value;
			}
		}

		// Token: 0x0600C2D3 RID: 49875 RVA: 0x001190B3 File Offset: 0x001172B3
		static UMaterialExpressionReflecionColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionReflecionColor");
		}

		// Token: 0x0600C2D4 RID: 49876 RVA: 0x001190C1 File Offset: 0x001172C1
		protected UMaterialExpressionReflecionColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040067BD RID: 26557
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionReflecionColor";

		// Token: 0x040067BE RID: 26558
		private static IntPtr _ClassPtr;

		// Token: 0x040067BF RID: 26559
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040067C0 RID: 26560
		internal static int __PropertyOffset_Input;

		// Token: 0x040067C1 RID: 26561
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x040067C2 RID: 26562
		internal static int __PropertyOffset_OffsetFraction_DEPRECATED;

		// Token: 0x040067C3 RID: 26563
		[Nullable(2)]
		private FExpressionInput _OffsetFraction_DEPRECATED;

		// Token: 0x040067C4 RID: 26564
		internal static int __PropertyOffset_ConstInput;
	}
}
