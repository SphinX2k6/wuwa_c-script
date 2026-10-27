using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007FB RID: 2043
	[UnrealObjectPath("/Script/Engine.AnimCompress_RemoveEverySecondKey")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAnimCompress_RemoveEverySecondKey : UAnimCompress, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006D05 RID: 27909 RVA: 0x0009CF1C File Offset: 0x0009B11C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCompress_RemoveEverySecondKey._ClassPtr;
		}

		// Token: 0x06006D06 RID: 27910 RVA: 0x0009CF28 File Offset: 0x0009B128
		public UAnimCompress_RemoveEverySecondKey() : this(BuiltinUtils.AllocNativeUObject(UAnimCompress_RemoveEverySecondKey.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006D07 RID: 27911 RVA: 0x0009CF50 File Offset: 0x0009B150
		[NullableContext(1)]
		public UAnimCompress_RemoveEverySecondKey(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimCompress_RemoveEverySecondKey.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x06006D08 RID: 27912 RVA: 0x0009CF83 File Offset: 0x0009B183
		// (set) Token: 0x06006D09 RID: 27913 RVA: 0x0009CF93 File Offset: 0x0009B193
		public unsafe int MinKeys
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_RemoveEverySecondKey.__PropertyOffset_MinKeys);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_RemoveEverySecondKey.__PropertyOffset_MinKeys) = value;
			}
		}

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06006D0A RID: 27914 RVA: 0x0009CFA4 File Offset: 0x0009B1A4
		// (set) Token: 0x06006D0B RID: 27915 RVA: 0x0009CFBD File Offset: 0x0009B1BD
		public unsafe bool bStartAtSecondKey
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimCompress_RemoveEverySecondKey.__PropertyOffset_bStartAtSecondKey) & UAnimCompress_RemoveEverySecondKey.__PropertyMask_bStartAtSecondKey) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimCompress_RemoveEverySecondKey.__PropertyOffset_bStartAtSecondKey) = ((*(base.NativePtr + (IntPtr)UAnimCompress_RemoveEverySecondKey.__PropertyOffset_bStartAtSecondKey) & ~UAnimCompress_RemoveEverySecondKey.__PropertyMask_bStartAtSecondKey) | (value ? UAnimCompress_RemoveEverySecondKey.__PropertyMask_bStartAtSecondKey : 0));
			}
		}

		// Token: 0x06006D0C RID: 27916 RVA: 0x0009CFED File Offset: 0x0009B1ED
		static UAnimCompress_RemoveEverySecondKey()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimCompress_RemoveEverySecondKey");
		}

		// Token: 0x06006D0D RID: 27917 RVA: 0x0009CFFB File Offset: 0x0009B1FB
		protected UAnimCompress_RemoveEverySecondKey(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040034A4 RID: 13476
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimCompress_RemoveEverySecondKey";

		// Token: 0x040034A5 RID: 13477
		private static IntPtr _ClassPtr;

		// Token: 0x040034A6 RID: 13478
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040034A7 RID: 13479
		internal static int __PropertyOffset_MinKeys;

		// Token: 0x040034A8 RID: 13480
		internal static int __PropertyOffset_bStartAtSecondKey;

		// Token: 0x040034A9 RID: 13481
		internal static byte __PropertyMask_bStartAtSecondKey;
	}
}
