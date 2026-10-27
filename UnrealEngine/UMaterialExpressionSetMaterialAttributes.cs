using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E3B RID: 3643
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSetMaterialAttributes")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMaterialExpressionSetMaterialAttributes : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C3B9 RID: 50105 RVA: 0x0011AACA File Offset: 0x00118CCA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSetMaterialAttributes._ClassPtr;
		}

		// Token: 0x0600C3BA RID: 50106 RVA: 0x0011AAD8 File Offset: 0x00118CD8
		public UMaterialExpressionSetMaterialAttributes() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSetMaterialAttributes.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C3BB RID: 50107 RVA: 0x0011AB00 File Offset: 0x00118D00
		public UMaterialExpressionSetMaterialAttributes(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSetMaterialAttributes.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D6C RID: 11628
		// (get) Token: 0x0600C3BC RID: 50108 RVA: 0x0011AB34 File Offset: 0x00118D34
		// (set) Token: 0x0600C3BD RID: 50109 RVA: 0x0011AB6D File Offset: 0x00118D6D
		public TArray<FExpressionInput> Inputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FExpressionInput> result;
				if ((result = this._Inputs) == null)
				{
					result = (this._Inputs = new TArray<FExpressionInput>(base.NativePtr + (IntPtr)UMaterialExpressionSetMaterialAttributes.__PropertyOffset_Inputs, this));
				}
				return result;
			}
			set
			{
				this.Inputs.CopyAssign(value);
			}
		}

		// Token: 0x17002D6D RID: 11629
		// (get) Token: 0x0600C3BE RID: 50110 RVA: 0x0011AB7C File Offset: 0x00118D7C
		// (set) Token: 0x0600C3BF RID: 50111 RVA: 0x0011ABB5 File Offset: 0x00118DB5
		public TArray<FGuid> AttributeSetTypes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._AttributeSetTypes) == null)
				{
					result = (this._AttributeSetTypes = new TArray<FGuid>(base.NativePtr + (IntPtr)UMaterialExpressionSetMaterialAttributes.__PropertyOffset_AttributeSetTypes, this));
				}
				return result;
			}
			set
			{
				this.AttributeSetTypes.CopyAssign(value);
			}
		}

		// Token: 0x0600C3C0 RID: 50112 RVA: 0x0011ABC3 File Offset: 0x00118DC3
		static UMaterialExpressionSetMaterialAttributes()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSetMaterialAttributes");
		}

		// Token: 0x0600C3C1 RID: 50113 RVA: 0x0011ABD1 File Offset: 0x00118DD1
		protected UMaterialExpressionSetMaterialAttributes(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006862 RID: 26722
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSetMaterialAttributes";

		// Token: 0x04006863 RID: 26723
		private static IntPtr _ClassPtr;

		// Token: 0x04006864 RID: 26724
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006865 RID: 26725
		internal static int __PropertyOffset_Inputs;

		// Token: 0x04006866 RID: 26726
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FExpressionInput> _Inputs;

		// Token: 0x04006867 RID: 26727
		internal static int __PropertyOffset_AttributeSetTypes;

		// Token: 0x04006868 RID: 26728
		[Nullable(2)]
		private TArray<FGuid> _AttributeSetTypes;
	}
}
