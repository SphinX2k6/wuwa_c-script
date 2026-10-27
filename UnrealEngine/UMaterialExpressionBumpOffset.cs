using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D96 RID: 3478
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionBumpOffset")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UMaterialExpressionBumpOffset : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD9D RID: 48541 RVA: 0x0010F521 File Offset: 0x0010D721
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionBumpOffset._ClassPtr;
		}

		// Token: 0x0600BD9E RID: 48542 RVA: 0x0010F530 File Offset: 0x0010D730
		public UMaterialExpressionBumpOffset() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionBumpOffset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD9F RID: 48543 RVA: 0x0010F558 File Offset: 0x0010D758
		public UMaterialExpressionBumpOffset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionBumpOffset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x0600BDA0 RID: 48544 RVA: 0x0010F58C File Offset: 0x0010D78C
		// (set) Token: 0x0600BDA1 RID: 48545 RVA: 0x0010F5C5 File Offset: 0x0010D7C5
		public FExpressionInput Coordinate
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Coordinate) == null)
				{
					result = (this._Coordinate = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionBumpOffset.__PropertyOffset_Coordinate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionBumpOffset.__PropertyOffset_Coordinate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002BFA RID: 11258
		// (get) Token: 0x0600BDA2 RID: 48546 RVA: 0x0010F5E8 File Offset: 0x0010D7E8
		// (set) Token: 0x0600BDA3 RID: 48547 RVA: 0x0010F621 File Offset: 0x0010D821
		public FExpressionInput Height
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Height) == null)
				{
					result = (this._Height = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionBumpOffset.__PropertyOffset_Height, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionBumpOffset.__PropertyOffset_Height, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002BFB RID: 11259
		// (get) Token: 0x0600BDA4 RID: 48548 RVA: 0x0010F644 File Offset: 0x0010D844
		// (set) Token: 0x0600BDA5 RID: 48549 RVA: 0x0010F67D File Offset: 0x0010D87D
		public FExpressionInput HeightRatioInput
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._HeightRatioInput) == null)
				{
					result = (this._HeightRatioInput = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionBumpOffset.__PropertyOffset_HeightRatioInput, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionBumpOffset.__PropertyOffset_HeightRatioInput, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x0600BDA6 RID: 48550 RVA: 0x0010F69E File Offset: 0x0010D89E
		// (set) Token: 0x0600BDA7 RID: 48551 RVA: 0x0010F6AE File Offset: 0x0010D8AE
		public unsafe float HeightRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionBumpOffset.__PropertyOffset_HeightRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionBumpOffset.__PropertyOffset_HeightRatio) = value;
			}
		}

		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x0600BDA8 RID: 48552 RVA: 0x0010F6BF File Offset: 0x0010D8BF
		// (set) Token: 0x0600BDA9 RID: 48553 RVA: 0x0010F6CF File Offset: 0x0010D8CF
		public unsafe float ReferencePlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionBumpOffset.__PropertyOffset_ReferencePlane);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionBumpOffset.__PropertyOffset_ReferencePlane) = value;
			}
		}

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x0600BDAA RID: 48554 RVA: 0x0010F6E0 File Offset: 0x0010D8E0
		// (set) Token: 0x0600BDAB RID: 48555 RVA: 0x0010F6F0 File Offset: 0x0010D8F0
		public unsafe uint ConstCoordinate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionBumpOffset.__PropertyOffset_ConstCoordinate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionBumpOffset.__PropertyOffset_ConstCoordinate) = (int)value;
			}
		}

		// Token: 0x0600BDAC RID: 48556 RVA: 0x0010F701 File Offset: 0x0010D901
		static UMaterialExpressionBumpOffset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionBumpOffset");
		}

		// Token: 0x0600BDAD RID: 48557 RVA: 0x0010F70F File Offset: 0x0010D90F
		protected UMaterialExpressionBumpOffset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400641E RID: 25630
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionBumpOffset";

		// Token: 0x0400641F RID: 25631
		private static IntPtr _ClassPtr;

		// Token: 0x04006420 RID: 25632
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006421 RID: 25633
		internal static int __PropertyOffset_Coordinate;

		// Token: 0x04006422 RID: 25634
		[Nullable(2)]
		private FExpressionInput _Coordinate;

		// Token: 0x04006423 RID: 25635
		internal static int __PropertyOffset_Height;

		// Token: 0x04006424 RID: 25636
		[Nullable(2)]
		private FExpressionInput _Height;

		// Token: 0x04006425 RID: 25637
		internal static int __PropertyOffset_HeightRatioInput;

		// Token: 0x04006426 RID: 25638
		[Nullable(2)]
		private FExpressionInput _HeightRatioInput;

		// Token: 0x04006427 RID: 25639
		internal static int __PropertyOffset_HeightRatio;

		// Token: 0x04006428 RID: 25640
		internal static int __PropertyOffset_ReferencePlane;

		// Token: 0x04006429 RID: 25641
		internal static int __PropertyOffset_ConstCoordinate;
	}
}
