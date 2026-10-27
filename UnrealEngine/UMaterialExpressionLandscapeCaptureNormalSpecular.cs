using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DEA RID: 3562
	[UnrealObjectPath("/Script/Engine.MaterialExpressionLandscapeCaptureNormalSpecular")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UMaterialExpressionLandscapeCaptureNormalSpecular : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C0C2 RID: 49346 RVA: 0x0011530E File Offset: 0x0011350E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeCaptureNormalSpecular._ClassPtr;
		}

		// Token: 0x0600C0C3 RID: 49347 RVA: 0x0011531C File Offset: 0x0011351C
		public UMaterialExpressionLandscapeCaptureNormalSpecular() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeCaptureNormalSpecular.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C0C4 RID: 49348 RVA: 0x00115344 File Offset: 0x00113544
		[NullableContext(1)]
		public UMaterialExpressionLandscapeCaptureNormalSpecular(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeCaptureNormalSpecular.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CBA RID: 11450
		// (get) Token: 0x0600C0C5 RID: 49349 RVA: 0x00115377 File Offset: 0x00113577
		// (set) Token: 0x0600C0C6 RID: 49350 RVA: 0x0011538B File Offset: 0x0011358B
		public unsafe TEnumAsByte<EMaterialSceneAttributeInputMode> InputMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureNormalSpecular.__PropertyOffset_InputMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureNormalSpecular.__PropertyOffset_InputMode) = value;
			}
		}

		// Token: 0x17002CBB RID: 11451
		// (get) Token: 0x0600C0C7 RID: 49351 RVA: 0x001153A0 File Offset: 0x001135A0
		// (set) Token: 0x0600C0C8 RID: 49352 RVA: 0x001153D9 File Offset: 0x001135D9
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
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureNormalSpecular.__PropertyOffset_Input, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureNormalSpecular.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CBC RID: 11452
		// (get) Token: 0x0600C0C9 RID: 49353 RVA: 0x001153FA File Offset: 0x001135FA
		// (set) Token: 0x0600C0CA RID: 49354 RVA: 0x0011540E File Offset: 0x0011360E
		public unsafe FVector2D ConstInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureNormalSpecular.__PropertyOffset_ConstInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureNormalSpecular.__PropertyOffset_ConstInput) = value;
			}
		}

		// Token: 0x0600C0CB RID: 49355 RVA: 0x00115423 File Offset: 0x00113623
		static UMaterialExpressionLandscapeCaptureNormalSpecular()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionLandscapeCaptureNormalSpecular");
		}

		// Token: 0x0600C0CC RID: 49356 RVA: 0x00115431 File Offset: 0x00113631
		protected UMaterialExpressionLandscapeCaptureNormalSpecular(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006652 RID: 26194
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionLandscapeCaptureNormalSpecular";

		// Token: 0x04006653 RID: 26195
		private static IntPtr _ClassPtr;

		// Token: 0x04006654 RID: 26196
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006655 RID: 26197
		internal static int __PropertyOffset_InputMode;

		// Token: 0x04006656 RID: 26198
		internal static int __PropertyOffset_Input;

		// Token: 0x04006657 RID: 26199
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x04006658 RID: 26200
		internal static int __PropertyOffset_ConstInput;
	}
}
