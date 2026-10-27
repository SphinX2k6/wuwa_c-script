using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FA0 RID: 8096
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.MaterialExpressionLandscapePhysicalMaterialOutput")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UMaterialExpressionLandscapePhysicalMaterialOutput : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EBA6 RID: 125862 RVA: 0x002DAF09 File Offset: 0x002D9109
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapePhysicalMaterialOutput._ClassPtr;
		}

		// Token: 0x0601EBA7 RID: 125863 RVA: 0x002DAF18 File Offset: 0x002D9118
		public UMaterialExpressionLandscapePhysicalMaterialOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapePhysicalMaterialOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EBA8 RID: 125864 RVA: 0x002DAF40 File Offset: 0x002D9140
		public UMaterialExpressionLandscapePhysicalMaterialOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapePhysicalMaterialOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A6B RID: 31339
		// (get) Token: 0x0601EBA9 RID: 125865 RVA: 0x002DAF74 File Offset: 0x002D9174
		// (set) Token: 0x0601EBAA RID: 125866 RVA: 0x002DAFAD File Offset: 0x002D91AD
		public TArray<FPhysicalMaterialInput> Inputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPhysicalMaterialInput> result;
				if ((result = this._Inputs) == null)
				{
					result = (this._Inputs = new TArray<FPhysicalMaterialInput>(base.NativePtr + (IntPtr)UMaterialExpressionLandscapePhysicalMaterialOutput.__PropertyOffset_Inputs, this));
				}
				return result;
			}
			set
			{
				this.Inputs.CopyAssign(value);
			}
		}

		// Token: 0x0601EBAB RID: 125867 RVA: 0x002DAFBB File Offset: 0x002D91BB
		static UMaterialExpressionLandscapePhysicalMaterialOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.MaterialExpressionLandscapePhysicalMaterialOutput");
		}

		// Token: 0x0601EBAC RID: 125868 RVA: 0x002DAFC9 File Offset: 0x002D91C9
		protected UMaterialExpressionLandscapePhysicalMaterialOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109D8 RID: 68056
		public new const string __ObjectPath = "/Script/Landscape.MaterialExpressionLandscapePhysicalMaterialOutput";

		// Token: 0x040109D9 RID: 68057
		private static IntPtr _ClassPtr;

		// Token: 0x040109DA RID: 68058
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109DB RID: 68059
		internal static int __PropertyOffset_Inputs;

		// Token: 0x040109DC RID: 68060
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPhysicalMaterialInput> _Inputs;
	}
}
