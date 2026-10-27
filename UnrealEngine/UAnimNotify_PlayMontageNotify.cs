using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000307 RID: 775
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNotify_PlayMontageNotify")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UAnimNotify_PlayMontageNotify : UAnimNotify, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002CE5 RID: 11493 RVA: 0x00044F38 File Offset: 0x00043138
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotify_PlayMontageNotify._ClassPtr;
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x00044F44 File Offset: 0x00043144
		public UAnimNotify_PlayMontageNotify() : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_PlayMontageNotify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x00044F6C File Offset: 0x0004316C
		[NullableContext(1)]
		public UAnimNotify_PlayMontageNotify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_PlayMontageNotify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x00044F9F File Offset: 0x0004319F
		// (set) Token: 0x06002CE9 RID: 11497 RVA: 0x00044FB3 File Offset: 0x000431B3
		public unsafe FName NotifyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotify_PlayMontageNotify.__PropertyOffset_NotifyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotify_PlayMontageNotify.__PropertyOffset_NotifyName) = value;
			}
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x00044FC8 File Offset: 0x000431C8
		static UAnimNotify_PlayMontageNotify()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AnimGraphRuntime.AnimNotify_PlayMontageNotify");
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x00044FD6 File Offset: 0x000431D6
		protected UAnimNotify_PlayMontageNotify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001288 RID: 4744
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNotify_PlayMontageNotify";

		// Token: 0x04001289 RID: 4745
		private static IntPtr _ClassPtr;

		// Token: 0x0400128A RID: 4746
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400128B RID: 4747
		internal static int __PropertyOffset_NotifyName;
	}
}
