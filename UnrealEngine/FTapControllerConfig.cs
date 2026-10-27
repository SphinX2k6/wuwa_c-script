using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028E2 RID: 10466
	[UnrealObjectPath("/Script/TapCommon.TapControllerConfig")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FTapControllerConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026D2C RID: 159020 RVA: 0x003B3620 File Offset: 0x003B1820
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTapControllerConfig._ScriptStructPtr != 0) ? FTapControllerConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.TapControllerConfig", ref FTapControllerConfig._ScriptStructPtr);
		}

		// Token: 0x1700958E RID: 38286
		// (get) Token: 0x06026D2D RID: 159021 RVA: 0x003B3644 File Offset: 0x003B1844
		// (set) Token: 0x06026D2E RID: 159022 RVA: 0x003B3654 File Offset: 0x003B1854
		public unsafe float DeadZone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapControllerConfig.__PropertyOffset_DeadZone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapControllerConfig.__PropertyOffset_DeadZone) = value;
			}
		}

		// Token: 0x1700958F RID: 38287
		// (get) Token: 0x06026D2F RID: 159023 RVA: 0x003B3665 File Offset: 0x003B1865
		// (set) Token: 0x06026D30 RID: 159024 RVA: 0x003B3675 File Offset: 0x003B1875
		public unsafe float CursorMaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapControllerConfig.__PropertyOffset_CursorMaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapControllerConfig.__PropertyOffset_CursorMaxSpeed) = value;
			}
		}

		// Token: 0x17009590 RID: 38288
		// (get) Token: 0x06026D31 RID: 159025 RVA: 0x003B3686 File Offset: 0x003B1886
		// (set) Token: 0x06026D32 RID: 159026 RVA: 0x003B3696 File Offset: 0x003B1896
		public unsafe float ScrollMaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapControllerConfig.__PropertyOffset_ScrollMaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapControllerConfig.__PropertyOffset_ScrollMaxSpeed) = value;
			}
		}

		// Token: 0x06026D33 RID: 159027 RVA: 0x003B36A7 File Offset: 0x003B18A7
		public FTapControllerConfig()
		{
		}

		// Token: 0x06026D34 RID: 159028 RVA: 0x003B36AF File Offset: 0x003B18AF
		public FTapControllerConfig(float DeadZone, float CursorMaxSpeed, float ScrollMaxSpeed)
		{
			this.DeadZone = DeadZone;
			this.CursorMaxSpeed = CursorMaxSpeed;
			this.ScrollMaxSpeed = ScrollMaxSpeed;
		}

		// Token: 0x06026D35 RID: 159029 RVA: 0x003B36CC File Offset: 0x003B18CC
		protected override IntPtr GetUStructPtr()
		{
			return FTapControllerConfig.StaticStruct();
		}

		// Token: 0x06026D36 RID: 159030 RVA: 0x003B36D8 File Offset: 0x003B18D8
		[NullableContext(2)]
		public FTapControllerConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026D37 RID: 159031 RVA: 0x003B36E2 File Offset: 0x003B18E2
		public FTapControllerConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026D38 RID: 159032 RVA: 0x003B36ED File Offset: 0x003B18ED
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTapControllerConfig(Pointer, false, true);
		}

		// Token: 0x06026D39 RID: 159033 RVA: 0x003B36F7 File Offset: 0x003B18F7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTapControllerConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04015508 RID: 87304
		[Nullable(1)]
		public const string __ObjectPath = "/Script/TapCommon.TapControllerConfig";

		// Token: 0x04015509 RID: 87305
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401550A RID: 87306
		internal static int __PropertyOffset_DeadZone;

		// Token: 0x0401550B RID: 87307
		internal static int __PropertyOffset_CursorMaxSpeed;

		// Token: 0x0401550C RID: 87308
		internal static int __PropertyOffset_ScrollMaxSpeed;
	}
}
