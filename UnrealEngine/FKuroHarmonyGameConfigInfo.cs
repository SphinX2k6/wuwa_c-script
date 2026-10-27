using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001EBA RID: 7866
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroHarmonyGameConfigInfo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroHarmonyGameConfigInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601DD99 RID: 122265 RVA: 0x002C27F9 File Offset: 0x002C09F9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroHarmonyGameConfigInfo._ScriptStructPtr != 0) ? FKuroHarmonyGameConfigInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.KuroHarmonyGameConfigInfo", ref FKuroHarmonyGameConfigInfo._ScriptStructPtr);
		}

		// Token: 0x170077A0 RID: 30624
		// (get) Token: 0x0601DD9A RID: 122266 RVA: 0x002C281D File Offset: 0x002C0A1D
		// (set) Token: 0x0601DD9B RID: 122267 RVA: 0x002C282D File Offset: 0x002C0A2D
		public unsafe int MessageType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MessageType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MessageType) = value;
			}
		}

		// Token: 0x170077A1 RID: 30625
		// (get) Token: 0x0601DD9C RID: 122268 RVA: 0x002C283E File Offset: 0x002C0A3E
		// (set) Token: 0x0601DD9D RID: 122269 RVA: 0x002C284E File Offset: 0x002C0A4E
		public unsafe int MaxPictureQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MaxPictureQualityLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MaxPictureQualityLevel) = value;
			}
		}

		// Token: 0x170077A2 RID: 30626
		// (get) Token: 0x0601DD9E RID: 122270 RVA: 0x002C285F File Offset: 0x002C0A5F
		// (set) Token: 0x0601DD9F RID: 122271 RVA: 0x002C286F File Offset: 0x002C0A6F
		public unsafe int CurrentPictureQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_CurrentPictureQualityLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_CurrentPictureQualityLevel) = value;
			}
		}

		// Token: 0x170077A3 RID: 30627
		// (get) Token: 0x0601DDA0 RID: 122272 RVA: 0x002C2880 File Offset: 0x002C0A80
		// (set) Token: 0x0601DDA1 RID: 122273 RVA: 0x002C2890 File Offset: 0x002C0A90
		public unsafe int MaxFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MaxFrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MaxFrameRate) = value;
			}
		}

		// Token: 0x170077A4 RID: 30628
		// (get) Token: 0x0601DDA2 RID: 122274 RVA: 0x002C28A1 File Offset: 0x002C0AA1
		// (set) Token: 0x0601DDA3 RID: 122275 RVA: 0x002C28B1 File Offset: 0x002C0AB1
		public unsafe int CurrentFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_CurrentFrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_CurrentFrameRate) = value;
			}
		}

		// Token: 0x170077A5 RID: 30629
		// (get) Token: 0x0601DDA4 RID: 122276 RVA: 0x002C28C2 File Offset: 0x002C0AC2
		// (set) Token: 0x0601DDA5 RID: 122277 RVA: 0x002C28D6 File Offset: 0x002C0AD6
		public unsafe string MaxResolution
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MaxResolution)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MaxResolution)), value);
			}
		}

		// Token: 0x170077A6 RID: 30630
		// (get) Token: 0x0601DDA6 RID: 122278 RVA: 0x002C28EB File Offset: 0x002C0AEB
		// (set) Token: 0x0601DDA7 RID: 122279 RVA: 0x002C28FF File Offset: 0x002C0AFF
		public unsafe string CurrentResolution
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_CurrentResolution)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_CurrentResolution)), value);
			}
		}

		// Token: 0x170077A7 RID: 30631
		// (get) Token: 0x0601DDA8 RID: 122280 RVA: 0x002C2914 File Offset: 0x002C0B14
		// (set) Token: 0x0601DDA9 RID: 122281 RVA: 0x002C2924 File Offset: 0x002C0B24
		public unsafe bool bAntiAliasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bAntiAliasing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bAntiAliasing) = (value ? 1 : 0);
			}
		}

		// Token: 0x170077A8 RID: 30632
		// (get) Token: 0x0601DDAA RID: 122282 RVA: 0x002C2935 File Offset: 0x002C0B35
		// (set) Token: 0x0601DDAB RID: 122283 RVA: 0x002C2945 File Offset: 0x002C0B45
		public unsafe bool bShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x170077A9 RID: 30633
		// (get) Token: 0x0601DDAC RID: 122284 RVA: 0x002C2956 File Offset: 0x002C0B56
		// (set) Token: 0x0601DDAD RID: 122285 RVA: 0x002C2966 File Offset: 0x002C0B66
		public unsafe bool bMultithreading
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bMultithreading) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bMultithreading) = (value ? 1 : 0);
			}
		}

		// Token: 0x170077AA RID: 30634
		// (get) Token: 0x0601DDAE RID: 122286 RVA: 0x002C2977 File Offset: 0x002C0B77
		// (set) Token: 0x0601DDAF RID: 122287 RVA: 0x002C2987 File Offset: 0x002C0B87
		public unsafe bool bParticle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bParticle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bParticle) = (value ? 1 : 0);
			}
		}

		// Token: 0x170077AB RID: 30635
		// (get) Token: 0x0601DDB0 RID: 122288 RVA: 0x002C2998 File Offset: 0x002C0B98
		// (set) Token: 0x0601DDB1 RID: 122289 RVA: 0x002C29A8 File Offset: 0x002C0BA8
		public unsafe bool bHdMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bHdMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bHdMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601DDB2 RID: 122290 RVA: 0x002C29B9 File Offset: 0x002C0BB9
		public FKuroHarmonyGameConfigInfo()
		{
		}

		// Token: 0x0601DDB3 RID: 122291 RVA: 0x002C29C4 File Offset: 0x002C0BC4
		public FKuroHarmonyGameConfigInfo(int MessageType, int MaxPictureQualityLevel, int CurrentPictureQualityLevel, int MaxFrameRate, int CurrentFrameRate, string MaxResolution, string CurrentResolution, bool bAntiAliasing, bool bShadow, bool bMultithreading, bool bParticle, bool bHdMode)
		{
			this.MessageType = MessageType;
			this.MaxPictureQualityLevel = MaxPictureQualityLevel;
			this.CurrentPictureQualityLevel = CurrentPictureQualityLevel;
			this.MaxFrameRate = MaxFrameRate;
			this.CurrentFrameRate = CurrentFrameRate;
			this.MaxResolution = MaxResolution;
			this.CurrentResolution = CurrentResolution;
			this.bAntiAliasing = bAntiAliasing;
			this.bShadow = bShadow;
			this.bMultithreading = bMultithreading;
			this.bParticle = bParticle;
			this.bHdMode = bHdMode;
		}

		// Token: 0x0601DDB4 RID: 122292 RVA: 0x002C2A34 File Offset: 0x002C0C34
		protected override IntPtr GetUStructPtr()
		{
			return FKuroHarmonyGameConfigInfo.StaticStruct();
		}

		// Token: 0x0601DDB5 RID: 122293 RVA: 0x002C2A40 File Offset: 0x002C0C40
		[NullableContext(2)]
		public FKuroHarmonyGameConfigInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DDB6 RID: 122294 RVA: 0x002C2A4A File Offset: 0x002C0C4A
		public FKuroHarmonyGameConfigInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DDB7 RID: 122295 RVA: 0x002C2A55 File Offset: 0x002C0C55
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroHarmonyGameConfigInfo(Pointer, false, true);
		}

		// Token: 0x0601DDB8 RID: 122296 RVA: 0x002C2A5F File Offset: 0x002C0C5F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroHarmonyGameConfigInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040102C5 RID: 66245
		public const string __ObjectPath = "/Script/KuroUtility.KuroHarmonyGameConfigInfo";

		// Token: 0x040102C6 RID: 66246
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040102C7 RID: 66247
		internal static int __PropertyOffset_MessageType;

		// Token: 0x040102C8 RID: 66248
		internal static int __PropertyOffset_MaxPictureQualityLevel;

		// Token: 0x040102C9 RID: 66249
		internal static int __PropertyOffset_CurrentPictureQualityLevel;

		// Token: 0x040102CA RID: 66250
		internal static int __PropertyOffset_MaxFrameRate;

		// Token: 0x040102CB RID: 66251
		internal static int __PropertyOffset_CurrentFrameRate;

		// Token: 0x040102CC RID: 66252
		internal static int __PropertyOffset_MaxResolution;

		// Token: 0x040102CD RID: 66253
		internal static int __PropertyOffset_CurrentResolution;

		// Token: 0x040102CE RID: 66254
		internal static int __PropertyOffset_bAntiAliasing;

		// Token: 0x040102CF RID: 66255
		internal static int __PropertyOffset_bShadow;

		// Token: 0x040102D0 RID: 66256
		internal static int __PropertyOffset_bMultithreading;

		// Token: 0x040102D1 RID: 66257
		internal static int __PropertyOffset_bParticle;

		// Token: 0x040102D2 RID: 66258
		internal static int __PropertyOffset_bHdMode;
	}
}
