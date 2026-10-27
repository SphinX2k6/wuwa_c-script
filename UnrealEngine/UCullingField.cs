using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012AB RID: 4779
	[UnrealObjectPath("/Script/FieldSystemEngine.CullingField")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UCullingField : UFieldNodeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011842 RID: 71746 RVA: 0x0019B3F1 File Offset: 0x001995F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCullingField._ClassPtr;
		}

		// Token: 0x06011843 RID: 71747 RVA: 0x0019B400 File Offset: 0x00199600
		public UCullingField() : this(BuiltinUtils.AllocNativeUObject(UCullingField.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011844 RID: 71748 RVA: 0x0019B428 File Offset: 0x00199628
		[NullableContext(1)]
		public UCullingField(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCullingField.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004466 RID: 17510
		// (get) Token: 0x06011845 RID: 71749 RVA: 0x0019B45B File Offset: 0x0019965B
		// (set) Token: 0x06011846 RID: 71750 RVA: 0x0019B46F File Offset: 0x0019966F
		[Nullable(2)]
		public unsafe UFieldNodeBase Culling
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFieldNodeBase>(base.NativePtr / (IntPtr)sizeof(void*) + UCullingField.__PropertyOffset_Culling);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCullingField.__PropertyOffset_Culling, value);
			}
		}

		// Token: 0x17004467 RID: 17511
		// (get) Token: 0x06011847 RID: 71751 RVA: 0x0019B484 File Offset: 0x00199684
		// (set) Token: 0x06011848 RID: 71752 RVA: 0x0019B498 File Offset: 0x00199698
		[Nullable(2)]
		public unsafe UFieldNodeBase Field
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFieldNodeBase>(base.NativePtr / (IntPtr)sizeof(void*) + UCullingField.__PropertyOffset_Field);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCullingField.__PropertyOffset_Field, value);
			}
		}

		// Token: 0x17004468 RID: 17512
		// (get) Token: 0x06011849 RID: 71753 RVA: 0x0019B4AD File Offset: 0x001996AD
		// (set) Token: 0x0601184A RID: 71754 RVA: 0x0019B4C1 File Offset: 0x001996C1
		public unsafe TEnumAsByte<EFieldCullingOperationType> Operation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCullingField.__PropertyOffset_Operation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCullingField.__PropertyOffset_Operation) = value;
			}
		}

		// Token: 0x0601184B RID: 71755 RVA: 0x0019B4D6 File Offset: 0x001996D6
		[NullableContext(2)]
		public UCullingField SetCullingField(UFieldNodeBase Culling, UFieldNodeBase Field, EFieldCullingOperationType Operation)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCullingField>(UCullingField.__SetCullingField_Internal(base.NativePtr, (Culling != null) ? Culling.NativePtr : IntPtr.Zero, (Field != null) ? Field.NativePtr : IntPtr.Zero, Operation));
		}

		// Token: 0x0601184C RID: 71756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetCullingField_Internal(IntPtr @this, IntPtr Culling, IntPtr Field, TEnumAsByte<EFieldCullingOperationType> Operation);

		// Token: 0x0601184D RID: 71757 RVA: 0x0019B50E File Offset: 0x0019970E
		static UCullingField()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.CullingField");
		}

		// Token: 0x0601184E RID: 71758 RVA: 0x0019B51C File Offset: 0x0019971C
		protected UCullingField(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400962C RID: 38444
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.CullingField";

		// Token: 0x0400962D RID: 38445
		private static IntPtr _ClassPtr;

		// Token: 0x0400962E RID: 38446
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400962F RID: 38447
		internal static int __PropertyOffset_Culling;

		// Token: 0x04009630 RID: 38448
		internal static int __PropertyOffset_Field;

		// Token: 0x04009631 RID: 38449
		internal static int __PropertyOffset_Operation;
	}
}
