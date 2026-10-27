using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E35 RID: 3637
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSceneDepth")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMaterialExpressionSceneDepth : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C383 RID: 50051 RVA: 0x0011A532 File Offset: 0x00118732
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSceneDepth._ClassPtr;
		}

		// Token: 0x0600C384 RID: 50052 RVA: 0x0011A540 File Offset: 0x00118740
		public UMaterialExpressionSceneDepth() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSceneDepth.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C385 RID: 50053 RVA: 0x0011A568 File Offset: 0x00118768
		public UMaterialExpressionSceneDepth(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSceneDepth.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D60 RID: 11616
		// (get) Token: 0x0600C386 RID: 50054 RVA: 0x0011A59B File Offset: 0x0011879B
		// (set) Token: 0x0600C387 RID: 50055 RVA: 0x0011A5AF File Offset: 0x001187AF
		[Nullable(0)]
		public unsafe TEnumAsByte<EMaterialSceneAttributeInputMode> InputMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSceneDepth.__PropertyOffset_InputMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSceneDepth.__PropertyOffset_InputMode) = value;
			}
		}

		// Token: 0x17002D61 RID: 11617
		// (get) Token: 0x0600C388 RID: 50056 RVA: 0x0011A5C4 File Offset: 0x001187C4
		// (set) Token: 0x0600C389 RID: 50057 RVA: 0x0011A5FD File Offset: 0x001187FD
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSceneDepth.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSceneDepth.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D62 RID: 11618
		// (get) Token: 0x0600C38A RID: 50058 RVA: 0x0011A620 File Offset: 0x00118820
		// (set) Token: 0x0600C38B RID: 50059 RVA: 0x0011A659 File Offset: 0x00118859
		public FExpressionInput Coordinates_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Coordinates_DEPRECATED) == null)
				{
					result = (this._Coordinates_DEPRECATED = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSceneDepth.__PropertyOffset_Coordinates_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSceneDepth.__PropertyOffset_Coordinates_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D63 RID: 11619
		// (get) Token: 0x0600C38C RID: 50060 RVA: 0x0011A67A File Offset: 0x0011887A
		// (set) Token: 0x0600C38D RID: 50061 RVA: 0x0011A68E File Offset: 0x0011888E
		public unsafe FVector2D ConstInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSceneDepth.__PropertyOffset_ConstInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSceneDepth.__PropertyOffset_ConstInput) = value;
			}
		}

		// Token: 0x0600C38E RID: 50062 RVA: 0x0011A6A3 File Offset: 0x001188A3
		static UMaterialExpressionSceneDepth()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSceneDepth");
		}

		// Token: 0x0600C38F RID: 50063 RVA: 0x0011A6B1 File Offset: 0x001188B1
		protected UMaterialExpressionSceneDepth(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006840 RID: 26688
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSceneDepth";

		// Token: 0x04006841 RID: 26689
		private static IntPtr _ClassPtr;

		// Token: 0x04006842 RID: 26690
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006843 RID: 26691
		internal static int __PropertyOffset_InputMode;

		// Token: 0x04006844 RID: 26692
		internal static int __PropertyOffset_Input;

		// Token: 0x04006845 RID: 26693
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x04006846 RID: 26694
		internal static int __PropertyOffset_Coordinates_DEPRECATED;

		// Token: 0x04006847 RID: 26695
		[Nullable(2)]
		private FExpressionInput _Coordinates_DEPRECATED;

		// Token: 0x04006848 RID: 26696
		internal static int __PropertyOffset_ConstInput;
	}
}
