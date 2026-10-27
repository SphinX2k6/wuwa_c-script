using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E2A RID: 3626
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionRotateAboutAxis")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class UMaterialExpressionRotateAboutAxis : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C2F2 RID: 49906 RVA: 0x0011944D File Offset: 0x0011764D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionRotateAboutAxis._ClassPtr;
		}

		// Token: 0x0600C2F3 RID: 49907 RVA: 0x0011945C File Offset: 0x0011765C
		public UMaterialExpressionRotateAboutAxis() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRotateAboutAxis.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C2F4 RID: 49908 RVA: 0x00119484 File Offset: 0x00117684
		public UMaterialExpressionRotateAboutAxis(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRotateAboutAxis.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D33 RID: 11571
		// (get) Token: 0x0600C2F5 RID: 49909 RVA: 0x001194B8 File Offset: 0x001176B8
		// (set) Token: 0x0600C2F6 RID: 49910 RVA: 0x001194F1 File Offset: 0x001176F1
		public FExpressionInput NormalizedRotationAxis
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._NormalizedRotationAxis) == null)
				{
					result = (this._NormalizedRotationAxis = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRotateAboutAxis.__PropertyOffset_NormalizedRotationAxis, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRotateAboutAxis.__PropertyOffset_NormalizedRotationAxis, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D34 RID: 11572
		// (get) Token: 0x0600C2F7 RID: 49911 RVA: 0x00119514 File Offset: 0x00117714
		// (set) Token: 0x0600C2F8 RID: 49912 RVA: 0x0011954D File Offset: 0x0011774D
		public FExpressionInput RotationAngle
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._RotationAngle) == null)
				{
					result = (this._RotationAngle = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRotateAboutAxis.__PropertyOffset_RotationAngle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRotateAboutAxis.__PropertyOffset_RotationAngle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D35 RID: 11573
		// (get) Token: 0x0600C2F9 RID: 49913 RVA: 0x00119570 File Offset: 0x00117770
		// (set) Token: 0x0600C2FA RID: 49914 RVA: 0x001195A9 File Offset: 0x001177A9
		public FExpressionInput PivotPoint
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._PivotPoint) == null)
				{
					result = (this._PivotPoint = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRotateAboutAxis.__PropertyOffset_PivotPoint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRotateAboutAxis.__PropertyOffset_PivotPoint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D36 RID: 11574
		// (get) Token: 0x0600C2FB RID: 49915 RVA: 0x001195CC File Offset: 0x001177CC
		// (set) Token: 0x0600C2FC RID: 49916 RVA: 0x00119605 File Offset: 0x00117805
		public FExpressionInput Position
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Position) == null)
				{
					result = (this._Position = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRotateAboutAxis.__PropertyOffset_Position, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRotateAboutAxis.__PropertyOffset_Position, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D37 RID: 11575
		// (get) Token: 0x0600C2FD RID: 49917 RVA: 0x00119626 File Offset: 0x00117826
		// (set) Token: 0x0600C2FE RID: 49918 RVA: 0x00119636 File Offset: 0x00117836
		public unsafe float Period
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionRotateAboutAxis.__PropertyOffset_Period);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionRotateAboutAxis.__PropertyOffset_Period) = value;
			}
		}

		// Token: 0x0600C2FF RID: 49919 RVA: 0x00119647 File Offset: 0x00117847
		static UMaterialExpressionRotateAboutAxis()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionRotateAboutAxis");
		}

		// Token: 0x0600C300 RID: 49920 RVA: 0x00119655 File Offset: 0x00117855
		protected UMaterialExpressionRotateAboutAxis(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040067DB RID: 26587
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionRotateAboutAxis";

		// Token: 0x040067DC RID: 26588
		private static IntPtr _ClassPtr;

		// Token: 0x040067DD RID: 26589
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040067DE RID: 26590
		internal static int __PropertyOffset_NormalizedRotationAxis;

		// Token: 0x040067DF RID: 26591
		[Nullable(2)]
		private FExpressionInput _NormalizedRotationAxis;

		// Token: 0x040067E0 RID: 26592
		internal static int __PropertyOffset_RotationAngle;

		// Token: 0x040067E1 RID: 26593
		[Nullable(2)]
		private FExpressionInput _RotationAngle;

		// Token: 0x040067E2 RID: 26594
		internal static int __PropertyOffset_PivotPoint;

		// Token: 0x040067E3 RID: 26595
		[Nullable(2)]
		private FExpressionInput _PivotPoint;

		// Token: 0x040067E4 RID: 26596
		internal static int __PropertyOffset_Position;

		// Token: 0x040067E5 RID: 26597
		[Nullable(2)]
		private FExpressionInput _Position;

		// Token: 0x040067E6 RID: 26598
		internal static int __PropertyOffset_Period;
	}
}
