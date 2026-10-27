using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002158 RID: 8536
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_PropertyWithWave")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public abstract class UUIEffectTextAnimation_PropertyWithWave : UUIEffectTextAnimation_Property, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060202FD RID: 131837 RVA: 0x002FD151 File Offset: 0x002FB351
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_PropertyWithWave._ClassPtr;
		}

		// Token: 0x17007E46 RID: 32326
		// (get) Token: 0x060202FE RID: 131838 RVA: 0x002FD15D File Offset: 0x002FB35D
		// (set) Token: 0x060202FF RID: 131839 RVA: 0x002FD16D File Offset: 0x002FB36D
		public unsafe float frequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PropertyWithWave.__PropertyOffset_frequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PropertyWithWave.__PropertyOffset_frequency) = value;
			}
		}

		// Token: 0x17007E47 RID: 32327
		// (get) Token: 0x06020300 RID: 131840 RVA: 0x002FD17E File Offset: 0x002FB37E
		// (set) Token: 0x06020301 RID: 131841 RVA: 0x002FD18E File Offset: 0x002FB38E
		public unsafe float speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PropertyWithWave.__PropertyOffset_speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PropertyWithWave.__PropertyOffset_speed) = value;
			}
		}

		// Token: 0x17007E48 RID: 32328
		// (get) Token: 0x06020302 RID: 131842 RVA: 0x002FD19F File Offset: 0x002FB39F
		// (set) Token: 0x06020303 RID: 131843 RVA: 0x002FD1AF File Offset: 0x002FB3AF
		public unsafe bool flipDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PropertyWithWave.__PropertyOffset_flipDirection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PropertyWithWave.__PropertyOffset_flipDirection) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007E49 RID: 32329
		// (get) Token: 0x06020304 RID: 131844 RVA: 0x002FD1C0 File Offset: 0x002FB3C0
		// (set) Token: 0x06020305 RID: 131845 RVA: 0x002FD1D4 File Offset: 0x002FB3D4
		[Nullable(2)]
		public unsafe UUIItem targetObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIItem>(base.NativePtr / (IntPtr)sizeof(void*) + UUIEffectTextAnimation_PropertyWithWave.__PropertyOffset_targetObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIEffectTextAnimation_PropertyWithWave.__PropertyOffset_targetObject, value);
			}
		}

		// Token: 0x06020306 RID: 131846 RVA: 0x002FD1E9 File Offset: 0x002FB3E9
		public void SetFrequency(float value)
		{
			UUIEffectTextAnimation_PropertyWithWave.__SetFrequency_Internal(base.NativePtr, value);
		}

		// Token: 0x06020307 RID: 131847 RVA: 0x002FD1F7 File Offset: 0x002FB3F7
		public float GetFrequency()
		{
			return UUIEffectTextAnimation_PropertyWithWave.__GetFrequency_Internal(base.NativePtr);
		}

		// Token: 0x06020308 RID: 131848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFrequency_Internal(IntPtr @this, float value);

		// Token: 0x06020309 RID: 131849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFrequency_Internal(IntPtr @this);

		// Token: 0x0602030A RID: 131850 RVA: 0x002FD204 File Offset: 0x002FB404
		static UUIEffectTextAnimation_PropertyWithWave()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_PropertyWithWave");
		}

		// Token: 0x0602030B RID: 131851 RVA: 0x002FD214 File Offset: 0x002FB414
		protected UUIEffectTextAnimation_PropertyWithWave() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_PropertyWithWave.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602030C RID: 131852 RVA: 0x002FD23C File Offset: 0x002FB43C
		protected UUIEffectTextAnimation_PropertyWithWave(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114DC RID: 70876
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_PropertyWithWave";

		// Token: 0x040114DD RID: 70877
		private static IntPtr _ClassPtr;

		// Token: 0x040114DE RID: 70878
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114DF RID: 70879
		internal static int __PropertyOffset_frequency;

		// Token: 0x040114E0 RID: 70880
		internal static int __PropertyOffset_speed;

		// Token: 0x040114E1 RID: 70881
		internal static int __PropertyOffset_flipDirection;

		// Token: 0x040114E2 RID: 70882
		internal static int __PropertyOffset_targetObject;
	}
}
