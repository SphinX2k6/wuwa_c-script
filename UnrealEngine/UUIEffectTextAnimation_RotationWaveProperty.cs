using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200215E RID: 8542
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_RotationWaveProperty")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UUIEffectTextAnimation_RotationWaveProperty : UUIEffectTextAnimation_PropertyWithWave, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602037C RID: 131964 RVA: 0x002FD862 File Offset: 0x002FBA62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_RotationWaveProperty._ClassPtr;
		}

		// Token: 0x0602037D RID: 131965 RVA: 0x002FD870 File Offset: 0x002FBA70
		public UUIEffectTextAnimation_RotationWaveProperty() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_RotationWaveProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602037E RID: 131966 RVA: 0x002FD898 File Offset: 0x002FBA98
		[NullableContext(1)]
		public UUIEffectTextAnimation_RotationWaveProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_RotationWaveProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E59 RID: 32345
		// (get) Token: 0x0602037F RID: 131967 RVA: 0x002FD8CB File Offset: 0x002FBACB
		// (set) Token: 0x06020380 RID: 131968 RVA: 0x002FD8DF File Offset: 0x002FBADF
		public unsafe FRotator rotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RotationWaveProperty.__PropertyOffset_rotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RotationWaveProperty.__PropertyOffset_rotator) = value;
			}
		}

		// Token: 0x06020381 RID: 131969 RVA: 0x002FD8F4 File Offset: 0x002FBAF4
		public void SetRotator(FRotator value)
		{
			UUIEffectTextAnimation_RotationWaveProperty.__SetRotator_Internal(base.NativePtr, value);
		}

		// Token: 0x06020382 RID: 131970 RVA: 0x002FD902 File Offset: 0x002FBB02
		public FRotator GetRotator()
		{
			return UUIEffectTextAnimation_RotationWaveProperty.__GetRotator_Internal(base.NativePtr);
		}

		// Token: 0x06020383 RID: 131971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRotator_Internal(IntPtr @this, FRotator value);

		// Token: 0x06020384 RID: 131972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetRotator_Internal(IntPtr @this);

		// Token: 0x06020385 RID: 131973 RVA: 0x002FD90F File Offset: 0x002FBB0F
		static UUIEffectTextAnimation_RotationWaveProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_RotationWaveProperty");
		}

		// Token: 0x06020386 RID: 131974 RVA: 0x002FD91D File Offset: 0x002FBB1D
		protected UUIEffectTextAnimation_RotationWaveProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011501 RID: 70913
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_RotationWaveProperty";

		// Token: 0x04011502 RID: 70914
		private static IntPtr _ClassPtr;

		// Token: 0x04011503 RID: 70915
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011504 RID: 70916
		internal static int __PropertyOffset_rotator;
	}
}
