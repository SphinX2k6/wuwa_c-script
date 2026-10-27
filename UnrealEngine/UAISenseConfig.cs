using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000FE RID: 254
	[UnrealObjectPath("/Script/AIModule.AISenseConfig")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UAISenseConfig : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001378 RID: 4984 RVA: 0x0001CBD2 File Offset: 0x0001ADD2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISenseConfig._ClassPtr;
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x0001CBDE File Offset: 0x0001ADDE
		// (set) Token: 0x0600137A RID: 4986 RVA: 0x0001CBF2 File Offset: 0x0001ADF2
		public unsafe FColor DebugColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig.__PropertyOffset_DebugColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig.__PropertyOffset_DebugColor) = value;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x0001CC07 File Offset: 0x0001AE07
		// (set) Token: 0x0600137C RID: 4988 RVA: 0x0001CC17 File Offset: 0x0001AE17
		public unsafe float MaxAge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig.__PropertyOffset_MaxAge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig.__PropertyOffset_MaxAge) = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x0001CC28 File Offset: 0x0001AE28
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x0001CC41 File Offset: 0x0001AE41
		public unsafe bool bStartsEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAISenseConfig.__PropertyOffset_bStartsEnabled) & UAISenseConfig.__PropertyMask_bStartsEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAISenseConfig.__PropertyOffset_bStartsEnabled) = ((*(base.NativePtr + (IntPtr)UAISenseConfig.__PropertyOffset_bStartsEnabled) & ~UAISenseConfig.__PropertyMask_bStartsEnabled) | (value ? UAISenseConfig.__PropertyMask_bStartsEnabled : 0));
			}
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0001CC71 File Offset: 0x0001AE71
		static UAISenseConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISenseConfig");
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0001CC80 File Offset: 0x0001AE80
		protected UAISenseConfig() : this(BuiltinUtils.AllocNativeUObject(UAISenseConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0001CCA8 File Offset: 0x0001AEA8
		protected UAISenseConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000393 RID: 915
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AISenseConfig";

		// Token: 0x04000394 RID: 916
		private static IntPtr _ClassPtr;

		// Token: 0x04000395 RID: 917
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000396 RID: 918
		internal static int __PropertyOffset_DebugColor;

		// Token: 0x04000397 RID: 919
		internal static int __PropertyOffset_MaxAge;

		// Token: 0x04000398 RID: 920
		internal static int __PropertyOffset_bStartsEnabled;

		// Token: 0x04000399 RID: 921
		internal static byte __PropertyMask_bStartsEnabled;
	}
}
