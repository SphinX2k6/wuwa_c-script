using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012BE RID: 4798
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/FieldSystemEngine.ToFloatField")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UToFloatField : UFieldNodeFloat, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011915 RID: 71957 RVA: 0x0019C56C File Offset: 0x0019A76C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UToFloatField._ClassPtr;
		}

		// Token: 0x06011916 RID: 71958 RVA: 0x0019C578 File Offset: 0x0019A778
		public UToFloatField() : this(BuiltinUtils.AllocNativeUObject(UToFloatField.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011917 RID: 71959 RVA: 0x0019C5A0 File Offset: 0x0019A7A0
		[NullableContext(1)]
		public UToFloatField(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UToFloatField.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700448C RID: 17548
		// (get) Token: 0x06011918 RID: 71960 RVA: 0x0019C5D3 File Offset: 0x0019A7D3
		// (set) Token: 0x06011919 RID: 71961 RVA: 0x0019C5E7 File Offset: 0x0019A7E7
		public unsafe UFieldNodeInt IntField
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFieldNodeInt>(base.NativePtr / (IntPtr)sizeof(void*) + UToFloatField.__PropertyOffset_IntField);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UToFloatField.__PropertyOffset_IntField, value);
			}
		}

		// Token: 0x0601191A RID: 71962 RVA: 0x0019C5FC File Offset: 0x0019A7FC
		public UToFloatField SetToFloatField(UFieldNodeInt IntegerField)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UToFloatField>(UToFloatField.__SetToFloatField_Internal(base.NativePtr, (IntegerField != null) ? IntegerField.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601191B RID: 71963
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetToFloatField_Internal(IntPtr @this, IntPtr IntegerField);

		// Token: 0x0601191C RID: 71964 RVA: 0x0019C61E File Offset: 0x0019A81E
		static UToFloatField()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.ToFloatField");
		}

		// Token: 0x0601191D RID: 71965 RVA: 0x0019C62C File Offset: 0x0019A82C
		protected UToFloatField(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400968C RID: 38540
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.ToFloatField";

		// Token: 0x0400968D RID: 38541
		private static IntPtr _ClassPtr;

		// Token: 0x0400968E RID: 38542
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400968F RID: 38543
		internal static int __PropertyOffset_IntField;
	}
}
