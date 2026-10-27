using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002207 RID: 8711
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkInterpolationSettings")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FLiveLinkInterpolationSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060212F1 RID: 135921 RVA: 0x0030ECC5 File Offset: 0x0030CEC5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkInterpolationSettings._ScriptStructPtr != 0) ? FLiveLinkInterpolationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkInterpolationSettings", ref FLiveLinkInterpolationSettings._ScriptStructPtr);
		}

		// Token: 0x17008186 RID: 33158
		// (get) Token: 0x060212F2 RID: 135922 RVA: 0x0030ECE9 File Offset: 0x0030CEE9
		// (set) Token: 0x060212F3 RID: 135923 RVA: 0x0030ECF9 File Offset: 0x0030CEF9
		public unsafe bool bUseInterpolation_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkInterpolationSettings.__PropertyOffset_bUseInterpolation_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkInterpolationSettings.__PropertyOffset_bUseInterpolation_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008187 RID: 33159
		// (get) Token: 0x060212F4 RID: 135924 RVA: 0x0030ED0A File Offset: 0x0030CF0A
		// (set) Token: 0x060212F5 RID: 135925 RVA: 0x0030ED1A File Offset: 0x0030CF1A
		public unsafe float InterpolationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkInterpolationSettings.__PropertyOffset_InterpolationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkInterpolationSettings.__PropertyOffset_InterpolationOffset) = value;
			}
		}

		// Token: 0x060212F6 RID: 135926 RVA: 0x0030ED2B File Offset: 0x0030CF2B
		public FLiveLinkInterpolationSettings()
		{
		}

		// Token: 0x060212F7 RID: 135927 RVA: 0x0030ED33 File Offset: 0x0030CF33
		public FLiveLinkInterpolationSettings(bool bUseInterpolation_DEPRECATED, float InterpolationOffset)
		{
			this.bUseInterpolation_DEPRECATED = bUseInterpolation_DEPRECATED;
			this.InterpolationOffset = InterpolationOffset;
		}

		// Token: 0x060212F8 RID: 135928 RVA: 0x0030ED49 File Offset: 0x0030CF49
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkInterpolationSettings.StaticStruct();
		}

		// Token: 0x060212F9 RID: 135929 RVA: 0x0030ED55 File Offset: 0x0030CF55
		[NullableContext(2)]
		public FLiveLinkInterpolationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060212FA RID: 135930 RVA: 0x0030ED5F File Offset: 0x0030CF5F
		public FLiveLinkInterpolationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060212FB RID: 135931 RVA: 0x0030ED6A File Offset: 0x0030CF6A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkInterpolationSettings(Pointer, false, true);
		}

		// Token: 0x060212FC RID: 135932 RVA: 0x0030ED74 File Offset: 0x0030CF74
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkInterpolationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04011B45 RID: 72517
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkInterpolationSettings";

		// Token: 0x04011B46 RID: 72518
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B47 RID: 72519
		internal static int __PropertyOffset_bUseInterpolation_DEPRECATED;

		// Token: 0x04011B48 RID: 72520
		internal static int __PropertyOffset_InterpolationOffset;
	}
}
