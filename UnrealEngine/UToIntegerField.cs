using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012BF RID: 4799
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/FieldSystemEngine.ToIntegerField")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UToIntegerField : UFieldNodeInt, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601191E RID: 71966 RVA: 0x0019C635 File Offset: 0x0019A835
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UToIntegerField._ClassPtr;
		}

		// Token: 0x0601191F RID: 71967 RVA: 0x0019C644 File Offset: 0x0019A844
		public UToIntegerField() : this(BuiltinUtils.AllocNativeUObject(UToIntegerField.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011920 RID: 71968 RVA: 0x0019C66C File Offset: 0x0019A86C
		[NullableContext(1)]
		public UToIntegerField(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UToIntegerField.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700448D RID: 17549
		// (get) Token: 0x06011921 RID: 71969 RVA: 0x0019C69F File Offset: 0x0019A89F
		// (set) Token: 0x06011922 RID: 71970 RVA: 0x0019C6B3 File Offset: 0x0019A8B3
		public unsafe UFieldNodeFloat FloatField
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFieldNodeFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UToIntegerField.__PropertyOffset_FloatField);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UToIntegerField.__PropertyOffset_FloatField, value);
			}
		}

		// Token: 0x06011923 RID: 71971 RVA: 0x0019C6C8 File Offset: 0x0019A8C8
		public UToIntegerField SetToIntegerField(UFieldNodeFloat FloatField)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UToIntegerField>(UToIntegerField.__SetToIntegerField_Internal(base.NativePtr, (FloatField != null) ? FloatField.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06011924 RID: 71972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetToIntegerField_Internal(IntPtr @this, IntPtr FloatField);

		// Token: 0x06011925 RID: 71973 RVA: 0x0019C6EA File Offset: 0x0019A8EA
		static UToIntegerField()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.ToIntegerField");
		}

		// Token: 0x06011926 RID: 71974 RVA: 0x0019C6F8 File Offset: 0x0019A8F8
		protected UToIntegerField(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009690 RID: 38544
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.ToIntegerField";

		// Token: 0x04009691 RID: 38545
		private static IntPtr _ClassPtr;

		// Token: 0x04009692 RID: 38546
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009693 RID: 38547
		internal static int __PropertyOffset_FloatField;
	}
}
