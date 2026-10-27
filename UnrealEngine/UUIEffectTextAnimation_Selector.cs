using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002162 RID: 8546
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_Selector")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UUIEffectTextAnimation_Selector : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060203B6 RID: 132022 RVA: 0x002FDC1A File Offset: 0x002FBE1A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_Selector._ClassPtr;
		}

		// Token: 0x17007E60 RID: 32352
		// (get) Token: 0x060203B7 RID: 132023 RVA: 0x002FDC26 File Offset: 0x002FBE26
		// (set) Token: 0x060203B8 RID: 132024 RVA: 0x002FDC36 File Offset: 0x002FBE36
		public unsafe float offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_Selector.__PropertyOffset_offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_Selector.__PropertyOffset_offset) = value;
			}
		}

		// Token: 0x060203B9 RID: 132025 RVA: 0x002FDC47 File Offset: 0x002FBE47
		public void SetOffset(float value)
		{
			UUIEffectTextAnimation_Selector.__SetOffset_Internal(base.NativePtr, value);
		}

		// Token: 0x060203BA RID: 132026 RVA: 0x002FDC55 File Offset: 0x002FBE55
		public float GetOffset()
		{
			return UUIEffectTextAnimation_Selector.__GetOffset_Internal(base.NativePtr);
		}

		// Token: 0x060203BB RID: 132027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOffset_Internal(IntPtr @this, float value);

		// Token: 0x060203BC RID: 132028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetOffset_Internal(IntPtr @this);

		// Token: 0x060203BD RID: 132029 RVA: 0x002FDC62 File Offset: 0x002FBE62
		static UUIEffectTextAnimation_Selector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_Selector");
		}

		// Token: 0x060203BE RID: 132030 RVA: 0x002FDC70 File Offset: 0x002FBE70
		protected UUIEffectTextAnimation_Selector() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_Selector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060203BF RID: 132031 RVA: 0x002FDC98 File Offset: 0x002FBE98
		protected UUIEffectTextAnimation_Selector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011514 RID: 70932
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_Selector";

		// Token: 0x04011515 RID: 70933
		private static IntPtr _ClassPtr;

		// Token: 0x04011516 RID: 70934
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011517 RID: 70935
		internal static int __PropertyOffset_offset;
	}
}
