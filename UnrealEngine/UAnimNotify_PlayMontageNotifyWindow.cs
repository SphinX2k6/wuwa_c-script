using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000308 RID: 776
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNotify_PlayMontageNotifyWindow")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UAnimNotify_PlayMontageNotifyWindow : UAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002CEC RID: 11500 RVA: 0x00044FDF File Offset: 0x000431DF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotify_PlayMontageNotifyWindow._ClassPtr;
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x00044FEC File Offset: 0x000431EC
		public UAnimNotify_PlayMontageNotifyWindow() : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_PlayMontageNotifyWindow.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x00045014 File Offset: 0x00043214
		[NullableContext(1)]
		public UAnimNotify_PlayMontageNotifyWindow(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_PlayMontageNotifyWindow.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x00045047 File Offset: 0x00043247
		// (set) Token: 0x06002CF0 RID: 11504 RVA: 0x0004505B File Offset: 0x0004325B
		public unsafe FName NotifyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotify_PlayMontageNotifyWindow.__PropertyOffset_NotifyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotify_PlayMontageNotifyWindow.__PropertyOffset_NotifyName) = value;
			}
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x00045070 File Offset: 0x00043270
		static UAnimNotify_PlayMontageNotifyWindow()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AnimGraphRuntime.AnimNotify_PlayMontageNotifyWindow");
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x0004507E File Offset: 0x0004327E
		protected UAnimNotify_PlayMontageNotifyWindow(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400128C RID: 4748
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNotify_PlayMontageNotifyWindow";

		// Token: 0x0400128D RID: 4749
		private static IntPtr _ClassPtr;

		// Token: 0x0400128E RID: 4750
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400128F RID: 4751
		internal static int __PropertyOffset_NotifyName;
	}
}
