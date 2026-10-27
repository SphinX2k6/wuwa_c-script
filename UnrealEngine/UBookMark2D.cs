using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008E0 RID: 2272
	[UnrealObjectPath("/Script/Engine.BookMark2D")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UBookMark2D : UBookmarkBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007CCB RID: 31947 RVA: 0x000B2F2E File Offset: 0x000B112E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBookMark2D._ClassPtr;
		}

		// Token: 0x06007CCC RID: 31948 RVA: 0x000B2F3C File Offset: 0x000B113C
		public UBookMark2D() : this(BuiltinUtils.AllocNativeUObject(UBookMark2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007CCD RID: 31949 RVA: 0x000B2F64 File Offset: 0x000B1164
		[NullableContext(1)]
		public UBookMark2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBookMark2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x06007CCE RID: 31950 RVA: 0x000B2F97 File Offset: 0x000B1197
		// (set) Token: 0x06007CCF RID: 31951 RVA: 0x000B2FA7 File Offset: 0x000B11A7
		public unsafe float Zoom2D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBookMark2D.__PropertyOffset_Zoom2D);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBookMark2D.__PropertyOffset_Zoom2D) = value;
			}
		}

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x06007CD0 RID: 31952 RVA: 0x000B2FB8 File Offset: 0x000B11B8
		// (set) Token: 0x06007CD1 RID: 31953 RVA: 0x000B2FCC File Offset: 0x000B11CC
		public unsafe FIntPoint Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBookMark2D.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBookMark2D.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x06007CD2 RID: 31954 RVA: 0x000B2FE1 File Offset: 0x000B11E1
		static UBookMark2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BookMark2D");
		}

		// Token: 0x06007CD3 RID: 31955 RVA: 0x000B2FEF File Offset: 0x000B11EF
		protected UBookMark2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003BD1 RID: 15313
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BookMark2D";

		// Token: 0x04003BD2 RID: 15314
		private static IntPtr _ClassPtr;

		// Token: 0x04003BD3 RID: 15315
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003BD4 RID: 15316
		internal static int __PropertyOffset_Zoom2D;

		// Token: 0x04003BD5 RID: 15317
		internal static int __PropertyOffset_Location;
	}
}
