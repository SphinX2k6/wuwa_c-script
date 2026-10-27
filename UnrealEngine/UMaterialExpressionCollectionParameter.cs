using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D9E RID: 3486
	[UnrealObjectPath("/Script/Engine.MaterialExpressionCollectionParameter")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UMaterialExpressionCollectionParameter : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BDE3 RID: 48611 RVA: 0x0010FCF2 File Offset: 0x0010DEF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionCollectionParameter._ClassPtr;
		}

		// Token: 0x0600BDE4 RID: 48612 RVA: 0x0010FD00 File Offset: 0x0010DF00
		public UMaterialExpressionCollectionParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCollectionParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BDE5 RID: 48613 RVA: 0x0010FD28 File Offset: 0x0010DF28
		[NullableContext(1)]
		public UMaterialExpressionCollectionParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCollectionParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C08 RID: 11272
		// (get) Token: 0x0600BDE6 RID: 48614 RVA: 0x0010FD5B File Offset: 0x0010DF5B
		// (set) Token: 0x0600BDE7 RID: 48615 RVA: 0x0010FD6F File Offset: 0x0010DF6F
		[Nullable(2)]
		public unsafe UMaterialParameterCollection Collection
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionCollectionParameter.__PropertyOffset_Collection);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionCollectionParameter.__PropertyOffset_Collection, value);
			}
		}

		// Token: 0x17002C09 RID: 11273
		// (get) Token: 0x0600BDE8 RID: 48616 RVA: 0x0010FD84 File Offset: 0x0010DF84
		// (set) Token: 0x0600BDE9 RID: 48617 RVA: 0x0010FD98 File Offset: 0x0010DF98
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionCollectionParameter.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionCollectionParameter.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17002C0A RID: 11274
		// (get) Token: 0x0600BDEA RID: 48618 RVA: 0x0010FDAD File Offset: 0x0010DFAD
		// (set) Token: 0x0600BDEB RID: 48619 RVA: 0x0010FDC1 File Offset: 0x0010DFC1
		public unsafe FGuid ParameterId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionCollectionParameter.__PropertyOffset_ParameterId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionCollectionParameter.__PropertyOffset_ParameterId) = value;
			}
		}

		// Token: 0x0600BDEC RID: 48620 RVA: 0x0010FDD6 File Offset: 0x0010DFD6
		static UMaterialExpressionCollectionParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionCollectionParameter");
		}

		// Token: 0x0600BDED RID: 48621 RVA: 0x0010FDE4 File Offset: 0x0010DFE4
		protected UMaterialExpressionCollectionParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400644D RID: 25677
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionCollectionParameter";

		// Token: 0x0400644E RID: 25678
		private static IntPtr _ClassPtr;

		// Token: 0x0400644F RID: 25679
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006450 RID: 25680
		internal static int __PropertyOffset_Collection;

		// Token: 0x04006451 RID: 25681
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04006452 RID: 25682
		internal static int __PropertyOffset_ParameterId;
	}
}
