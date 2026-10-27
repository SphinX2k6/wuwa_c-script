using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FA1 RID: 8097
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.MaterialExpressionLandscapeRetainNode")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UMaterialExpressionLandscapeRetainNode : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EBAD RID: 125869 RVA: 0x002DAFD2 File Offset: 0x002D91D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeRetainNode._ClassPtr;
		}

		// Token: 0x0601EBAE RID: 125870 RVA: 0x002DAFE0 File Offset: 0x002D91E0
		public UMaterialExpressionLandscapeRetainNode() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeRetainNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EBAF RID: 125871 RVA: 0x002DB008 File Offset: 0x002D9208
		public UMaterialExpressionLandscapeRetainNode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeRetainNode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A6C RID: 31340
		// (get) Token: 0x0601EBB0 RID: 125872 RVA: 0x002DB03C File Offset: 0x002D923C
		// (set) Token: 0x0601EBB1 RID: 125873 RVA: 0x002DB075 File Offset: 0x002D9275
		public FMaterialAttributesInput MaterialAttribute
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialAttributesInput result;
				if ((result = this._MaterialAttribute) == null)
				{
					result = (this._MaterialAttribute = new FMaterialAttributesInput(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeRetainNode.__PropertyOffset_MaterialAttribute, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialAttributesInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLandscapeRetainNode.__PropertyOffset_MaterialAttribute, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007A6D RID: 31341
		// (get) Token: 0x0601EBB2 RID: 125874 RVA: 0x002DB096 File Offset: 0x002D9296
		// (set) Token: 0x0601EBB3 RID: 125875 RVA: 0x002DB0AA File Offset: 0x002D92AA
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeRetainNode.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeRetainNode.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x0601EBB4 RID: 125876 RVA: 0x002DB0BF File Offset: 0x002D92BF
		static UMaterialExpressionLandscapeRetainNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.MaterialExpressionLandscapeRetainNode");
		}

		// Token: 0x0601EBB5 RID: 125877 RVA: 0x002DB0CD File Offset: 0x002D92CD
		protected UMaterialExpressionLandscapeRetainNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109DD RID: 68061
		public new const string __ObjectPath = "/Script/Landscape.MaterialExpressionLandscapeRetainNode";

		// Token: 0x040109DE RID: 68062
		private static IntPtr _ClassPtr;

		// Token: 0x040109DF RID: 68063
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109E0 RID: 68064
		internal static int __PropertyOffset_MaterialAttribute;

		// Token: 0x040109E1 RID: 68065
		[Nullable(2)]
		private FMaterialAttributesInput _MaterialAttribute;

		// Token: 0x040109E2 RID: 68066
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
