using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C50 RID: 3152
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputAlphaBoolBlend")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FInputAlphaBoolBlend : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009FCE RID: 40910 RVA: 0x000E31D9 File Offset: 0x000E13D9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputAlphaBoolBlend._ScriptStructPtr != 0) ? FInputAlphaBoolBlend._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InputAlphaBoolBlend", ref FInputAlphaBoolBlend._ScriptStructPtr);
		}

		// Token: 0x17002615 RID: 9749
		// (get) Token: 0x06009FCF RID: 40911 RVA: 0x000E31FD File Offset: 0x000E13FD
		// (set) Token: 0x06009FD0 RID: 40912 RVA: 0x000E320D File Offset: 0x000E140D
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputAlphaBoolBlend.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputAlphaBoolBlend.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x17002616 RID: 9750
		// (get) Token: 0x06009FD1 RID: 40913 RVA: 0x000E321E File Offset: 0x000E141E
		// (set) Token: 0x06009FD2 RID: 40914 RVA: 0x000E322E File Offset: 0x000E142E
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputAlphaBoolBlend.__PropertyOffset_BlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputAlphaBoolBlend.__PropertyOffset_BlendOutTime) = value;
			}
		}

		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x06009FD3 RID: 40915 RVA: 0x000E323F File Offset: 0x000E143F
		// (set) Token: 0x06009FD4 RID: 40916 RVA: 0x000E324F File Offset: 0x000E144F
		public unsafe EAlphaBlendOption BlendOption
		{
			get
			{
				return (EAlphaBlendOption)(*(base.NativePtr + (IntPtr)FInputAlphaBoolBlend.__PropertyOffset_BlendOption));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputAlphaBoolBlend.__PropertyOffset_BlendOption) = (byte)value;
			}
		}

		// Token: 0x17002618 RID: 9752
		// (get) Token: 0x06009FD5 RID: 40917 RVA: 0x000E3260 File Offset: 0x000E1460
		// (set) Token: 0x06009FD6 RID: 40918 RVA: 0x000E3270 File Offset: 0x000E1470
		public unsafe bool bInitialized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputAlphaBoolBlend.__PropertyOffset_bInitialized) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputAlphaBoolBlend.__PropertyOffset_bInitialized) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x06009FD7 RID: 40919 RVA: 0x000E3281 File Offset: 0x000E1481
		// (set) Token: 0x06009FD8 RID: 40920 RVA: 0x000E3295 File Offset: 0x000E1495
		[Nullable(2)]
		public unsafe UCurveFloat CustomCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FInputAlphaBoolBlend.__PropertyOffset_CustomCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FInputAlphaBoolBlend.__PropertyOffset_CustomCurve, value);
			}
		}

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x06009FD9 RID: 40921 RVA: 0x000E32AC File Offset: 0x000E14AC
		// (set) Token: 0x06009FDA RID: 40922 RVA: 0x000E32EF File Offset: 0x000E14EF
		public FAlphaBlend AlphaBlend
		{
			get
			{
				base.FastCheckIsValid();
				FAlphaBlend result;
				if ((result = this._AlphaBlend) == null)
				{
					result = (this._AlphaBlend = new FAlphaBlend(base.NativePtr + (IntPtr)FInputAlphaBoolBlend.__PropertyOffset_AlphaBlend, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAlphaBlend.StaticStruct(), base.NativePtr + (IntPtr)FInputAlphaBoolBlend.__PropertyOffset_AlphaBlend, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06009FDB RID: 40923 RVA: 0x000E3310 File Offset: 0x000E1510
		public FInputAlphaBoolBlend()
		{
		}

		// Token: 0x06009FDC RID: 40924 RVA: 0x000E3318 File Offset: 0x000E1518
		public FInputAlphaBoolBlend(float BlendInTime, float BlendOutTime, EAlphaBlendOption BlendOption, bool bInitialized, UCurveFloat CustomCurve, FAlphaBlend AlphaBlend)
		{
			this.BlendInTime = BlendInTime;
			this.BlendOutTime = BlendOutTime;
			this.BlendOption = BlendOption;
			this.bInitialized = bInitialized;
			this.CustomCurve = CustomCurve;
			this.AlphaBlend = AlphaBlend;
		}

		// Token: 0x06009FDD RID: 40925 RVA: 0x000E334D File Offset: 0x000E154D
		protected override IntPtr GetUStructPtr()
		{
			return FInputAlphaBoolBlend.StaticStruct();
		}

		// Token: 0x06009FDE RID: 40926 RVA: 0x000E3359 File Offset: 0x000E1559
		[NullableContext(2)]
		public FInputAlphaBoolBlend(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009FDF RID: 40927 RVA: 0x000E3363 File Offset: 0x000E1563
		public FInputAlphaBoolBlend(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009FE0 RID: 40928 RVA: 0x000E336E File Offset: 0x000E156E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputAlphaBoolBlend(Pointer, false, true);
		}

		// Token: 0x06009FE1 RID: 40929 RVA: 0x000E3378 File Offset: 0x000E1578
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputAlphaBoolBlend(Pointer, MemoryOwner);
		}

		// Token: 0x040057F2 RID: 22514
		public const string __ObjectPath = "/Script/Engine.InputAlphaBoolBlend";

		// Token: 0x040057F3 RID: 22515
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040057F4 RID: 22516
		internal static int __PropertyOffset_BlendInTime;

		// Token: 0x040057F5 RID: 22517
		internal static int __PropertyOffset_BlendOutTime;

		// Token: 0x040057F6 RID: 22518
		internal static int __PropertyOffset_BlendOption;

		// Token: 0x040057F7 RID: 22519
		internal static int __PropertyOffset_bInitialized;

		// Token: 0x040057F8 RID: 22520
		internal static int __PropertyOffset_CustomCurve;

		// Token: 0x040057F9 RID: 22521
		internal static int __PropertyOffset_AlphaBlend;

		// Token: 0x040057FA RID: 22522
		[Nullable(2)]
		private FAlphaBlend _AlphaBlend;
	}
}
