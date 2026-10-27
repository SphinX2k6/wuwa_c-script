using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200172C RID: 5932
	[UnrealObjectPath("/Script/KuroBullet.KSC_Buff_KuroBullet")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Buff_KuroBullet : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060155B4 RID: 87476 RVA: 0x001F6195 File Offset: 0x001F4395
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_KuroBullet._ClassPtr;
		}

		// Token: 0x060155B5 RID: 87477 RVA: 0x001F61A4 File Offset: 0x001F43A4
		public UKSC_Buff_KuroBullet() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_KuroBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060155B6 RID: 87478 RVA: 0x001F61CC File Offset: 0x001F43CC
		[NullableContext(1)]
		public UKSC_Buff_KuroBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_KuroBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700545A RID: 21594
		// (get) Token: 0x060155B7 RID: 87479 RVA: 0x001F61FF File Offset: 0x001F43FF
		// (set) Token: 0x060155B8 RID: 87480 RVA: 0x001F6213 File Offset: 0x001F4413
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_KuroBullet DaBuffKuroBullet_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_KuroBullet>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_KuroBullet.__PropertyOffset_DaBuffKuroBullet_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_KuroBullet.__PropertyOffset_DaBuffKuroBullet_, value);
			}
		}

		// Token: 0x060155B9 RID: 87481 RVA: 0x001F6228 File Offset: 0x001F4428
		static UKSC_Buff_KuroBullet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.KSC_Buff_KuroBullet");
		}

		// Token: 0x060155BA RID: 87482 RVA: 0x001F6236 File Offset: 0x001F4436
		protected UKSC_Buff_KuroBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BA55 RID: 47701
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.KSC_Buff_KuroBullet";

		// Token: 0x0400BA56 RID: 47702
		private static IntPtr _ClassPtr;

		// Token: 0x0400BA57 RID: 47703
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BA58 RID: 47704
		internal static int __PropertyOffset_DaBuffKuroBullet_;
	}
}
