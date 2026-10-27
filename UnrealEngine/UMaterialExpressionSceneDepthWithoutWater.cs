using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E36 RID: 3638
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSceneDepthWithoutWater")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UMaterialExpressionSceneDepthWithoutWater : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C390 RID: 50064 RVA: 0x0011A6BA File Offset: 0x001188BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSceneDepthWithoutWater._ClassPtr;
		}

		// Token: 0x0600C391 RID: 50065 RVA: 0x0011A6C8 File Offset: 0x001188C8
		public UMaterialExpressionSceneDepthWithoutWater() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSceneDepthWithoutWater.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C392 RID: 50066 RVA: 0x0011A6F0 File Offset: 0x001188F0
		[NullableContext(1)]
		public UMaterialExpressionSceneDepthWithoutWater(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSceneDepthWithoutWater.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D64 RID: 11620
		// (get) Token: 0x0600C393 RID: 50067 RVA: 0x0011A723 File Offset: 0x00118923
		// (set) Token: 0x0600C394 RID: 50068 RVA: 0x0011A737 File Offset: 0x00118937
		public unsafe TEnumAsByte<EMaterialSceneAttributeInputMode> InputMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSceneDepthWithoutWater.__PropertyOffset_InputMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSceneDepthWithoutWater.__PropertyOffset_InputMode) = value;
			}
		}

		// Token: 0x17002D65 RID: 11621
		// (get) Token: 0x0600C395 RID: 50069 RVA: 0x0011A74C File Offset: 0x0011894C
		// (set) Token: 0x0600C396 RID: 50070 RVA: 0x0011A785 File Offset: 0x00118985
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
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSceneDepthWithoutWater.__PropertyOffset_Input, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSceneDepthWithoutWater.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D66 RID: 11622
		// (get) Token: 0x0600C397 RID: 50071 RVA: 0x0011A7A6 File Offset: 0x001189A6
		// (set) Token: 0x0600C398 RID: 50072 RVA: 0x0011A7BA File Offset: 0x001189BA
		public unsafe FVector2D ConstInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSceneDepthWithoutWater.__PropertyOffset_ConstInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSceneDepthWithoutWater.__PropertyOffset_ConstInput) = value;
			}
		}

		// Token: 0x17002D67 RID: 11623
		// (get) Token: 0x0600C399 RID: 50073 RVA: 0x0011A7CF File Offset: 0x001189CF
		// (set) Token: 0x0600C39A RID: 50074 RVA: 0x0011A7DF File Offset: 0x001189DF
		public unsafe float FallbackDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSceneDepthWithoutWater.__PropertyOffset_FallbackDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSceneDepthWithoutWater.__PropertyOffset_FallbackDepth) = value;
			}
		}

		// Token: 0x0600C39B RID: 50075 RVA: 0x0011A7F0 File Offset: 0x001189F0
		static UMaterialExpressionSceneDepthWithoutWater()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSceneDepthWithoutWater");
		}

		// Token: 0x0600C39C RID: 50076 RVA: 0x0011A7FE File Offset: 0x001189FE
		protected UMaterialExpressionSceneDepthWithoutWater(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006849 RID: 26697
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSceneDepthWithoutWater";

		// Token: 0x0400684A RID: 26698
		private static IntPtr _ClassPtr;

		// Token: 0x0400684B RID: 26699
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400684C RID: 26700
		internal static int __PropertyOffset_InputMode;

		// Token: 0x0400684D RID: 26701
		internal static int __PropertyOffset_Input;

		// Token: 0x0400684E RID: 26702
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x0400684F RID: 26703
		internal static int __PropertyOffset_ConstInput;

		// Token: 0x04006850 RID: 26704
		internal static int __PropertyOffset_FallbackDepth;
	}
}
