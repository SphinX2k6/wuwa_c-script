using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007FD RID: 2045
	[UnrealObjectPath("/Script/Engine.AnimCompress_RemoveTrivialKeys")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UAnimCompress_RemoveTrivialKeys : UAnimCompress, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006D25 RID: 27941 RVA: 0x0009D1FB File Offset: 0x0009B3FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCompress_RemoveTrivialKeys._ClassPtr;
		}

		// Token: 0x06006D26 RID: 27942 RVA: 0x0009D208 File Offset: 0x0009B408
		public UAnimCompress_RemoveTrivialKeys() : this(BuiltinUtils.AllocNativeUObject(UAnimCompress_RemoveTrivialKeys.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006D27 RID: 27943 RVA: 0x0009D230 File Offset: 0x0009B430
		[NullableContext(1)]
		public UAnimCompress_RemoveTrivialKeys(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimCompress_RemoveTrivialKeys.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x06006D28 RID: 27944 RVA: 0x0009D263 File Offset: 0x0009B463
		// (set) Token: 0x06006D29 RID: 27945 RVA: 0x0009D273 File Offset: 0x0009B473
		public unsafe float MaxPosDiff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_RemoveTrivialKeys.__PropertyOffset_MaxPosDiff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_RemoveTrivialKeys.__PropertyOffset_MaxPosDiff) = value;
			}
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x06006D2A RID: 27946 RVA: 0x0009D284 File Offset: 0x0009B484
		// (set) Token: 0x06006D2B RID: 27947 RVA: 0x0009D294 File Offset: 0x0009B494
		public unsafe float MaxAngleDiff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_RemoveTrivialKeys.__PropertyOffset_MaxAngleDiff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_RemoveTrivialKeys.__PropertyOffset_MaxAngleDiff) = value;
			}
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x06006D2C RID: 27948 RVA: 0x0009D2A5 File Offset: 0x0009B4A5
		// (set) Token: 0x06006D2D RID: 27949 RVA: 0x0009D2B5 File Offset: 0x0009B4B5
		public unsafe float MaxScaleDiff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_RemoveTrivialKeys.__PropertyOffset_MaxScaleDiff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_RemoveTrivialKeys.__PropertyOffset_MaxScaleDiff) = value;
			}
		}

		// Token: 0x06006D2E RID: 27950 RVA: 0x0009D2C6 File Offset: 0x0009B4C6
		static UAnimCompress_RemoveTrivialKeys()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimCompress_RemoveTrivialKeys");
		}

		// Token: 0x06006D2F RID: 27951 RVA: 0x0009D2D4 File Offset: 0x0009B4D4
		protected UAnimCompress_RemoveTrivialKeys(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040034B8 RID: 13496
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimCompress_RemoveTrivialKeys";

		// Token: 0x040034B9 RID: 13497
		private static IntPtr _ClassPtr;

		// Token: 0x040034BA RID: 13498
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040034BB RID: 13499
		internal static int __PropertyOffset_MaxPosDiff;

		// Token: 0x040034BC RID: 13500
		internal static int __PropertyOffset_MaxAngleDiff;

		// Token: 0x040034BD RID: 13501
		internal static int __PropertyOffset_MaxScaleDiff;
	}
}
