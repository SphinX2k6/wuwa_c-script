using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000304 RID: 772
	[UnrealObjectPath("/Script/KuroAnim.MotorWheelDisplayInfo")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FMotorWheelDisplayInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005301 RID: 21249 RVA: 0x0007407D File Offset: 0x0007227D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorWheelDisplayInfo._ScriptStructPtr != 0) ? FMotorWheelDisplayInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.MotorWheelDisplayInfo", ref FMotorWheelDisplayInfo._ScriptStructPtr);
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x06005302 RID: 21250 RVA: 0x000740A1 File Offset: 0x000722A1
		// (set) Token: 0x06005303 RID: 21251 RVA: 0x000740B5 File Offset: 0x000722B5
		public unsafe FVector WheelLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorWheelDisplayInfo.__PropertyOffset_WheelLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorWheelDisplayInfo.__PropertyOffset_WheelLocation) = value;
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06005304 RID: 21252 RVA: 0x000740CA File Offset: 0x000722CA
		// (set) Token: 0x06005305 RID: 21253 RVA: 0x000740DA File Offset: 0x000722DA
		public unsafe float WheelSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorWheelDisplayInfo.__PropertyOffset_WheelSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorWheelDisplayInfo.__PropertyOffset_WheelSpeed) = value;
			}
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06005306 RID: 21254 RVA: 0x000740EB File Offset: 0x000722EB
		// (set) Token: 0x06005307 RID: 21255 RVA: 0x000740FB File Offset: 0x000722FB
		public unsafe float WheelAccel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorWheelDisplayInfo.__PropertyOffset_WheelAccel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorWheelDisplayInfo.__PropertyOffset_WheelAccel) = value;
			}
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x0007410C File Offset: 0x0007230C
		public FMotorWheelDisplayInfo()
		{
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x00074114 File Offset: 0x00072314
		protected override IntPtr GetUStructPtr()
		{
			return FMotorWheelDisplayInfo.StaticStruct();
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x00074120 File Offset: 0x00072320
		[NullableContext(2)]
		public FMotorWheelDisplayInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x0007412A File Offset: 0x0007232A
		public FMotorWheelDisplayInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x00074135 File Offset: 0x00072335
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorWheelDisplayInfo(Pointer, false, true);
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x0007413F File Offset: 0x0007233F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorWheelDisplayInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040021DB RID: 8667
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.MotorWheelDisplayInfo";

		// Token: 0x040021DC RID: 8668
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021DD RID: 8669
		internal static int __PropertyOffset_WheelLocation;

		// Token: 0x040021DE RID: 8670
		internal static int __PropertyOffset_WheelSpeed;

		// Token: 0x040021DF RID: 8671
		internal static int __PropertyOffset_WheelAccel;
	}
}
