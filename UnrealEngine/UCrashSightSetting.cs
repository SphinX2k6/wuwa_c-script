using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000774 RID: 1908
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CrashSight.CrashSightSetting")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UCrashSightSetting : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060063FE RID: 25598 RVA: 0x0008FBD3 File Offset: 0x0008DDD3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCrashSightSetting._ClassPtr;
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x0008FBE0 File Offset: 0x0008DDE0
		public UCrashSightSetting() : this(BuiltinUtils.AllocNativeUObject(UCrashSightSetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x0008FC08 File Offset: 0x0008DE08
		public UCrashSightSetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCrashSightSetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06006401 RID: 25601 RVA: 0x0008FC3B File Offset: 0x0008DE3B
		// (set) Token: 0x06006402 RID: 25602 RVA: 0x0008FC4B File Offset: 0x0008DE4B
		public unsafe bool bNeedUploadLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCrashSightSetting.__PropertyOffset_bNeedUploadLog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCrashSightSetting.__PropertyOffset_bNeedUploadLog) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06006403 RID: 25603 RVA: 0x0008FC5C File Offset: 0x0008DE5C
		// (set) Token: 0x06006404 RID: 25604 RVA: 0x0008FC6C File Offset: 0x0008DE6C
		public unsafe bool bInternational
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCrashSightSetting.__PropertyOffset_bInternational) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCrashSightSetting.__PropertyOffset_bInternational) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06006405 RID: 25605 RVA: 0x0008FC7D File Offset: 0x0008DE7D
		// (set) Token: 0x06006406 RID: 25606 RVA: 0x0008FC8D File Offset: 0x0008DE8D
		public unsafe bool bIOSInitCrashHandler
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCrashSightSetting.__PropertyOffset_bIOSInitCrashHandler) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCrashSightSetting.__PropertyOffset_bIOSInitCrashHandler) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x06006407 RID: 25607 RVA: 0x0008FC9E File Offset: 0x0008DE9E
		// (set) Token: 0x06006408 RID: 25608 RVA: 0x0008FCB2 File Offset: 0x0008DEB2
		public unsafe string AndroidAppID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UCrashSightSetting.__PropertyOffset_AndroidAppID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UCrashSightSetting.__PropertyOffset_AndroidAppID)), value);
			}
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x06006409 RID: 25609 RVA: 0x0008FCC7 File Offset: 0x0008DEC7
		// (set) Token: 0x0600640A RID: 25610 RVA: 0x0008FCDB File Offset: 0x0008DEDB
		public unsafe string AndroidUploadURL
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UCrashSightSetting.__PropertyOffset_AndroidUploadURL)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UCrashSightSetting.__PropertyOffset_AndroidUploadURL)), value);
			}
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x0600640B RID: 25611 RVA: 0x0008FCF0 File Offset: 0x0008DEF0
		// (set) Token: 0x0600640C RID: 25612 RVA: 0x0008FD04 File Offset: 0x0008DF04
		public unsafe string IOSAppID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UCrashSightSetting.__PropertyOffset_IOSAppID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UCrashSightSetting.__PropertyOffset_IOSAppID)), value);
			}
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x0600640D RID: 25613 RVA: 0x0008FD19 File Offset: 0x0008DF19
		// (set) Token: 0x0600640E RID: 25614 RVA: 0x0008FD2D File Offset: 0x0008DF2D
		public unsafe string IOSUploadURL
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UCrashSightSetting.__PropertyOffset_IOSUploadURL)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UCrashSightSetting.__PropertyOffset_IOSUploadURL)), value);
			}
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x0600640F RID: 25615 RVA: 0x0008FD42 File Offset: 0x0008DF42
		// (set) Token: 0x06006410 RID: 25616 RVA: 0x0008FD56 File Offset: 0x0008DF56
		public unsafe string OpenHarmonyAppID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UCrashSightSetting.__PropertyOffset_OpenHarmonyAppID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UCrashSightSetting.__PropertyOffset_OpenHarmonyAppID)), value);
			}
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06006411 RID: 25617 RVA: 0x0008FD6B File Offset: 0x0008DF6B
		// (set) Token: 0x06006412 RID: 25618 RVA: 0x0008FD7F File Offset: 0x0008DF7F
		public unsafe string OpenHarmonyUploadURL
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UCrashSightSetting.__PropertyOffset_OpenHarmonyUploadURL)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UCrashSightSetting.__PropertyOffset_OpenHarmonyUploadURL)), value);
			}
		}

		// Token: 0x06006413 RID: 25619 RVA: 0x0008FD94 File Offset: 0x0008DF94
		static UCrashSightSetting()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CrashSight.CrashSightSetting");
		}

		// Token: 0x06006414 RID: 25620 RVA: 0x0008FDA2 File Offset: 0x0008DFA2
		protected UCrashSightSetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FF8 RID: 12280
		public new const string __ObjectPath = "/Script/CrashSight.CrashSightSetting";

		// Token: 0x04002FF9 RID: 12281
		private static IntPtr _ClassPtr;

		// Token: 0x04002FFA RID: 12282
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002FFB RID: 12283
		internal static int __PropertyOffset_bNeedUploadLog;

		// Token: 0x04002FFC RID: 12284
		internal static int __PropertyOffset_bInternational;

		// Token: 0x04002FFD RID: 12285
		internal static int __PropertyOffset_bIOSInitCrashHandler;

		// Token: 0x04002FFE RID: 12286
		internal static int __PropertyOffset_AndroidAppID;

		// Token: 0x04002FFF RID: 12287
		internal static int __PropertyOffset_AndroidUploadURL;

		// Token: 0x04003000 RID: 12288
		internal static int __PropertyOffset_IOSAppID;

		// Token: 0x04003001 RID: 12289
		internal static int __PropertyOffset_IOSUploadURL;

		// Token: 0x04003002 RID: 12290
		internal static int __PropertyOffset_OpenHarmonyAppID;

		// Token: 0x04003003 RID: 12291
		internal static int __PropertyOffset_OpenHarmonyUploadURL;
	}
}
