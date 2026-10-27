using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DE7 RID: 3559
	[UnrealObjectPath("/Script/Engine.MaterialExpressionLandscapeCaptureColorRoughness")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UMaterialExpressionLandscapeCaptureColorRoughness : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C09B RID: 49307 RVA: 0x00114E75 File Offset: 0x00113075
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeCaptureColorRoughness._ClassPtr;
		}

		// Token: 0x0600C09C RID: 49308 RVA: 0x00114E84 File Offset: 0x00113084
		public UMaterialExpressionLandscapeCaptureColorRoughness() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeCaptureColorRoughness.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C09D RID: 49309 RVA: 0x00114EAC File Offset: 0x001130AC
		[NullableContext(1)]
		public UMaterialExpressionLandscapeCaptureColorRoughness(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeCaptureColorRoughness.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CAE RID: 11438
		// (get) Token: 0x0600C09E RID: 49310 RVA: 0x00114EDF File Offset: 0x001130DF
		// (set) Token: 0x0600C09F RID: 49311 RVA: 0x00114EF3 File Offset: 0x001130F3
		public unsafe TEnumAsByte<EMaterialSceneAttributeInputMode> InputMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureColorRoughness.__PropertyOffset_InputMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureColorRoughness.__PropertyOffset_InputMode) = value;
			}
		}

		// Token: 0x17002CAF RID: 11439
		// (get) Token: 0x0600C0A0 RID: 49312 RVA: 0x00114F08 File Offset: 0x00113108
		// (set) Token: 0x0600C0A1 RID: 49313 RVA: 0x00114F41 File Offset: 0x00113141
		[Nullable(1)]
		public FExpressionInput Input
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureColorRoughness.__PropertyOffset_Input, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureColorRoughness.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CB0 RID: 11440
		// (get) Token: 0x0600C0A2 RID: 49314 RVA: 0x00114F62 File Offset: 0x00113162
		// (set) Token: 0x0600C0A3 RID: 49315 RVA: 0x00114F76 File Offset: 0x00113176
		public unsafe FVector2D ConstInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureColorRoughness.__PropertyOffset_ConstInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureColorRoughness.__PropertyOffset_ConstInput) = value;
			}
		}

		// Token: 0x0600C0A4 RID: 49316 RVA: 0x00114F8B File Offset: 0x0011318B
		static UMaterialExpressionLandscapeCaptureColorRoughness()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionLandscapeCaptureColorRoughness");
		}

		// Token: 0x0600C0A5 RID: 49317 RVA: 0x00114F99 File Offset: 0x00113199
		protected UMaterialExpressionLandscapeCaptureColorRoughness(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006637 RID: 26167
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionLandscapeCaptureColorRoughness";

		// Token: 0x04006638 RID: 26168
		private static IntPtr _ClassPtr;

		// Token: 0x04006639 RID: 26169
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400663A RID: 26170
		internal static int __PropertyOffset_InputMode;

		// Token: 0x0400663B RID: 26171
		internal static int __PropertyOffset_Input;

		// Token: 0x0400663C RID: 26172
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x0400663D RID: 26173
		internal static int __PropertyOffset_ConstInput;
	}
}
