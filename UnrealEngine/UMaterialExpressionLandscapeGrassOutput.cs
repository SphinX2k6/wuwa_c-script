using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F97 RID: 8087
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.MaterialExpressionLandscapeGrassOutput")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UMaterialExpressionLandscapeGrassOutput : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB3F RID: 125759 RVA: 0x002DA496 File Offset: 0x002D8696
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeGrassOutput._ClassPtr;
		}

		// Token: 0x0601EB40 RID: 125760 RVA: 0x002DA4A4 File Offset: 0x002D86A4
		public UMaterialExpressionLandscapeGrassOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeGrassOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB41 RID: 125761 RVA: 0x002DA4CC File Offset: 0x002D86CC
		public UMaterialExpressionLandscapeGrassOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeGrassOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A4E RID: 31310
		// (get) Token: 0x0601EB42 RID: 125762 RVA: 0x002DA500 File Offset: 0x002D8700
		// (set) Token: 0x0601EB43 RID: 125763 RVA: 0x002DA539 File Offset: 0x002D8739
		public TArray<FGrassInput> GrassTypes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGrassInput> result;
				if ((result = this._GrassTypes) == null)
				{
					result = (this._GrassTypes = new TArray<FGrassInput>(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeGrassOutput.__PropertyOffset_GrassTypes, this));
				}
				return result;
			}
			set
			{
				this.GrassTypes.CopyAssign(value);
			}
		}

		// Token: 0x0601EB44 RID: 125764 RVA: 0x002DA547 File Offset: 0x002D8747
		static UMaterialExpressionLandscapeGrassOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.MaterialExpressionLandscapeGrassOutput");
		}

		// Token: 0x0601EB45 RID: 125765 RVA: 0x002DA555 File Offset: 0x002D8755
		protected UMaterialExpressionLandscapeGrassOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010997 RID: 67991
		public new const string __ObjectPath = "/Script/Landscape.MaterialExpressionLandscapeGrassOutput";

		// Token: 0x04010998 RID: 67992
		private static IntPtr _ClassPtr;

		// Token: 0x04010999 RID: 67993
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401099A RID: 67994
		internal static int __PropertyOffset_GrassTypes;

		// Token: 0x0401099B RID: 67995
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGrassInput> _GrassTypes;
	}
}
