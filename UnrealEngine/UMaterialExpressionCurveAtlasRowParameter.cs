using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DA8 RID: 3496
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionCurveAtlasRowParameter")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UMaterialExpressionCurveAtlasRowParameter : UMaterialExpressionScalarParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE47 RID: 48711 RVA: 0x00110721 File Offset: 0x0010E921
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionCurveAtlasRowParameter._ClassPtr;
		}

		// Token: 0x0600BE48 RID: 48712 RVA: 0x00110730 File Offset: 0x0010E930
		public UMaterialExpressionCurveAtlasRowParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCurveAtlasRowParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE49 RID: 48713 RVA: 0x00110758 File Offset: 0x0010E958
		[NullableContext(1)]
		public UMaterialExpressionCurveAtlasRowParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCurveAtlasRowParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C21 RID: 11297
		// (get) Token: 0x0600BE4A RID: 48714 RVA: 0x0011078B File Offset: 0x0010E98B
		// (set) Token: 0x0600BE4B RID: 48715 RVA: 0x0011079F File Offset: 0x0010E99F
		public unsafe UCurveLinearColor Curve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionCurveAtlasRowParameter.__PropertyOffset_Curve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionCurveAtlasRowParameter.__PropertyOffset_Curve, value);
			}
		}

		// Token: 0x17002C22 RID: 11298
		// (get) Token: 0x0600BE4C RID: 48716 RVA: 0x001107B4 File Offset: 0x0010E9B4
		// (set) Token: 0x0600BE4D RID: 48717 RVA: 0x001107C8 File Offset: 0x0010E9C8
		public unsafe UCurveLinearColorAtlas Atlas
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColorAtlas>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionCurveAtlasRowParameter.__PropertyOffset_Atlas);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionCurveAtlasRowParameter.__PropertyOffset_Atlas, value);
			}
		}

		// Token: 0x17002C23 RID: 11299
		// (get) Token: 0x0600BE4E RID: 48718 RVA: 0x001107E0 File Offset: 0x0010E9E0
		// (set) Token: 0x0600BE4F RID: 48719 RVA: 0x00110819 File Offset: 0x0010EA19
		[Nullable(1)]
		public FExpressionInput InputTime
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._InputTime) == null)
				{
					result = (this._InputTime = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionCurveAtlasRowParameter.__PropertyOffset_InputTime, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionCurveAtlasRowParameter.__PropertyOffset_InputTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BE50 RID: 48720 RVA: 0x0011083A File Offset: 0x0010EA3A
		static UMaterialExpressionCurveAtlasRowParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionCurveAtlasRowParameter");
		}

		// Token: 0x0600BE51 RID: 48721 RVA: 0x00110848 File Offset: 0x0010EA48
		protected UMaterialExpressionCurveAtlasRowParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400648D RID: 25741
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionCurveAtlasRowParameter";

		// Token: 0x0400648E RID: 25742
		private static IntPtr _ClassPtr;

		// Token: 0x0400648F RID: 25743
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006490 RID: 25744
		internal static int __PropertyOffset_Curve;

		// Token: 0x04006491 RID: 25745
		internal static int __PropertyOffset_Atlas;

		// Token: 0x04006492 RID: 25746
		internal static int __PropertyOffset_InputTime;

		// Token: 0x04006493 RID: 25747
		private FExpressionInput _InputTime;
	}
}
