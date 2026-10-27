using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E51 RID: 3665
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSpeedTree")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UMaterialExpressionSpeedTree : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C488 RID: 50312 RVA: 0x0011C376 File Offset: 0x0011A576
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSpeedTree._ClassPtr;
		}

		// Token: 0x0600C489 RID: 50313 RVA: 0x0011C384 File Offset: 0x0011A584
		public UMaterialExpressionSpeedTree() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSpeedTree.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C48A RID: 50314 RVA: 0x0011C3AC File Offset: 0x0011A5AC
		public UMaterialExpressionSpeedTree(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSpeedTree.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D9D RID: 11677
		// (get) Token: 0x0600C48B RID: 50315 RVA: 0x0011C3E0 File Offset: 0x0011A5E0
		// (set) Token: 0x0600C48C RID: 50316 RVA: 0x0011C419 File Offset: 0x0011A619
		public FExpressionInput GeometryInput
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._GeometryInput) == null)
				{
					result = (this._GeometryInput = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_GeometryInput, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_GeometryInput, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D9E RID: 11678
		// (get) Token: 0x0600C48D RID: 50317 RVA: 0x0011C43C File Offset: 0x0011A63C
		// (set) Token: 0x0600C48E RID: 50318 RVA: 0x0011C475 File Offset: 0x0011A675
		public FExpressionInput WindInput
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._WindInput) == null)
				{
					result = (this._WindInput = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_WindInput, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_WindInput, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D9F RID: 11679
		// (get) Token: 0x0600C48F RID: 50319 RVA: 0x0011C498 File Offset: 0x0011A698
		// (set) Token: 0x0600C490 RID: 50320 RVA: 0x0011C4D1 File Offset: 0x0011A6D1
		public FExpressionInput LODInput
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._LODInput) == null)
				{
					result = (this._LODInput = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_LODInput, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_LODInput, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DA0 RID: 11680
		// (get) Token: 0x0600C491 RID: 50321 RVA: 0x0011C4F4 File Offset: 0x0011A6F4
		// (set) Token: 0x0600C492 RID: 50322 RVA: 0x0011C52D File Offset: 0x0011A72D
		public FExpressionInput ExtraBendWS
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ExtraBendWS) == null)
				{
					result = (this._ExtraBendWS = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_ExtraBendWS, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_ExtraBendWS, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DA1 RID: 11681
		// (get) Token: 0x0600C493 RID: 50323 RVA: 0x0011C54E File Offset: 0x0011A74E
		// (set) Token: 0x0600C494 RID: 50324 RVA: 0x0011C562 File Offset: 0x0011A762
		[Nullable(0)]
		public unsafe TEnumAsByte<ESpeedTreeGeometryType> GeometryType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_GeometryType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_GeometryType) = value;
			}
		}

		// Token: 0x17002DA2 RID: 11682
		// (get) Token: 0x0600C495 RID: 50325 RVA: 0x0011C577 File Offset: 0x0011A777
		// (set) Token: 0x0600C496 RID: 50326 RVA: 0x0011C58B File Offset: 0x0011A78B
		[Nullable(0)]
		public unsafe TEnumAsByte<ESpeedTreeWindType> WindType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_WindType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_WindType) = value;
			}
		}

		// Token: 0x17002DA3 RID: 11683
		// (get) Token: 0x0600C497 RID: 50327 RVA: 0x0011C5A0 File Offset: 0x0011A7A0
		// (set) Token: 0x0600C498 RID: 50328 RVA: 0x0011C5B4 File Offset: 0x0011A7B4
		[Nullable(0)]
		public unsafe TEnumAsByte<ESpeedTreeLODType> LODType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_LODType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_LODType) = value;
			}
		}

		// Token: 0x17002DA4 RID: 11684
		// (get) Token: 0x0600C499 RID: 50329 RVA: 0x0011C5C9 File Offset: 0x0011A7C9
		// (set) Token: 0x0600C49A RID: 50330 RVA: 0x0011C5D9 File Offset: 0x0011A7D9
		public unsafe float BillboardThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_BillboardThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_BillboardThreshold) = value;
			}
		}

		// Token: 0x17002DA5 RID: 11685
		// (get) Token: 0x0600C49B RID: 50331 RVA: 0x0011C5EA File Offset: 0x0011A7EA
		// (set) Token: 0x0600C49C RID: 50332 RVA: 0x0011C5FA File Offset: 0x0011A7FA
		public unsafe bool bAccurateWindVelocities
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_bAccurateWindVelocities) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSpeedTree.__PropertyOffset_bAccurateWindVelocities) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600C49D RID: 50333 RVA: 0x0011C60B File Offset: 0x0011A80B
		static UMaterialExpressionSpeedTree()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSpeedTree");
		}

		// Token: 0x0600C49E RID: 50334 RVA: 0x0011C619 File Offset: 0x0011A819
		protected UMaterialExpressionSpeedTree(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040068F6 RID: 26870
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSpeedTree";

		// Token: 0x040068F7 RID: 26871
		private static IntPtr _ClassPtr;

		// Token: 0x040068F8 RID: 26872
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040068F9 RID: 26873
		internal static int __PropertyOffset_GeometryInput;

		// Token: 0x040068FA RID: 26874
		[Nullable(2)]
		private FExpressionInput _GeometryInput;

		// Token: 0x040068FB RID: 26875
		internal static int __PropertyOffset_WindInput;

		// Token: 0x040068FC RID: 26876
		[Nullable(2)]
		private FExpressionInput _WindInput;

		// Token: 0x040068FD RID: 26877
		internal static int __PropertyOffset_LODInput;

		// Token: 0x040068FE RID: 26878
		[Nullable(2)]
		private FExpressionInput _LODInput;

		// Token: 0x040068FF RID: 26879
		internal static int __PropertyOffset_ExtraBendWS;

		// Token: 0x04006900 RID: 26880
		[Nullable(2)]
		private FExpressionInput _ExtraBendWS;

		// Token: 0x04006901 RID: 26881
		internal static int __PropertyOffset_GeometryType;

		// Token: 0x04006902 RID: 26882
		internal static int __PropertyOffset_WindType;

		// Token: 0x04006903 RID: 26883
		internal static int __PropertyOffset_LODType;

		// Token: 0x04006904 RID: 26884
		internal static int __PropertyOffset_BillboardThreshold;

		// Token: 0x04006905 RID: 26885
		internal static int __PropertyOffset_bAccurateWindVelocities;
	}
}
