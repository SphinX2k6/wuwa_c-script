using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A98 RID: 6808
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.FS_Circle2Dtest")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FFS_Circle2Dtest : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060191C8 RID: 102856 RVA: 0x00251CDD File Offset: 0x0024FEDD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFS_Circle2Dtest._ScriptStructPtr != 0) ? FFS_Circle2Dtest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.FS_Circle2Dtest", ref FFS_Circle2Dtest._ScriptStructPtr);
		}

		// Token: 0x170063BC RID: 25532
		// (get) Token: 0x060191C9 RID: 102857 RVA: 0x00251D01 File Offset: 0x0024FF01
		// (set) Token: 0x060191CA RID: 102858 RVA: 0x00251D15 File Offset: 0x0024FF15
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFS_Circle2Dtest.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFS_Circle2Dtest.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x170063BD RID: 25533
		// (get) Token: 0x060191CB RID: 102859 RVA: 0x00251D2A File Offset: 0x0024FF2A
		// (set) Token: 0x060191CC RID: 102860 RVA: 0x00251D3A File Offset: 0x0024FF3A
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFS_Circle2Dtest.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFS_Circle2Dtest.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x060191CD RID: 102861 RVA: 0x00251D4B File Offset: 0x0024FF4B
		public FFS_Circle2Dtest()
		{
		}

		// Token: 0x060191CE RID: 102862 RVA: 0x00251D53 File Offset: 0x0024FF53
		public FFS_Circle2Dtest(FVector Center, float Radius)
		{
			this.Center = Center;
			this.Radius = Radius;
		}

		// Token: 0x060191CF RID: 102863 RVA: 0x00251D69 File Offset: 0x0024FF69
		protected override IntPtr GetUStructPtr()
		{
			return FFS_Circle2Dtest.StaticStruct();
		}

		// Token: 0x060191D0 RID: 102864 RVA: 0x00251D75 File Offset: 0x0024FF75
		[NullableContext(2)]
		public FFS_Circle2Dtest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060191D1 RID: 102865 RVA: 0x00251D7F File Offset: 0x0024FF7F
		public FFS_Circle2Dtest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060191D2 RID: 102866 RVA: 0x00251D8A File Offset: 0x0024FF8A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFS_Circle2Dtest(Pointer, false, true);
		}

		// Token: 0x060191D3 RID: 102867 RVA: 0x00251D94 File Offset: 0x0024FF94
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFS_Circle2Dtest(Pointer, MemoryOwner);
		}

		// Token: 0x0400DAF1 RID: 56049
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.FS_Circle2Dtest";

		// Token: 0x0400DAF2 RID: 56050
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DAF3 RID: 56051
		internal static int __PropertyOffset_Center;

		// Token: 0x0400DAF4 RID: 56052
		internal static int __PropertyOffset_Radius;
	}
}
