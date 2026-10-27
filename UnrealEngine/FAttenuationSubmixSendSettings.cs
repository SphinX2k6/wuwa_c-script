using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000866 RID: 2150
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AttenuationSubmixSendSettings")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FAttenuationSubmixSendSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007416 RID: 29718 RVA: 0x000A6864 File Offset: 0x000A4A64
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAttenuationSubmixSendSettings._ScriptStructPtr != 0) ? FAttenuationSubmixSendSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AttenuationSubmixSendSettings", ref FAttenuationSubmixSendSettings._ScriptStructPtr);
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x06007417 RID: 29719 RVA: 0x000A6888 File Offset: 0x000A4A88
		// (set) Token: 0x06007418 RID: 29720 RVA: 0x000A689C File Offset: 0x000A4A9C
		[Nullable(2)]
		public unsafe USoundSubmixBase Submix
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundSubmixBase>(base.NativePtr / (IntPtr)sizeof(void*) + FAttenuationSubmixSendSettings.__PropertyOffset_Submix);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAttenuationSubmixSendSettings.__PropertyOffset_Submix, value);
			}
		}

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x06007419 RID: 29721 RVA: 0x000A68B1 File Offset: 0x000A4AB1
		// (set) Token: 0x0600741A RID: 29722 RVA: 0x000A68C1 File Offset: 0x000A4AC1
		public unsafe ESubmixSendMethod SubmixSendMethod
		{
			get
			{
				return (ESubmixSendMethod)(*(base.NativePtr + (IntPtr)FAttenuationSubmixSendSettings.__PropertyOffset_SubmixSendMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttenuationSubmixSendSettings.__PropertyOffset_SubmixSendMethod) = (byte)value;
			}
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x0600741B RID: 29723 RVA: 0x000A68D2 File Offset: 0x000A4AD2
		// (set) Token: 0x0600741C RID: 29724 RVA: 0x000A68E2 File Offset: 0x000A4AE2
		public unsafe float SubmixSendLevelMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAttenuationSubmixSendSettings.__PropertyOffset_SubmixSendLevelMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttenuationSubmixSendSettings.__PropertyOffset_SubmixSendLevelMin) = value;
			}
		}

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x0600741D RID: 29725 RVA: 0x000A68F3 File Offset: 0x000A4AF3
		// (set) Token: 0x0600741E RID: 29726 RVA: 0x000A6903 File Offset: 0x000A4B03
		public unsafe float SubmixSendLevelMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAttenuationSubmixSendSettings.__PropertyOffset_SubmixSendLevelMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttenuationSubmixSendSettings.__PropertyOffset_SubmixSendLevelMax) = value;
			}
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x0600741F RID: 29727 RVA: 0x000A6914 File Offset: 0x000A4B14
		// (set) Token: 0x06007420 RID: 29728 RVA: 0x000A6924 File Offset: 0x000A4B24
		public unsafe float SubmixSendDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAttenuationSubmixSendSettings.__PropertyOffset_SubmixSendDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttenuationSubmixSendSettings.__PropertyOffset_SubmixSendDistanceMin) = value;
			}
		}

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x06007421 RID: 29729 RVA: 0x000A6935 File Offset: 0x000A4B35
		// (set) Token: 0x06007422 RID: 29730 RVA: 0x000A6945 File Offset: 0x000A4B45
		public unsafe float SubmixSendDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAttenuationSubmixSendSettings.__PropertyOffset_SubmixSendDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttenuationSubmixSendSettings.__PropertyOffset_SubmixSendDistanceMax) = value;
			}
		}

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x06007423 RID: 29731 RVA: 0x000A6956 File Offset: 0x000A4B56
		// (set) Token: 0x06007424 RID: 29732 RVA: 0x000A6966 File Offset: 0x000A4B66
		public unsafe float ManualSubmixSendLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAttenuationSubmixSendSettings.__PropertyOffset_ManualSubmixSendLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttenuationSubmixSendSettings.__PropertyOffset_ManualSubmixSendLevel) = value;
			}
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x06007425 RID: 29733 RVA: 0x000A6978 File Offset: 0x000A4B78
		// (set) Token: 0x06007426 RID: 29734 RVA: 0x000A69BB File Offset: 0x000A4BBB
		public FRuntimeFloatCurve CustomSubmixSendCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._CustomSubmixSendCurve) == null)
				{
					result = (this._CustomSubmixSendCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FAttenuationSubmixSendSettings.__PropertyOffset_CustomSubmixSendCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FAttenuationSubmixSendSettings.__PropertyOffset_CustomSubmixSendCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06007427 RID: 29735 RVA: 0x000A69DC File Offset: 0x000A4BDC
		public FAttenuationSubmixSendSettings()
		{
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x000A69E4 File Offset: 0x000A4BE4
		public FAttenuationSubmixSendSettings(USoundSubmixBase Submix, ESubmixSendMethod SubmixSendMethod, float SubmixSendLevelMin, float SubmixSendLevelMax, float SubmixSendDistanceMin, float SubmixSendDistanceMax, float ManualSubmixSendLevel, FRuntimeFloatCurve CustomSubmixSendCurve)
		{
			this.Submix = Submix;
			this.SubmixSendMethod = SubmixSendMethod;
			this.SubmixSendLevelMin = SubmixSendLevelMin;
			this.SubmixSendLevelMax = SubmixSendLevelMax;
			this.SubmixSendDistanceMin = SubmixSendDistanceMin;
			this.SubmixSendDistanceMax = SubmixSendDistanceMax;
			this.ManualSubmixSendLevel = ManualSubmixSendLevel;
			this.CustomSubmixSendCurve = CustomSubmixSendCurve;
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x000A6A34 File Offset: 0x000A4C34
		protected override IntPtr GetUStructPtr()
		{
			return FAttenuationSubmixSendSettings.StaticStruct();
		}

		// Token: 0x0600742A RID: 29738 RVA: 0x000A6A40 File Offset: 0x000A4C40
		[NullableContext(2)]
		public FAttenuationSubmixSendSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600742B RID: 29739 RVA: 0x000A6A4A File Offset: 0x000A4C4A
		public FAttenuationSubmixSendSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600742C RID: 29740 RVA: 0x000A6A55 File Offset: 0x000A4C55
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAttenuationSubmixSendSettings(Pointer, false, true);
		}

		// Token: 0x0600742D RID: 29741 RVA: 0x000A6A5F File Offset: 0x000A4C5F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAttenuationSubmixSendSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040037D9 RID: 14297
		public const string __ObjectPath = "/Script/Engine.AttenuationSubmixSendSettings";

		// Token: 0x040037DA RID: 14298
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040037DB RID: 14299
		internal static int __PropertyOffset_Submix;

		// Token: 0x040037DC RID: 14300
		internal static int __PropertyOffset_SubmixSendMethod;

		// Token: 0x040037DD RID: 14301
		internal static int __PropertyOffset_SubmixSendLevelMin;

		// Token: 0x040037DE RID: 14302
		internal static int __PropertyOffset_SubmixSendLevelMax;

		// Token: 0x040037DF RID: 14303
		internal static int __PropertyOffset_SubmixSendDistanceMin;

		// Token: 0x040037E0 RID: 14304
		internal static int __PropertyOffset_SubmixSendDistanceMax;

		// Token: 0x040037E1 RID: 14305
		internal static int __PropertyOffset_ManualSubmixSendLevel;

		// Token: 0x040037E2 RID: 14306
		internal static int __PropertyOffset_CustomSubmixSendCurve;

		// Token: 0x040037E3 RID: 14307
		[Nullable(2)]
		private FRuntimeFloatCurve _CustomSubmixSendCurve;
	}
}
