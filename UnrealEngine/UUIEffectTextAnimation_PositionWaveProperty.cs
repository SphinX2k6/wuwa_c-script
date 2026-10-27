using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002155 RID: 8533
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_PositionWaveProperty")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UUIEffectTextAnimation_PositionWaveProperty : UUIEffectTextAnimation_PropertyWithWave, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060202DE RID: 131806 RVA: 0x002FCF62 File Offset: 0x002FB162
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_PositionWaveProperty._ClassPtr;
		}

		// Token: 0x060202DF RID: 131807 RVA: 0x002FCF70 File Offset: 0x002FB170
		public UUIEffectTextAnimation_PositionWaveProperty() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_PositionWaveProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060202E0 RID: 131808 RVA: 0x002FCF98 File Offset: 0x002FB198
		[NullableContext(1)]
		public UUIEffectTextAnimation_PositionWaveProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_PositionWaveProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E43 RID: 32323
		// (get) Token: 0x060202E1 RID: 131809 RVA: 0x002FCFCB File Offset: 0x002FB1CB
		// (set) Token: 0x060202E2 RID: 131810 RVA: 0x002FCFDF File Offset: 0x002FB1DF
		public unsafe FVector position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PositionWaveProperty.__PropertyOffset_position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PositionWaveProperty.__PropertyOffset_position) = value;
			}
		}

		// Token: 0x060202E3 RID: 131811 RVA: 0x002FCFF4 File Offset: 0x002FB1F4
		public void SetPosition(FVector value)
		{
			UUIEffectTextAnimation_PositionWaveProperty.__SetPosition_Internal(base.NativePtr, value);
		}

		// Token: 0x060202E4 RID: 131812 RVA: 0x002FD002 File Offset: 0x002FB202
		public FVector GetPosition()
		{
			return UUIEffectTextAnimation_PositionWaveProperty.__GetPosition_Internal(base.NativePtr);
		}

		// Token: 0x060202E5 RID: 131813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPosition_Internal(IntPtr @this, FVector value);

		// Token: 0x060202E6 RID: 131814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPosition_Internal(IntPtr @this);

		// Token: 0x060202E7 RID: 131815 RVA: 0x002FD00F File Offset: 0x002FB20F
		static UUIEffectTextAnimation_PositionWaveProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_PositionWaveProperty");
		}

		// Token: 0x060202E8 RID: 131816 RVA: 0x002FD01D File Offset: 0x002FB21D
		protected UUIEffectTextAnimation_PositionWaveProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114D0 RID: 70864
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_PositionWaveProperty";

		// Token: 0x040114D1 RID: 70865
		private static IntPtr _ClassPtr;

		// Token: 0x040114D2 RID: 70866
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114D3 RID: 70867
		internal static int __PropertyOffset_position;
	}
}
