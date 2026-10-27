using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DD0 RID: 3536
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionGetMaterialAttributes")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UMaterialExpressionGetMaterialAttributes : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BFB4 RID: 49076 RVA: 0x001130E3 File Offset: 0x001112E3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionGetMaterialAttributes._ClassPtr;
		}

		// Token: 0x0600BFB5 RID: 49077 RVA: 0x001130F0 File Offset: 0x001112F0
		public UMaterialExpressionGetMaterialAttributes() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionGetMaterialAttributes.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BFB6 RID: 49078 RVA: 0x00113118 File Offset: 0x00111318
		public UMaterialExpressionGetMaterialAttributes(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionGetMaterialAttributes.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C74 RID: 11380
		// (get) Token: 0x0600BFB7 RID: 49079 RVA: 0x0011314C File Offset: 0x0011134C
		// (set) Token: 0x0600BFB8 RID: 49080 RVA: 0x00113185 File Offset: 0x00111385
		public FMaterialAttributesInput MaterialAttributes
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialAttributesInput result;
				if ((result = this._MaterialAttributes) == null)
				{
					result = (this._MaterialAttributes = new FMaterialAttributesInput(base.NativePtr + (IntPtr)UMaterialExpressionGetMaterialAttributes.__PropertyOffset_MaterialAttributes, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialAttributesInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionGetMaterialAttributes.__PropertyOffset_MaterialAttributes, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C75 RID: 11381
		// (get) Token: 0x0600BFB9 RID: 49081 RVA: 0x001131A8 File Offset: 0x001113A8
		// (set) Token: 0x0600BFBA RID: 49082 RVA: 0x001131E1 File Offset: 0x001113E1
		public TArray<FGuid> AttributeGetTypes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._AttributeGetTypes) == null)
				{
					result = (this._AttributeGetTypes = new TArray<FGuid>(base.NativePtr + (IntPtr)UMaterialExpressionGetMaterialAttributes.__PropertyOffset_AttributeGetTypes, this));
				}
				return result;
			}
			set
			{
				this.AttributeGetTypes.CopyAssign(value);
			}
		}

		// Token: 0x0600BFBB RID: 49083 RVA: 0x001131EF File Offset: 0x001113EF
		static UMaterialExpressionGetMaterialAttributes()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionGetMaterialAttributes");
		}

		// Token: 0x0600BFBC RID: 49084 RVA: 0x001131FD File Offset: 0x001113FD
		protected UMaterialExpressionGetMaterialAttributes(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006589 RID: 25993
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionGetMaterialAttributes";

		// Token: 0x0400658A RID: 25994
		private static IntPtr _ClassPtr;

		// Token: 0x0400658B RID: 25995
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400658C RID: 25996
		internal static int __PropertyOffset_MaterialAttributes;

		// Token: 0x0400658D RID: 25997
		[Nullable(2)]
		private FMaterialAttributesInput _MaterialAttributes;

		// Token: 0x0400658E RID: 25998
		internal static int __PropertyOffset_AttributeGetTypes;

		// Token: 0x0400658F RID: 25999
		[Nullable(2)]
		private TArray<FGuid> _AttributeGetTypes;
	}
}
