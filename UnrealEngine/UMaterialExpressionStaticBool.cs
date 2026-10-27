using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E55 RID: 3669
	[UnrealObjectPath("/Script/Engine.MaterialExpressionStaticBool")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UMaterialExpressionStaticBool : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C4C0 RID: 50368 RVA: 0x0011CA29 File Offset: 0x0011AC29
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionStaticBool._ClassPtr;
		}

		// Token: 0x0600C4C1 RID: 50369 RVA: 0x0011CA38 File Offset: 0x0011AC38
		public UMaterialExpressionStaticBool() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionStaticBool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C4C2 RID: 50370 RVA: 0x0011CA60 File Offset: 0x0011AC60
		[NullableContext(1)]
		public UMaterialExpressionStaticBool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionStaticBool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DAF RID: 11695
		// (get) Token: 0x0600C4C3 RID: 50371 RVA: 0x0011CA93 File Offset: 0x0011AC93
		// (set) Token: 0x0600C4C4 RID: 50372 RVA: 0x0011CAAC File Offset: 0x0011ACAC
		public unsafe bool Value
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionStaticBool.__PropertyOffset_Value) & UMaterialExpressionStaticBool.__PropertyMask_Value) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionStaticBool.__PropertyOffset_Value) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionStaticBool.__PropertyOffset_Value) & ~UMaterialExpressionStaticBool.__PropertyMask_Value) | (value ? UMaterialExpressionStaticBool.__PropertyMask_Value : 0));
			}
		}

		// Token: 0x0600C4C5 RID: 50373 RVA: 0x0011CADC File Offset: 0x0011ACDC
		static UMaterialExpressionStaticBool()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionStaticBool");
		}

		// Token: 0x0600C4C6 RID: 50374 RVA: 0x0011CAEA File Offset: 0x0011ACEA
		protected UMaterialExpressionStaticBool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400691E RID: 26910
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionStaticBool";

		// Token: 0x0400691F RID: 26911
		private static IntPtr _ClassPtr;

		// Token: 0x04006920 RID: 26912
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006921 RID: 26913
		internal static int __PropertyOffset_Value;

		// Token: 0x04006922 RID: 26914
		internal static byte __PropertyMask_Value;
	}
}
