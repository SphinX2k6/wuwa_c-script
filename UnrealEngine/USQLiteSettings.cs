using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028B8 RID: 10424
	[UnrealObjectPath("/Script/SQLiteCore.SQLiteSettings")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class USQLiteSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026B6F RID: 158575 RVA: 0x003B0F9C File Offset: 0x003AF19C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USQLiteSettings._ClassPtr;
		}

		// Token: 0x06026B70 RID: 158576 RVA: 0x003B0FA8 File Offset: 0x003AF1A8
		public USQLiteSettings() : this(BuiltinUtils.AllocNativeUObject(USQLiteSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026B71 RID: 158577 RVA: 0x003B0FD0 File Offset: 0x003AF1D0
		[NullableContext(1)]
		public USQLiteSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USQLiteSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009528 RID: 38184
		// (get) Token: 0x06026B72 RID: 158578 RVA: 0x003B1003 File Offset: 0x003AF203
		// (set) Token: 0x06026B73 RID: 158579 RVA: 0x003B1013 File Offset: 0x003AF213
		public unsafe int LookAsideSizeEach
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USQLiteSettings.__PropertyOffset_LookAsideSizeEach);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USQLiteSettings.__PropertyOffset_LookAsideSizeEach) = value;
			}
		}

		// Token: 0x17009529 RID: 38185
		// (get) Token: 0x06026B74 RID: 158580 RVA: 0x003B1024 File Offset: 0x003AF224
		// (set) Token: 0x06026B75 RID: 158581 RVA: 0x003B1034 File Offset: 0x003AF234
		public unsafe int LookAsideNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USQLiteSettings.__PropertyOffset_LookAsideNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USQLiteSettings.__PropertyOffset_LookAsideNumber) = value;
			}
		}

		// Token: 0x1700952A RID: 38186
		// (get) Token: 0x06026B76 RID: 158582 RVA: 0x003B1045 File Offset: 0x003AF245
		// (set) Token: 0x06026B77 RID: 158583 RVA: 0x003B1055 File Offset: 0x003AF255
		public unsafe int PageCacheSizeEach
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USQLiteSettings.__PropertyOffset_PageCacheSizeEach);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USQLiteSettings.__PropertyOffset_PageCacheSizeEach) = value;
			}
		}

		// Token: 0x1700952B RID: 38187
		// (get) Token: 0x06026B78 RID: 158584 RVA: 0x003B1066 File Offset: 0x003AF266
		// (set) Token: 0x06026B79 RID: 158585 RVA: 0x003B1076 File Offset: 0x003AF276
		public unsafe int PageCacheNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USQLiteSettings.__PropertyOffset_PageCacheNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USQLiteSettings.__PropertyOffset_PageCacheNumber) = value;
			}
		}

		// Token: 0x1700952C RID: 38188
		// (get) Token: 0x06026B7A RID: 158586 RVA: 0x003B1087 File Offset: 0x003AF287
		// (set) Token: 0x06026B7B RID: 158587 RVA: 0x003B1097 File Offset: 0x003AF297
		public unsafe bool EnableTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USQLiteSettings.__PropertyOffset_EnableTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USQLiteSettings.__PropertyOffset_EnableTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700952D RID: 38189
		// (get) Token: 0x06026B7C RID: 158588 RVA: 0x003B10A8 File Offset: 0x003AF2A8
		// (set) Token: 0x06026B7D RID: 158589 RVA: 0x003B10B8 File Offset: 0x003AF2B8
		public unsafe bool EnableDBFilePakInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USQLiteSettings.__PropertyOffset_EnableDBFilePakInfo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USQLiteSettings.__PropertyOffset_EnableDBFilePakInfo) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700952E RID: 38190
		// (get) Token: 0x06026B7E RID: 158590 RVA: 0x003B10C9 File Offset: 0x003AF2C9
		// (set) Token: 0x06026B7F RID: 158591 RVA: 0x003B10D9 File Offset: 0x003AF2D9
		public unsafe bool UseReadCache
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USQLiteSettings.__PropertyOffset_UseReadCache) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USQLiteSettings.__PropertyOffset_UseReadCache) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026B80 RID: 158592 RVA: 0x003B10EA File Offset: 0x003AF2EA
		static USQLiteSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SQLiteCore.SQLiteSettings");
		}

		// Token: 0x06026B81 RID: 158593 RVA: 0x003B10F8 File Offset: 0x003AF2F8
		protected USQLiteSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040153E8 RID: 87016
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SQLiteCore.SQLiteSettings";

		// Token: 0x040153E9 RID: 87017
		private static IntPtr _ClassPtr;

		// Token: 0x040153EA RID: 87018
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040153EB RID: 87019
		internal static int __PropertyOffset_LookAsideSizeEach;

		// Token: 0x040153EC RID: 87020
		internal static int __PropertyOffset_LookAsideNumber;

		// Token: 0x040153ED RID: 87021
		internal static int __PropertyOffset_PageCacheSizeEach;

		// Token: 0x040153EE RID: 87022
		internal static int __PropertyOffset_PageCacheNumber;

		// Token: 0x040153EF RID: 87023
		internal static int __PropertyOffset_EnableTrace;

		// Token: 0x040153F0 RID: 87024
		internal static int __PropertyOffset_EnableDBFilePakInfo;

		// Token: 0x040153F1 RID: 87025
		internal static int __PropertyOffset_UseReadCache;
	}
}
