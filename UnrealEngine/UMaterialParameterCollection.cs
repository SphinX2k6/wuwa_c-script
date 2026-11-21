using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200023E RID: 574
	[UnrealObjectPath("/Script/Engine.MaterialParameterCollection")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UMaterialParameterCollection : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600313A RID: 12602 RVA: 0x00046235 File Offset: 0x00044435
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialParameterCollection._ClassPtr;
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x00046244 File Offset: 0x00044444
		public UMaterialParameterCollection() : this(BuiltinUtils.AllocNativeUObject(UMaterialParameterCollection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x0004626C File Offset: 0x0004446C
		[NullableContext(1)]
		public UMaterialParameterCollection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialParameterCollection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600313D RID: 12605 RVA: 0x0004629F File Offset: 0x0004449F
		// (set) Token: 0x0600313E RID: 12606 RVA: 0x000462B3 File Offset: 0x000444B3
		public unsafe FGuid StateId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialParameterCollection.__PropertyOffset_StateId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialParameterCollection.__PropertyOffset_StateId) = value;
			}
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x000462C8 File Offset: 0x000444C8
		static UMaterialParameterCollection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialParameterCollection");
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x000462D6 File Offset: 0x000444D6
		protected UMaterialParameterCollection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040010DB RID: 4315
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialParameterCollection";

		// Token: 0x040010DC RID: 4316
		private static IntPtr _ClassPtr;

		// Token: 0x040010DD RID: 4317
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040010DE RID: 4318
		internal static int __PropertyOffset_StateId;
	}
}
