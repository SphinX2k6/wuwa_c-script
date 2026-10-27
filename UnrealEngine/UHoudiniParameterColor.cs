using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014EC RID: 5356
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterColor")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UHoudiniParameterColor : UHoudiniParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601367F RID: 79487 RVA: 0x001C8876 File Offset: 0x001C6A76
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterColor._ClassPtr;
		}

		// Token: 0x06013680 RID: 79488 RVA: 0x001C8884 File Offset: 0x001C6A84
		public UHoudiniParameterColor() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013681 RID: 79489 RVA: 0x001C88AC File Offset: 0x001C6AAC
		[NullableContext(1)]
		public UHoudiniParameterColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BBD RID: 19389
		// (get) Token: 0x06013682 RID: 79490 RVA: 0x001C88DF File Offset: 0x001C6ADF
		// (set) Token: 0x06013683 RID: 79491 RVA: 0x001C88F3 File Offset: 0x001C6AF3
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterColor.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterColor.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17004BBE RID: 19390
		// (get) Token: 0x06013684 RID: 79492 RVA: 0x001C8908 File Offset: 0x001C6B08
		// (set) Token: 0x06013685 RID: 79493 RVA: 0x001C891C File Offset: 0x001C6B1C
		public unsafe FLinearColor DefaultColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterColor.__PropertyOffset_DefaultColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterColor.__PropertyOffset_DefaultColor) = value;
			}
		}

		// Token: 0x17004BBF RID: 19391
		// (get) Token: 0x06013686 RID: 79494 RVA: 0x001C8931 File Offset: 0x001C6B31
		// (set) Token: 0x06013687 RID: 79495 RVA: 0x001C8941 File Offset: 0x001C6B41
		public unsafe bool bIsChildOfRamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterColor.__PropertyOffset_bIsChildOfRamp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterColor.__PropertyOffset_bIsChildOfRamp) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013688 RID: 79496 RVA: 0x001C8952 File Offset: 0x001C6B52
		static UHoudiniParameterColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterColor");
		}

		// Token: 0x06013689 RID: 79497 RVA: 0x001C8960 File Offset: 0x001C6B60
		protected UHoudiniParameterColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A7C5 RID: 42949
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterColor";

		// Token: 0x0400A7C6 RID: 42950
		private static IntPtr _ClassPtr;

		// Token: 0x0400A7C7 RID: 42951
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A7C8 RID: 42952
		internal static int __PropertyOffset_Color;

		// Token: 0x0400A7C9 RID: 42953
		internal static int __PropertyOffset_DefaultColor;

		// Token: 0x0400A7CA RID: 42954
		internal static int __PropertyOffset_bIsChildOfRamp;
	}
}
