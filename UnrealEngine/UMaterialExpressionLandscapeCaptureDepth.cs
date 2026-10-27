using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DE8 RID: 3560
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionLandscapeCaptureDepth")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMaterialExpressionLandscapeCaptureDepth : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C0A6 RID: 49318 RVA: 0x00114FA2 File Offset: 0x001131A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeCaptureDepth._ClassPtr;
		}

		// Token: 0x0600C0A7 RID: 49319 RVA: 0x00114FB0 File Offset: 0x001131B0
		public UMaterialExpressionLandscapeCaptureDepth() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeCaptureDepth.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C0A8 RID: 49320 RVA: 0x00114FD8 File Offset: 0x001131D8
		public UMaterialExpressionLandscapeCaptureDepth(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeCaptureDepth.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CB1 RID: 11441
		// (get) Token: 0x0600C0A9 RID: 49321 RVA: 0x0011500B File Offset: 0x0011320B
		// (set) Token: 0x0600C0AA RID: 49322 RVA: 0x0011501F File Offset: 0x0011321F
		[Nullable(0)]
		public unsafe TEnumAsByte<EMaterialSceneAttributeInputMode> InputMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepth.__PropertyOffset_InputMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepth.__PropertyOffset_InputMode) = value;
			}
		}

		// Token: 0x17002CB2 RID: 11442
		// (get) Token: 0x0600C0AB RID: 49323 RVA: 0x00115034 File Offset: 0x00113234
		// (set) Token: 0x0600C0AC RID: 49324 RVA: 0x0011506D File Offset: 0x0011326D
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepth.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepth.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CB3 RID: 11443
		// (get) Token: 0x0600C0AD RID: 49325 RVA: 0x00115090 File Offset: 0x00113290
		// (set) Token: 0x0600C0AE RID: 49326 RVA: 0x001150C9 File Offset: 0x001132C9
		public FExpressionInput DefaultDepth
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._DefaultDepth) == null)
				{
					result = (this._DefaultDepth = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepth.__PropertyOffset_DefaultDepth, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepth.__PropertyOffset_DefaultDepth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CB4 RID: 11444
		// (get) Token: 0x0600C0AF RID: 49327 RVA: 0x001150EA File Offset: 0x001132EA
		// (set) Token: 0x0600C0B0 RID: 49328 RVA: 0x001150FE File Offset: 0x001132FE
		public unsafe FVector2D ConstInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepth.__PropertyOffset_ConstInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepth.__PropertyOffset_ConstInput) = value;
			}
		}

		// Token: 0x0600C0B1 RID: 49329 RVA: 0x00115113 File Offset: 0x00113313
		static UMaterialExpressionLandscapeCaptureDepth()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionLandscapeCaptureDepth");
		}

		// Token: 0x0600C0B2 RID: 49330 RVA: 0x00115121 File Offset: 0x00113321
		protected UMaterialExpressionLandscapeCaptureDepth(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400663E RID: 26174
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionLandscapeCaptureDepth";

		// Token: 0x0400663F RID: 26175
		private static IntPtr _ClassPtr;

		// Token: 0x04006640 RID: 26176
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006641 RID: 26177
		internal static int __PropertyOffset_InputMode;

		// Token: 0x04006642 RID: 26178
		internal static int __PropertyOffset_Input;

		// Token: 0x04006643 RID: 26179
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x04006644 RID: 26180
		internal static int __PropertyOffset_DefaultDepth;

		// Token: 0x04006645 RID: 26181
		[Nullable(2)]
		private FExpressionInput _DefaultDepth;

		// Token: 0x04006646 RID: 26182
		internal static int __PropertyOffset_ConstInput;
	}
}
