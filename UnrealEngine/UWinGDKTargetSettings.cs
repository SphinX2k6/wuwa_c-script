using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A6D RID: 10861
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WinGDKPlatformEditor.WinGDKTargetSettings")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UWinGDKTargetSettings : UGDKTargetSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028101 RID: 164097 RVA: 0x003CFCA6 File Offset: 0x003CDEA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWinGDKTargetSettings._ClassPtr;
		}

		// Token: 0x06028102 RID: 164098 RVA: 0x003CFCB4 File Offset: 0x003CDEB4
		public UWinGDKTargetSettings() : this(BuiltinUtils.AllocNativeUObject(UWinGDKTargetSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028103 RID: 164099 RVA: 0x003CFCDC File Offset: 0x003CDEDC
		public UWinGDKTargetSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWinGDKTargetSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170098FA RID: 39162
		// (get) Token: 0x06028104 RID: 164100 RVA: 0x003CFD0F File Offset: 0x003CDF0F
		// (set) Token: 0x06028105 RID: 164101 RVA: 0x003CFD1F File Offset: 0x003CDF1F
		public unsafe bool bMSAFullTrust
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWinGDKTargetSettings.__PropertyOffset_bMSAFullTrust) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWinGDKTargetSettings.__PropertyOffset_bMSAFullTrust) = (value ? 1 : 0);
			}
		}

		// Token: 0x170098FB RID: 39163
		// (get) Token: 0x06028106 RID: 164102 RVA: 0x003CFD30 File Offset: 0x003CDF30
		// (set) Token: 0x06028107 RID: 164103 RVA: 0x003CFD40 File Offset: 0x003CDF40
		public unsafe bool bUseModFolder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWinGDKTargetSettings.__PropertyOffset_bUseModFolder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWinGDKTargetSettings.__PropertyOffset_bUseModFolder) = (value ? 1 : 0);
			}
		}

		// Token: 0x170098FC RID: 39164
		// (get) Token: 0x06028108 RID: 164104 RVA: 0x003CFD51 File Offset: 0x003CDF51
		// (set) Token: 0x06028109 RID: 164105 RVA: 0x003CFD65 File Offset: 0x003CDF65
		public unsafe string ModFolder
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UWinGDKTargetSettings.__PropertyOffset_ModFolder)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UWinGDKTargetSettings.__PropertyOffset_ModFolder)), value);
			}
		}

		// Token: 0x0602810A RID: 164106 RVA: 0x003CFD7A File Offset: 0x003CDF7A
		static UWinGDKTargetSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/WinGDKPlatformEditor.WinGDKTargetSettings");
		}

		// Token: 0x0602810B RID: 164107 RVA: 0x003CFD88 File Offset: 0x003CDF88
		protected UWinGDKTargetSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015FC3 RID: 90051
		public new const string __ObjectPath = "/Script/WinGDKPlatformEditor.WinGDKTargetSettings";

		// Token: 0x04015FC4 RID: 90052
		private static IntPtr _ClassPtr;

		// Token: 0x04015FC5 RID: 90053
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015FC6 RID: 90054
		internal static int __PropertyOffset_bMSAFullTrust;

		// Token: 0x04015FC7 RID: 90055
		internal static int __PropertyOffset_bUseModFolder;

		// Token: 0x04015FC8 RID: 90056
		internal static int __PropertyOffset_ModFolder;
	}
}
