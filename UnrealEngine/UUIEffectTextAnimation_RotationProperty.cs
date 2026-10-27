using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200215C RID: 8540
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_RotationProperty")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UUIEffectTextAnimation_RotationProperty : UUIEffectTextAnimation_PropertyWithEase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602035A RID: 131930 RVA: 0x002FD65B File Offset: 0x002FB85B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_RotationProperty._ClassPtr;
		}

		// Token: 0x0602035B RID: 131931 RVA: 0x002FD668 File Offset: 0x002FB868
		public UUIEffectTextAnimation_RotationProperty() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_RotationProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602035C RID: 131932 RVA: 0x002FD690 File Offset: 0x002FB890
		[NullableContext(1)]
		public UUIEffectTextAnimation_RotationProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_RotationProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E55 RID: 32341
		// (get) Token: 0x0602035D RID: 131933 RVA: 0x002FD6C3 File Offset: 0x002FB8C3
		// (set) Token: 0x0602035E RID: 131934 RVA: 0x002FD6D7 File Offset: 0x002FB8D7
		public unsafe FRotator rotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RotationProperty.__PropertyOffset_rotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RotationProperty.__PropertyOffset_rotator) = value;
			}
		}

		// Token: 0x0602035F RID: 131935 RVA: 0x002FD6EC File Offset: 0x002FB8EC
		public void SetRotator(FRotator value)
		{
			UUIEffectTextAnimation_RotationProperty.__SetRotator_Internal(base.NativePtr, value);
		}

		// Token: 0x06020360 RID: 131936 RVA: 0x002FD6FA File Offset: 0x002FB8FA
		public FRotator GetRotator()
		{
			return UUIEffectTextAnimation_RotationProperty.__GetRotator_Internal(base.NativePtr);
		}

		// Token: 0x06020361 RID: 131937
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRotator_Internal(IntPtr @this, FRotator value);

		// Token: 0x06020362 RID: 131938
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetRotator_Internal(IntPtr @this);

		// Token: 0x06020363 RID: 131939 RVA: 0x002FD707 File Offset: 0x002FB907
		static UUIEffectTextAnimation_RotationProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_RotationProperty");
		}

		// Token: 0x06020364 RID: 131940 RVA: 0x002FD715 File Offset: 0x002FB915
		protected UUIEffectTextAnimation_RotationProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114F7 RID: 70903
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_RotationProperty";

		// Token: 0x040114F8 RID: 70904
		private static IntPtr _ClassPtr;

		// Token: 0x040114F9 RID: 70905
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114FA RID: 70906
		internal static int __PropertyOffset_rotator;
	}
}
