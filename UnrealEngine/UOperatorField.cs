using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012B7 RID: 4791
	[UnrealObjectPath("/Script/FieldSystemEngine.OperatorField")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UOperatorField : UFieldNodeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060118AE RID: 71854 RVA: 0x0019BD3A File Offset: 0x00199F3A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOperatorField._ClassPtr;
		}

		// Token: 0x060118AF RID: 71855 RVA: 0x0019BD48 File Offset: 0x00199F48
		public UOperatorField() : this(BuiltinUtils.AllocNativeUObject(UOperatorField.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060118B0 RID: 71856 RVA: 0x0019BD70 File Offset: 0x00199F70
		[NullableContext(1)]
		public UOperatorField(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOperatorField.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004471 RID: 17521
		// (get) Token: 0x060118B1 RID: 71857 RVA: 0x0019BDA3 File Offset: 0x00199FA3
		// (set) Token: 0x060118B2 RID: 71858 RVA: 0x0019BDB3 File Offset: 0x00199FB3
		public unsafe float Magnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOperatorField.__PropertyOffset_Magnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOperatorField.__PropertyOffset_Magnitude) = value;
			}
		}

		// Token: 0x17004472 RID: 17522
		// (get) Token: 0x060118B3 RID: 71859 RVA: 0x0019BDC4 File Offset: 0x00199FC4
		// (set) Token: 0x060118B4 RID: 71860 RVA: 0x0019BDD8 File Offset: 0x00199FD8
		[Nullable(2)]
		public unsafe UFieldNodeBase RightField
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFieldNodeBase>(base.NativePtr / (IntPtr)sizeof(void*) + UOperatorField.__PropertyOffset_RightField);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UOperatorField.__PropertyOffset_RightField, value);
			}
		}

		// Token: 0x17004473 RID: 17523
		// (get) Token: 0x060118B5 RID: 71861 RVA: 0x0019BDED File Offset: 0x00199FED
		// (set) Token: 0x060118B6 RID: 71862 RVA: 0x0019BE01 File Offset: 0x0019A001
		[Nullable(2)]
		public unsafe UFieldNodeBase LeftField
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFieldNodeBase>(base.NativePtr / (IntPtr)sizeof(void*) + UOperatorField.__PropertyOffset_LeftField);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UOperatorField.__PropertyOffset_LeftField, value);
			}
		}

		// Token: 0x17004474 RID: 17524
		// (get) Token: 0x060118B7 RID: 71863 RVA: 0x0019BE16 File Offset: 0x0019A016
		// (set) Token: 0x060118B8 RID: 71864 RVA: 0x0019BE2A File Offset: 0x0019A02A
		public unsafe TEnumAsByte<EFieldOperationType> Operation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOperatorField.__PropertyOffset_Operation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOperatorField.__PropertyOffset_Operation) = value;
			}
		}

		// Token: 0x060118B9 RID: 71865 RVA: 0x0019BE3F File Offset: 0x0019A03F
		[NullableContext(2)]
		public UOperatorField SetOperatorField(float Magnitude, UFieldNodeBase RightField, UFieldNodeBase LeftField, EFieldOperationType Operation)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UOperatorField>(UOperatorField.__SetOperatorField_Internal(base.NativePtr, Magnitude, (RightField != null) ? RightField.NativePtr : IntPtr.Zero, (LeftField != null) ? LeftField.NativePtr : IntPtr.Zero, Operation));
		}

		// Token: 0x060118BA RID: 71866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetOperatorField_Internal(IntPtr @this, float Magnitude, IntPtr RightField, IntPtr LeftField, TEnumAsByte<EFieldOperationType> Operation);

		// Token: 0x060118BB RID: 71867 RVA: 0x0019BE79 File Offset: 0x0019A079
		static UOperatorField()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.OperatorField");
		}

		// Token: 0x060118BC RID: 71868 RVA: 0x0019BE87 File Offset: 0x0019A087
		protected UOperatorField(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400965C RID: 38492
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.OperatorField";

		// Token: 0x0400965D RID: 38493
		private static IntPtr _ClassPtr;

		// Token: 0x0400965E RID: 38494
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400965F RID: 38495
		internal static int __PropertyOffset_Magnitude;

		// Token: 0x04009660 RID: 38496
		internal static int __PropertyOffset_RightField;

		// Token: 0x04009661 RID: 38497
		internal static int __PropertyOffset_LeftField;

		// Token: 0x04009662 RID: 38498
		internal static int __PropertyOffset_Operation;
	}
}
