using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E33 RID: 3635
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSceneColor")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMaterialExpressionSceneColor : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C36B RID: 50027 RVA: 0x0011A27E File Offset: 0x0011847E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSceneColor._ClassPtr;
		}

		// Token: 0x0600C36C RID: 50028 RVA: 0x0011A28C File Offset: 0x0011848C
		public UMaterialExpressionSceneColor() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSceneColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C36D RID: 50029 RVA: 0x0011A2B4 File Offset: 0x001184B4
		public UMaterialExpressionSceneColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSceneColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D59 RID: 11609
		// (get) Token: 0x0600C36E RID: 50030 RVA: 0x0011A2E7 File Offset: 0x001184E7
		// (set) Token: 0x0600C36F RID: 50031 RVA: 0x0011A2FB File Offset: 0x001184FB
		[Nullable(0)]
		public unsafe TEnumAsByte<EMaterialSceneAttributeInputMode> InputMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSceneColor.__PropertyOffset_InputMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSceneColor.__PropertyOffset_InputMode) = value;
			}
		}

		// Token: 0x17002D5A RID: 11610
		// (get) Token: 0x0600C370 RID: 50032 RVA: 0x0011A310 File Offset: 0x00118510
		// (set) Token: 0x0600C371 RID: 50033 RVA: 0x0011A349 File Offset: 0x00118549
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSceneColor.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSceneColor.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D5B RID: 11611
		// (get) Token: 0x0600C372 RID: 50034 RVA: 0x0011A36C File Offset: 0x0011856C
		// (set) Token: 0x0600C373 RID: 50035 RVA: 0x0011A3A5 File Offset: 0x001185A5
		public FExpressionInput OffsetFraction_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._OffsetFraction_DEPRECATED) == null)
				{
					result = (this._OffsetFraction_DEPRECATED = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSceneColor.__PropertyOffset_OffsetFraction_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSceneColor.__PropertyOffset_OffsetFraction_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D5C RID: 11612
		// (get) Token: 0x0600C374 RID: 50036 RVA: 0x0011A3C6 File Offset: 0x001185C6
		// (set) Token: 0x0600C375 RID: 50037 RVA: 0x0011A3DA File Offset: 0x001185DA
		public unsafe FVector2D ConstInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSceneColor.__PropertyOffset_ConstInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSceneColor.__PropertyOffset_ConstInput) = value;
			}
		}

		// Token: 0x0600C376 RID: 50038 RVA: 0x0011A3EF File Offset: 0x001185EF
		static UMaterialExpressionSceneColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSceneColor");
		}

		// Token: 0x0600C377 RID: 50039 RVA: 0x0011A3FD File Offset: 0x001185FD
		protected UMaterialExpressionSceneColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006830 RID: 26672
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSceneColor";

		// Token: 0x04006831 RID: 26673
		private static IntPtr _ClassPtr;

		// Token: 0x04006832 RID: 26674
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006833 RID: 26675
		internal static int __PropertyOffset_InputMode;

		// Token: 0x04006834 RID: 26676
		internal static int __PropertyOffset_Input;

		// Token: 0x04006835 RID: 26677
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x04006836 RID: 26678
		internal static int __PropertyOffset_OffsetFraction_DEPRECATED;

		// Token: 0x04006837 RID: 26679
		[Nullable(2)]
		private FExpressionInput _OffsetFraction_DEPRECATED;

		// Token: 0x04006838 RID: 26680
		internal static int __PropertyOffset_ConstInput;
	}
}
