using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D95 RID: 3477
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionBreakMaterialAttributes")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionBreakMaterialAttributes : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD96 RID: 48534 RVA: 0x0010F445 File Offset: 0x0010D645
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionBreakMaterialAttributes._ClassPtr;
		}

		// Token: 0x0600BD97 RID: 48535 RVA: 0x0010F454 File Offset: 0x0010D654
		public UMaterialExpressionBreakMaterialAttributes() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionBreakMaterialAttributes.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD98 RID: 48536 RVA: 0x0010F47C File Offset: 0x0010D67C
		public UMaterialExpressionBreakMaterialAttributes(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionBreakMaterialAttributes.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x0600BD99 RID: 48537 RVA: 0x0010F4B0 File Offset: 0x0010D6B0
		// (set) Token: 0x0600BD9A RID: 48538 RVA: 0x0010F4E9 File Offset: 0x0010D6E9
		public FMaterialAttributesInput MaterialAttributes
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialAttributesInput result;
				if ((result = this._MaterialAttributes) == null)
				{
					result = (this._MaterialAttributes = new FMaterialAttributesInput(base.NativePtr + (IntPtr)UMaterialExpressionBreakMaterialAttributes.__PropertyOffset_MaterialAttributes, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialAttributesInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionBreakMaterialAttributes.__PropertyOffset_MaterialAttributes, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BD9B RID: 48539 RVA: 0x0010F50A File Offset: 0x0010D70A
		static UMaterialExpressionBreakMaterialAttributes()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionBreakMaterialAttributes");
		}

		// Token: 0x0600BD9C RID: 48540 RVA: 0x0010F518 File Offset: 0x0010D718
		protected UMaterialExpressionBreakMaterialAttributes(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006419 RID: 25625
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionBreakMaterialAttributes";

		// Token: 0x0400641A RID: 25626
		private static IntPtr _ClassPtr;

		// Token: 0x0400641B RID: 25627
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400641C RID: 25628
		internal static int __PropertyOffset_MaterialAttributes;

		// Token: 0x0400641D RID: 25629
		[Nullable(2)]
		private FMaterialAttributesInput _MaterialAttributes;
	}
}
