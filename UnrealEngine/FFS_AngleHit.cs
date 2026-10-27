using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A96 RID: 6806
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.FS_AngleHit")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FFS_AngleHit : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060191AE RID: 102830 RVA: 0x00251B35 File Offset: 0x0024FD35
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFS_AngleHit._ScriptStructPtr != 0) ? FFS_AngleHit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.FS_AngleHit", ref FFS_AngleHit._ScriptStructPtr);
		}

		// Token: 0x170063B7 RID: 25527
		// (get) Token: 0x060191AF RID: 102831 RVA: 0x00251B59 File Offset: 0x0024FD59
		// (set) Token: 0x060191B0 RID: 102832 RVA: 0x00251B69 File Offset: 0x0024FD69
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFS_AngleHit.__PropertyOffset_Angle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFS_AngleHit.__PropertyOffset_Angle) = value;
			}
		}

		// Token: 0x170063B8 RID: 25528
		// (get) Token: 0x060191B1 RID: 102833 RVA: 0x00251B7A File Offset: 0x0024FD7A
		// (set) Token: 0x060191B2 RID: 102834 RVA: 0x00251B8E File Offset: 0x0024FD8E
		public unsafe FVector2D HitPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFS_AngleHit.__PropertyOffset_HitPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFS_AngleHit.__PropertyOffset_HitPoint) = value;
			}
		}

		// Token: 0x170063B9 RID: 25529
		// (get) Token: 0x060191B3 RID: 102835 RVA: 0x00251BA3 File Offset: 0x0024FDA3
		// (set) Token: 0x060191B4 RID: 102836 RVA: 0x00251BB3 File Offset: 0x0024FDB3
		public unsafe bool bHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFS_AngleHit.__PropertyOffset_bHit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFS_AngleHit.__PropertyOffset_bHit) = (value ? 1 : 0);
			}
		}

		// Token: 0x060191B5 RID: 102837 RVA: 0x00251BC4 File Offset: 0x0024FDC4
		public FFS_AngleHit()
		{
		}

		// Token: 0x060191B6 RID: 102838 RVA: 0x00251BCC File Offset: 0x0024FDCC
		public FFS_AngleHit(float Angle, FVector2D HitPoint, bool bHit)
		{
			this.Angle = Angle;
			this.HitPoint = HitPoint;
			this.bHit = bHit;
		}

		// Token: 0x060191B7 RID: 102839 RVA: 0x00251BE9 File Offset: 0x0024FDE9
		protected override IntPtr GetUStructPtr()
		{
			return FFS_AngleHit.StaticStruct();
		}

		// Token: 0x060191B8 RID: 102840 RVA: 0x00251BF5 File Offset: 0x0024FDF5
		[NullableContext(2)]
		public FFS_AngleHit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060191B9 RID: 102841 RVA: 0x00251BFF File Offset: 0x0024FDFF
		public FFS_AngleHit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060191BA RID: 102842 RVA: 0x00251C0A File Offset: 0x0024FE0A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFS_AngleHit(Pointer, false, true);
		}

		// Token: 0x060191BB RID: 102843 RVA: 0x00251C14 File Offset: 0x0024FE14
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFS_AngleHit(Pointer, MemoryOwner);
		}

		// Token: 0x0400DAE8 RID: 56040
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.FS_AngleHit";

		// Token: 0x0400DAE9 RID: 56041
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DAEA RID: 56042
		internal static int __PropertyOffset_Angle;

		// Token: 0x0400DAEB RID: 56043
		internal static int __PropertyOffset_HitPoint;

		// Token: 0x0400DAEC RID: 56044
		internal static int __PropertyOffset_bHit;
	}
}
