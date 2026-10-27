using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001712 RID: 5906
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.StarEmitterSettings")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FStarEmitterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060154F3 RID: 87283 RVA: 0x001F51E1 File Offset: 0x001F33E1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStarEmitterSettings._ScriptStructPtr != 0) ? FStarEmitterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.StarEmitterSettings", ref FStarEmitterSettings._ScriptStructPtr);
		}

		// Token: 0x1700543A RID: 21562
		// (get) Token: 0x060154F4 RID: 87284 RVA: 0x001F5205 File Offset: 0x001F3405
		// (set) Token: 0x060154F5 RID: 87285 RVA: 0x001F5215 File Offset: 0x001F3415
		public unsafe int StarCorners
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStarEmitterSettings.__PropertyOffset_StarCorners);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStarEmitterSettings.__PropertyOffset_StarCorners) = value;
			}
		}

		// Token: 0x1700543B RID: 21563
		// (get) Token: 0x060154F6 RID: 87286 RVA: 0x001F5226 File Offset: 0x001F3426
		// (set) Token: 0x060154F7 RID: 87287 RVA: 0x001F5236 File Offset: 0x001F3436
		public unsafe float OuterRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStarEmitterSettings.__PropertyOffset_OuterRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStarEmitterSettings.__PropertyOffset_OuterRadius) = value;
			}
		}

		// Token: 0x1700543C RID: 21564
		// (get) Token: 0x060154F8 RID: 87288 RVA: 0x001F5247 File Offset: 0x001F3447
		// (set) Token: 0x060154F9 RID: 87289 RVA: 0x001F5257 File Offset: 0x001F3457
		public unsafe float InnerRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStarEmitterSettings.__PropertyOffset_InnerRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStarEmitterSettings.__PropertyOffset_InnerRadius) = value;
			}
		}

		// Token: 0x1700543D RID: 21565
		// (get) Token: 0x060154FA RID: 87290 RVA: 0x001F5268 File Offset: 0x001F3468
		// (set) Token: 0x060154FB RID: 87291 RVA: 0x001F5278 File Offset: 0x001F3478
		public unsafe int FillCorners
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStarEmitterSettings.__PropertyOffset_FillCorners);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStarEmitterSettings.__PropertyOffset_FillCorners) = value;
			}
		}

		// Token: 0x1700543E RID: 21566
		// (get) Token: 0x060154FC RID: 87292 RVA: 0x001F528C File Offset: 0x001F348C
		// (set) Token: 0x060154FD RID: 87293 RVA: 0x001F52CF File Offset: 0x001F34CF
		public FEmitterStackSettings StackSettings
		{
			get
			{
				base.FastCheckIsValid();
				FEmitterStackSettings result;
				if ((result = this._StackSettings) == null)
				{
					result = (this._StackSettings = new FEmitterStackSettings(base.NativePtr + (IntPtr)FStarEmitterSettings.__PropertyOffset_StackSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEmitterStackSettings.StaticStruct(), base.NativePtr + (IntPtr)FStarEmitterSettings.__PropertyOffset_StackSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060154FE RID: 87294 RVA: 0x001F52F0 File Offset: 0x001F34F0
		public FStarEmitterSettings()
		{
		}

		// Token: 0x060154FF RID: 87295 RVA: 0x001F52F8 File Offset: 0x001F34F8
		public FStarEmitterSettings(int StarCorners, float OuterRadius, float InnerRadius, int FillCorners, FEmitterStackSettings StackSettings)
		{
			this.StarCorners = StarCorners;
			this.OuterRadius = OuterRadius;
			this.InnerRadius = InnerRadius;
			this.FillCorners = FillCorners;
			this.StackSettings = StackSettings;
		}

		// Token: 0x06015500 RID: 87296 RVA: 0x001F5325 File Offset: 0x001F3525
		protected override IntPtr GetUStructPtr()
		{
			return FStarEmitterSettings.StaticStruct();
		}

		// Token: 0x06015501 RID: 87297 RVA: 0x001F5331 File Offset: 0x001F3531
		[NullableContext(2)]
		public FStarEmitterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015502 RID: 87298 RVA: 0x001F533B File Offset: 0x001F353B
		public FStarEmitterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015503 RID: 87299 RVA: 0x001F5346 File Offset: 0x001F3546
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStarEmitterSettings(Pointer, false, true);
		}

		// Token: 0x06015504 RID: 87300 RVA: 0x001F5350 File Offset: 0x001F3550
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStarEmitterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400B9D6 RID: 47574
		public const string __ObjectPath = "/Script/KuroBulletCore.StarEmitterSettings";

		// Token: 0x0400B9D7 RID: 47575
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B9D8 RID: 47576
		internal static int __PropertyOffset_StarCorners;

		// Token: 0x0400B9D9 RID: 47577
		internal static int __PropertyOffset_OuterRadius;

		// Token: 0x0400B9DA RID: 47578
		internal static int __PropertyOffset_InnerRadius;

		// Token: 0x0400B9DB RID: 47579
		internal static int __PropertyOffset_FillCorners;

		// Token: 0x0400B9DC RID: 47580
		internal static int __PropertyOffset_StackSettings;

		// Token: 0x0400B9DD RID: 47581
		[Nullable(2)]
		private FEmitterStackSettings _StackSettings;
	}
}
