using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002153 RID: 8531
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_PositionProperty")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UUIEffectTextAnimation_PositionProperty : UUIEffectTextAnimation_PropertyWithEase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060202B8 RID: 131768 RVA: 0x002FCD12 File Offset: 0x002FAF12
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_PositionProperty._ClassPtr;
		}

		// Token: 0x060202B9 RID: 131769 RVA: 0x002FCD20 File Offset: 0x002FAF20
		public UUIEffectTextAnimation_PositionProperty() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_PositionProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060202BA RID: 131770 RVA: 0x002FCD48 File Offset: 0x002FAF48
		[NullableContext(1)]
		public UUIEffectTextAnimation_PositionProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_PositionProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E3D RID: 32317
		// (get) Token: 0x060202BB RID: 131771 RVA: 0x002FCD7B File Offset: 0x002FAF7B
		// (set) Token: 0x060202BC RID: 131772 RVA: 0x002FCD8F File Offset: 0x002FAF8F
		public unsafe FVector position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PositionProperty.__PropertyOffset_position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PositionProperty.__PropertyOffset_position) = value;
			}
		}

		// Token: 0x17007E3E RID: 32318
		// (get) Token: 0x060202BD RID: 131773 RVA: 0x002FCDA4 File Offset: 0x002FAFA4
		// (set) Token: 0x060202BE RID: 131774 RVA: 0x002FCDB8 File Offset: 0x002FAFB8
		public unsafe FVector initialPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PositionProperty.__PropertyOffset_initialPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PositionProperty.__PropertyOffset_initialPosition) = value;
			}
		}

		// Token: 0x17007E3F RID: 32319
		// (get) Token: 0x060202BF RID: 131775 RVA: 0x002FCDCD File Offset: 0x002FAFCD
		// (set) Token: 0x060202C0 RID: 131776 RVA: 0x002FCDDD File Offset: 0x002FAFDD
		public unsafe bool bUseInitialPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PositionProperty.__PropertyOffset_bUseInitialPosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PositionProperty.__PropertyOffset_bUseInitialPosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x060202C1 RID: 131777 RVA: 0x002FCDEE File Offset: 0x002FAFEE
		public void SetPosition(FVector value)
		{
			UUIEffectTextAnimation_PositionProperty.__SetPosition_Internal(base.NativePtr, value);
		}

		// Token: 0x060202C2 RID: 131778 RVA: 0x002FCDFC File Offset: 0x002FAFFC
		public FVector GetPosition()
		{
			return UUIEffectTextAnimation_PositionProperty.__GetPosition_Internal(base.NativePtr);
		}

		// Token: 0x060202C3 RID: 131779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPosition_Internal(IntPtr @this, FVector value);

		// Token: 0x060202C4 RID: 131780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPosition_Internal(IntPtr @this);

		// Token: 0x060202C5 RID: 131781 RVA: 0x002FCE09 File Offset: 0x002FB009
		static UUIEffectTextAnimation_PositionProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_PositionProperty");
		}

		// Token: 0x060202C6 RID: 131782 RVA: 0x002FCE17 File Offset: 0x002FB017
		protected UUIEffectTextAnimation_PositionProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114C4 RID: 70852
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_PositionProperty";

		// Token: 0x040114C5 RID: 70853
		private static IntPtr _ClassPtr;

		// Token: 0x040114C6 RID: 70854
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114C7 RID: 70855
		internal static int __PropertyOffset_position;

		// Token: 0x040114C8 RID: 70856
		internal static int __PropertyOffset_initialPosition;

		// Token: 0x040114C9 RID: 70857
		internal static int __PropertyOffset_bUseInitialPosition;
	}
}
