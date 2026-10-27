using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023E5 RID: 9189
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEasingSettings")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FMovieSceneEasingSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060227F0 RID: 141296 RVA: 0x003306D4 File Offset: 0x0032E8D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEasingSettings._ScriptStructPtr != 0) ? FMovieSceneEasingSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEasingSettings", ref FMovieSceneEasingSettings._ScriptStructPtr);
		}

		// Token: 0x170084DD RID: 34013
		// (get) Token: 0x060227F1 RID: 141297 RVA: 0x003306F8 File Offset: 0x0032E8F8
		// (set) Token: 0x060227F2 RID: 141298 RVA: 0x00330708 File Offset: 0x0032E908
		public unsafe int AutoEaseInDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_AutoEaseInDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_AutoEaseInDuration) = value;
			}
		}

		// Token: 0x170084DE RID: 34014
		// (get) Token: 0x060227F3 RID: 141299 RVA: 0x00330719 File Offset: 0x0032E919
		// (set) Token: 0x060227F4 RID: 141300 RVA: 0x00330729 File Offset: 0x0032E929
		public unsafe int AutoEaseOutDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_AutoEaseOutDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_AutoEaseOutDuration) = value;
			}
		}

		// Token: 0x170084DF RID: 34015
		// (get) Token: 0x060227F5 RID: 141301 RVA: 0x0033073A File Offset: 0x0032E93A
		// (set) Token: 0x060227F6 RID: 141302 RVA: 0x00330754 File Offset: 0x0032E954
		[Nullable(2)]
		public unsafe IMovieSceneEasingFunction EaseIn
		{
			[NullableContext(2)]
			get
			{
				return (IMovieSceneEasingFunction)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_EaseIn));
			}
			[NullableContext(2)]
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_EaseIn) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x170084E0 RID: 34016
		// (get) Token: 0x060227F7 RID: 141303 RVA: 0x0033077A File Offset: 0x0032E97A
		// (set) Token: 0x060227F8 RID: 141304 RVA: 0x0033078A File Offset: 0x0032E98A
		public unsafe bool bManualEaseIn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_bManualEaseIn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_bManualEaseIn) = (value ? 1 : 0);
			}
		}

		// Token: 0x170084E1 RID: 34017
		// (get) Token: 0x060227F9 RID: 141305 RVA: 0x0033079B File Offset: 0x0032E99B
		// (set) Token: 0x060227FA RID: 141306 RVA: 0x003307AB File Offset: 0x0032E9AB
		public unsafe int ManualEaseInDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_ManualEaseInDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_ManualEaseInDuration) = value;
			}
		}

		// Token: 0x170084E2 RID: 34018
		// (get) Token: 0x060227FB RID: 141307 RVA: 0x003307BC File Offset: 0x0032E9BC
		// (set) Token: 0x060227FC RID: 141308 RVA: 0x003307D6 File Offset: 0x0032E9D6
		[Nullable(2)]
		public unsafe IMovieSceneEasingFunction EaseOut
		{
			[NullableContext(2)]
			get
			{
				return (IMovieSceneEasingFunction)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_EaseOut));
			}
			[NullableContext(2)]
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_EaseOut) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x170084E3 RID: 34019
		// (get) Token: 0x060227FD RID: 141309 RVA: 0x003307FC File Offset: 0x0032E9FC
		// (set) Token: 0x060227FE RID: 141310 RVA: 0x0033080C File Offset: 0x0032EA0C
		public unsafe bool bManualEaseOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_bManualEaseOut) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_bManualEaseOut) = (value ? 1 : 0);
			}
		}

		// Token: 0x170084E4 RID: 34020
		// (get) Token: 0x060227FF RID: 141311 RVA: 0x0033081D File Offset: 0x0032EA1D
		// (set) Token: 0x06022800 RID: 141312 RVA: 0x0033082D File Offset: 0x0032EA2D
		public unsafe int ManualEaseOutDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_ManualEaseOutDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_ManualEaseOutDuration) = value;
			}
		}

		// Token: 0x170084E5 RID: 34021
		// (get) Token: 0x06022801 RID: 141313 RVA: 0x00330840 File Offset: 0x0032EA40
		// (set) Token: 0x06022802 RID: 141314 RVA: 0x00330883 File Offset: 0x0032EA83
		public FMovieSceneEasingStructFunction StructEaseIn
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEasingStructFunction result;
				if ((result = this._StructEaseIn) == null)
				{
					result = (this._StructEaseIn = new FMovieSceneEasingStructFunction(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_StructEaseIn, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEasingStructFunction.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_StructEaseIn, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084E6 RID: 34022
		// (get) Token: 0x06022803 RID: 141315 RVA: 0x003308A4 File Offset: 0x0032EAA4
		// (set) Token: 0x06022804 RID: 141316 RVA: 0x003308E7 File Offset: 0x0032EAE7
		public FMovieSceneEasingStructFunction StructEaseOut
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEasingStructFunction result;
				if ((result = this._StructEaseOut) == null)
				{
					result = (this._StructEaseOut = new FMovieSceneEasingStructFunction(base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_StructEaseOut, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEasingStructFunction.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEasingSettings.__PropertyOffset_StructEaseOut, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022805 RID: 141317 RVA: 0x00330908 File Offset: 0x0032EB08
		public FMovieSceneEasingSettings()
		{
		}

		// Token: 0x06022806 RID: 141318 RVA: 0x00330910 File Offset: 0x0032EB10
		public FMovieSceneEasingSettings(int AutoEaseInDuration, int AutoEaseOutDuration, IMovieSceneEasingFunction EaseIn, bool bManualEaseIn, int ManualEaseInDuration, IMovieSceneEasingFunction EaseOut, bool bManualEaseOut, int ManualEaseOutDuration, float AutoEaseInTime_DEPRECATED, float AutoEaseOutTime_DEPRECATED, float ManualEaseInTime_DEPRECATED, float ManualEaseOutTime_DEPRECATED, FMovieSceneEasingStructFunction StructEaseIn, FMovieSceneEasingStructFunction StructEaseOut)
		{
			this.AutoEaseInDuration = AutoEaseInDuration;
			this.AutoEaseOutDuration = AutoEaseOutDuration;
			this.EaseIn = EaseIn;
			this.bManualEaseIn = bManualEaseIn;
			this.ManualEaseInDuration = ManualEaseInDuration;
			this.EaseOut = EaseOut;
			this.bManualEaseOut = bManualEaseOut;
			this.ManualEaseOutDuration = ManualEaseOutDuration;
			this.StructEaseIn = StructEaseIn;
			this.StructEaseOut = StructEaseOut;
		}

		// Token: 0x06022807 RID: 141319 RVA: 0x00330970 File Offset: 0x0032EB70
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEasingSettings.StaticStruct();
		}

		// Token: 0x06022808 RID: 141320 RVA: 0x0033097C File Offset: 0x0032EB7C
		[NullableContext(2)]
		public FMovieSceneEasingSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022809 RID: 141321 RVA: 0x00330986 File Offset: 0x0032EB86
		public FMovieSceneEasingSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602280A RID: 141322 RVA: 0x00330991 File Offset: 0x0032EB91
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEasingSettings(Pointer, false, true);
		}

		// Token: 0x0602280B RID: 141323 RVA: 0x0033099B File Offset: 0x0032EB9B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEasingSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0401270B RID: 75531
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEasingSettings";

		// Token: 0x0401270C RID: 75532
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401270D RID: 75533
		internal static int __PropertyOffset_AutoEaseInDuration;

		// Token: 0x0401270E RID: 75534
		internal static int __PropertyOffset_AutoEaseOutDuration;

		// Token: 0x0401270F RID: 75535
		internal static int __PropertyOffset_EaseIn;

		// Token: 0x04012710 RID: 75536
		internal static int __PropertyOffset_bManualEaseIn;

		// Token: 0x04012711 RID: 75537
		internal static int __PropertyOffset_ManualEaseInDuration;

		// Token: 0x04012712 RID: 75538
		internal static int __PropertyOffset_EaseOut;

		// Token: 0x04012713 RID: 75539
		internal static int __PropertyOffset_bManualEaseOut;

		// Token: 0x04012714 RID: 75540
		internal static int __PropertyOffset_ManualEaseOutDuration;

		// Token: 0x04012715 RID: 75541
		internal static int __PropertyOffset_StructEaseIn;

		// Token: 0x04012716 RID: 75542
		[Nullable(2)]
		private FMovieSceneEasingStructFunction _StructEaseIn;

		// Token: 0x04012717 RID: 75543
		internal static int __PropertyOffset_StructEaseOut;

		// Token: 0x04012718 RID: 75544
		[Nullable(2)]
		private FMovieSceneEasingStructFunction _StructEaseOut;
	}
}
