using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F95 RID: 8085
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.MaterialExpressionLandscapeColormap")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UMaterialExpressionLandscapeColormap : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB2D RID: 125741 RVA: 0x002DA2A4 File Offset: 0x002D84A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeColormap._ClassPtr;
		}

		// Token: 0x0601EB2E RID: 125742 RVA: 0x002DA2B0 File Offset: 0x002D84B0
		public UMaterialExpressionLandscapeColormap() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeColormap.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB2F RID: 125743 RVA: 0x002DA2D8 File Offset: 0x002D84D8
		public UMaterialExpressionLandscapeColormap(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeColormap.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A4A RID: 31306
		// (get) Token: 0x0601EB30 RID: 125744 RVA: 0x002DA30B File Offset: 0x002D850B
		// (set) Token: 0x0601EB31 RID: 125745 RVA: 0x002DA31F File Offset: 0x002D851F
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeColormap.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeColormap.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x17007A4B RID: 31307
		// (get) Token: 0x0601EB32 RID: 125746 RVA: 0x002DA334 File Offset: 0x002D8534
		// (set) Token: 0x0601EB33 RID: 125747 RVA: 0x002DA36D File Offset: 0x002D856D
		public FExpressionInput UV
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._UV) == null)
				{
					result = (this._UV = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeColormap.__PropertyOffset_UV, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLandscapeColormap.__PropertyOffset_UV, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601EB34 RID: 125748 RVA: 0x002DA38E File Offset: 0x002D858E
		static UMaterialExpressionLandscapeColormap()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.MaterialExpressionLandscapeColormap");
		}

		// Token: 0x0601EB35 RID: 125749 RVA: 0x002DA39C File Offset: 0x002D859C
		protected UMaterialExpressionLandscapeColormap(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401098B RID: 67979
		public new const string __ObjectPath = "/Script/Landscape.MaterialExpressionLandscapeColormap";

		// Token: 0x0401098C RID: 67980
		private static IntPtr _ClassPtr;

		// Token: 0x0401098D RID: 67981
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401098E RID: 67982
		internal static int __PropertyOffset_ExpressionGUID;

		// Token: 0x0401098F RID: 67983
		internal static int __PropertyOffset_UV;

		// Token: 0x04010990 RID: 67984
		[Nullable(2)]
		private FExpressionInput _UV;
	}
}
