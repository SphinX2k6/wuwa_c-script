using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F96 RID: 8086
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.MaterialExpressionLandscapeDefineLayer")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UMaterialExpressionLandscapeDefineLayer : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB36 RID: 125750 RVA: 0x002DA3A5 File Offset: 0x002D85A5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeDefineLayer._ClassPtr;
		}

		// Token: 0x0601EB37 RID: 125751 RVA: 0x002DA3B4 File Offset: 0x002D85B4
		public UMaterialExpressionLandscapeDefineLayer() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeDefineLayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB38 RID: 125752 RVA: 0x002DA3DC File Offset: 0x002D85DC
		public UMaterialExpressionLandscapeDefineLayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeDefineLayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A4C RID: 31308
		// (get) Token: 0x0601EB39 RID: 125753 RVA: 0x002DA40F File Offset: 0x002D860F
		// (set) Token: 0x0601EB3A RID: 125754 RVA: 0x002DA423 File Offset: 0x002D8623
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeDefineLayer.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeDefineLayer.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x17007A4D RID: 31309
		// (get) Token: 0x0601EB3B RID: 125755 RVA: 0x002DA438 File Offset: 0x002D8638
		// (set) Token: 0x0601EB3C RID: 125756 RVA: 0x002DA471 File Offset: 0x002D8671
		public TArray<FName> LayerNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._LayerNames) == null)
				{
					result = (this._LayerNames = new TArray<FName>(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeDefineLayer.__PropertyOffset_LayerNames, this));
				}
				return result;
			}
			set
			{
				this.LayerNames.CopyAssign(value);
			}
		}

		// Token: 0x0601EB3D RID: 125757 RVA: 0x002DA47F File Offset: 0x002D867F
		static UMaterialExpressionLandscapeDefineLayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.MaterialExpressionLandscapeDefineLayer");
		}

		// Token: 0x0601EB3E RID: 125758 RVA: 0x002DA48D File Offset: 0x002D868D
		protected UMaterialExpressionLandscapeDefineLayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010991 RID: 67985
		public new const string __ObjectPath = "/Script/Landscape.MaterialExpressionLandscapeDefineLayer";

		// Token: 0x04010992 RID: 67986
		private static IntPtr _ClassPtr;

		// Token: 0x04010993 RID: 67987
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010994 RID: 67988
		internal static int __PropertyOffset_ExpressionGUID;

		// Token: 0x04010995 RID: 67989
		internal static int __PropertyOffset_LayerNames;

		// Token: 0x04010996 RID: 67990
		[Nullable(2)]
		private TArray<FName> _LayerNames;
	}
}
