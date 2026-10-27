using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002018 RID: 8216
	[UnrealObjectPath("/Script/LGUI.KuroWorldMapUIParams")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UKuroWorldMapUIParams : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EF5F RID: 126815 RVA: 0x002E0B4E File Offset: 0x002DED4E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroWorldMapUIParams._ClassPtr;
		}

		// Token: 0x0601EF60 RID: 126816 RVA: 0x002E0B5C File Offset: 0x002DED5C
		public UKuroWorldMapUIParams() : this(BuiltinUtils.AllocNativeUObject(UKuroWorldMapUIParams.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EF61 RID: 126817 RVA: 0x002E0B84 File Offset: 0x002DED84
		[NullableContext(1)]
		public UKuroWorldMapUIParams(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroWorldMapUIParams.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007B3E RID: 31550
		// (get) Token: 0x0601EF62 RID: 126818 RVA: 0x002E0BB7 File Offset: 0x002DEDB7
		// (set) Token: 0x0601EF63 RID: 126819 RVA: 0x002E0BC7 File Offset: 0x002DEDC7
		public unsafe int MarkMenuRectSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldMapUIParams.__PropertyOffset_MarkMenuRectSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldMapUIParams.__PropertyOffset_MarkMenuRectSize) = value;
			}
		}

		// Token: 0x17007B3F RID: 31551
		// (get) Token: 0x0601EF64 RID: 126820 RVA: 0x002E0BD8 File Offset: 0x002DEDD8
		// (set) Token: 0x0601EF65 RID: 126821 RVA: 0x002E0BEC File Offset: 0x002DEDEC
		public unsafe FVector2D FocusMark_AnchoredPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldMapUIParams.__PropertyOffset_FocusMark_AnchoredPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldMapUIParams.__PropertyOffset_FocusMark_AnchoredPosition) = value;
			}
		}

		// Token: 0x17007B40 RID: 31552
		// (get) Token: 0x0601EF66 RID: 126822 RVA: 0x002E0C01 File Offset: 0x002DEE01
		// (set) Token: 0x0601EF67 RID: 126823 RVA: 0x002E0C11 File Offset: 0x002DEE11
		public unsafe float TweenTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldMapUIParams.__PropertyOffset_TweenTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldMapUIParams.__PropertyOffset_TweenTime) = value;
			}
		}

		// Token: 0x17007B41 RID: 31553
		// (get) Token: 0x0601EF68 RID: 126824 RVA: 0x002E0C22 File Offset: 0x002DEE22
		// (set) Token: 0x0601EF69 RID: 126825 RVA: 0x002E0C32 File Offset: 0x002DEE32
		public unsafe LTweenEase TweenTypeEase
		{
			get
			{
				return (LTweenEase)(*(base.NativePtr + (IntPtr)UKuroWorldMapUIParams.__PropertyOffset_TweenTypeEase));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldMapUIParams.__PropertyOffset_TweenTypeEase) = (byte)value;
			}
		}

		// Token: 0x17007B42 RID: 31554
		// (get) Token: 0x0601EF6A RID: 126826 RVA: 0x002E0C43 File Offset: 0x002DEE43
		// (set) Token: 0x0601EF6B RID: 126827 RVA: 0x002E0C53 File Offset: 0x002DEE53
		public unsafe float GamePadTweenTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldMapUIParams.__PropertyOffset_GamePadTweenTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldMapUIParams.__PropertyOffset_GamePadTweenTime) = value;
			}
		}

		// Token: 0x17007B43 RID: 31555
		// (get) Token: 0x0601EF6C RID: 126828 RVA: 0x002E0C64 File Offset: 0x002DEE64
		// (set) Token: 0x0601EF6D RID: 126829 RVA: 0x002E0C74 File Offset: 0x002DEE74
		public unsafe float GamePadMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldMapUIParams.__PropertyOffset_GamePadMoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldMapUIParams.__PropertyOffset_GamePadMoveSpeed) = value;
			}
		}

		// Token: 0x0601EF6E RID: 126830 RVA: 0x002E0C85 File Offset: 0x002DEE85
		static UKuroWorldMapUIParams()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.KuroWorldMapUIParams");
		}

		// Token: 0x0601EF6F RID: 126831 RVA: 0x002E0C93 File Offset: 0x002DEE93
		protected UKuroWorldMapUIParams(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D50 RID: 68944
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.KuroWorldMapUIParams";

		// Token: 0x04010D51 RID: 68945
		private static IntPtr _ClassPtr;

		// Token: 0x04010D52 RID: 68946
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D53 RID: 68947
		internal static int __PropertyOffset_MarkMenuRectSize;

		// Token: 0x04010D54 RID: 68948
		internal static int __PropertyOffset_FocusMark_AnchoredPosition;

		// Token: 0x04010D55 RID: 68949
		internal static int __PropertyOffset_TweenTime;

		// Token: 0x04010D56 RID: 68950
		internal static int __PropertyOffset_TweenTypeEase;

		// Token: 0x04010D57 RID: 68951
		internal static int __PropertyOffset_GamePadTweenTime;

		// Token: 0x04010D58 RID: 68952
		internal static int __PropertyOffset_GamePadMoveSpeed;
	}
}
