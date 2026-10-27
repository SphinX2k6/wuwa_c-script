using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028DA RID: 10458
	[UnrealObjectPath("/Script/TapCommon.TapAntiAddictionConfig")]
	[UnrealStructLayout(3, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3)]
	public class FTapAntiAddictionConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026CC3 RID: 158915 RVA: 0x003B2B18 File Offset: 0x003B0D18
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTapAntiAddictionConfig._ScriptStructPtr != 0) ? FTapAntiAddictionConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.TapAntiAddictionConfig", ref FTapAntiAddictionConfig._ScriptStructPtr);
		}

		// Token: 0x17009577 RID: 38263
		// (get) Token: 0x06026CC4 RID: 158916 RVA: 0x003B2B3C File Offset: 0x003B0D3C
		// (set) Token: 0x06026CC5 RID: 158917 RVA: 0x003B2B4C File Offset: 0x003B0D4C
		public unsafe bool bShowSwitchAccount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapAntiAddictionConfig.__PropertyOffset_bShowSwitchAccount) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapAntiAddictionConfig.__PropertyOffset_bShowSwitchAccount) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009578 RID: 38264
		// (get) Token: 0x06026CC6 RID: 158918 RVA: 0x003B2B5D File Offset: 0x003B0D5D
		// (set) Token: 0x06026CC7 RID: 158919 RVA: 0x003B2B6D File Offset: 0x003B0D6D
		public unsafe bool bUseAgeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapAntiAddictionConfig.__PropertyOffset_bUseAgeRange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapAntiAddictionConfig.__PropertyOffset_bUseAgeRange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009579 RID: 38265
		// (get) Token: 0x06026CC8 RID: 158920 RVA: 0x003B2B7E File Offset: 0x003B0D7E
		// (set) Token: 0x06026CC9 RID: 158921 RVA: 0x003B2B8E File Offset: 0x003B0D8E
		public unsafe ETapAntiAddictionConfigRegion Region
		{
			get
			{
				return (ETapAntiAddictionConfigRegion)(*(base.NativePtr + (IntPtr)FTapAntiAddictionConfig.__PropertyOffset_Region));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapAntiAddictionConfig.__PropertyOffset_Region) = (byte)value;
			}
		}

		// Token: 0x06026CCA RID: 158922 RVA: 0x003B2B9F File Offset: 0x003B0D9F
		public FTapAntiAddictionConfig()
		{
		}

		// Token: 0x06026CCB RID: 158923 RVA: 0x003B2BA7 File Offset: 0x003B0DA7
		public FTapAntiAddictionConfig(bool bShowSwitchAccount, bool bUseAgeRange, ETapAntiAddictionConfigRegion Region)
		{
			this.bShowSwitchAccount = bShowSwitchAccount;
			this.bUseAgeRange = bUseAgeRange;
			this.Region = Region;
		}

		// Token: 0x06026CCC RID: 158924 RVA: 0x003B2BC4 File Offset: 0x003B0DC4
		protected override IntPtr GetUStructPtr()
		{
			return FTapAntiAddictionConfig.StaticStruct();
		}

		// Token: 0x06026CCD RID: 158925 RVA: 0x003B2BD0 File Offset: 0x003B0DD0
		[NullableContext(2)]
		public FTapAntiAddictionConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026CCE RID: 158926 RVA: 0x003B2BDA File Offset: 0x003B0DDA
		public FTapAntiAddictionConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026CCF RID: 158927 RVA: 0x003B2BE5 File Offset: 0x003B0DE5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTapAntiAddictionConfig(Pointer, false, true);
		}

		// Token: 0x06026CD0 RID: 158928 RVA: 0x003B2BEF File Offset: 0x003B0DEF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTapAntiAddictionConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040154D2 RID: 87250
		[Nullable(1)]
		public const string __ObjectPath = "/Script/TapCommon.TapAntiAddictionConfig";

		// Token: 0x040154D3 RID: 87251
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040154D4 RID: 87252
		internal static int __PropertyOffset_bShowSwitchAccount;

		// Token: 0x040154D5 RID: 87253
		internal static int __PropertyOffset_bUseAgeRange;

		// Token: 0x040154D6 RID: 87254
		internal static int __PropertyOffset_Region;
	}
}
