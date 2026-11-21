using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006FD RID: 1789
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_Selector")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UUIEffectTextAnimation_Selector : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009868 RID: 39016 RVA: 0x000E56FB File Offset: 0x000E38FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_Selector._ClassPtr;
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06009869 RID: 39017 RVA: 0x000E5707 File Offset: 0x000E3907
		// (set) Token: 0x0600986A RID: 39018 RVA: 0x000E5717 File Offset: 0x000E3917
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

		// Token: 0x0600986B RID: 39019 RVA: 0x000E5728 File Offset: 0x000E3928
		public void SetOffset(float value)
		{
			UUIEffectTextAnimation_Selector.__SetOffset_Internal(base.NativePtr, value);
		}

		// Token: 0x0600986C RID: 39020 RVA: 0x000E5736 File Offset: 0x000E3936
		public float GetOffset()
		{
			return UUIEffectTextAnimation_Selector.__GetOffset_Internal(base.NativePtr);
		}

		// Token: 0x0600986D RID: 39021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOffset_Internal(IntPtr @this, float value);

		// Token: 0x0600986E RID: 39022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetOffset_Internal(IntPtr @this);

		// Token: 0x0600986F RID: 39023 RVA: 0x000E5743 File Offset: 0x000E3943
		static UUIEffectTextAnimation_Selector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_Selector");
		}

		// Token: 0x06009870 RID: 39024 RVA: 0x000E5754 File Offset: 0x000E3954
		protected UUIEffectTextAnimation_Selector() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_Selector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009871 RID: 39025 RVA: 0x000E577C File Offset: 0x000E397C
		protected UUIEffectTextAnimation_Selector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400422F RID: 16943
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_Selector";

		// Token: 0x04004230 RID: 16944
		private static IntPtr _ClassPtr;

		// Token: 0x04004231 RID: 16945
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004232 RID: 16946
		internal static int __PropertyOffset_offset;
	}
}
