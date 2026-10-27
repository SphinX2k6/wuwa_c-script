using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A74 RID: 10868
	[UnrealObjectPath("/Script/WwiseFileHandler.WwiseFileHandlerSettings")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UWwiseFileHandlerSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602812B RID: 164139 RVA: 0x003CFFE8 File Offset: 0x003CE1E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWwiseFileHandlerSettings._ClassPtr;
		}

		// Token: 0x0602812C RID: 164140 RVA: 0x003CFFF4 File Offset: 0x003CE1F4
		public UWwiseFileHandlerSettings() : this(BuiltinUtils.AllocNativeUObject(UWwiseFileHandlerSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602812D RID: 164141 RVA: 0x003D001C File Offset: 0x003CE21C
		[NullableContext(1)]
		public UWwiseFileHandlerSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWwiseFileHandlerSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009900 RID: 39168
		// (get) Token: 0x0602812E RID: 164142 RVA: 0x003D004F File Offset: 0x003CE24F
		// (set) Token: 0x0602812F RID: 164143 RVA: 0x003D005F File Offset: 0x003CE25F
		public unsafe bool bUseSharedOpQueue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_bUseSharedOpQueue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_bUseSharedOpQueue) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009901 RID: 39169
		// (get) Token: 0x06028130 RID: 164144 RVA: 0x003D0070 File Offset: 0x003CE270
		// (set) Token: 0x06028131 RID: 164145 RVA: 0x003D0080 File Offset: 0x003CE280
		public unsafe bool bIOInSharedOpQueue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_bIOInSharedOpQueue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_bIOInSharedOpQueue) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009902 RID: 39170
		// (get) Token: 0x06028132 RID: 164146 RVA: 0x003D0091 File Offset: 0x003CE291
		// (set) Token: 0x06028133 RID: 164147 RVA: 0x003D00A1 File Offset: 0x003CE2A1
		public unsafe EKuroWwiseTaskPriority FileCacheOpenQueuePriority
		{
			get
			{
				return (EKuroWwiseTaskPriority)(*(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_FileCacheOpenQueuePriority));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_FileCacheOpenQueuePriority) = (int)value;
			}
		}

		// Token: 0x17009903 RID: 39171
		// (get) Token: 0x06028134 RID: 164148 RVA: 0x003D00B2 File Offset: 0x003CE2B2
		// (set) Token: 0x06028135 RID: 164149 RVA: 0x003D00C2 File Offset: 0x003CE2C2
		public unsafe EKuroWwiseTaskPriority FileCacheDeleteQueuePriority
		{
			get
			{
				return (EKuroWwiseTaskPriority)(*(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_FileCacheDeleteQueuePriority));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_FileCacheDeleteQueuePriority) = (int)value;
			}
		}

		// Token: 0x17009904 RID: 39172
		// (get) Token: 0x06028136 RID: 164150 RVA: 0x003D00D3 File Offset: 0x003CE2D3
		// (set) Token: 0x06028137 RID: 164151 RVA: 0x003D00E3 File Offset: 0x003CE2E3
		public unsafe EKuroWwiseTaskPriority FileHandlerOpQueuePriority
		{
			get
			{
				return (EKuroWwiseTaskPriority)(*(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_FileHandlerOpQueuePriority));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_FileHandlerOpQueuePriority) = (int)value;
			}
		}

		// Token: 0x17009905 RID: 39173
		// (get) Token: 0x06028138 RID: 164152 RVA: 0x003D00F4 File Offset: 0x003CE2F4
		// (set) Token: 0x06028139 RID: 164153 RVA: 0x003D0104 File Offset: 0x003CE304
		public unsafe EKuroWwiseTaskPriority IOHookBatchOpQueuePriority
		{
			get
			{
				return (EKuroWwiseTaskPriority)(*(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_IOHookBatchOpQueuePriority));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_IOHookBatchOpQueuePriority) = (int)value;
			}
		}

		// Token: 0x17009906 RID: 39174
		// (get) Token: 0x0602813A RID: 164154 RVA: 0x003D0115 File Offset: 0x003CE315
		// (set) Token: 0x0602813B RID: 164155 RVA: 0x003D0125 File Offset: 0x003CE325
		public unsafe bool bUseMediaExtDecrement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_bUseMediaExtDecrement) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_bUseMediaExtDecrement) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009907 RID: 39175
		// (get) Token: 0x0602813C RID: 164156 RVA: 0x003D0136 File Offset: 0x003CE336
		// (set) Token: 0x0602813D RID: 164157 RVA: 0x003D0146 File Offset: 0x003CE346
		public unsafe bool bSoundBankDeleteCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_bSoundBankDeleteCheck) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_bSoundBankDeleteCheck) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009908 RID: 39176
		// (get) Token: 0x0602813E RID: 164158 RVA: 0x003D0157 File Offset: 0x003CE357
		// (set) Token: 0x0602813F RID: 164159 RVA: 0x003D0167 File Offset: 0x003CE367
		public unsafe bool bSoundBankCallbackCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_bSoundBankCallbackCheck) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWwiseFileHandlerSettings.__PropertyOffset_bSoundBankCallbackCheck) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028140 RID: 164160 RVA: 0x003D0178 File Offset: 0x003CE378
		static UWwiseFileHandlerSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/WwiseFileHandler.WwiseFileHandlerSettings");
		}

		// Token: 0x06028141 RID: 164161 RVA: 0x003D0186 File Offset: 0x003CE386
		protected UWwiseFileHandlerSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015FE6 RID: 90086
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/WwiseFileHandler.WwiseFileHandlerSettings";

		// Token: 0x04015FE7 RID: 90087
		private static IntPtr _ClassPtr;

		// Token: 0x04015FE8 RID: 90088
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015FE9 RID: 90089
		internal static int __PropertyOffset_bUseSharedOpQueue;

		// Token: 0x04015FEA RID: 90090
		internal static int __PropertyOffset_bIOInSharedOpQueue;

		// Token: 0x04015FEB RID: 90091
		internal static int __PropertyOffset_FileCacheOpenQueuePriority;

		// Token: 0x04015FEC RID: 90092
		internal static int __PropertyOffset_FileCacheDeleteQueuePriority;

		// Token: 0x04015FED RID: 90093
		internal static int __PropertyOffset_FileHandlerOpQueuePriority;

		// Token: 0x04015FEE RID: 90094
		internal static int __PropertyOffset_IOHookBatchOpQueuePriority;

		// Token: 0x04015FEF RID: 90095
		internal static int __PropertyOffset_bUseMediaExtDecrement;

		// Token: 0x04015FF0 RID: 90096
		internal static int __PropertyOffset_bSoundBankDeleteCheck;

		// Token: 0x04015FF1 RID: 90097
		internal static int __PropertyOffset_bSoundBankCallbackCheck;
	}
}
