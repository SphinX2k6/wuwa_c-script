using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DFD RID: 3581
	[UnrealObjectPath("/Script/Engine.MaterialExpressionNamedRerouteUsage")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UMaterialExpressionNamedRerouteUsage : UMaterialExpressionNamedRerouteBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C1A6 RID: 49574 RVA: 0x00116FFF File Offset: 0x001151FF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionNamedRerouteUsage._ClassPtr;
		}

		// Token: 0x0600C1A7 RID: 49575 RVA: 0x0011700C File Offset: 0x0011520C
		public UMaterialExpressionNamedRerouteUsage() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionNamedRerouteUsage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C1A8 RID: 49576 RVA: 0x00117034 File Offset: 0x00115234
		[NullableContext(1)]
		public UMaterialExpressionNamedRerouteUsage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionNamedRerouteUsage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CFD RID: 11517
		// (get) Token: 0x0600C1A9 RID: 49577 RVA: 0x00117067 File Offset: 0x00115267
		// (set) Token: 0x0600C1AA RID: 49578 RVA: 0x0011707B File Offset: 0x0011527B
		[Nullable(2)]
		public unsafe UMaterialExpressionNamedRerouteDeclaration Declaration
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialExpressionNamedRerouteDeclaration>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionNamedRerouteUsage.__PropertyOffset_Declaration);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionNamedRerouteUsage.__PropertyOffset_Declaration, value);
			}
		}

		// Token: 0x17002CFE RID: 11518
		// (get) Token: 0x0600C1AB RID: 49579 RVA: 0x00117090 File Offset: 0x00115290
		// (set) Token: 0x0600C1AC RID: 49580 RVA: 0x001170A4 File Offset: 0x001152A4
		public unsafe FGuid DeclarationGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionNamedRerouteUsage.__PropertyOffset_DeclarationGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionNamedRerouteUsage.__PropertyOffset_DeclarationGuid) = value;
			}
		}

		// Token: 0x0600C1AD RID: 49581 RVA: 0x001170B9 File Offset: 0x001152B9
		static UMaterialExpressionNamedRerouteUsage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionNamedRerouteUsage");
		}

		// Token: 0x0600C1AE RID: 49582 RVA: 0x001170C7 File Offset: 0x001152C7
		protected UMaterialExpressionNamedRerouteUsage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040066FE RID: 26366
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionNamedRerouteUsage";

		// Token: 0x040066FF RID: 26367
		private static IntPtr _ClassPtr;

		// Token: 0x04006700 RID: 26368
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006701 RID: 26369
		internal static int __PropertyOffset_Declaration;

		// Token: 0x04006702 RID: 26370
		internal static int __PropertyOffset_DeclarationGuid;
	}
}
