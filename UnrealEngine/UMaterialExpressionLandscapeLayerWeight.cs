using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F9F RID: 8095
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.MaterialExpressionLandscapeLayerWeight")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UMaterialExpressionLandscapeLayerWeight : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB95 RID: 125845 RVA: 0x002DAD38 File Offset: 0x002D8F38
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeLayerWeight._ClassPtr;
		}

		// Token: 0x0601EB96 RID: 125846 RVA: 0x002DAD44 File Offset: 0x002D8F44
		public UMaterialExpressionLandscapeLayerWeight() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeLayerWeight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB97 RID: 125847 RVA: 0x002DAD6C File Offset: 0x002D8F6C
		public UMaterialExpressionLandscapeLayerWeight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeLayerWeight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A65 RID: 31333
		// (get) Token: 0x0601EB98 RID: 125848 RVA: 0x002DADA0 File Offset: 0x002D8FA0
		// (set) Token: 0x0601EB99 RID: 125849 RVA: 0x002DADD9 File Offset: 0x002D8FD9
		public FExpressionInput Base
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Base) == null)
				{
					result = (this._Base = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerWeight.__PropertyOffset_Base, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerWeight.__PropertyOffset_Base, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007A66 RID: 31334
		// (get) Token: 0x0601EB9A RID: 125850 RVA: 0x002DADFC File Offset: 0x002D8FFC
		// (set) Token: 0x0601EB9B RID: 125851 RVA: 0x002DAE35 File Offset: 0x002D9035
		public FExpressionInput Layer
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Layer) == null)
				{
					result = (this._Layer = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerWeight.__PropertyOffset_Layer, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerWeight.__PropertyOffset_Layer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007A67 RID: 31335
		// (get) Token: 0x0601EB9C RID: 125852 RVA: 0x002DAE56 File Offset: 0x002D9056
		// (set) Token: 0x0601EB9D RID: 125853 RVA: 0x002DAE6A File Offset: 0x002D906A
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerWeight.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerWeight.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17007A68 RID: 31336
		// (get) Token: 0x0601EB9E RID: 125854 RVA: 0x002DAE7F File Offset: 0x002D907F
		// (set) Token: 0x0601EB9F RID: 125855 RVA: 0x002DAE8F File Offset: 0x002D908F
		public unsafe float PreviewWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerWeight.__PropertyOffset_PreviewWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerWeight.__PropertyOffset_PreviewWeight) = value;
			}
		}

		// Token: 0x17007A69 RID: 31337
		// (get) Token: 0x0601EBA0 RID: 125856 RVA: 0x002DAEA0 File Offset: 0x002D90A0
		// (set) Token: 0x0601EBA1 RID: 125857 RVA: 0x002DAEB4 File Offset: 0x002D90B4
		public unsafe FVector ConstBase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerWeight.__PropertyOffset_ConstBase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerWeight.__PropertyOffset_ConstBase) = value;
			}
		}

		// Token: 0x17007A6A RID: 31338
		// (get) Token: 0x0601EBA2 RID: 125858 RVA: 0x002DAEC9 File Offset: 0x002D90C9
		// (set) Token: 0x0601EBA3 RID: 125859 RVA: 0x002DAEDD File Offset: 0x002D90DD
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerWeight.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeLayerWeight.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x0601EBA4 RID: 125860 RVA: 0x002DAEF2 File Offset: 0x002D90F2
		static UMaterialExpressionLandscapeLayerWeight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.MaterialExpressionLandscapeLayerWeight");
		}

		// Token: 0x0601EBA5 RID: 125861 RVA: 0x002DAF00 File Offset: 0x002D9100
		protected UMaterialExpressionLandscapeLayerWeight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109CD RID: 68045
		public new const string __ObjectPath = "/Script/Landscape.MaterialExpressionLandscapeLayerWeight";

		// Token: 0x040109CE RID: 68046
		private static IntPtr _ClassPtr;

		// Token: 0x040109CF RID: 68047
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109D0 RID: 68048
		internal static int __PropertyOffset_Base;

		// Token: 0x040109D1 RID: 68049
		[Nullable(2)]
		private FExpressionInput _Base;

		// Token: 0x040109D2 RID: 68050
		internal static int __PropertyOffset_Layer;

		// Token: 0x040109D3 RID: 68051
		[Nullable(2)]
		private FExpressionInput _Layer;

		// Token: 0x040109D4 RID: 68052
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x040109D5 RID: 68053
		internal static int __PropertyOffset_PreviewWeight;

		// Token: 0x040109D6 RID: 68054
		internal static int __PropertyOffset_ConstBase;

		// Token: 0x040109D7 RID: 68055
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
