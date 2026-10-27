using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008DF RID: 2271
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BookMark")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UBookMark : UBookmarkBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007CC0 RID: 31936 RVA: 0x000B2E12 File Offset: 0x000B1012
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBookMark._ClassPtr;
		}

		// Token: 0x06007CC1 RID: 31937 RVA: 0x000B2E20 File Offset: 0x000B1020
		public UBookMark() : this(BuiltinUtils.AllocNativeUObject(UBookMark.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007CC2 RID: 31938 RVA: 0x000B2E48 File Offset: 0x000B1048
		public UBookMark(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBookMark.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06007CC3 RID: 31939 RVA: 0x000B2E7B File Offset: 0x000B107B
		// (set) Token: 0x06007CC4 RID: 31940 RVA: 0x000B2E8F File Offset: 0x000B108F
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBookMark.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBookMark.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06007CC5 RID: 31941 RVA: 0x000B2EA4 File Offset: 0x000B10A4
		// (set) Token: 0x06007CC6 RID: 31942 RVA: 0x000B2EB8 File Offset: 0x000B10B8
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBookMark.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBookMark.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x06007CC7 RID: 31943 RVA: 0x000B2ED0 File Offset: 0x000B10D0
		// (set) Token: 0x06007CC8 RID: 31944 RVA: 0x000B2F09 File Offset: 0x000B1109
		public TArray<string> HiddenLevels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._HiddenLevels) == null)
				{
					result = (this._HiddenLevels = new TArray<string>(base.NativePtr + (IntPtr)UBookMark.__PropertyOffset_HiddenLevels, this));
				}
				return result;
			}
			set
			{
				this.HiddenLevels.CopyAssign(value);
			}
		}

		// Token: 0x06007CC9 RID: 31945 RVA: 0x000B2F17 File Offset: 0x000B1117
		static UBookMark()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BookMark");
		}

		// Token: 0x06007CCA RID: 31946 RVA: 0x000B2F25 File Offset: 0x000B1125
		protected UBookMark(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003BCA RID: 15306
		public new const string __ObjectPath = "/Script/Engine.BookMark";

		// Token: 0x04003BCB RID: 15307
		private static IntPtr _ClassPtr;

		// Token: 0x04003BCC RID: 15308
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003BCD RID: 15309
		internal static int __PropertyOffset_Location;

		// Token: 0x04003BCE RID: 15310
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04003BCF RID: 15311
		internal static int __PropertyOffset_HiddenLevels;

		// Token: 0x04003BD0 RID: 15312
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _HiddenLevels;
	}
}
