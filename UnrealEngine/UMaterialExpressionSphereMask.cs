using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E52 RID: 3666
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSphereMask")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class UMaterialExpressionSphereMask : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C49F RID: 50335 RVA: 0x0011C622 File Offset: 0x0011A822
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSphereMask._ClassPtr;
		}

		// Token: 0x0600C4A0 RID: 50336 RVA: 0x0011C630 File Offset: 0x0011A830
		public UMaterialExpressionSphereMask() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSphereMask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C4A1 RID: 50337 RVA: 0x0011C658 File Offset: 0x0011A858
		public UMaterialExpressionSphereMask(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSphereMask.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x0600C4A2 RID: 50338 RVA: 0x0011C68C File Offset: 0x0011A88C
		// (set) Token: 0x0600C4A3 RID: 50339 RVA: 0x0011C6C5 File Offset: 0x0011A8C5
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSphereMask.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSphereMask.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x0600C4A4 RID: 50340 RVA: 0x0011C6E8 File Offset: 0x0011A8E8
		// (set) Token: 0x0600C4A5 RID: 50341 RVA: 0x0011C721 File Offset: 0x0011A921
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSphereMask.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSphereMask.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x0600C4A6 RID: 50342 RVA: 0x0011C744 File Offset: 0x0011A944
		// (set) Token: 0x0600C4A7 RID: 50343 RVA: 0x0011C77D File Offset: 0x0011A97D
		public FExpressionInput Radius
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Radius) == null)
				{
					result = (this._Radius = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSphereMask.__PropertyOffset_Radius, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSphereMask.__PropertyOffset_Radius, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DA9 RID: 11689
		// (get) Token: 0x0600C4A8 RID: 50344 RVA: 0x0011C7A0 File Offset: 0x0011A9A0
		// (set) Token: 0x0600C4A9 RID: 50345 RVA: 0x0011C7D9 File Offset: 0x0011A9D9
		public FExpressionInput Hardness
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Hardness) == null)
				{
					result = (this._Hardness = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSphereMask.__PropertyOffset_Hardness, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSphereMask.__PropertyOffset_Hardness, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DAA RID: 11690
		// (get) Token: 0x0600C4AA RID: 50346 RVA: 0x0011C7FA File Offset: 0x0011A9FA
		// (set) Token: 0x0600C4AB RID: 50347 RVA: 0x0011C80A File Offset: 0x0011AA0A
		public unsafe float AttenuationRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSphereMask.__PropertyOffset_AttenuationRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSphereMask.__PropertyOffset_AttenuationRadius) = value;
			}
		}

		// Token: 0x17002DAB RID: 11691
		// (get) Token: 0x0600C4AC RID: 50348 RVA: 0x0011C81B File Offset: 0x0011AA1B
		// (set) Token: 0x0600C4AD RID: 50349 RVA: 0x0011C82B File Offset: 0x0011AA2B
		public unsafe float HardnessPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSphereMask.__PropertyOffset_HardnessPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSphereMask.__PropertyOffset_HardnessPercent) = value;
			}
		}

		// Token: 0x0600C4AE RID: 50350 RVA: 0x0011C83C File Offset: 0x0011AA3C
		static UMaterialExpressionSphereMask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSphereMask");
		}

		// Token: 0x0600C4AF RID: 50351 RVA: 0x0011C84A File Offset: 0x0011AA4A
		protected UMaterialExpressionSphereMask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006906 RID: 26886
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSphereMask";

		// Token: 0x04006907 RID: 26887
		private static IntPtr _ClassPtr;

		// Token: 0x04006908 RID: 26888
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006909 RID: 26889
		internal static int __PropertyOffset_A;

		// Token: 0x0400690A RID: 26890
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x0400690B RID: 26891
		internal static int __PropertyOffset_B;

		// Token: 0x0400690C RID: 26892
		[Nullable(2)]
		private FExpressionInput _B;

		// Token: 0x0400690D RID: 26893
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400690E RID: 26894
		[Nullable(2)]
		private FExpressionInput _Radius;

		// Token: 0x0400690F RID: 26895
		internal static int __PropertyOffset_Hardness;

		// Token: 0x04006910 RID: 26896
		[Nullable(2)]
		private FExpressionInput _Hardness;

		// Token: 0x04006911 RID: 26897
		internal static int __PropertyOffset_AttenuationRadius;

		// Token: 0x04006912 RID: 26898
		internal static int __PropertyOffset_HardnessPercent;
	}
}
