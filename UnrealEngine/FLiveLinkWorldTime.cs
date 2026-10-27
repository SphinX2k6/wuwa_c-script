using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002233 RID: 8755
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkWorldTime")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLiveLinkWorldTime : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021537 RID: 136503 RVA: 0x00311D09 File Offset: 0x0030FF09
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkWorldTime._ScriptStructPtr != 0) ? FLiveLinkWorldTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkWorldTime", ref FLiveLinkWorldTime._ScriptStructPtr);
		}

		// Token: 0x1700820B RID: 33291
		// (get) Token: 0x06021538 RID: 136504 RVA: 0x00311D2D File Offset: 0x0030FF2D
		// (set) Token: 0x06021539 RID: 136505 RVA: 0x00311D3D File Offset: 0x0030FF3D
		public unsafe double Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkWorldTime.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkWorldTime.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x1700820C RID: 33292
		// (get) Token: 0x0602153A RID: 136506 RVA: 0x00311D4E File Offset: 0x0030FF4E
		// (set) Token: 0x0602153B RID: 136507 RVA: 0x00311D5E File Offset: 0x0030FF5E
		public unsafe double Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkWorldTime.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkWorldTime.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x0602153C RID: 136508 RVA: 0x00311D6F File Offset: 0x0030FF6F
		public FLiveLinkWorldTime()
		{
		}

		// Token: 0x0602153D RID: 136509 RVA: 0x00311D77 File Offset: 0x0030FF77
		public FLiveLinkWorldTime(double Time, double Offset)
		{
			this.Time = Time;
			this.Offset = Offset;
		}

		// Token: 0x0602153E RID: 136510 RVA: 0x00311D8D File Offset: 0x0030FF8D
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkWorldTime.StaticStruct();
		}

		// Token: 0x0602153F RID: 136511 RVA: 0x00311D99 File Offset: 0x0030FF99
		[NullableContext(2)]
		public FLiveLinkWorldTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021540 RID: 136512 RVA: 0x00311DA3 File Offset: 0x0030FFA3
		public FLiveLinkWorldTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021541 RID: 136513 RVA: 0x00311DAE File Offset: 0x0030FFAE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkWorldTime(Pointer, false, true);
		}

		// Token: 0x06021542 RID: 136514 RVA: 0x00311DB8 File Offset: 0x0030FFB8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkWorldTime(Pointer, MemoryOwner);
		}

		// Token: 0x04011C4E RID: 72782
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkWorldTime";

		// Token: 0x04011C4F RID: 72783
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011C50 RID: 72784
		internal static int __PropertyOffset_Time;

		// Token: 0x04011C51 RID: 72785
		internal static int __PropertyOffset_Offset;
	}
}
