using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000664 RID: 1636
	[UnrealObjectPath("/Script/LGUI.KuroWorldMapUIParams")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UKuroWorldMapUIParams : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008DC8 RID: 36296 RVA: 0x000D58BA File Offset: 0x000D3ABA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroWorldMapUIParams._ClassPtr;
		}

		// Token: 0x06008DC9 RID: 36297 RVA: 0x000D58C8 File Offset: 0x000D3AC8
		public UKuroWorldMapUIParams() : this(BuiltinUtils.AllocNativeUObject(UKuroWorldMapUIParams.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008DCA RID: 36298 RVA: 0x000D58F0 File Offset: 0x000D3AF0
		[NullableContext(1)]
		public UKuroWorldMapUIParams(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroWorldMapUIParams.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x06008DCB RID: 36299 RVA: 0x000D5923 File Offset: 0x000D3B23
		// (set) Token: 0x06008DCC RID: 36300 RVA: 0x000D5933 File Offset: 0x000D3B33
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

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x06008DCD RID: 36301 RVA: 0x000D5944 File Offset: 0x000D3B44
		// (set) Token: 0x06008DCE RID: 36302 RVA: 0x000D5958 File Offset: 0x000D3B58
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

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x06008DCF RID: 36303 RVA: 0x000D596D File Offset: 0x000D3B6D
		// (set) Token: 0x06008DD0 RID: 36304 RVA: 0x000D597D File Offset: 0x000D3B7D
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

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x06008DD1 RID: 36305 RVA: 0x000D598E File Offset: 0x000D3B8E
		// (set) Token: 0x06008DD2 RID: 36306 RVA: 0x000D599E File Offset: 0x000D3B9E
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

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x06008DD3 RID: 36307 RVA: 0x000D59AF File Offset: 0x000D3BAF
		// (set) Token: 0x06008DD4 RID: 36308 RVA: 0x000D59BF File Offset: 0x000D3BBF
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

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x06008DD5 RID: 36309 RVA: 0x000D59D0 File Offset: 0x000D3BD0
		// (set) Token: 0x06008DD6 RID: 36310 RVA: 0x000D59E0 File Offset: 0x000D3BE0
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

		// Token: 0x06008DD7 RID: 36311 RVA: 0x000D59F1 File Offset: 0x000D3BF1
		static UKuroWorldMapUIParams()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.KuroWorldMapUIParams");
		}

		// Token: 0x06008DD8 RID: 36312 RVA: 0x000D59FF File Offset: 0x000D3BFF
		protected UKuroWorldMapUIParams(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003E7A RID: 15994
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.KuroWorldMapUIParams";

		// Token: 0x04003E7B RID: 15995
		private static IntPtr _ClassPtr;

		// Token: 0x04003E7C RID: 15996
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003E7D RID: 15997
		internal static int __PropertyOffset_MarkMenuRectSize;

		// Token: 0x04003E7E RID: 15998
		internal static int __PropertyOffset_FocusMark_AnchoredPosition;

		// Token: 0x04003E7F RID: 15999
		internal static int __PropertyOffset_TweenTime;

		// Token: 0x04003E80 RID: 16000
		internal static int __PropertyOffset_TweenTypeEase;

		// Token: 0x04003E81 RID: 16001
		internal static int __PropertyOffset_GamePadTweenTime;

		// Token: 0x04003E82 RID: 16002
		internal static int __PropertyOffset_GamePadMoveSpeed;
	}
}
