using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200297E RID: 10622
	[UnrealObjectPath("/Script/UMG.KuroUMGSafeZone")]
	[UnrealStructLayout(712, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 712)]
	public class UKuroUMGSafeZone : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060274C2 RID: 160962 RVA: 0x003BEBCF File Offset: 0x003BCDCF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroUMGSafeZone._ClassPtr;
		}

		// Token: 0x060274C3 RID: 160963 RVA: 0x003BEBDC File Offset: 0x003BCDDC
		public UKuroUMGSafeZone() : this(BuiltinUtils.AllocNativeUObject(UKuroUMGSafeZone.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060274C4 RID: 160964 RVA: 0x003BEC04 File Offset: 0x003BCE04
		[NullableContext(1)]
		public UKuroUMGSafeZone(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroUMGSafeZone.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009711 RID: 38673
		// (get) Token: 0x060274C5 RID: 160965 RVA: 0x003BEC37 File Offset: 0x003BCE37
		// (set) Token: 0x060274C6 RID: 160966 RVA: 0x003BEC47 File Offset: 0x003BCE47
		public unsafe bool PadLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroUMGSafeZone.__PropertyOffset_PadLeft) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroUMGSafeZone.__PropertyOffset_PadLeft) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009712 RID: 38674
		// (get) Token: 0x060274C7 RID: 160967 RVA: 0x003BEC58 File Offset: 0x003BCE58
		// (set) Token: 0x060274C8 RID: 160968 RVA: 0x003BEC68 File Offset: 0x003BCE68
		public unsafe bool PadRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroUMGSafeZone.__PropertyOffset_PadRight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroUMGSafeZone.__PropertyOffset_PadRight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009713 RID: 38675
		// (get) Token: 0x060274C9 RID: 160969 RVA: 0x003BEC79 File Offset: 0x003BCE79
		// (set) Token: 0x060274CA RID: 160970 RVA: 0x003BEC89 File Offset: 0x003BCE89
		public unsafe bool PadTop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroUMGSafeZone.__PropertyOffset_PadTop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroUMGSafeZone.__PropertyOffset_PadTop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009714 RID: 38676
		// (get) Token: 0x060274CB RID: 160971 RVA: 0x003BEC9A File Offset: 0x003BCE9A
		// (set) Token: 0x060274CC RID: 160972 RVA: 0x003BECAA File Offset: 0x003BCEAA
		public unsafe bool PadBottom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroUMGSafeZone.__PropertyOffset_PadBottom) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroUMGSafeZone.__PropertyOffset_PadBottom) = (value ? 1 : 0);
			}
		}

		// Token: 0x060274CD RID: 160973 RVA: 0x003BECBB File Offset: 0x003BCEBB
		static UKuroUMGSafeZone()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.KuroUMGSafeZone");
		}

		// Token: 0x060274CE RID: 160974 RVA: 0x003BECC9 File Offset: 0x003BCEC9
		protected UKuroUMGSafeZone(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401595B RID: 88411
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.KuroUMGSafeZone";

		// Token: 0x0401595C RID: 88412
		private static IntPtr _ClassPtr;

		// Token: 0x0401595D RID: 88413
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401595E RID: 88414
		internal static int __PropertyOffset_PadLeft;

		// Token: 0x0401595F RID: 88415
		internal static int __PropertyOffset_PadRight;

		// Token: 0x04015960 RID: 88416
		internal static int __PropertyOffset_PadTop;

		// Token: 0x04015961 RID: 88417
		internal static int __PropertyOffset_PadBottom;
	}
}
