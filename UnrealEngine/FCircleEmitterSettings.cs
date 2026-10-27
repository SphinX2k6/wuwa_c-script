using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016CD RID: 5837
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.CircleEmitterSettings")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FCircleEmitterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015263 RID: 86627 RVA: 0x001F168D File Offset: 0x001EF88D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCircleEmitterSettings._ScriptStructPtr != 0) ? FCircleEmitterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.CircleEmitterSettings", ref FCircleEmitterSettings._ScriptStructPtr);
		}

		// Token: 0x17005398 RID: 21400
		// (get) Token: 0x06015264 RID: 86628 RVA: 0x001F16B1 File Offset: 0x001EF8B1
		// (set) Token: 0x06015265 RID: 86629 RVA: 0x001F16C1 File Offset: 0x001EF8C1
		public unsafe float CircleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCircleEmitterSettings.__PropertyOffset_CircleRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCircleEmitterSettings.__PropertyOffset_CircleRadius) = value;
			}
		}

		// Token: 0x17005399 RID: 21401
		// (get) Token: 0x06015266 RID: 86630 RVA: 0x001F16D2 File Offset: 0x001EF8D2
		// (set) Token: 0x06015267 RID: 86631 RVA: 0x001F16E2 File Offset: 0x001EF8E2
		public unsafe float FillAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCircleEmitterSettings.__PropertyOffset_FillAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCircleEmitterSettings.__PropertyOffset_FillAngle) = value;
			}
		}

		// Token: 0x1700539A RID: 21402
		// (get) Token: 0x06015268 RID: 86632 RVA: 0x001F16F3 File Offset: 0x001EF8F3
		// (set) Token: 0x06015269 RID: 86633 RVA: 0x001F1703 File Offset: 0x001EF903
		public unsafe float StartAngleOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCircleEmitterSettings.__PropertyOffset_StartAngleOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCircleEmitterSettings.__PropertyOffset_StartAngleOffset) = value;
			}
		}

		// Token: 0x1700539B RID: 21403
		// (get) Token: 0x0601526A RID: 86634 RVA: 0x001F1714 File Offset: 0x001EF914
		// (set) Token: 0x0601526B RID: 86635 RVA: 0x001F1757 File Offset: 0x001EF957
		public FEmitterStackSettings StackSettings
		{
			get
			{
				base.FastCheckIsValid();
				FEmitterStackSettings result;
				if ((result = this._StackSettings) == null)
				{
					result = (this._StackSettings = new FEmitterStackSettings(base.NativePtr + (IntPtr)FCircleEmitterSettings.__PropertyOffset_StackSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEmitterStackSettings.StaticStruct(), base.NativePtr + (IntPtr)FCircleEmitterSettings.__PropertyOffset_StackSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601526C RID: 86636 RVA: 0x001F1778 File Offset: 0x001EF978
		public FCircleEmitterSettings()
		{
		}

		// Token: 0x0601526D RID: 86637 RVA: 0x001F1780 File Offset: 0x001EF980
		public FCircleEmitterSettings(float CircleRadius, float FillAngle, float StartAngleOffset, FEmitterStackSettings StackSettings)
		{
			this.CircleRadius = CircleRadius;
			this.FillAngle = FillAngle;
			this.StartAngleOffset = StartAngleOffset;
			this.StackSettings = StackSettings;
		}

		// Token: 0x0601526E RID: 86638 RVA: 0x001F17A5 File Offset: 0x001EF9A5
		protected override IntPtr GetUStructPtr()
		{
			return FCircleEmitterSettings.StaticStruct();
		}

		// Token: 0x0601526F RID: 86639 RVA: 0x001F17B1 File Offset: 0x001EF9B1
		[NullableContext(2)]
		public FCircleEmitterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015270 RID: 86640 RVA: 0x001F17BB File Offset: 0x001EF9BB
		public FCircleEmitterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015271 RID: 86641 RVA: 0x001F17C6 File Offset: 0x001EF9C6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCircleEmitterSettings(Pointer, false, true);
		}

		// Token: 0x06015272 RID: 86642 RVA: 0x001F17D0 File Offset: 0x001EF9D0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCircleEmitterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400B816 RID: 47126
		public const string __ObjectPath = "/Script/KuroBulletCore.CircleEmitterSettings";

		// Token: 0x0400B817 RID: 47127
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B818 RID: 47128
		internal static int __PropertyOffset_CircleRadius;

		// Token: 0x0400B819 RID: 47129
		internal static int __PropertyOffset_FillAngle;

		// Token: 0x0400B81A RID: 47130
		internal static int __PropertyOffset_StartAngleOffset;

		// Token: 0x0400B81B RID: 47131
		internal static int __PropertyOffset_StackSettings;

		// Token: 0x0400B81C RID: 47132
		[Nullable(2)]
		private FEmitterStackSettings _StackSettings;
	}
}
