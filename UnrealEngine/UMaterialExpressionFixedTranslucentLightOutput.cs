using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DC5 RID: 3525
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionFixedTranslucentLightOutput")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UMaterialExpressionFixedTranslucentLightOutput : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF33 RID: 48947 RVA: 0x001121DE File Offset: 0x001103DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionFixedTranslucentLightOutput._ClassPtr;
		}

		// Token: 0x0600BF34 RID: 48948 RVA: 0x001121EC File Offset: 0x001103EC
		public UMaterialExpressionFixedTranslucentLightOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFixedTranslucentLightOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF35 RID: 48949 RVA: 0x00112214 File Offset: 0x00110414
		public UMaterialExpressionFixedTranslucentLightOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFixedTranslucentLightOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C4F RID: 11343
		// (get) Token: 0x0600BF36 RID: 48950 RVA: 0x00112248 File Offset: 0x00110448
		// (set) Token: 0x0600BF37 RID: 48951 RVA: 0x00112281 File Offset: 0x00110481
		public FExpressionInput FixedLightDirection
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._FixedLightDirection) == null)
				{
					result = (this._FixedLightDirection = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFixedTranslucentLightOutput.__PropertyOffset_FixedLightDirection, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFixedTranslucentLightOutput.__PropertyOffset_FixedLightDirection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C50 RID: 11344
		// (get) Token: 0x0600BF38 RID: 48952 RVA: 0x001122A4 File Offset: 0x001104A4
		// (set) Token: 0x0600BF39 RID: 48953 RVA: 0x001122DD File Offset: 0x001104DD
		public FExpressionInput FixedShadowMask
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._FixedShadowMask) == null)
				{
					result = (this._FixedShadowMask = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFixedTranslucentLightOutput.__PropertyOffset_FixedShadowMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFixedTranslucentLightOutput.__PropertyOffset_FixedShadowMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C51 RID: 11345
		// (get) Token: 0x0600BF3A RID: 48954 RVA: 0x00112300 File Offset: 0x00110500
		// (set) Token: 0x0600BF3B RID: 48955 RVA: 0x00112339 File Offset: 0x00110539
		public FExpressionInput FixedLightColor
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._FixedLightColor) == null)
				{
					result = (this._FixedLightColor = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFixedTranslucentLightOutput.__PropertyOffset_FixedLightColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFixedTranslucentLightOutput.__PropertyOffset_FixedLightColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C52 RID: 11346
		// (get) Token: 0x0600BF3C RID: 48956 RVA: 0x0011235C File Offset: 0x0011055C
		// (set) Token: 0x0600BF3D RID: 48957 RVA: 0x00112395 File Offset: 0x00110595
		public FExpressionInput FixedAmbientColor
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._FixedAmbientColor) == null)
				{
					result = (this._FixedAmbientColor = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFixedTranslucentLightOutput.__PropertyOffset_FixedAmbientColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFixedTranslucentLightOutput.__PropertyOffset_FixedAmbientColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BF3E RID: 48958 RVA: 0x001123B6 File Offset: 0x001105B6
		static UMaterialExpressionFixedTranslucentLightOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionFixedTranslucentLightOutput");
		}

		// Token: 0x0600BF3F RID: 48959 RVA: 0x001123C4 File Offset: 0x001105C4
		protected UMaterialExpressionFixedTranslucentLightOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400652F RID: 25903
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionFixedTranslucentLightOutput";

		// Token: 0x04006530 RID: 25904
		private static IntPtr _ClassPtr;

		// Token: 0x04006531 RID: 25905
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006532 RID: 25906
		internal static int __PropertyOffset_FixedLightDirection;

		// Token: 0x04006533 RID: 25907
		[Nullable(2)]
		private FExpressionInput _FixedLightDirection;

		// Token: 0x04006534 RID: 25908
		internal static int __PropertyOffset_FixedShadowMask;

		// Token: 0x04006535 RID: 25909
		[Nullable(2)]
		private FExpressionInput _FixedShadowMask;

		// Token: 0x04006536 RID: 25910
		internal static int __PropertyOffset_FixedLightColor;

		// Token: 0x04006537 RID: 25911
		[Nullable(2)]
		private FExpressionInput _FixedLightColor;

		// Token: 0x04006538 RID: 25912
		internal static int __PropertyOffset_FixedAmbientColor;

		// Token: 0x04006539 RID: 25913
		[Nullable(2)]
		private FExpressionInput _FixedAmbientColor;
	}
}
