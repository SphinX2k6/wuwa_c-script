using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A23 RID: 6691
	[UnrealObjectPath("/Script/KuroPointCloud.KPCWDynamicCustomPointInfo")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKPCWDynamicCustomPointInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018C02 RID: 101378 RVA: 0x0024939A File Offset: 0x0024759A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKPCWDynamicCustomPointInfo._ScriptStructPtr != 0) ? FKPCWDynamicCustomPointInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPointCloud.KPCWDynamicCustomPointInfo", ref FKPCWDynamicCustomPointInfo._ScriptStructPtr);
		}

		// Token: 0x1700621D RID: 25117
		// (get) Token: 0x06018C03 RID: 101379 RVA: 0x002493BE File Offset: 0x002475BE
		// (set) Token: 0x06018C04 RID: 101380 RVA: 0x002493CE File Offset: 0x002475CE
		public unsafe bool bPointVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKPCWDynamicCustomPointInfo.__PropertyOffset_bPointVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKPCWDynamicCustomPointInfo.__PropertyOffset_bPointVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700621E RID: 25118
		// (get) Token: 0x06018C05 RID: 101381 RVA: 0x002493DF File Offset: 0x002475DF
		// (set) Token: 0x06018C06 RID: 101382 RVA: 0x002493F3 File Offset: 0x002475F3
		public unsafe FTransform PointTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKPCWDynamicCustomPointInfo.__PropertyOffset_PointTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKPCWDynamicCustomPointInfo.__PropertyOffset_PointTransform) = value;
			}
		}

		// Token: 0x06018C07 RID: 101383 RVA: 0x00249408 File Offset: 0x00247608
		public FKPCWDynamicCustomPointInfo()
		{
		}

		// Token: 0x06018C08 RID: 101384 RVA: 0x00249410 File Offset: 0x00247610
		public FKPCWDynamicCustomPointInfo(bool bPointVisible, FTransform PointTransform)
		{
			this.bPointVisible = bPointVisible;
			this.PointTransform = PointTransform;
		}

		// Token: 0x06018C09 RID: 101385 RVA: 0x00249426 File Offset: 0x00247626
		protected override IntPtr GetUStructPtr()
		{
			return FKPCWDynamicCustomPointInfo.StaticStruct();
		}

		// Token: 0x06018C0A RID: 101386 RVA: 0x00249432 File Offset: 0x00247632
		[NullableContext(2)]
		public FKPCWDynamicCustomPointInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018C0B RID: 101387 RVA: 0x0024943C File Offset: 0x0024763C
		public FKPCWDynamicCustomPointInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018C0C RID: 101388 RVA: 0x00249447 File Offset: 0x00247647
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKPCWDynamicCustomPointInfo(Pointer, false, true);
		}

		// Token: 0x06018C0D RID: 101389 RVA: 0x00249451 File Offset: 0x00247651
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKPCWDynamicCustomPointInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400D624 RID: 54820
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPointCloud.KPCWDynamicCustomPointInfo";

		// Token: 0x0400D625 RID: 54821
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D626 RID: 54822
		internal static int __PropertyOffset_bPointVisible;

		// Token: 0x0400D627 RID: 54823
		internal static int __PropertyOffset_PointTransform;
	}
}
